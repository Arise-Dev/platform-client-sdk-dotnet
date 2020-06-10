---
title: UpdateCoachingAppointmentRequest
---
## ININ.PureCloudApi.Model.UpdateCoachingAppointmentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of coaching appointment. | [optional] |
| **Description** | **string** | The description of coaching appointment. | [optional] |
| **DateStart** | **DateTime?** | The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LengthInMinutes** | **int?** | The duration of coaching appointment in minutes. | [optional] |
| **ConversationIds** | **List&lt;string&gt;** | IDs of conversations associated with this coaching appointment. | [optional] |
| **DocumentIds** | **List&lt;string&gt;** | IDs of documents associated with this coaching appointment. | [optional] |
{: class="table table-striped"}


