# function-template-csharp

## Installation

```shell
dotnet new install function-template-csharp

dotnet new function-csharp -n TheFunction -o c:\repos\func2
```

## Development

```shell
dotnet pack -p:Version=0.0.1-alpha1

dotnet new install ./src/function-template-csharp/bin/Release/function-template-csharp.0.0.1-alpha1.nupkg

dotnet new function-csharp -n TheFunction -o c:\repos\func2

dotnet new uninstall function-template-csharp
```
