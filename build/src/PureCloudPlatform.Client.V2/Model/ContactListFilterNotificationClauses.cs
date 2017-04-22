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
    /// ContactListFilterNotificationClauses
    /// </summary>
    [DataContract]
    public partial class ContactListFilterNotificationClauses :  IEquatable<ContactListFilterNotificationClauses>
    {
        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FilterTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or
        }
        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [DataMember(Name="filterType", EmitDefaultValue=false)]
        public FilterTypeEnum? FilterType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListFilterNotificationClauses" /> class.
        /// </summary>
        /// <param name="FilterType">FilterType.</param>
        /// <param name="Predicates">Predicates.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public ContactListFilterNotificationClauses(FilterTypeEnum? FilterType = null, List<ContactListFilterNotificationPredicates> Predicates = null, Object AdditionalProperties = null)
        {
            this.FilterType = FilterType;
            this.Predicates = Predicates;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets Predicates
        /// </summary>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<ContactListFilterNotificationPredicates> Predicates { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListFilterNotificationClauses {\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as ContactListFilterNotificationClauses);
        }

        /// <summary>
        /// Returns true if ContactListFilterNotificationClauses instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactListFilterNotificationClauses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListFilterNotificationClauses other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FilterType == other.FilterType ||
                    this.FilterType != null &&
                    this.FilterType.Equals(other.FilterType)
                ) &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                if (this.FilterType != null)
                    hash = hash * 59 + this.FilterType.GetHashCode();
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
