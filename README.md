How to run test cases:=================================================================
1) Right click on "Rewards.NTest" project.
2) Select "Run Tests" option.
3) It will open new window and automatically run all the test methods.


How to build the solution:============================================
1) Open the project with visual studio 2019
2) Build the project and check all dependecies are loaded or not
3) If not loaded please right click on project "Rewards.API" and then select "edit project file"
4) It will show all packages which are used in project
5) Please reinstall all packages
6) Do same thing for the project "Rewards.Buisness"



How to run api:====================================================
1) Open RewardsController file in Api folder in Rewards.API project
2) Then click "IIS express" or "F5"
3) It will open browser chrome or edge
4) By default it will open swagger url
5) In that swagger url we have api documentation with internal postman


Softwares used:============================================
OS:windows 10
IDE:Visual studio 2019 enterprise
Framework: Asp.Net core 3.1
SDK:Asp.Net core 3.X (latest)


Api Documentation:====================================================
1)Swagger package used for api documentation.


Handling Exception:=========================================
1) Here "GlobalExceptionFilter" class used to handle exceptions apis level


Logging:=============================================================
1) Here serilog package is used and configured to log the exception into notepad file.
2) Logs will be avaiable under "Logs" folder date wise.



Test Cases:============================================================
1) Nunit test framework used to write the test cases