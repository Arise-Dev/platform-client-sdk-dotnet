---
title: DomainLogicalInterface
---
## ININ.PureCloudApi.Model.DomainLogicalInterface

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **EdgeUri** | **string** |  | [optional] |
| **EdgeAssignedId** | **string** |  | [optional] |
| **FriendlyName** | **string** | Friendly Name | |
| **VlanTagId** | **int?** |  | [optional] |
| **HardwareAddress** | **string** | Hardware Address | |
| **PhysicalAdapterId** | **string** | Physical Adapter Id | |
| **IfStatus** | **string** |  | [optional] |
| **InterfaceType** | **string** | The type of this network interface. | [optional] |
| **Routes** | [**List&lt;DomainNetworkRoute&gt;**](DomainNetworkRoute.html) | The list of routes assigned to this interface. | [optional] |
| **Addresses** | [**List&lt;DomainNetworkAddress&gt;**](DomainNetworkAddress.html) | The list of IP addresses on this interface.  Priority of dns addresses are based on order in the list. | [optional] |
| **Ipv4Capabilities** | [**DomainCapabilities**](DomainCapabilities.html) | IPv4 interface settings. | [optional] |
| **Ipv6Capabilities** | [**DomainCapabilities**](DomainCapabilities.html) | IPv6 interface settings. | [optional] |
| **CurrentState** | **string** |  | [optional] |
| **LastModifiedUserId** | **string** |  | [optional] |
| **LastModifiedCorrelationId** | **string** |  | [optional] |
| **CommandResponses** | [**List&lt;DomainNetworkCommandResponse&gt;**](DomainNetworkCommandResponse.html) |  | [optional] |
| **InheritPhoneTrunkBasesIPv4** | **bool?** | The IPv4 phone trunk base assignment will be inherited from the Edge Group. | [optional] |
| **InheritPhoneTrunkBasesIPv6** | **bool?** | The IPv6 phone trunk base assignment will be inherited from the Edge Group. | [optional] |
| **UseForInternalEdgeCommunication** | **bool?** | This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group. | [optional] |
| **ExternalTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | External trunk base settings to use for external communication from this interface. | [optional] |
| **PhoneTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}

