---
title: Message
---
## ININ.PureCloudApi.Model.Message

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) | The time line of the participant&#39;s message, divided into activity segments. | [optional] |
| **Direction** | **string** | The direction of the message. | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this message. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) |  | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Provider** | **string** | The source provider for the message. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **ToAddress** | [**Address**](Address.html) | Address and name data for a call endpoint. | [optional] |
| **FromAddress** | [**Address**](Address.html) | Address and name data for a call endpoint. | [optional] |
| **Messages** | [**List&lt;MessageDetails&gt;**](MessageDetails.html) | The messages sent on this communication channel. | [optional] |
{: class="table table-striped"}


