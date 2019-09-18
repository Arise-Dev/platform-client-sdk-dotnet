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
    /// A combination of a single queue and one or more media types to associate with a service goal group
    /// </summary>
    [DataContract]
    public partial class QueueMediaAssociation :  IEquatable<QueueMediaAssociation>
    {
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMediaAssociation" /> class.
        /// </summary>
        /// <param name="Queue">The queue to associate with the service goal group.</param>
        /// <param name="MediaTypes">The media types of the given queue to associate with the service goal group.</param>
        /// <param name="Delete">If marked true on a PATCH, this QueueMediaAssociation will be permanently deleted.</param>
        public QueueMediaAssociation(QueueReference Queue = null, List<MediaTypesEnum> MediaTypes = null, bool? Delete = null)
        {
            this.Queue = Queue;
            this.MediaTypes = MediaTypes;
            this.Delete = Delete;
            
        }
        
        
        
        /// <summary>
        /// The reference ID for this QueueMediaAssociation
        /// </summary>
        /// <value>The reference ID for this QueueMediaAssociation</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The queue to associate with the service goal group
        /// </summary>
        /// <value>The queue to associate with the service goal group</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueReference Queue { get; set; }
        
        
        
        /// <summary>
        /// The media types of the given queue to associate with the service goal group
        /// </summary>
        /// <value>The media types of the given queue to associate with the service goal group</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }
        
        
        
        /// <summary>
        /// If marked true on a PATCH, this QueueMediaAssociation will be permanently deleted
        /// </summary>
        /// <value>If marked true on a PATCH, this QueueMediaAssociation will be permanently deleted</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueMediaAssociation {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(obj as QueueMediaAssociation);
        }

        /// <summary>
        /// Returns true if QueueMediaAssociation instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueMediaAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueMediaAssociation other)
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
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
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
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                
                return hash;
            }
        }
    }

}
