---
title: UserObservationQuery
---
## ININ.PureCloudApi.Model.UserObservationQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Filter** | [**UserObservationQueryFilter**](UserObservationQueryFilter.html) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | |
| **Metrics** | **List&lt;string&gt;** | Behaves like a SQL SELECT clause. Only named metrics will be retrieved. | |
| **DetailMetrics** | **List&lt;string&gt;** | Metrics for which to include additional detailed observations | [optional] |
{: class="table table-striped"}


