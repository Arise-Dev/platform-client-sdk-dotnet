---
title: WorkPlanListItemResponse
---
## ININ.PureCloudApi.Model.WorkPlanListItemResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Enabled** | **bool?** | Whether the work plan is enabled for scheduling | [optional] |
| **ConstrainWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is enabled for this work plan | [optional] |
| **FlexibleWeeklyPaidTime** | **bool?** | Whether the weekly paid time constraint is flexible for this work plan | [optional] |
| **WeeklyExactPaidMinutes** | **int?** | Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == false | [optional] |
| **WeeklyMinimumPaidMinutes** | **int?** | Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true | [optional] |
| **WeeklyMaximumPaidMinutes** | **int?** | Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true | [optional] |
| **ConstrainPaidTimeGranularity** | **bool?** | Whether paid time granularity is constrained for this workplan | [optional] |
| **PaidTimeGranularityMinutes** | **int?** | Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity == true | [optional] |
| **ConstrainMinimumTimeBetweenShifts** | **bool?** | Whether the minimum time between shifts constraint is enabled for this work plan | [optional] |
| **MinimumTimeBetweenShiftsMinutes** | **int?** | Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts == true | [optional] |
| **MaximumDays** | **int?** | Maximum number days in a week allowed to be scheduled for this work plan | [optional] |
| **OptionalDays** | [**SetWrapperDayOfWeek**](SetWrapperDayOfWeek.html) | Optional days to schedule for this work plan. Populate with expand=details | [optional] |
| **ShiftStartVariances** | [**ListWrapperShiftStartVariance**](ListWrapperShiftStartVariance.html) | Variance in minutes among start times of shifts in this work plan. Populate with expand=details | [optional] |
| **Shifts** | [**List&lt;WorkPlanShift&gt;**](WorkPlanShift.html) | Shifts in this work plan. Populate with expand=details (defaults to empty list) | [optional] |
| **Agents** | [**List&lt;DeletableUserReference&gt;**](DeletableUserReference.html) | Agents in this work plan. Populate with expand=details (defaults to empty list) | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for this work plan | |
| **AgentCount** | **int?** | Number of agents in this work plan.  Populate with expand=agentCount | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


