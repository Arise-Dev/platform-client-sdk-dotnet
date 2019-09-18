---
title: DataSchema
---
## ININ.PureCloudApi.Model.DataSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | The schema&#39;s version, a positive integer. Required for updates. | |
| **AppliesTo** | **List&lt;string&gt;** | One of \&quot;CONTACT\&quot; or \&quot;EXTERNAL_ORGANIZATION\&quot;.  Indicates the built-in entity type to which this schema applies. | [optional] |
| **Enabled** | **bool?** | The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists. | [optional] |
| **CreatedBy** | [**DomainEntityRef**](DomainEntityRef.html) | The URI of the user that created this schema. | [optional] |
| **DateCreated** | **DateTime?** | The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **JsonSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) | A JSON schema defining the extension to the built-in entity type. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


