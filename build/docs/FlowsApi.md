---
title: FlowsApi
---
## PureCloudPlatform.Client.V2.Api.FlowsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**PostAnalyticsFlowsAggregatesQuery**](FlowsApi.html#postanalyticsflowsaggregatesquery) | **POST** /api/v2/analytics/flows/aggregates/query | Query for flow aggregates |
| [**PostAnalyticsFlowsObservationsQuery**](FlowsApi.html#postanalyticsflowsobservationsquery) | **POST** /api/v2/analytics/flows/observations/query | Query for flow observations |
{: class="table table-striped"}

<a name="postanalyticsflowsaggregatesquery"></a>

## [**FlowAggregateQueryResponse**](FlowAggregateQueryResponse.html) PostAnalyticsFlowsAggregatesQuery (FlowAggregationQuery body)



Query for flow aggregates



Requires ANY permissions: 

* analytics:flowAggregate:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowsAggregatesQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FlowsApi();
            var body = new FlowAggregationQuery(); // FlowAggregationQuery | query

            try
            { 
                // Query for flow aggregates
                FlowAggregateQueryResponse result = apiInstance.PostAnalyticsFlowsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowsApi.PostAnalyticsFlowsAggregatesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowAggregationQuery**](FlowAggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**FlowAggregateQueryResponse**](FlowAggregateQueryResponse.html)

<a name="postanalyticsflowsobservationsquery"></a>

## [**FlowObservationQueryResponse**](FlowObservationQueryResponse.html) PostAnalyticsFlowsObservationsQuery (FlowObservationQuery body)



Query for flow observations



Requires ANY permissions: 

* analytics:flowObservation:view

### Example
```{"language":"csharp"}
using System;
using System.Diagnostics;
using PureCloudPlatform.Client.V2.Api;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace Example
{
    public class PostAnalyticsFlowsObservationsQueryExample
    {
        public void main()
        { 
            // Configure OAuth2 access token for authorization: PureCloud OAuth
            // The following example is using the Authorization Code Grant
            var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
                "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
                "http://redirecturi.com/",
                "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");

            var apiInstance = new FlowsApi();
            var body = new FlowObservationQuery(); // FlowObservationQuery | query

            try
            { 
                // Query for flow observations
                FlowObservationQueryResponse result = apiInstance.PostAnalyticsFlowsObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowsApi.PostAnalyticsFlowsObservationsQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FlowObservationQuery**](FlowObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**FlowObservationQueryResponse**](FlowObservationQueryResponse.html)

