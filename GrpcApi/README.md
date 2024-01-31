# Google CommonProtos 

## Nuget Package
There is no DateOnly type in protobuf we have to install a nuget ```Google.Api.CommonProtos```

## Add link to project
As well as the dotnet-grpc tool to import the reference
```powershell
dotnet tool install -g dotnet-grpc
```

the add the file with 
```powershell
dotnet-grpc add-file %UserProfile%\.nuget\packages\google.api.commonprotos\2.13.0\content\protos\google\type\date.proto
```

## Syntax resolving in Rider

For these protos to be recognized by rider we have to add their path 
>Settings -> Languages & Frameworks > Protocol Buffers -> Import Paths
