## This Repo demonstrates the parallel execution of unit tests with dotnet test

## Running the tests

- Output file is created in `c:\temp\output.txt` if this doesn't exist or is undesireable change it in [MyLibrary/MyNetStandardClass](./MyLibrary/MyNetStandardClass.cs)
- Run dotnet test in the current directory of your repo


```

PS E:\My Documents\DotnetTestParallelExample> cd "E:\My Documents\DotnetTestParallelExample"
PS E:\My Documents\DotnetTestParallelExample> dotnet test
Test run for E:\My Documents\DotnetTestParallelExample\TestsCore2\bin\Debug\netcoreapp2.2\TestsCore2.dll(.NETCoreApp,Version=v2.2)
Test run for E:\My Documents\DotnetTestParallelExample\Tests461\bin\Debug\net461\Tests461.dll(.NETFramework,Version=v4.6.1)
Microsoft (R) Test Execution Command Line Tool Version 16.3.0-preview-20190905-01
Copyright (c) Microsoft Corporation.  All rights reserved.

Microsoft (R) Test Execution Command Line Tool Version 16.3.0-preview-20190905-01
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.Starting test execution, please wait...


A total of 1 test files matched the specified pattern.

Test Run Successful.
Total tests: 1
     Passed: 1
 Total time: 4.0378 Seconds

Test Run Successful.
Total tests: 1
     Passed: 1
 Total time: 4.0491 Seconds

```

Open the output file

```
c:\temp\output.txt
```

This shows the following:

```
Core SetUp 526728187
Core Enter Test 526728187
461 SetUp 526728312
461 Enter Test 526728328
Core Exit Test 526731187
461 Exit Test 526731328
```

Both tests execute in parallel

## Runsettings

Runsettings file is included but does not seem to be respected

```
del c:\temp\output.txt
dotnet test -s test.runsettings
```