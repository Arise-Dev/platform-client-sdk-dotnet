---
title: RuleSet
---
## ININ.PureCloudApi.Model.RuleSet

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the RuleSet. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**UriReference**](UriReference.html) | A ContactList to provide user-interface suggestions for contact columns on relevant conditions and actions. | [optional] |
| **Queue** | [**UriReference**](UriReference.html) | A Queue to provide user-interface suggestions for wrap-up codes on relevant conditions and actions. | [optional] |
| **Rules** | [**List&lt;DialerRule&gt;**](DialerRule.html) | The list of rules. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


