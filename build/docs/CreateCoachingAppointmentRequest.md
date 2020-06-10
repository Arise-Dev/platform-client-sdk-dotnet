---
title: CreateCoachingAppointmentRequest
---
## ININ.PureCloudApi.Model.CreateCoachingAppointmentRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | The name of coaching appointment. | |
| **Description** | **string** | The description of coaching appointment. | |
| **DateStart** | **DateTime?** | The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **LengthInMinutes** | **int?** | The duration of coaching appointment in minutes. | |
| **FacilitatorId** | **string** | The facilitator ID of coaching appointment. | [optional] |
| **AttendeeIds** | **List&lt;string&gt;** | IDs of attendees in the coaching appointment. | |
| **ConversationIds** | **List&lt;string&gt;** | IDs of conversations associated with this coaching appointment. | |
| **DocumentIds** | **List&lt;string&gt;** | IDs of documents associated with this coaching appointment. | |
{: class="table table-striped"}


