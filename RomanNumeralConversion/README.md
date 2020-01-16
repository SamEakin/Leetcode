# Test Driven Development for C# in VS Code:
## Setting up a dotnet project:
### 1. Create a project directory:
```
mkdir ProjectName && cd ProjectName
```
### 2. Create the solution:
```
dotnet new sln
```
### 3. Make Source Code directory:
```
mkdir ApplicationName && cd ApplicationName
```
### 4. Create the source project:
```
dotnet new classlib
```
- change the name of the generated "Class1.cs" file.
### 5. Add the Class Library Project to the solution:
```
cd ..
dotnet sln add ApplicationName/ApplicationName.csproj
```
### 6. Create the Test Project:
```
mkdir ApplicationName.Tests && cd ApplicationName.Tests
dotnet new nunit
```
### 7. Add project reference to the Test project:
```
dotnet add reference ../ApplicationName/ApplicationName.csproj
```
### 8. Add the Test Project to the solution:
```
cd ..
dotnet sln add ApplicationName.Tests/ApplicationName.Tests.csproj
```

## Running Tests:
```
dotnet test
```

## Creating Tests:
```cs
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
```