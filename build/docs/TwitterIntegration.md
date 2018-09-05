---
title: TwitterIntegration
---
## ININ.PureCloudApi.Model.TwitterIntegration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | A unique Integration Id | |
| **Name** | **string** | The name of the Twitter Integration | |
| **AccessTokenKey** | **string** | The Access Token Key from Twitter messenger | |
| **ConsumerKey** | **string** | The Consumer Key from Twitter messenger | |
| **Username** | **string** | The Username from Twitter | [optional] |
| **UserId** | **string** | The UserId from Twitter | [optional] |
| **Status** | **string** | The status of the Twitter Integration | [optional] |
| **Tier** | **string** | The type of twitter account to be used for the integration | |
| **EnvName** | **string** | The Twitter environment name, e.g.: env-beta (required for premium tier) | [optional] |
| **Recipient** | [**UriReference**](UriReference.html) | The recipient associated to the Twitter Integration. This recipient is used to associate a flow to an integration | [optional] |
| **DateCreated** | **DateTime?** | Date this Integration was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date this Integration was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedBy** | [**UriReference**](UriReference.html) | User reference that created this Integration | [optional] |
| **ModifiedBy** | [**UriReference**](UriReference.html) | User reference that last modified this Integration | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


