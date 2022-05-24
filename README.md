Run test cases:================================================
1. Right click on "Rewards.NTest" project.
2. Select "Run Tests" option.
3. It will open new window and automatically run all the test methods.

Build the solution:============================================
1. Open the project with visual studio 2019
2. Build the project and check all dependecies are loaded or not
3. If not loaded please right click on project "Rewards.API" and then select "edit project file"
4. It will show all packages which are used in project
5. Please reinstall all packages
6. Do same thing for the project "Rewards.Buisness"

Run api:=======================================================
1. Open RewardsController file in Api folder in Rewards.API project
2. Then click "IIS express" or "F5"
3. It will open browser chrome or edge
4. By default it will open swagger url
5. In that swagger url we have api documentation with internal postman

Softwares used:=======================================================
1. OS:windows 10
2. IDE:Visual studio 2019 enterprise
3. Framework: Asp.Net core 3.1
4. SDK:Asp.Net core 3.X (latest)

Api Documentation:====================================================

1. Swagger package used for api documentation.

Handling Exception:==================================================
1. Here "GlobalExceptionFilter" class used to handle exceptions apis level

Logging:=============================================================
1. Here serilog package is used and configured to log the exception into notepad file.
2. Logs will be avaiable under "Logs" folder date wise.

Test Cases:==========================================================
1. Nunit test framework used to write the test cases

Health check:========================================================
1. Health check enabled for this application
2. We can check health by accessing url https://localhost:44391/healthchecks-ui#/healthchecks
3. If you are unable to access above url please change port number based on your local system

Deployment:=========================================================
1. We can deploy the application into iis in our system or windows server by accessing url https://www.c-sharpcorner.com/article/iis-how-to-host-a-net-core-application-in-10-steps/
2. If we have azure subscription we can deploy into azure also by creaing app services from the url http://portal.azure.com/


CustomerRewardsReport Page:========================================

1.We can access customer rewards report by accessing https://localhost:44391/home/CustomerRewardsReport

2.Below is the screenshot


![dataset_image](https://user-images.githubusercontent.com/100580561/170055927-b9c79702-e651-4649-98fd-76ccf964f7ea.jpg)
