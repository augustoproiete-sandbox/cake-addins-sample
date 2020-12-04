| README.md |
|:---|

<h1 align="center">Cake.Addins.Sample</h1>
<div align="center">

 Sample [Cake](https://cakebuild.net) add-in for testing the [Cake.Extensions](https://github.com/augustoproiete/cake-extensions) meta-package.

[![NuGet Version](http://img.shields.io/nuget/v/Cake.Addins.Sample.svg?style=flat-square)](https://www.nuget.org/packages/Cake.Addins.Sample/) [![Stack Overflow](https://img.shields.io/badge/stack%20overflow-cakebuild-orange.svg?style=flat-square)](http://stackoverflow.com/questions/tagged/cakebuild)

</div>

## Getting started :rocket:

Call the `Sample()` alias in order to run the add-in using the default settings:

```csharp
#addin "nuget:?package=Cake.Addins.Sample&version=0.0.1-preview&prerelease"

Task("Example")
    .Does(() =>
{
    Sample();
});

RunTarget("Example");
```

## Release History

Click on the [Releases](https://github.com/augustoproiete/cake-addins-sample/releases) tab on GitHub.

---

_Copyright &copy; 2020 C. Augusto Proiete & Contributors - Provided under the [MIT License](LICENSE)._
