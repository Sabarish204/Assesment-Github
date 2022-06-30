<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
 



 


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>       
      </ul>
    </li>
    <li><a href="#cloning--build-repo">Cloning & Build Repo</a></li>
    <li><a href="#build">Build</a></li>
    <li><a href="#run-api">Run Api</a></li>
    <li><a href="#softwares-used">Software Used</a></li>
    <li><a href="#api-documentation">Api Documentation</a></li>
    <li><a href="#handling-exception">Handling Exception</a></li>
    <li><a href="#logging">Logging</a></li>
    <li><a href="#tests">Tests</a></li>
    <li><a href="#health-check">Health Check</a></li>
    <li><a href="#deployment">Deployment</a></li>
    <li><a href="#customerrewardsreport-page">Customerrewardsreport Page</a></li>
    <li><a href="#api-document">Api Document</a></li>
    <li><a href="#cutom-logging">Custom Logging</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

![project_landing_page](https://user-images.githubusercontent.com/100580561/170325795-16861955-4d80-41f6-b712-a64bacd95e4b.jpg)


This api project is intently developed to get reward points based on purchased amount from retailer shop.
Customer will get reward points based on thier daily purchases. 
For example,for every dollar spent over $50 on the transaction, the customer receives one point.
In addition, for every dollar spent over $100, the customer receives another point.


<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [Asp.Net Core](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-3.1)
* [.Net Core SDK 3.X](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
* [Bootstrap](https://getbootstrap.com)
* [JQuery](https://jquery.com)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

 

### Prerequisites

Donwload and install the visual studio (2019/2022) & .Net Core Sdk 3.X from below link
* [Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [.Net Core SDK 3.X](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
  

## Cloning & Build Repo

1. Clone the repo
   ```sh
   git clone https://github.com/Sabarish204/RewardPoints.git
   ```
2. Build the solution in visual studio
   ```sh
   ctrl+shift+b
   ```
<p align="right">(<a href="#top">back to top</a>)</p>


## Build
1. Open the project with visual studio 2019 or 2022
2. Build the project and check all dependecies are loaded or 
3. If not loaded please right click on project "Rewards.API" and then select "edit project file"
4. It will show all packages which are used in project
5. Please reinstall all packages
6. Do same thing for the project "Rewards.Buisness"

## Run Api
1. Open RewardsController file in Api folder in Rewards.API project
2. Then click "IIS express" or "F5"
3. It will open browser chrome or edge
4. It will open browser chrome or edge
5. Please reinstall all packages
6. In that swagger url we have api documentation with internal postman

## Softwares used
1. OS:windows 10
2. IDE:Visual studio 2019 enterprise
3. Framework: Asp.Net core 3.1
4. SDK:Asp.Net core 3.X (latest)


## Api Documentation
1. Swagger package used for api documentation.
 
 
## Handling Exception
1. Here "GlobalExceptionFilter" class used to handle exceptions apis level

## Logging
1. Here serilog package is used and configured to log the exception into notepad file.
2. Logs will be avaiable under "Logs" folder date wise.
 
 

## Tests
1.Nunit test framework used to write the test cases
 
 ![test_image](https://user-images.githubusercontent.com/100580561/170326791-faed73b5-bd89-4b50-834c-6bf9535c1cd0.jpg)

## Health check
1. Health check enabled for this application
2. We can check health by accessing url https://localhost:44391/healthchecks-ui#/healthchecks
3. If you are unable to access above url please change port number based on your local system

![health_check_image](https://user-images.githubusercontent.com/100580561/170327145-648e37bc-73d2-418d-b052-7cc5d2ed3a5c.jpg)


## Deployment

1. We can deploy the application into iis in our system or windows server by accessing url https://www.c-sharpcorner.com/article/iis-how-to-host-a-net-core-application-in-10-steps/
2. If we have azure subscription we can deploy into azure also by creaing app services from the url http://portal.azure.com/

## CustomerRewardsReport Page

1. We can access customer rewards report by accessing https://localhost:44391/home/CustomerRewardsReport
2. Below is the screenshot

![dataset_image](https://user-images.githubusercontent.com/100580561/170330268-eb13a98c-caa1-4d02-bf42-ac85cca10171.jpg)

<p align="right">(<a href="#top">back to top</a>)</p>


## Api Document

1. Url      : https://localhost:44391/api/Rewards/CalculateRewardPoints/{spentMoney}
2. Parameter: "{spentMoney}" is the parameter we have to pass as query param. Ex:690
3. Type     : GET
4. Response : { "Points": 1230 }

<p align="right">(<a href="#top">back to top</a>)</p>

## Custom Logging

1. In appsettings.json file we have to modify "FolderPath" based on our system.
2. Here i used "G" drive.
3. Don't use "C" drive for logs folder creation. It won't allow.

![appsettings_img](https://user-images.githubusercontent.com/100580561/176670953-503c0fb0-ed65-4f7e-ae67-1994fa46e52d.PNG)


<p align="right">(<a href="#top">back to top</a>)</p>

  
