# Microsoft Graph Connect Sample for AngularJS (REST)

## Table of contents

* [Introduction](#introduction)
* [Prerequisites](#prerequisites)
* [Register the application](#register-the-application)
* [Build and run the sample](#build-and-run-the-sample)
* [Questions and comments](#questions-and-comments)
* [Contributing](#contributing)
* [Additional resources](#additional-resources)

## Introduction

This sample shows how to connect an AngularJS app to a Microsoft work or school (Azure Active Directory) or personal (Microsoft) account  using the Microsoft Graph API to send an email. In addition, the sample uses the Office Fabric UI for styling and formatting the user experience.  We also have an [Angular connect sample](https://github.com/microsoftgraph/angular-connect-sample) that uses that [Microsoft Graph JavaScript SDK](https://github.com/microsoftgraph/msgraph-sdk-javascript).

![Microsoft Graph Connect sample screenshot](./README_assets/screenshot.png)

This sample uses the [Microsoft Authentication Library Preview for JavaScript (msal.js)](https://github.com/AzureAD/microsoft-authentication-library-for-js) to get an access token.

## Prerequisites

To use the Microsoft Graph Connect sample for AngularJS, you need the following:
* [Node.js](https://nodejs.org/). Node is required to run the sample on a development server and to install dependencies. 

* Either a [Microsoft account](https://www.outlook.com) or [Office 365 for business account](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account)

## Register the application

1. Navigate to [the Azure portal - App registrations](https://go.microsoft.com/fwlink/?linkid=2083908) to register your app. Login using a **personal account** (aka: Microsoft Account) or **Work or School Account**. 
 
1. Select **New registration**. On the **Register an application** page, set the values as follows. 
    * Set **Name** to **AngularDemo**. 
    * Set **Supported account types** to **Accounts in any organizational directory and personal Microsoft accounts**. 
    * Under **Redirect URI**, set the first drop-down to `Web` and set the value to **http://localhost:8080** 

1. Choose **Register**. On the **AngularDemo** page, copy the value of the **Application (client) ID** and save it, you will need it in the next step.

1. Select **Authentication** under **Manage**. Locate the **Implicit grant** section and enable **ID tokens**. Choose **Save**.

1. Select **Certificates & secrets** under **Manage**. Select the **New client secret** button. Enter a value in **Description** and select one of the options for **Expires** and choose **Add**.

1. Copy the **client secret** value before you leave this page. You will need it in the next step.
    > [!IMPORTANT]
    > This client secret is never shown again, so make sure you copy it now.

If you have an existing application that you have registered in the past, feel free to use that instead of creating a new registration.

## Build and run the sample

1. Download or clone the Microsoft Graph Connect Sample for AngularJS.

2. Using your favorite IDE, open **config.js** in *public/scripts*.

3. Replace the **clientID** placeholder value with the application ID of your registered Azure application.

4. In a command prompt, run the following command in the root directory. This installs project dependencies.

  ```
npm install
  ```
  
5. Run `npm start` to start the development server.

6. Navigate to `http://localhost:8080` in your web browser.

7. Choose the **Connect** button.

8. Sign in with your personal or work or school account and grant the requested permissions.

9. Optionally edit the recipient's email address, and then choose the **Send mail** button. When the mail is sent, a Success message is displayed below the button.

## Contributing

If you'd like to contribute to this sample, see [CONTRIBUTING.MD](/CONTRIBUTING.md).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Questions and comments

We'd love to get your feedback about this sample. You can send your questions and suggestions in the [Issues](https://github.com/microsoftgraph/angular-connect-rest-sample/issues) section of this repository.

Questions about Microsoft Graph development in general should be posted to [Stack Overflow](https://stackoverflow.com/questions/tagged/microsoftgraph). Make sure that your questions or comments are tagged with [microsoftgraph].
  
## Additional resources

- [Other Microsoft Graph Connect samples](https://github.com/MicrosoftGraph?utf8=%E2%9C%93&query=-Connect)
- [Microsoft Graph](http://graph.microsoft.io)

## Copyright
Copyright (c) 2016 Microsoft. All rights reserved.





