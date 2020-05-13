---
title: BuAsyncAgentSchedulesQueryResponse
---
## ININ.PureCloudApi.Model.BuAsyncAgentSchedulesQueryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of the operation | [optional] |
| **OperationId** | **string** | The ID for the operation | [optional] |
| **Result** | [**BuAgentSchedulesQueryResponse**](BuAgentSchedulesQueryResponse.html) | The result of the operation.  Null unless status == Complete | [optional] |
| **Progress** | **int?** | Percent progress for the operation | [optional] |
| **DownloadUrl** | **string** | The URL from which to download the result if it is too large to pass directly | [optional] |
{: class="table table-striped"}


