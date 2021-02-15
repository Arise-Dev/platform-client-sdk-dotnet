---
title: UploadsApi
---
## PureCloudPlatform.Client.V2.Api.UploadsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostUploadsPublicassetsImages**](UploadsApi.html#postuploadspublicassetsimages) | **POST** /api/v2/uploads/publicassets/images | Creates presigned url for uploading a public asset image |
| [**PostUploadsRecordings**](UploadsApi.html#postuploadsrecordings) | **POST** /api/v2/uploads/recordings | Creates presigned url for uploading a recording file |
| [**PostUploadsWorkforcemanagementHistoricaldataCsv**](UploadsApi.html#postuploadsworkforcemanagementhistoricaldatacsv) | **POST** /api/v2/uploads/workforcemanagement/historicaldata/csv | Creates presigned url for uploading WFM historical data file. Requires data in csv format. |
| [**PostUploadsWorkforcemanagementHistoricaldataJson**](UploadsApi.html#postuploadsworkforcemanagementhistoricaldatajson) | **POST** /api/v2/uploads/workforcemanagement/historicaldata/json | Creates presigned url for uploading WFM historical data file. Requires data in json format. |
{: class="table table-striped"}

<a name="postuploadspublicassetsimages"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsPublicassetsImages (UploadUrlRequest body)



Creates presigned url for uploading a public asset image



Requires ALL permissions: 

* uploads:publicasset:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsPublicassetsImagesExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading a public asset image
                UploadUrlResponse result = apiInstance.PostUploadsPublicassetsImages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsPublicassetsImages: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadsrecordings"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsRecordings (UploadUrlRequest body)



Creates presigned url for uploading a recording file



Requires ALL permissions: 

* recording:recording:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsRecordingsExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading a recording file
                UploadUrlResponse result = apiInstance.PostUploadsRecordings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsRecordings: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadsworkforcemanagementhistoricaldatacsv"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsWorkforcemanagementHistoricaldataCsv (UploadUrlRequest body)



Creates presigned url for uploading WFM historical data file. Requires data in csv format.



Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsWorkforcemanagementHistoricaldataCsvExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading WFM historical data file. Requires data in csv format.
                UploadUrlResponse result = apiInstance.PostUploadsWorkforcemanagementHistoricaldataCsv(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsWorkforcemanagementHistoricaldataCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

<a name="postuploadsworkforcemanagementhistoricaldatajson"></a>

## [**UploadUrlResponse**](UploadUrlResponse.html) PostUploadsWorkforcemanagementHistoricaldataJson (UploadUrlRequest body)



Creates presigned url for uploading WFM historical data file. Requires data in json format.



Requires ALL permissions: 

* wfm:historicalData:upload

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostUploadsWorkforcemanagementHistoricaldataJsonExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new UploadsApi();
            var body = new UploadUrlRequest(); // UploadUrlRequest | query

            try
            { 
                // Creates presigned url for uploading WFM historical data file. Requires data in json format.
                UploadUrlResponse result = apiInstance.PostUploadsWorkforcemanagementHistoricaldataJson(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.PostUploadsWorkforcemanagementHistoricaldataJson: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UploadUrlRequest**](UploadUrlRequest.html)| query |  |
{: class="table table-striped"}

### Return type

[**UploadUrlResponse**](UploadUrlResponse.html)

