﻿using Microsoft.Graph;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the currently logged in user's profile information
        /// </summary>        
        public static async Task<User> GetMeAsync()
        {
            User currentUserObject = null;
            try
            {
                var graphClient = AuthenticationHelper.GetAuthenticatedClient();
                currentUserObject = await graphClient.Me.Request().GetAsync();

                Debug.WriteLine("Got user: " + currentUserObject.DisplayName);
                return currentUserObject;
            }

            catch (ServiceException e)
            {
                Debug.WriteLine("We could not get the current user: " + e.Error.Message);
                return null;
            }
        }

        /// <summary>
        /// Get people near me.  Demonstrates using HttpClient to call the 
        /// Graph API.
        /// </summary>
        /// <returns></returns>
        static async Task<string> GetPeopleNearMe()
        {
            try
            {
                //Get the Graph client
                var graphClient = AuthenticationHelper.GetAuthenticatedClient();

                var token = await AuthenticationHelper.GetTokenForUserAsync();

                var request = new HttpRequestMessage(HttpMethod.Get, graphClient.BaseUrl + "/me/people");
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await graphClient.HttpProvider.SendAsync(request);
                var bodyContents = await response.Content.ReadAsStringAsync();

                Debug.WriteLine(bodyContents);
                return bodyContents;
            }

            catch (Exception e)
            {
                Debug.WriteLine("Could not get people: " + e.Message);
                return null;
            }
        }

        static async Task RunAsync()
        {
            //Display information about the current user            
            Console.WriteLine("Get My Profile");
            Console.WriteLine();

            var me = await GetMeAsync();

            Console.WriteLine(me.DisplayName);
            Console.WriteLine("User:{0}\t\tEmail:{1}", me.DisplayName, me.Mail);
            Console.WriteLine();

            //Display information about people near me
            Console.WriteLine("Get People Near Me");

            var peopleJson = await GetPeopleNearMe();
            dynamic people = JObject.Parse(peopleJson);
            if (null != people)
            {
                foreach (var p in people.value)
                {
                    var personType = p.personType;
                    Console.WriteLine("Object:{0}\t\t\t\tClass:{1}\t\tSubclass:{2}", p.displayName, personType["class"], personType.subclass);
                }
            }
        }
    }
}
