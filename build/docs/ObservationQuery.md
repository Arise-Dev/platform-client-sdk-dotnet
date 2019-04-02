---
title: ObservationQuery
---
## ININ.PureCloudApi.Model.ObservationQuery

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Filter** | [**AnalyticsQueryFilter**](AnalyticsQueryFilter.html) | Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters | |
| **Metrics** | **List&lt;string&gt;** | Behaves like a SQL SELECT clause. Enables retrieving only named metrics. If omitted, all metrics that are available will be returned (like SELECT *). | [optional] |
| **DetailMetrics** | **List&lt;string&gt;** | Metrics for which to include additional detailed observations | [optional] |
{: class="table table-striped"}


