---
title: PatchSegment
---
## ININ.PureCloudApi.Model.PatchSegment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **IsActive** | **bool?** | Whether or not the segment is active. | [optional] |
| **DisplayName** | **string** | The display name of the segment. | |
| **Version** | **int?** | The version of the segment. | [optional] |
| **Description** | **string** | A description of the segment. | [optional] |
| **Color** | **string** | The hexadecimal color value of the segment. | [optional] |
| **ShouldDisplayToAgent** | **bool?** | Whether or not the segment should be displayed to agent/supervisor users. | [optional] |
| **Context** | [**Context**](Context.html) | The context of the segment. | [optional] |
| **Journey** | [**Journey**](Journey.html) | The pattern of rules defining the segment. | [optional] |
| **ExternalSegment** | [**PatchExternalSegment**](PatchExternalSegment.html) | Details of an entity corresponding to this segment in an external system. | [optional] |
| **AssignmentExpirationDays** | **int?** | Time, in days, from when the segment is assigned until it is automatically unassigned. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **CreatedDate** | **DateTime?** | Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ModifiedDate** | **DateTime?** | Timestamp indicating when the the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
{: class="table table-striped"}


