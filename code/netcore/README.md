# Org.OpenAPITools - the C# library for the Reisdocumenten

API voor het ontsluiten van gegevens van reisdocumenten uit de GBA en RNI.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://github.com/VNG-Realisatie/Bevragingen-ingeschreven-personen](https://github.com/VNG-Realisatie/Bevragingen-ingeschreven-personen)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://virtserver.swaggerhub.com/VNGRealisatie/api/reisdocumenten";
            var apiInstance = new ReisdocumentenApi(config);
            var reisdocumentnummer = reisdocumentnummer_example;  // string | Het nummer van het verstrekte Nederlandse reisdocument.

            try
            {
                ReisdocumentHal result = apiInstance.ReisdocumentenReisdocumentnummer(reisdocumentnummer);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReisdocumentenApi.ReisdocumentenReisdocumentnummer: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://virtserver.swaggerhub.com/VNGRealisatie/api/reisdocumenten*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ReisdocumentenApi* | [**ReisdocumentenReisdocumentnummer**](docs/ReisdocumentenApi.md#reisdocumentenreisdocumentnummer) | **GET** /reisdocumenten/{reisdocumentnummer} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AanduidingInhoudingVermissingReisdocumentEnum](docs/AanduidingInhoudingVermissingReisdocumentEnum.md)
 - [Model.BadRequestFoutbericht](docs/BadRequestFoutbericht.md)
 - [Model.BadRequestFoutberichtAllOf](docs/BadRequestFoutberichtAllOf.md)
 - [Model.DatumOnvolledig](docs/DatumOnvolledig.md)
 - [Model.Foutbericht](docs/Foutbericht.md)
 - [Model.HalLink](docs/HalLink.md)
 - [Model.InvalidParams](docs/InvalidParams.md)
 - [Model.Reisdocument](docs/Reisdocument.md)
 - [Model.ReisdocumentHal](docs/ReisdocumentHal.md)
 - [Model.ReisdocumentHalAllOf](docs/ReisdocumentHalAllOf.md)
 - [Model.ReisdocumentInOnderzoek](docs/ReisdocumentInOnderzoek.md)
 - [Model.ReisdocumentLinks](docs/ReisdocumentLinks.md)
 - [Model.Waardetabel](docs/Waardetabel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
