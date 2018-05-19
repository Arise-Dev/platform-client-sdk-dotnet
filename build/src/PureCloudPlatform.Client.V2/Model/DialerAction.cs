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
    /// DialerAction
    /// </summary>
    [DataContract]
    public partial class DialerAction :  IEquatable<DialerAction>
    {
        
        
        /// <summary>
        /// The type of this DialerAction.
        /// </summary>
        /// <value>The type of this DialerAction.</value>
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
            /// Enum Action for "Action"
            /// </summary>
            [EnumMember(Value = "Action")]
            Action,
            
            /// <summary>
            /// Enum Modifycontactattribute for "modifyContactAttribute"
            /// </summary>
            [EnumMember(Value = "modifyContactAttribute")]
            Modifycontactattribute
        }
        
        
        
        
        /// <summary>
        /// Additional type specification for this DialerAction.
        /// </summary>
        /// <value>Additional type specification for this DialerAction.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum DoNotDial for "DO_NOT_DIAL"
            /// </summary>
            [EnumMember(Value = "DO_NOT_DIAL")]
            DoNotDial,
            
            /// <summary>
            /// Enum ModifyContactAttribute for "MODIFY_CONTACT_ATTRIBUTE"
            /// </summary>
            [EnumMember(Value = "MODIFY_CONTACT_ATTRIBUTE")]
            ModifyContactAttribute,
            
            /// <summary>
            /// Enum SwitchToPreview for "SWITCH_TO_PREVIEW"
            /// </summary>
            [EnumMember(Value = "SWITCH_TO_PREVIEW")]
            SwitchToPreview,
            
            /// <summary>
            /// Enum AppendNumberToDncList for "APPEND_NUMBER_TO_DNC_LIST"
            /// </summary>
            [EnumMember(Value = "APPEND_NUMBER_TO_DNC_LIST")]
            AppendNumberToDncList,
            
            /// <summary>
            /// Enum ScheduleCallback for "SCHEDULE_CALLBACK"
            /// </summary>
            [EnumMember(Value = "SCHEDULE_CALLBACK")]
            ScheduleCallback,
            
            /// <summary>
            /// Enum ContactUncallable for "CONTACT_UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "CONTACT_UNCALLABLE")]
            ContactUncallable,
            
            /// <summary>
            /// Enum NumberUncallable for "NUMBER_UNCALLABLE"
            /// </summary>
            [EnumMember(Value = "NUMBER_UNCALLABLE")]
            NumberUncallable,
            
            /// <summary>
            /// Enum SetCallerId for "SET_CALLER_ID"
            /// </summary>
            [EnumMember(Value = "SET_CALLER_ID")]
            SetCallerId,
            
            /// <summary>
            /// Enum SetSkills for "SET_SKILLS"
            /// </summary>
            [EnumMember(Value = "SET_SKILLS")]
            SetSkills
        }
        
        
        
        
        /// <summary>
        /// Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.
        /// </summary>
        /// <value>Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UpdateOptionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Set for "SET"
            /// </summary>
            [EnumMember(Value = "SET")]
            Set,
            
            /// <summary>
            /// Enum Increment for "INCREMENT"
            /// </summary>
            [EnumMember(Value = "INCREMENT")]
            Increment,
            
            /// <summary>
            /// Enum Decrement for "DECREMENT"
            /// </summary>
            [EnumMember(Value = "DECREMENT")]
            Decrement,
            
            /// <summary>
            /// Enum CurrentTime for "CURRENT_TIME"
            /// </summary>
            [EnumMember(Value = "CURRENT_TIME")]
            CurrentTime
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this DialerAction.
        /// </summary>
        /// <value>The type of this DialerAction.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        /// <summary>
        /// Additional type specification for this DialerAction.
        /// </summary>
        /// <value>Additional type specification for this DialerAction.</value>
        [DataMember(Name="actionTypeName", EmitDefaultValue=false)]
        public ActionTypeNameEnum? ActionTypeName { get; set; }
        
        
        
        /// <summary>
        /// Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.
        /// </summary>
        /// <value>Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE.</value>
        [DataMember(Name="updateOption", EmitDefaultValue=false)]
        public UpdateOptionEnum? UpdateOption { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DialerAction() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAction" /> class.
        /// </summary>
        
        
        /// <param name="Type">The type of this DialerAction. (required).</param>
        
        
        
        /// <param name="ActionTypeName">Additional type specification for this DialerAction. (required).</param>
        
        
        
        /// <param name="UpdateOption">Specifies how a contact attribute should be updated. Required for MODIFY_CONTACT_ATTRIBUTE..</param>
        
        
        
        /// <param name="Properties">A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} )..</param>
        
        
        public DialerAction(TypeEnum? Type = null, ActionTypeNameEnum? ActionTypeName = null, UpdateOptionEnum? UpdateOption = null, Dictionary<string, string> Properties = null)
        {
            
            
            
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DialerAction and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
            
            
            
            // to ensure "ActionTypeName" is required (not null)
            if (ActionTypeName == null)
            {
                throw new InvalidDataException("ActionTypeName is a required property for DialerAction and cannot be null");
            }
            else
            {
                this.ActionTypeName = ActionTypeName;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.UpdateOption = UpdateOption;
            
            
            
            
            
            
            
            
this.Properties = Properties;
            
            
            
            
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} ).
        /// </summary>
        /// <value>A map of key-value pairs pertinent to the DialerAction. Different types of DialerActions require different properties. MODIFY_CONTACT_ATTRIBUTE with an updateOption of SET takes a contact column as the key and accepts any value. SCHEDULE_CALLBACK takes a key &#39;callbackOffset&#39; that specifies how far in the future the callback should be scheduled, in minutes. SET_CALLER_ID takes two keys: &#39;callerAddress&#39;, which should be the caller id phone number, and &#39;callerName&#39;. For either key, you can also specify a column on the contact to get the value from. To do this, specify &#39;contact.Column&#39;, where &#39;Column&#39; is the name of the contact column from which to get the value. SET_SKILLS takes a key &#39;skills&#39; with an array of skill ids wrapped into a string (Example: {&#39;skills&#39;: &#39;[&#39;skillIdHere&#39;]&#39;} ).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAction {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  ActionTypeName: ").Append(ActionTypeName).Append("\n");
            
            sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
            
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
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
            return this.Equals(obj as DialerAction);
        }

        /// <summary>
        /// Returns true if DialerAction instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAction other)
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
                    this.ActionTypeName == other.ActionTypeName ||
                    this.ActionTypeName != null &&
                    this.ActionTypeName.Equals(other.ActionTypeName)
                ) &&
                (
                    this.UpdateOption == other.UpdateOption ||
                    this.UpdateOption != null &&
                    this.UpdateOption.Equals(other.UpdateOption)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                
                if (this.ActionTypeName != null)
                    hash = hash * 59 + this.ActionTypeName.GetHashCode();
                
                if (this.UpdateOption != null)
                    hash = hash * 59 + this.UpdateOption.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                return hash;
            }
        }
    }

}
