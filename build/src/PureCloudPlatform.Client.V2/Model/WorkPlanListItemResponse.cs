using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Work plan information
    /// </summary>
    [DataContract]
    public partial class WorkPlanListItemResponse :  IEquatable<WorkPlanListItemResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanListItemResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlanListItemResponse() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanListItemResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Enabled">Whether the work plan is enabled for scheduling.</param>
        /// <param name="ConstrainWeeklyPaidTime">Whether the weekly paid time constraint is enabled for this work plan.</param>
        /// <param name="FlexibleWeeklyPaidTime">Whether the weekly paid time constraint is flexible for this work plan.</param>
        /// <param name="WeeklyExactPaidMinutes">Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == false.</param>
        /// <param name="WeeklyMinimumPaidMinutes">Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true.</param>
        /// <param name="WeeklyMaximumPaidMinutes">Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true.</param>
        /// <param name="ConstrainPaidTimeGranularity">Whether paid time granularity is constrained for this workplan.</param>
        /// <param name="PaidTimeGranularityMinutes">Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity == true.</param>
        /// <param name="ConstrainMinimumTimeBetweenShifts">Whether the minimum time between shifts constraint is enabled for this work plan.</param>
        /// <param name="MinimumTimeBetweenShiftsMinutes">Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts == true.</param>
        /// <param name="MaximumDays">Maximum number days in a week allowed to be scheduled for this work plan.</param>
        /// <param name="MinimumWorkingDaysPerWeek">The minimum number of days that agents assigned to a work plan must work per week.</param>
        /// <param name="OptionalDays">Optional days to schedule for this work plan. Populate with expand=details.</param>
        /// <param name="ShiftStartVariances">Variance in minutes among start times of shifts in this work plan. Populate with expand=details.</param>
        /// <param name="Shifts">Shifts in this work plan. Populate with expand=details (defaults to empty list).</param>
        /// <param name="Agents">Agents in this work plan. Populate with expand=details (defaults to empty list).</param>
        /// <param name="Metadata">Version metadata for this work plan (required).</param>
        /// <param name="AgentCount">Number of agents in this work plan.  Populate with expand=agentCount.</param>
        public WorkPlanListItemResponse(string Name = null, bool? Enabled = null, bool? ConstrainWeeklyPaidTime = null, bool? FlexibleWeeklyPaidTime = null, int? WeeklyExactPaidMinutes = null, int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, bool? ConstrainPaidTimeGranularity = null, int? PaidTimeGranularityMinutes = null, bool? ConstrainMinimumTimeBetweenShifts = null, int? MinimumTimeBetweenShiftsMinutes = null, int? MaximumDays = null, int? MinimumWorkingDaysPerWeek = null, SetWrapperDayOfWeek OptionalDays = null, ListWrapperShiftStartVariance ShiftStartVariances = null, List<WorkPlanShift> Shifts = null, List<DeletableUserReference> Agents = null, WfmVersionedEntityMetadata Metadata = null, int? AgentCount = null)
        {
            this.Name = Name;
            this.Enabled = Enabled;
            this.ConstrainWeeklyPaidTime = ConstrainWeeklyPaidTime;
            this.FlexibleWeeklyPaidTime = FlexibleWeeklyPaidTime;
            this.WeeklyExactPaidMinutes = WeeklyExactPaidMinutes;
            this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
            this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
            this.ConstrainPaidTimeGranularity = ConstrainPaidTimeGranularity;
            this.PaidTimeGranularityMinutes = PaidTimeGranularityMinutes;
            this.ConstrainMinimumTimeBetweenShifts = ConstrainMinimumTimeBetweenShifts;
            this.MinimumTimeBetweenShiftsMinutes = MinimumTimeBetweenShiftsMinutes;
            this.MaximumDays = MaximumDays;
            this.MinimumWorkingDaysPerWeek = MinimumWorkingDaysPerWeek;
            this.OptionalDays = OptionalDays;
            this.ShiftStartVariances = ShiftStartVariances;
            this.Shifts = Shifts;
            this.Agents = Agents;
            this.Metadata = Metadata;
            this.AgentCount = AgentCount;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Whether the work plan is enabled for scheduling
        /// </summary>
        /// <value>Whether the work plan is enabled for scheduling</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// Whether the weekly paid time constraint is enabled for this work plan
        /// </summary>
        /// <value>Whether the weekly paid time constraint is enabled for this work plan</value>
        [DataMember(Name="constrainWeeklyPaidTime", EmitDefaultValue=false)]
        public bool? ConstrainWeeklyPaidTime { get; set; }
        
        
        
        /// <summary>
        /// Whether the weekly paid time constraint is flexible for this work plan
        /// </summary>
        /// <value>Whether the weekly paid time constraint is flexible for this work plan</value>
        [DataMember(Name="flexibleWeeklyPaidTime", EmitDefaultValue=false)]
        public bool? FlexibleWeeklyPaidTime { get; set; }
        
        
        
        /// <summary>
        /// Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == false
        /// </summary>
        /// <value>Exact weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == false</value>
        [DataMember(Name="weeklyExactPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyExactPaidMinutes { get; set; }
        
        
        
        /// <summary>
        /// Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true
        /// </summary>
        /// <value>Minimum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true</value>
        [DataMember(Name="weeklyMinimumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMinimumPaidMinutes { get; set; }
        
        
        
        /// <summary>
        /// Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true
        /// </summary>
        /// <value>Maximum weekly paid time in minutes for this work plan. Used if flexibleWeeklyPaidTime == true</value>
        [DataMember(Name="weeklyMaximumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMaximumPaidMinutes { get; set; }
        
        
        
        /// <summary>
        /// Whether paid time granularity is constrained for this workplan
        /// </summary>
        /// <value>Whether paid time granularity is constrained for this workplan</value>
        [DataMember(Name="constrainPaidTimeGranularity", EmitDefaultValue=false)]
        public bool? ConstrainPaidTimeGranularity { get; set; }
        
        
        
        /// <summary>
        /// Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity == true
        /// </summary>
        /// <value>Granularity in minutes allowed for shift paid time in this work plan. Used if constrainPaidTimeGranularity == true</value>
        [DataMember(Name="paidTimeGranularityMinutes", EmitDefaultValue=false)]
        public int? PaidTimeGranularityMinutes { get; set; }
        
        
        
        /// <summary>
        /// Whether the minimum time between shifts constraint is enabled for this work plan
        /// </summary>
        /// <value>Whether the minimum time between shifts constraint is enabled for this work plan</value>
        [DataMember(Name="constrainMinimumTimeBetweenShifts", EmitDefaultValue=false)]
        public bool? ConstrainMinimumTimeBetweenShifts { get; set; }
        
        
        
        /// <summary>
        /// Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts == true
        /// </summary>
        /// <value>Minimum time between shifts in minutes defined in this work plan. Used if constrainMinimumTimeBetweenShifts == true</value>
        [DataMember(Name="minimumTimeBetweenShiftsMinutes", EmitDefaultValue=false)]
        public int? MinimumTimeBetweenShiftsMinutes { get; set; }
        
        
        
        /// <summary>
        /// Maximum number days in a week allowed to be scheduled for this work plan
        /// </summary>
        /// <value>Maximum number days in a week allowed to be scheduled for this work plan</value>
        [DataMember(Name="maximumDays", EmitDefaultValue=false)]
        public int? MaximumDays { get; set; }
        
        
        
        /// <summary>
        /// The minimum number of days that agents assigned to a work plan must work per week
        /// </summary>
        /// <value>The minimum number of days that agents assigned to a work plan must work per week</value>
        [DataMember(Name="minimumWorkingDaysPerWeek", EmitDefaultValue=false)]
        public int? MinimumWorkingDaysPerWeek { get; set; }
        
        
        
        /// <summary>
        /// Optional days to schedule for this work plan. Populate with expand=details
        /// </summary>
        /// <value>Optional days to schedule for this work plan. Populate with expand=details</value>
        [DataMember(Name="optionalDays", EmitDefaultValue=false)]
        public SetWrapperDayOfWeek OptionalDays { get; set; }
        
        
        
        /// <summary>
        /// Variance in minutes among start times of shifts in this work plan. Populate with expand=details
        /// </summary>
        /// <value>Variance in minutes among start times of shifts in this work plan. Populate with expand=details</value>
        [DataMember(Name="shiftStartVariances", EmitDefaultValue=false)]
        public ListWrapperShiftStartVariance ShiftStartVariances { get; set; }
        
        
        
        /// <summary>
        /// Shifts in this work plan. Populate with expand=details (defaults to empty list)
        /// </summary>
        /// <value>Shifts in this work plan. Populate with expand=details (defaults to empty list)</value>
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<WorkPlanShift> Shifts { get; set; }
        
        
        
        /// <summary>
        /// Agents in this work plan. Populate with expand=details (defaults to empty list)
        /// </summary>
        /// <value>Agents in this work plan. Populate with expand=details (defaults to empty list)</value>
        [DataMember(Name="agents", EmitDefaultValue=false)]
        public List<DeletableUserReference> Agents { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for this work plan
        /// </summary>
        /// <value>Version metadata for this work plan</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        
        /// <summary>
        /// Number of agents in this work plan.  Populate with expand=agentCount
        /// </summary>
        /// <value>Number of agents in this work plan.  Populate with expand=agentCount</value>
        [DataMember(Name="agentCount", EmitDefaultValue=false)]
        public int? AgentCount { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanListItemResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ConstrainWeeklyPaidTime: ").Append(ConstrainWeeklyPaidTime).Append("\n");
            sb.Append("  FlexibleWeeklyPaidTime: ").Append(FlexibleWeeklyPaidTime).Append("\n");
            sb.Append("  WeeklyExactPaidMinutes: ").Append(WeeklyExactPaidMinutes).Append("\n");
            sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
            sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
            sb.Append("  ConstrainPaidTimeGranularity: ").Append(ConstrainPaidTimeGranularity).Append("\n");
            sb.Append("  PaidTimeGranularityMinutes: ").Append(PaidTimeGranularityMinutes).Append("\n");
            sb.Append("  ConstrainMinimumTimeBetweenShifts: ").Append(ConstrainMinimumTimeBetweenShifts).Append("\n");
            sb.Append("  MinimumTimeBetweenShiftsMinutes: ").Append(MinimumTimeBetweenShiftsMinutes).Append("\n");
            sb.Append("  MaximumDays: ").Append(MaximumDays).Append("\n");
            sb.Append("  MinimumWorkingDaysPerWeek: ").Append(MinimumWorkingDaysPerWeek).Append("\n");
            sb.Append("  OptionalDays: ").Append(OptionalDays).Append("\n");
            sb.Append("  ShiftStartVariances: ").Append(ShiftStartVariances).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AgentCount: ").Append(AgentCount).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WorkPlanListItemResponse);
        }

        /// <summary>
        /// Returns true if WorkPlanListItemResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanListItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanListItemResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.ConstrainWeeklyPaidTime == other.ConstrainWeeklyPaidTime ||
                    this.ConstrainWeeklyPaidTime != null &&
                    this.ConstrainWeeklyPaidTime.Equals(other.ConstrainWeeklyPaidTime)
                ) &&
                (
                    this.FlexibleWeeklyPaidTime == other.FlexibleWeeklyPaidTime ||
                    this.FlexibleWeeklyPaidTime != null &&
                    this.FlexibleWeeklyPaidTime.Equals(other.FlexibleWeeklyPaidTime)
                ) &&
                (
                    this.WeeklyExactPaidMinutes == other.WeeklyExactPaidMinutes ||
                    this.WeeklyExactPaidMinutes != null &&
                    this.WeeklyExactPaidMinutes.Equals(other.WeeklyExactPaidMinutes)
                ) &&
                (
                    this.WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                    this.WeeklyMinimumPaidMinutes != null &&
                    this.WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
                ) &&
                (
                    this.WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                    this.WeeklyMaximumPaidMinutes != null &&
                    this.WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
                ) &&
                (
                    this.ConstrainPaidTimeGranularity == other.ConstrainPaidTimeGranularity ||
                    this.ConstrainPaidTimeGranularity != null &&
                    this.ConstrainPaidTimeGranularity.Equals(other.ConstrainPaidTimeGranularity)
                ) &&
                (
                    this.PaidTimeGranularityMinutes == other.PaidTimeGranularityMinutes ||
                    this.PaidTimeGranularityMinutes != null &&
                    this.PaidTimeGranularityMinutes.Equals(other.PaidTimeGranularityMinutes)
                ) &&
                (
                    this.ConstrainMinimumTimeBetweenShifts == other.ConstrainMinimumTimeBetweenShifts ||
                    this.ConstrainMinimumTimeBetweenShifts != null &&
                    this.ConstrainMinimumTimeBetweenShifts.Equals(other.ConstrainMinimumTimeBetweenShifts)
                ) &&
                (
                    this.MinimumTimeBetweenShiftsMinutes == other.MinimumTimeBetweenShiftsMinutes ||
                    this.MinimumTimeBetweenShiftsMinutes != null &&
                    this.MinimumTimeBetweenShiftsMinutes.Equals(other.MinimumTimeBetweenShiftsMinutes)
                ) &&
                (
                    this.MaximumDays == other.MaximumDays ||
                    this.MaximumDays != null &&
                    this.MaximumDays.Equals(other.MaximumDays)
                ) &&
                (
                    this.MinimumWorkingDaysPerWeek == other.MinimumWorkingDaysPerWeek ||
                    this.MinimumWorkingDaysPerWeek != null &&
                    this.MinimumWorkingDaysPerWeek.Equals(other.MinimumWorkingDaysPerWeek)
                ) &&
                (
                    this.OptionalDays == other.OptionalDays ||
                    this.OptionalDays != null &&
                    this.OptionalDays.Equals(other.OptionalDays)
                ) &&
                (
                    this.ShiftStartVariances == other.ShiftStartVariances ||
                    this.ShiftStartVariances != null &&
                    this.ShiftStartVariances.Equals(other.ShiftStartVariances)
                ) &&
                (
                    this.Shifts == other.Shifts ||
                    this.Shifts != null &&
                    this.Shifts.SequenceEqual(other.Shifts)
                ) &&
                (
                    this.Agents == other.Agents ||
                    this.Agents != null &&
                    this.Agents.SequenceEqual(other.Agents)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.AgentCount == other.AgentCount ||
                    this.AgentCount != null &&
                    this.AgentCount.Equals(other.AgentCount)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.ConstrainWeeklyPaidTime != null)
                    hash = hash * 59 + this.ConstrainWeeklyPaidTime.GetHashCode();
                
                if (this.FlexibleWeeklyPaidTime != null)
                    hash = hash * 59 + this.FlexibleWeeklyPaidTime.GetHashCode();
                
                if (this.WeeklyExactPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyExactPaidMinutes.GetHashCode();
                
                if (this.WeeklyMinimumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMinimumPaidMinutes.GetHashCode();
                
                if (this.WeeklyMaximumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMaximumPaidMinutes.GetHashCode();
                
                if (this.ConstrainPaidTimeGranularity != null)
                    hash = hash * 59 + this.ConstrainPaidTimeGranularity.GetHashCode();
                
                if (this.PaidTimeGranularityMinutes != null)
                    hash = hash * 59 + this.PaidTimeGranularityMinutes.GetHashCode();
                
                if (this.ConstrainMinimumTimeBetweenShifts != null)
                    hash = hash * 59 + this.ConstrainMinimumTimeBetweenShifts.GetHashCode();
                
                if (this.MinimumTimeBetweenShiftsMinutes != null)
                    hash = hash * 59 + this.MinimumTimeBetweenShiftsMinutes.GetHashCode();
                
                if (this.MaximumDays != null)
                    hash = hash * 59 + this.MaximumDays.GetHashCode();
                
                if (this.MinimumWorkingDaysPerWeek != null)
                    hash = hash * 59 + this.MinimumWorkingDaysPerWeek.GetHashCode();
                
                if (this.OptionalDays != null)
                    hash = hash * 59 + this.OptionalDays.GetHashCode();
                
                if (this.ShiftStartVariances != null)
                    hash = hash * 59 + this.ShiftStartVariances.GetHashCode();
                
                if (this.Shifts != null)
                    hash = hash * 59 + this.Shifts.GetHashCode();
                
                if (this.Agents != null)
                    hash = hash * 59 + this.Agents.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.AgentCount != null)
                    hash = hash * 59 + this.AgentCount.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
