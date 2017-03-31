---
title: Response
---
## ININ.PureCloudApi.Model.Response

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | Version number required for updates. | [optional] |
| **Libraries** | [**List&lt;UriReference&gt;**](UriReference.html) | One or more libraries response is associated with. | |
| **Texts** | [**List&lt;ResponseText&gt;**](ResponseText.html) | One or more texts associated with the response. | |
| **CreatedBy** | [**User**](User.html) | User that created the response | [optional] |
| **DateCreated** | **DateTime?** | The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **InteractionType** | **string** | The interaction type for this response. | [optional] |
| **Substitutions** | [**List&lt;ResponseSubstitution&gt;**](ResponseSubstitution.html) | Details about any text substitutions used in the texts for this response. | [optional] |
| **SubstitutionsSchema** | [**JsonSchemaDocument**](JsonSchemaDocument.html) | Metadata about the text substitutions in json schema format. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


