# function-template-csharp

C# Crossplane Composition Template

## Installation

```shell
dotnet new install function-template-csharp

dotnet new function-csharp -n TheFunction -o c:\repos\func2
```

## Features

- XRD to Model Generation
  - Modify the xrd.yaml and models will be automatically generated
- CRD to Model Generation
  - Add crd.yaml(s) to the project and models will be automatically generated
  - Most Crossplane Providers already published [KubernetesCRDModelGen](https://github.com/IvanJosipovic/KubernetesCRDModelGen?tab=readme-ov-file#published-packages)

    | Group | NuGet |
    | --- | --- |
    | aws.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.aws.upbound.io/) |
    | azapi.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azapi.upbound.io/) |
    | azure.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.upbound.io/) |
    | azuread.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azuread.upbound.io/) |
    | crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.crossplane.io/) |
    | databricks.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.databricks.crossplane.io/) |
    | gcp.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.gcp.upbound.io/) |
    | helm.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.helm.crossplane.io/) |
    | kubernetes.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.kubernetes.crossplane.io/) |
    | opentofu.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.opentofu.upbound.io/) |
    | tf.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.tf.upbound.io/) |
    | upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.upbound.io/) |
    | vault.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.vault.upbound.io/) |

- Supports Crossplane v1.17 or greater



## Development

```shell
dotnet pack -p:Version=0.0.1-alpha1

dotnet new install ./src/function-template-csharp/bin/Release/function-template-csharp.0.0.1-alpha1.nupkg

dotnet new function-csharp -n TheFunction -o c:\repos\func2

dotnet new uninstall function-template-csharp
```
