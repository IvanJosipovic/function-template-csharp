# FUNCTION

## How to Test

You can run your function locally and test it using `crossplane render`
with the example manifests.

### Download Crank and rename to Crossplane
https://releases.crossplane.io/stable/current/bin

## Run Function In IDE
Download the lastest [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
```shell
dotnet run
```

## Run Function In Docker
```shell
docker build -t function-myfunction src/MyFunction
docker run -it -p 9443:9443 function-myfunction
```

## Run Test
Then, in another terminal, call it with these example manifests

```shell
crossplane render example/xr.yaml example/composition.yaml example/functions.yaml
```

```yaml
apiVersion: platform.example.com/v1alpha1
kind: XStorageBucket
metadata:
  name: example
status:
  conditions:
  - lastTransitionTime: "2024-01-01T00:00:00Z"
    message: 'Unready resources: account, container, and rg'
    reason: Creating
    status: "False"
    type: Ready
---
apiVersion: storage.azure.m.upbound.io/v1beta1
kind: Account
metadata:
  annotations:
    crossplane.io/composition-resource-name: account
  labels:
    crossplane.io/composite: example
  name: example
  namespace: default
  ownerReferences:
  - apiVersion: platform.example.com/v1alpha1
    blockOwnerDeletion: true
    controller: true
    kind: XStorageBucket
    name: example
    uid: ""
spec:
  forProvider:
    accountReplicationType: LRS
    accountTier: Standard
    blobProperties:
      versioningEnabled: true
    infrastructureEncryptionEnabled: true
    location: eastus
    resourceGroupNameSelector:
      matchControllerRef: true
---
apiVersion: storage.azure.m.upbound.io/v1beta1
kind: Container
metadata:
  annotations:
    crossplane.io/composition-resource-name: container
  labels:
    crossplane.io/composite: example
  name: example
  namespace: default
  ownerReferences:
  - apiVersion: platform.example.com/v1alpha1
    blockOwnerDeletion: true
    controller: true
    kind: XStorageBucket
    name: example
    uid: ""
spec:
  forProvider:
    containerAccessType: blob
    storageAccountNameSelector:
      matchControllerRef: true
---
apiVersion: azure.m.upbound.io/v1beta1
kind: ResourceGroup
metadata:
  annotations:
    crossplane.io/composition-resource-name: rg
  labels:
    crossplane.io/composite: example
  name: example
  namespace: default
  ownerReferences:
  - apiVersion: platform.example.com/v1alpha1
    blockOwnerDeletion: true
    controller: true
    kind: XStorageBucket
    name: example
    uid: ""
spec:
  forProvider:
    location: eastus
```
