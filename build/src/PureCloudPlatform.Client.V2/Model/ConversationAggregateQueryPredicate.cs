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
    /// ConversationAggregateQueryPredicate
    /// </summary>
    [DataContract]
    public partial class ConversationAggregateQueryPredicate :  IEquatable<ConversationAggregateQueryPredicate>
    {
        
        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
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
            /// Enum Dimension for "dimension"
            /// </summary>
            [EnumMember(Value = "dimension")]
            Dimension,
            
            /// <summary>
            /// Enum Property for "property"
            /// </summary>
            [EnumMember(Value = "property")]
            Property,
            
            /// <summary>
            /// Enum Metric for "metric"
            /// </summary>
            [EnumMember(Value = "metric")]
            Metric
        }
        
        
        
        
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Addressfrom for "addressFrom"
            /// </summary>
            [EnumMember(Value = "addressFrom")]
            Addressfrom,
            
            /// <summary>
            /// Enum Addressto for "addressTo"
            /// </summary>
            [EnumMember(Value = "addressTo")]
            Addressto,
            
            /// <summary>
            /// Enum Agentassistantid for "agentAssistantId"
            /// </summary>
            [EnumMember(Value = "agentAssistantId")]
            Agentassistantid,
            
            /// <summary>
            /// Enum Agentrank for "agentRank"
            /// </summary>
            [EnumMember(Value = "agentRank")]
            Agentrank,
            
            /// <summary>
            /// Enum Agentscore for "agentScore"
            /// </summary>
            [EnumMember(Value = "agentScore")]
            Agentscore,
            
            /// <summary>
            /// Enum Ani for "ani"
            /// </summary>
            [EnumMember(Value = "ani")]
            Ani,
            
            /// <summary>
            /// Enum Assignerid for "assignerId"
            /// </summary>
            [EnumMember(Value = "assignerId")]
            Assignerid,
            
            /// <summary>
            /// Enum Conversationid for "conversationId"
            /// </summary>
            [EnumMember(Value = "conversationId")]
            Conversationid,
            
            /// <summary>
            /// Enum Convertedfrom for "convertedFrom"
            /// </summary>
            [EnumMember(Value = "convertedFrom")]
            Convertedfrom,
            
            /// <summary>
            /// Enum Convertedto for "convertedTo"
            /// </summary>
            [EnumMember(Value = "convertedTo")]
            Convertedto,
            
            /// <summary>
            /// Enum Direction for "direction"
            /// </summary>
            [EnumMember(Value = "direction")]
            Direction,
            
            /// <summary>
            /// Enum Disconnecttype for "disconnectType"
            /// </summary>
            [EnumMember(Value = "disconnectType")]
            Disconnecttype,
            
            /// <summary>
            /// Enum Divisionid for "divisionId"
            /// </summary>
            [EnumMember(Value = "divisionId")]
            Divisionid,
            
            /// <summary>
            /// Enum Dnis for "dnis"
            /// </summary>
            [EnumMember(Value = "dnis")]
            Dnis,
            
            /// <summary>
            /// Enum Edgeid for "edgeId"
            /// </summary>
            [EnumMember(Value = "edgeId")]
            Edgeid,
            
            /// <summary>
            /// Enum Externalcontactid for "externalContactId"
            /// </summary>
            [EnumMember(Value = "externalContactId")]
            Externalcontactid,
            
            /// <summary>
            /// Enum Externalmediacount for "externalMediaCount"
            /// </summary>
            [EnumMember(Value = "externalMediaCount")]
            Externalmediacount,
            
            /// <summary>
            /// Enum Externalorganizationid for "externalOrganizationId"
            /// </summary>
            [EnumMember(Value = "externalOrganizationId")]
            Externalorganizationid,
            
            /// <summary>
            /// Enum Firstqueue for "firstQueue"
            /// </summary>
            [EnumMember(Value = "firstQueue")]
            Firstqueue,
            
            /// <summary>
            /// Enum Flaggedreason for "flaggedReason"
            /// </summary>
            [EnumMember(Value = "flaggedReason")]
            Flaggedreason,
            
            /// <summary>
            /// Enum Flowintype for "flowInType"
            /// </summary>
            [EnumMember(Value = "flowInType")]
            Flowintype,
            
            /// <summary>
            /// Enum Flowouttype for "flowOutType"
            /// </summary>
            [EnumMember(Value = "flowOutType")]
            Flowouttype,
            
            /// <summary>
            /// Enum Groupid for "groupId"
            /// </summary>
            [EnumMember(Value = "groupId")]
            Groupid,
            
            /// <summary>
            /// Enum Interactiontype for "interactionType"
            /// </summary>
            [EnumMember(Value = "interactionType")]
            Interactiontype,
            
            /// <summary>
            /// Enum Journeyactionid for "journeyActionId"
            /// </summary>
            [EnumMember(Value = "journeyActionId")]
            Journeyactionid,
            
            /// <summary>
            /// Enum Journeyactionmapid for "journeyActionMapId"
            /// </summary>
            [EnumMember(Value = "journeyActionMapId")]
            Journeyactionmapid,
            
            /// <summary>
            /// Enum Journeyactionmapversion for "journeyActionMapVersion"
            /// </summary>
            [EnumMember(Value = "journeyActionMapVersion")]
            Journeyactionmapversion,
            
            /// <summary>
            /// Enum Journeycustomerid for "journeyCustomerId"
            /// </summary>
            [EnumMember(Value = "journeyCustomerId")]
            Journeycustomerid,
            
            /// <summary>
            /// Enum Journeycustomeridtype for "journeyCustomerIdType"
            /// </summary>
            [EnumMember(Value = "journeyCustomerIdType")]
            Journeycustomeridtype,
            
            /// <summary>
            /// Enum Journeycustomersessionid for "journeyCustomerSessionId"
            /// </summary>
            [EnumMember(Value = "journeyCustomerSessionId")]
            Journeycustomersessionid,
            
            /// <summary>
            /// Enum Journeycustomersessionidtype for "journeyCustomerSessionIdType"
            /// </summary>
            [EnumMember(Value = "journeyCustomerSessionIdType")]
            Journeycustomersessionidtype,
            
            /// <summary>
            /// Enum Mediacount for "mediaCount"
            /// </summary>
            [EnumMember(Value = "mediaCount")]
            Mediacount,
            
            /// <summary>
            /// Enum Mediatype for "mediaType"
            /// </summary>
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            /// <summary>
            /// Enum Messagetype for "messageType"
            /// </summary>
            [EnumMember(Value = "messageType")]
            Messagetype,
            
            /// <summary>
            /// Enum Originatingdirection for "originatingDirection"
            /// </summary>
            [EnumMember(Value = "originatingDirection")]
            Originatingdirection,
            
            /// <summary>
            /// Enum Outboundcampaignid for "outboundCampaignId"
            /// </summary>
            [EnumMember(Value = "outboundCampaignId")]
            Outboundcampaignid,
            
            /// <summary>
            /// Enum Outboundcontactid for "outboundContactId"
            /// </summary>
            [EnumMember(Value = "outboundContactId")]
            Outboundcontactid,
            
            /// <summary>
            /// Enum Outboundcontactlistid for "outboundContactListId"
            /// </summary>
            [EnumMember(Value = "outboundContactListId")]
            Outboundcontactlistid,
            
            /// <summary>
            /// Enum Participantname for "participantName"
            /// </summary>
            [EnumMember(Value = "participantName")]
            Participantname,
            
            /// <summary>
            /// Enum Peerid for "peerId"
            /// </summary>
            [EnumMember(Value = "peerId")]
            Peerid,
            
            /// <summary>
            /// Enum Proposedagentid for "proposedAgentId"
            /// </summary>
            [EnumMember(Value = "proposedAgentId")]
            Proposedagentid,
            
            /// <summary>
            /// Enum Provider for "provider"
            /// </summary>
            [EnumMember(Value = "provider")]
            Provider,
            
            /// <summary>
            /// Enum Purpose for "purpose"
            /// </summary>
            [EnumMember(Value = "purpose")]
            Purpose,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Remote for "remote"
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote,
            
            /// <summary>
            /// Enum Reoffered for "reoffered"
            /// </summary>
            [EnumMember(Value = "reoffered")]
            Reoffered,
            
            /// <summary>
            /// Enum Requestedlanguageid for "requestedLanguageId"
            /// </summary>
            [EnumMember(Value = "requestedLanguageId")]
            Requestedlanguageid,
            
            /// <summary>
            /// Enum Requestedrouting for "requestedRouting"
            /// </summary>
            [EnumMember(Value = "requestedRouting")]
            Requestedrouting,
            
            /// <summary>
            /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
            /// </summary>
            [EnumMember(Value = "requestedRoutingSkillId")]
            Requestedroutingskillid,
            
            /// <summary>
            /// Enum Roomid for "roomId"
            /// </summary>
            [EnumMember(Value = "roomId")]
            Roomid,
            
            /// <summary>
            /// Enum Routingpriority for "routingPriority"
            /// </summary>
            [EnumMember(Value = "routingPriority")]
            Routingpriority,
            
            /// <summary>
            /// Enum Scoredagentid for "scoredAgentId"
            /// </summary>
            [EnumMember(Value = "scoredAgentId")]
            Scoredagentid,
            
            /// <summary>
            /// Enum Selectedagentid for "selectedAgentId"
            /// </summary>
            [EnumMember(Value = "selectedAgentId")]
            Selectedagentid,
            
            /// <summary>
            /// Enum Selectedagentrank for "selectedAgentRank"
            /// </summary>
            [EnumMember(Value = "selectedAgentRank")]
            Selectedagentrank,
            
            /// <summary>
            /// Enum Sessiondnis for "sessionDnis"
            /// </summary>
            [EnumMember(Value = "sessionDnis")]
            Sessiondnis,
            
            /// <summary>
            /// Enum Sessionid for "sessionId"
            /// </summary>
            [EnumMember(Value = "sessionId")]
            Sessionid,
            
            /// <summary>
            /// Enum Stationid for "stationId"
            /// </summary>
            [EnumMember(Value = "stationId")]
            Stationid,
            
            /// <summary>
            /// Enum Teamid for "teamId"
            /// </summary>
            [EnumMember(Value = "teamId")]
            Teamid,
            
            /// <summary>
            /// Enum Usedrouting for "usedRouting"
            /// </summary>
            [EnumMember(Value = "usedRouting")]
            Usedrouting,
            
            /// <summary>
            /// Enum Userid for "userId"
            /// </summary>
            [EnumMember(Value = "userId")]
            Userid,
            
            /// <summary>
            /// Enum Wrapupcode for "wrapUpCode"
            /// </summary>
            [EnumMember(Value = "wrapUpCode")]
            Wrapupcode
        }
        
        
        
        
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Matches for "matches"
            /// </summary>
            [EnumMember(Value = "matches")]
            Matches,
            
            /// <summary>
            /// Enum Exists for "exists"
            /// </summary>
            [EnumMember(Value = "exists")]
            Exists,
            
            /// <summary>
            /// Enum Notexists for "notExists"
            /// </summary>
            [EnumMember(Value = "notExists")]
            Notexists
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Optional type, can usually be inferred
        /// </summary>
        /// <value>Optional type, can usually be inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Left hand side for dimension predicates
        /// </summary>
        /// <value>Left hand side for dimension predicates</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public DimensionEnum? Dimension { get; set; }
        
        
        
        /// <summary>
        /// Optional operator, default is matches
        /// </summary>
        /// <value>Optional operator, default is matches</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAggregateQueryPredicate" /> class.
        /// </summary>
        /// <param name="Type">Optional type, can usually be inferred.</param>
        /// <param name="Dimension">Left hand side for dimension predicates.</param>
        /// <param name="_Operator">Optional operator, default is matches.</param>
        /// <param name="Value">Right hand side for dimension predicates.</param>
        /// <param name="Range">Right hand side for dimension predicates.</param>
        public ConversationAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? _Operator = null, string Value = null, NumericRange Range = null)
        {
            this.Type = Type;
            this.Dimension = Dimension;
            this._Operator = _Operator;
            this.Value = Value;
            this.Range = Range;
            
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        /// <summary>
        /// Right hand side for dimension predicates
        /// </summary>
        /// <value>Right hand side for dimension predicates</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public NumericRange Range { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAggregateQueryPredicate {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(obj as ConversationAggregateQueryPredicate);
        }

        /// <summary>
        /// Returns true if ConversationAggregateQueryPredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAggregateQueryPredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAggregateQueryPredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Range == other.Range ||
                    this.Range != null &&
                    this.Range.Equals(other.Range)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Range != null)
                    hash = hash * 59 + this.Range.GetHashCode();
                
                return hash;
            }
        }
    }

}
