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
    /// ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification
    /// </summary>
    [DataContract]
    public partial class ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification :  IEquatable<ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="User">User.</param>
        /// <param name="StartTime">StartTime.</param>
        public ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification(string Status = null, ArchitectDependencyTrackingBuildNotificationUser User = null, DateTime? StartTime = null)
        {
            this.Status = Status;
            this.User = User;
            this.StartTime = StartTime;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public ArchitectDependencyTrackingBuildNotificationUser User { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(obj as ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification);
        }

        /// <summary>
        /// Returns true if ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                return hash;
            }
        }
    }

}
