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
    /// MessageConversationNotificationMessageDetails
    /// </summary>
    [DataContract]
    public partial class MessageConversationNotificationMessageDetails :  IEquatable<MessageConversationNotificationMessageDetails>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MessageStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queued for "QUEUED"
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            Queued,
            
            /// <summary>
            /// Enum Sent for "SENT"
            /// </summary>
            [EnumMember(Value = "SENT")]
            Sent,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum Received for "RECEIVED"
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            Received
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MessageStatus
        /// </summary>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageConversationNotificationMessageDetails" /> class.
        /// </summary>
        
        
        /// <param name="Message">Message.</param>
        
        
        
        /// <param name="MessageTime">MessageTime.</param>
        
        
        
        /// <param name="MessageSegmentCount">MessageSegmentCount.</param>
        
        
        
        /// <param name="MessageStatus">MessageStatus.</param>
        
        
        
        /// <param name="Media">Media.</param>
        
        
        public MessageConversationNotificationMessageDetails(MessageConversationNotificationUriReference Message = null, DateTime? MessageTime = null, int? MessageSegmentCount = null, MessageStatusEnum? MessageStatus = null, List<ConversationNotificationMedia> Media = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Message = Message;
            
            
            
            
            
            
            
            
this.MessageTime = MessageTime;
            
            
            
            
            
            
            
            
this.MessageSegmentCount = MessageSegmentCount;
            
            
            
            
            
            
            
            
this.MessageStatus = MessageStatus;
            
            
            
            
            
            
            
            
this.Media = Media;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MessageConversationNotificationUriReference Message { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageTime
        /// </summary>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageSegmentCount
        /// </summary>
        [DataMember(Name="messageSegmentCount", EmitDefaultValue=false)]
        public int? MessageSegmentCount { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public List<ConversationNotificationMedia> Media { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageConversationNotificationMessageDetails {\n");
            
            sb.Append("  Message: ").Append(Message).Append("\n");
            
            sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
            
            sb.Append("  MessageSegmentCount: ").Append(MessageSegmentCount).Append("\n");
            
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            
            sb.Append("  Media: ").Append(Media).Append("\n");
            
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
            return this.Equals(obj as MessageConversationNotificationMessageDetails);
        }

        /// <summary>
        /// Returns true if MessageConversationNotificationMessageDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageConversationNotificationMessageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageConversationNotificationMessageDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.MessageTime == other.MessageTime ||
                    this.MessageTime != null &&
                    this.MessageTime.Equals(other.MessageTime)
                ) &&
                (
                    this.MessageSegmentCount == other.MessageSegmentCount ||
                    this.MessageSegmentCount != null &&
                    this.MessageSegmentCount.Equals(other.MessageSegmentCount)
                ) &&
                (
                    this.MessageStatus == other.MessageStatus ||
                    this.MessageStatus != null &&
                    this.MessageStatus.Equals(other.MessageStatus)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.SequenceEqual(other.Media)
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
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.MessageTime != null)
                    hash = hash * 59 + this.MessageTime.GetHashCode();
                
                if (this.MessageSegmentCount != null)
                    hash = hash * 59 + this.MessageSegmentCount.GetHashCode();
                
                if (this.MessageStatus != null)
                    hash = hash * 59 + this.MessageStatus.GetHashCode();
                
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                
                return hash;
            }
        }
    }

}
