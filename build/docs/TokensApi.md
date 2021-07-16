---
title: TokensApi
---
## PureCloudPlatform.Client.V2.Api.TokensApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteToken**](TokensApi.html#deletetoken) | **DELETE** /api/v2/tokens/{userId} | Delete all auth tokens for the specified user. |
| [**DeleteTokensMe**](TokensApi.html#deletetokensme) | **DELETE** /api/v2/tokens/me | Delete auth token used to make the request. |
| [**GetTokensMe**](TokensApi.html#gettokensme) | **GET** /api/v2/tokens/me | Fetch information about the current token |
| [**HeadTokensMe**](TokensApi.html#headtokensme) | **HEAD** /api/v2/tokens/me | Verify user token |
{: class="table table-striped"}

<a name="deletetoken"></a>

## void DeleteToken (string userId)



Delete all auth tokens for the specified user.



Requires ANY permissions: 

* oauth:token:delete

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTokenExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TokensApi();
            var userId = userId_example;  // string | User ID

            try
            { 
                // Delete all auth tokens for the specified user.
                apiInstance.DeleteToken(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.DeleteToken: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletetokensme"></a>

## void DeleteTokensMe ()



Delete auth token used to make the request.



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class DeleteTokensMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TokensApi();

            try
            { 
                // Delete auth token used to make the request.
                apiInstance.DeleteTokensMe();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.DeleteTokensMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

void (empty response body)

<a name="gettokensme"></a>

## [**TokenInfo**](TokenInfo.html) GetTokensMe ()



Fetch information about the current token



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class GetTokensMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TokensApi();

            try
            { 
                // Fetch information about the current token
                TokenInfo result = apiInstance.GetTokensMe();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.GetTokensMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

[**TokenInfo**](TokenInfo.html)

<a name="headtokensme"></a>

## void HeadTokensMe ()



Verify user token



Requires NO permissions: 


### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class HeadTokensMeExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new TokensApi();

            try
            { 
                // Verify user token
                apiInstance.HeadTokensMe();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokensApi.HeadTokensMe: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.


### Return type

void (empty response body)

