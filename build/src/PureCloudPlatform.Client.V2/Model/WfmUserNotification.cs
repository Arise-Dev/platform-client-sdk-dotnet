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
    /// WfmUserNotification
    /// </summary>
    [DataContract]
    public partial class WfmUserNotification :  IEquatable<WfmUserNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this notification
        /// </summary>
        /// <value>The type of this notification</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Shifttrade for "ShiftTrade"
            /// </summary>
            [EnumMember(Value = "ShiftTrade")]
            Shifttrade
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this notification
        /// </summary>
        /// <value>The type of this notification</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmUserNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmUserNotification() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmUserNotification" /> class.
        /// </summary>
        /// <param name="Id">The immutable globally unique identifier for the object. (required).</param>
        /// <param name="MutableGroupId">The group ID of the notification (mutable, may change  on update) (required).</param>
        /// <param name="ShiftTrade">A shift trade notification.  Only set if type == ShiftTrade.</param>
        /// <param name="MarkedAsRead">Whether this notification has been marked \&quot;read\&quot; (required).</param>
        /// <param name="OtherNotificationIdsInGroup">Other notification IDs in group.  This field is only populated in real-time notifications.</param>
        public WfmUserNotification(string Id = null, string MutableGroupId = null, ShiftTradeNotification ShiftTrade = null, bool? MarkedAsRead = null, List<string> OtherNotificationIdsInGroup = null)
        {
            this.Id = Id;
            this.MutableGroupId = MutableGroupId;
            this.ShiftTrade = ShiftTrade;
            this.MarkedAsRead = MarkedAsRead;
            this.OtherNotificationIdsInGroup = OtherNotificationIdsInGroup;
            
        }
        
        
        
        /// <summary>
        /// The immutable globally unique identifier for the object.
        /// </summary>
        /// <value>The immutable globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The group ID of the notification (mutable, may change  on update)
        /// </summary>
        /// <value>The group ID of the notification (mutable, may change  on update)</value>
        [DataMember(Name="mutableGroupId", EmitDefaultValue=false)]
        public string MutableGroupId { get; set; }
        
        
        
        /// <summary>
        /// The timestamp for this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp for this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; private set; }
        
        
        
        
        
        /// <summary>
        /// A shift trade notification.  Only set if type == ShiftTrade
        /// </summary>
        /// <value>A shift trade notification.  Only set if type == ShiftTrade</value>
        [DataMember(Name="shiftTrade", EmitDefaultValue=false)]
        public ShiftTradeNotification ShiftTrade { get; set; }
        
        
        
        /// <summary>
        /// Whether this notification has been marked \&quot;read\&quot;
        /// </summary>
        /// <value>Whether this notification has been marked \&quot;read\&quot;</value>
        [DataMember(Name="markedAsRead", EmitDefaultValue=false)]
        public bool? MarkedAsRead { get; set; }
        
        
        
        /// <summary>
        /// Whether this notification is for an agent
        /// </summary>
        /// <value>Whether this notification is for an agent</value>
        [DataMember(Name="agentNotification", EmitDefaultValue=false)]
        public bool? AgentNotification { get; private set; }
        
        
        
        /// <summary>
        /// Other notification IDs in group.  This field is only populated in real-time notifications
        /// </summary>
        /// <value>Other notification IDs in group.  This field is only populated in real-time notifications</value>
        [DataMember(Name="otherNotificationIdsInGroup", EmitDefaultValue=false)]
        public List<string> OtherNotificationIdsInGroup { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmUserNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MutableGroupId: ").Append(MutableGroupId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ShiftTrade: ").Append(ShiftTrade).Append("\n");
            sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
            sb.Append("  AgentNotification: ").Append(AgentNotification).Append("\n");
            sb.Append("  OtherNotificationIdsInGroup: ").Append(OtherNotificationIdsInGroup).Append("\n");
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
            return this.Equals(obj as WfmUserNotification);
        }

        /// <summary>
        /// Returns true if WfmUserNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmUserNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmUserNotification other)
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
                    this.MutableGroupId == other.MutableGroupId ||
                    this.MutableGroupId != null &&
                    this.MutableGroupId.Equals(other.MutableGroupId)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ShiftTrade == other.ShiftTrade ||
                    this.ShiftTrade != null &&
                    this.ShiftTrade.Equals(other.ShiftTrade)
                ) &&
                (
                    this.MarkedAsRead == other.MarkedAsRead ||
                    this.MarkedAsRead != null &&
                    this.MarkedAsRead.Equals(other.MarkedAsRead)
                ) &&
                (
                    this.AgentNotification == other.AgentNotification ||
                    this.AgentNotification != null &&
                    this.AgentNotification.Equals(other.AgentNotification)
                ) &&
                (
                    this.OtherNotificationIdsInGroup == other.OtherNotificationIdsInGroup ||
                    this.OtherNotificationIdsInGroup != null &&
                    this.OtherNotificationIdsInGroup.SequenceEqual(other.OtherNotificationIdsInGroup)
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
                
                if (this.MutableGroupId != null)
                    hash = hash * 59 + this.MutableGroupId.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.ShiftTrade != null)
                    hash = hash * 59 + this.ShiftTrade.GetHashCode();
                
                if (this.MarkedAsRead != null)
                    hash = hash * 59 + this.MarkedAsRead.GetHashCode();
                
                if (this.AgentNotification != null)
                    hash = hash * 59 + this.AgentNotification.GetHashCode();
                
                if (this.OtherNotificationIdsInGroup != null)
                    hash = hash * 59 + this.OtherNotificationIdsInGroup.GetHashCode();
                
                return hash;
            }
        }
    }

}
