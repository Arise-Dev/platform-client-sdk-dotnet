---
title: Relationship
---
## ININ.PureCloudApi.Model.Relationship

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **User** | [**User**](User.html) | The user associated with the external organization | |
| **ExternalOrganization** | [**ExternalOrganization**](ExternalOrganization.html) | The external organization this relationship is attached to | |
| **_Relationship** | **string** | The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant | |
| **ExternalDataSources** | [**List&lt;ExternalDataSource&gt;**](ExternalDataSource.html) | Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


