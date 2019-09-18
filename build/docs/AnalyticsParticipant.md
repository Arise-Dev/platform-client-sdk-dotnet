---
title: AnalyticsParticipant
---
## ININ.PureCloudApi.Model.AnalyticsParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ParticipantId** | **string** | Unique identifier for the participant | [optional] |
| **ParticipantName** | **string** | A human readable name identifying the participant | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | List of attributes associated to this participant | [optional] |
| **UserId** | **string** | If a user, then this will be the unique identifier for the user | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose | [optional] |
| **ExternalContactId** | **string** | External Contact Identifier | [optional] |
| **ExternalOrganizationId** | **string** | External Organization Identifier | [optional] |
| **FlaggedReason** | **string** | Reason for which participant flagged conversation | [optional] |
| **Sessions** | [**List&lt;AnalyticsSession&gt;**](AnalyticsSession.html) | List of sessions associated to this participant | [optional] |
{: class="table table-striped"}


