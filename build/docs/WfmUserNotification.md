---
title: WfmUserNotification
---
## ININ.PureCloudApi.Model.WfmUserNotification

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The immutable globally unique identifier for the object. | |
| **MutableGroupId** | **string** | The group ID of the notification (mutable, may change  on update) | |
| **Timestamp** | **DateTime?** | The timestamp for this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Type** | **string** | The type of this notification | [optional] |
| **ShiftTrade** | [**ShiftTradeNotification**](ShiftTradeNotification.html) | A shift trade notification.  Only set if type == ShiftTrade | [optional] |
| **MarkedAsRead** | **bool?** | Whether this notification has been marked \&quot;read\&quot; | |
| **AgentNotification** | **bool?** | Whether this notification is for an agent | [optional] |
| **OtherNotificationIdsInGroup** | **List&lt;string&gt;** | Other notification IDs in group.  This field is only populated in real-time notifications | [optional] |
{: class="table table-striped"}


