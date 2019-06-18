# OriginStamp C# Client - the C# library for the OriginStamp API

[![Build Status](https://travis-ci.com/OriginStampTimestamping/originstamp-client-csharp.svg?branch=master)](https://travis-ci.com/OriginStampTimestamping/originstamp-client-csharp)

![](https://originstamp.com/assets/images/logo/logo_simple_small.png)

> A C# implementation of the OriginStamp API

For endpoint documentation see [OriginStamp Documentation](https://docs.originstamp.com).
This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://originstamp.com](https://originstamp.com)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 11.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.1 or later

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;
```

## Getting Started

The package is available via [NuGet] (https://docs.nuget.org/consume/installing-nuget) [here](https://www.nuget.org/packages/OriginStamp.ApiClient/).

```csharp
using System;
using System.Diagnostics;
using OriginStamp.Client.Api;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace Example
{
    public class CreateTimestampExample
    {
        public void main()
        {
            var apiInstance = new TimestampApi();
            var authorization = "authorization_example";  // string | A valid API key is essential for authorization to handle the request.
            var timestampRequest = new TimestampRequest(); // TimestampRequest | DTO for the hash submission. Add all relevant information concerning your hash submission.

            try
            {
                // Submission
                DefaultTimestampResponse result = apiInstance.CreateTimestamp(authorization, timestampRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimestampApi.CreateTimestamp: " + e.Message );
            }
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.originstamp.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*SchedulerApi* | [**GetNextSchedulingTime**](docs/SchedulerApi.md#getnextschedulingtime) | **POST** /v3/submission/times | NextSchedule
*TimestampApi* | [**CreateTimestamp**](docs/TimestampApi.md#createtimestamp) | **POST** /v3/timestamp/create | Submission
*TimestampApi* | [**GetApiKeyUsage**](docs/TimestampApi.md#getapikeyusage) | **GET** /v3/api_key/usage | Usage
*TimestampApi* | [**GetHashStatus**](docs/TimestampApi.md#gethashstatus) | **GET** /v3/timestamp/{hash_string} | Status
*TimestampApi* | [**GetProof**](docs/TimestampApi.md#getproof) | **POST** /v3/timestamp/proof | Proof
*TimestampApi* | [**TriggerTimestampWebhook**](docs/TimestampApi.md#triggertimestampwebhook) | **POST** /v3/webhook/start | Dev


## Documentation for Models

 - [Model.DefaultSchedulerResponse](docs/DefaultSchedulerResponse.md)
 - [Model.DefaultTimestampResponse](docs/DefaultTimestampResponse.md)
 - [Model.DefaultUsageResponse](docs/DefaultUsageResponse.md)
 - [Model.Defaultstring](docs/Defaultstring.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.ProofRequest](docs/ProofRequest.md)
 - [Model.ResponseEntity](docs/ResponseEntity.md)
 - [Model.SchedulerRequest](docs/SchedulerRequest.md)
 - [Model.SchedulerResponse](docs/SchedulerResponse.md)
 - [Model.TimestampData](docs/TimestampData.md)
 - [Model.TimestampRequest](docs/TimestampRequest.md)
 - [Model.TimestampResponse](docs/TimestampResponse.md)
 - [Model.UsageResponse](docs/UsageResponse.md)
 - [Model.WebhookRequest](docs/WebhookRequest.md)

## Documentation for Authorization

Authentication schemes defined for the API:
### Key Authorization

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

## Author

mail@originstamp.com
