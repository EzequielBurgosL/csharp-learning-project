# C# Learning Project

This repository contains a series of C# exercises. Each exercise is located in its own namespace within the `oopTutorial` folder. 

## Project Setup

### 1. **Initialize the Project**

To initialize the project, ensure that you have .NET SDK installed. You can download it from the official [.NET website](https://dotnet.microsoft.com/download).

Once the SDK is installed, navigate to your project folder and run the following command to restore all dependencies:

```bash
dotnet restore
```

### 2. **Run the Project**

To run a specific C# file (like `Program.cs`), use the following command:

```bash
dotnet run --project oopTutorial/exercise1/exercise1.csproj
```

Replace the path with the appropriate exercise you want to run.

### 3. **Run Tests**

To run the tests for this project, you can use the `dotnet test` command. Ensure you have created a test project and linked it to the solution file. Run the following command to run all tests:

```bash
dotnet test
```

### 4. **Format the Code**

To automatically format your code according to your style settings, use the following command:

```bash
dotnet format
```

This will apply the code style rules defined in the `.editorconfig` file and automatically format all C# files in the project.
