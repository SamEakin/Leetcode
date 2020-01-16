# Creating a Test Driven Project from the terminal:

## Create a project directory:
```
mkdir Name_of_project_directory
cd Name_of_project_directory
```
- this will hold the source project as well as the test project.

## Create a new solution:
```
dotnet new sln
```
- this will be the solution which runs both the source code and the test code together.

## Create the source code project:
```
dotnet new console -n AppName
```

## Create the test project:
```
dotnet new nunit -n AppName.Tests
```

## Add source project reference to the test project:
```
cd AppName.Tests
dotnet add reference ../AppName/AppName.csproj
```
- this hooks up the source code to the tests

## Add source project and test project references to solution:
```
cd ..
dotnet sln add AppName/Appname.csproj
dotnet sln add AppName.Tests/AppName.Tests.csproj

```

## Done! 
```
dotnet test
```
- make sure everything is hooked up correctly. you should see the following:
```
Starting test execution, please wait...

Test Run Successful.
Total tests: 1
     Passed: 1
 Total time: 2.0234 Seconds
```
