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
    /// AuditLogMessage
    /// </summary>
    [DataContract]
    public partial class AuditLogMessage :  IEquatable<AuditLogMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServiceNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Contactcenter for "ContactCenter"
            /// </summary>
            [EnumMember(Value = "ContactCenter")]
            Contactcenter,
            
            /// <summary>
            /// Enum Contentmanagement for "ContentManagement"
            /// </summary>
            [EnumMember(Value = "ContentManagement")]
            Contentmanagement,
            
            /// <summary>
            /// Enum Peoplepermissions for "PeoplePermissions"
            /// </summary>
            [EnumMember(Value = "PeoplePermissions")]
            Peoplepermissions,
            
            /// <summary>
            /// Enum Quality for "Quality"
            /// </summary>
            [EnumMember(Value = "Quality")]
            Quality,
            
            /// <summary>
            /// Enum Languageunderstanding for "LanguageUnderstanding"
            /// </summary>
            [EnumMember(Value = "LanguageUnderstanding")]
            Languageunderstanding,
            
            /// <summary>
            /// Enum Topicsdefinitions for "TopicsDefinitions"
            /// </summary>
            [EnumMember(Value = "TopicsDefinitions")]
            Topicsdefinitions,
            
            /// <summary>
            /// Enum Predictiveengagement for "PredictiveEngagement"
            /// </summary>
            [EnumMember(Value = "PredictiveEngagement")]
            Predictiveengagement,
            
            /// <summary>
            /// Enum Workforcemanagement for "WorkforceManagement"
            /// </summary>
            [EnumMember(Value = "WorkforceManagement")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum Triggers for "Triggers"
            /// </summary>
            [EnumMember(Value = "Triggers")]
            Triggers,
            
            /// <summary>
            /// Enum Responsemanagement for "ResponseManagement"
            /// </summary>
            [EnumMember(Value = "ResponseManagement")]
            Responsemanagement
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum View for "View"
            /// </summary>
            [EnumMember(Value = "View")]
            View,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,
            
            /// <summary>
            /// Enum Download for "Download"
            /// </summary>
            [EnumMember(Value = "Download")]
            Download,
            
            /// <summary>
            /// Enum Memberadd for "MemberAdd"
            /// </summary>
            [EnumMember(Value = "MemberAdd")]
            Memberadd,
            
            /// <summary>
            /// Enum Memberupdate for "MemberUpdate"
            /// </summary>
            [EnumMember(Value = "MemberUpdate")]
            Memberupdate,
            
            /// <summary>
            /// Enum Memberremove for "MemberRemove"
            /// </summary>
            [EnumMember(Value = "MemberRemove")]
            Memberremove,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Applyprotection for "ApplyProtection"
            /// </summary>
            [EnumMember(Value = "ApplyProtection")]
            Applyprotection,
            
            /// <summary>
            /// Enum Revokeprotection for "RevokeProtection"
            /// </summary>
            [EnumMember(Value = "RevokeProtection")]
            Revokeprotection,
            
            /// <summary>
            /// Enum Updateretention for "UpdateRetention"
            /// </summary>
            [EnumMember(Value = "UpdateRetention")]
            Updateretention,
            
            /// <summary>
            /// Enum Readall for "ReadAll"
            /// </summary>
            [EnumMember(Value = "ReadAll")]
            Readall,
            
            /// <summary>
            /// Enum Execute for "Execute"
            /// </summary>
            [EnumMember(Value = "Execute")]
            Execute,
            
            /// <summary>
            /// Enum Publish for "Publish"
            /// </summary>
            [EnumMember(Value = "Publish")]
            Publish,
            
            /// <summary>
            /// Enum Unpublish for "Unpublish"
            /// </summary>
            [EnumMember(Value = "Unpublish")]
            Unpublish,
            
            /// <summary>
            /// Enum Enable for "Enable"
            /// </summary>
            [EnumMember(Value = "Enable")]
            Enable,
            
            /// <summary>
            /// Enum Disable for "Disable"
            /// </summary>
            [EnumMember(Value = "Disable")]
            Disable,
            
            /// <summary>
            /// Enum Authorize for "Authorize"
            /// </summary>
            [EnumMember(Value = "Authorize")]
            Authorize,
            
            /// <summary>
            /// Enum Deauthorize for "Deauthorize"
            /// </summary>
            [EnumMember(Value = "Deauthorize")]
            Deauthorize,
            
            /// <summary>
            /// Enum Authenticate for "Authenticate"
            /// </summary>
            [EnumMember(Value = "Authenticate")]
            Authenticate,
            
            /// <summary>
            /// Enum Changepassword for "ChangePassword"
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            Changepassword
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Document for "Document"
            /// </summary>
            [EnumMember(Value = "Document")]
            Document,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Recording for "Recording"
            /// </summary>
            [EnumMember(Value = "Recording")]
            Recording,
            
            /// <summary>
            /// Enum Role for "Role"
            /// </summary>
            [EnumMember(Value = "Role")]
            Role,
            
            /// <summary>
            /// Enum Voicemailuserpolicy for "VoicemailUserPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailUserPolicy")]
            Voicemailuserpolicy,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapupCode"
            /// </summary>
            [EnumMember(Value = "WrapupCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Accesstoken for "AccessToken"
            /// </summary>
            [EnumMember(Value = "AccessToken")]
            Accesstoken,
            
            /// <summary>
            /// Enum Oauthclient for "OAuthClient"
            /// </summary>
            [EnumMember(Value = "OAuthClient")]
            Oauthclient,
            
            /// <summary>
            /// Enum Oauthclientauthorization for "OAuthClientAuthorization"
            /// </summary>
            [EnumMember(Value = "OAuthClientAuthorization")]
            Oauthclientauthorization,
            
            /// <summary>
            /// Enum Authorganization for "AuthOrganization"
            /// </summary>
            [EnumMember(Value = "AuthOrganization")]
            Authorganization,
            
            /// <summary>
            /// Enum Authuser for "AuthUser"
            /// </summary>
            [EnumMember(Value = "AuthUser")]
            Authuser,
            
            /// <summary>
            /// Enum Bulkactions for "BulkActions"
            /// </summary>
            [EnumMember(Value = "BulkActions")]
            Bulkactions,
            
            /// <summary>
            /// Enum Feedback for "Feedback"
            /// </summary>
            [EnumMember(Value = "Feedback")]
            Feedback,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Program for "Program"
            /// </summary>
            [EnumMember(Value = "Program")]
            Program,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum Sessiontype for "SessionType"
            /// </summary>
            [EnumMember(Value = "SessionType")]
            Sessiontype,
            
            /// <summary>
            /// Enum Eventtype for "EventType"
            /// </summary>
            [EnumMember(Value = "EventType")]
            Eventtype,
            
            /// <summary>
            /// Enum Clickstreamsettings for "ClickstreamSettings"
            /// </summary>
            [EnumMember(Value = "ClickstreamSettings")]
            Clickstreamsettings,
            
            /// <summary>
            /// Enum Schedule for "Schedule"
            /// </summary>
            [EnumMember(Value = "Schedule")]
            Schedule,
            
            /// <summary>
            /// Enum Trigger for "Trigger"
            /// </summary>
            [EnumMember(Value = "Trigger")]
            Trigger,
            
            /// <summary>
            /// Enum Response for "Response"
            /// </summary>
            [EnumMember(Value = "Response")]
            Response
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        
        
        
        
        
        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
        /// </summary>
        /// <param name="Id">Id of the audit message..</param>
        /// <param name="User">User associated with this audit message..</param>
        /// <param name="Client">Client associated with this audit message..</param>
        /// <param name="RemoteIp">List of IP addresses of systems that originated or handled the request..</param>
        /// <param name="ServiceName">Name of the service that logged this audit message..</param>
        /// <param name="EventDate">Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Message">Message describing the event being audited..</param>
        /// <param name="Action">Action that took place..</param>
        /// <param name="Entity">Entity that was impacted..</param>
        /// <param name="EntityType">Type of the entity that was impacted..</param>
        /// <param name="PropertyChanges">List of properties that were changed and changes made to those properties..</param>
        /// <param name="Context">Additional context for this message..</param>
        public AuditLogMessage(string Id = null, DomainEntityRef User = null, AddressableEntityRef Client = null, List<string> RemoteIp = null, ServiceNameEnum? ServiceName = null, DateTime? EventDate = null, MessageInfo Message = null, ActionEnum? Action = null, DomainEntityRef Entity = null, EntityTypeEnum? EntityType = null, List<PropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null)
        {
            this.Id = Id;
            this.User = User;
            this.Client = Client;
            this.RemoteIp = RemoteIp;
            this.ServiceName = ServiceName;
            this.EventDate = EventDate;
            this.Message = Message;
            this.Action = Action;
            this.Entity = Entity;
            this.EntityType = EntityType;
            this.PropertyChanges = PropertyChanges;
            this.Context = Context;
            
        }
        
        
        
        /// <summary>
        /// Id of the audit message.
        /// </summary>
        /// <value>Id of the audit message.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// User associated with this audit message.
        /// </summary>
        /// <value>User associated with this audit message.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DomainEntityRef User { get; set; }
        
        
        
        /// <summary>
        /// Client associated with this audit message.
        /// </summary>
        /// <value>Client associated with this audit message.</value>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public AddressableEntityRef Client { get; set; }
        
        
        
        /// <summary>
        /// List of IP addresses of systems that originated or handled the request.
        /// </summary>
        /// <value>List of IP addresses of systems that originated or handled the request.</value>
        [DataMember(Name="remoteIp", EmitDefaultValue=false)]
        public List<string> RemoteIp { get; set; }
        
        
        
        
        
        /// <summary>
        /// Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        public DateTime? EventDate { get; set; }
        
        
        
        /// <summary>
        /// Message describing the event being audited.
        /// </summary>
        /// <value>Message describing the event being audited.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MessageInfo Message { get; set; }
        
        
        
        
        
        /// <summary>
        /// Entity that was impacted.
        /// </summary>
        /// <value>Entity that was impacted.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public DomainEntityRef Entity { get; set; }
        
        
        
        
        
        /// <summary>
        /// List of properties that were changed and changes made to those properties.
        /// </summary>
        /// <value>List of properties that were changed and changes made to those properties.</value>
        [DataMember(Name="propertyChanges", EmitDefaultValue=false)]
        public List<PropertyChange> PropertyChanges { get; set; }
        
        
        
        /// <summary>
        /// Additional context for this message.
        /// </summary>
        /// <value>Additional context for this message.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public Dictionary<string, string> Context { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogMessage {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  RemoteIp: ").Append(RemoteIp).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as AuditLogMessage);
        }

        /// <summary>
        /// Returns true if AuditLogMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditLogMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogMessage other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) &&
                (
                    this.RemoteIp == other.RemoteIp ||
                    this.RemoteIp != null &&
                    this.RemoteIp.SequenceEqual(other.RemoteIp)
                ) &&
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) &&
                (
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.PropertyChanges == other.PropertyChanges ||
                    this.PropertyChanges != null &&
                    this.PropertyChanges.SequenceEqual(other.PropertyChanges)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.SequenceEqual(other.Context)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();
                
                if (this.RemoteIp != null)
                    hash = hash * 59 + this.RemoteIp.GetHashCode();
                
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                
                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();
                
                if (this.PropertyChanges != null)
                    hash = hash * 59 + this.PropertyChanges.GetHashCode();
                
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                
                return hash;
            }
        }
    }

}
