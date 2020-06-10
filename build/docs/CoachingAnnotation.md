---
title: CoachingAnnotation
---
## ININ.PureCloudApi.Model.CoachingAnnotation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **CreatedBy** | [**UserReference**](UserReference.html) | The user who created the annotation. | [optional] |
| **DateCreated** | **DateTime?** | The date/time the annotation was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | [**UserReference**](UserReference.html) | The last user to modify the annotation. | [optional] |
| **DateModified** | **DateTime?** | The date/time the annotation was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Text** | **string** | The text of the annotation. | |
| **IsDeleted** | **bool?** | Flag indicating whether the annotation is deleted. | [optional] |
| **AccessType** | **string** | Determines the permissions required to view this item. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


