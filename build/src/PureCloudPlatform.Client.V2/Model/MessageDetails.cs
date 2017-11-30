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
    /// MessageDetails
    /// </summary>
    [DataContract]
    public partial class MessageDetails :  IEquatable<MessageDetails>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates the delivery status of the message.
        /// </summary>
        /// <value>Indicates the delivery status of the message.</value>
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
            /// Enum Queued for "queued"
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued,
            
            /// <summary>
            /// Enum Sent for "sent"
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Received for "received"
            /// </summary>
            [EnumMember(Value = "received")]
            Received
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates the delivery status of the message.
        /// </summary>
        /// <value>Indicates the delivery status of the message.</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDetails" /> class.
        /// </summary>
        
        
        /// <param name="MessageId">UUID identifying the message media..</param>
        
        
        
        /// <param name="MessageURI">A URI for this message entity..</param>
        
        
        
        /// <param name="MessageStatus">Indicates the delivery status of the message..</param>
        
        
        
        /// <param name="MessageSegmentCount">The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits..</param>
        
        
        
        /// <param name="MessageTime">The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        public MessageDetails(string MessageId = null, string MessageURI = null, MessageStatusEnum? MessageStatus = null, int? MessageSegmentCount = null, DateTime? MessageTime = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MessageId = MessageId;
            
            
            
            
            
            
            
            
this.MessageURI = MessageURI;
            
            
            
            
            
            
            
            
this.MessageStatus = MessageStatus;
            
            
            
            
            
            
            
            
this.MessageSegmentCount = MessageSegmentCount;
            
            
            
            
            
            
            
            
this.MessageTime = MessageTime;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// UUID identifying the message media.
        /// </summary>
        /// <value>UUID identifying the message media.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }
        
        
        
        /// <summary>
        /// A URI for this message entity.
        /// </summary>
        /// <value>A URI for this message entity.</value>
        [DataMember(Name="messageURI", EmitDefaultValue=false)]
        public string MessageURI { get; set; }
        
        
        
        
        
        /// <summary>
        /// The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.
        /// </summary>
        /// <value>The message segment count, greater than 1 if the message content was split into multiple parts for this message type, e.g. SMS character limits.</value>
        [DataMember(Name="messageSegmentCount", EmitDefaultValue=false)]
        public int? MessageSegmentCount { get; set; }
        
        
        
        /// <summary>
        /// The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the message was sent or received. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="messageTime", EmitDefaultValue=false)]
        public DateTime? MessageTime { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDetails {\n");
            
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            
            sb.Append("  MessageURI: ").Append(MessageURI).Append("\n");
            
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            
            sb.Append("  MessageSegmentCount: ").Append(MessageSegmentCount).Append("\n");
            
            sb.Append("  MessageTime: ").Append(MessageTime).Append("\n");
            
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
            return this.Equals(obj as MessageDetails);
        }

        /// <summary>
        /// Returns true if MessageDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.MessageURI == other.MessageURI ||
                    this.MessageURI != null &&
                    this.MessageURI.Equals(other.MessageURI)
                ) &&
                (
                    this.MessageStatus == other.MessageStatus ||
                    this.MessageStatus != null &&
                    this.MessageStatus.Equals(other.MessageStatus)
                ) &&
                (
                    this.MessageSegmentCount == other.MessageSegmentCount ||
                    this.MessageSegmentCount != null &&
                    this.MessageSegmentCount.Equals(other.MessageSegmentCount)
                ) &&
                (
                    this.MessageTime == other.MessageTime ||
                    this.MessageTime != null &&
                    this.MessageTime.Equals(other.MessageTime)
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
                
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                
                if (this.MessageURI != null)
                    hash = hash * 59 + this.MessageURI.GetHashCode();
                
                if (this.MessageStatus != null)
                    hash = hash * 59 + this.MessageStatus.GetHashCode();
                
                if (this.MessageSegmentCount != null)
                    hash = hash * 59 + this.MessageSegmentCount.GetHashCode();
                
                if (this.MessageTime != null)
                    hash = hash * 59 + this.MessageTime.GetHashCode();
                
                return hash;
            }
        }
    }

}
