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
    /// SCIM User List Response
    /// </summary>
    [DataContract]
    public partial class ScimUserListResponse :  IEquatable<ScimUserListResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUserListResponse" /> class.
        /// </summary>
        /// <param name="Resources">Resources.</param>
        /// <param name="Schemas">schemas supported.</param>
        public ScimUserListResponse(List<ScimV2User> Resources = null, List<string> Schemas = null)
        {
            this.Resources = Resources;
            this.Schemas = Schemas;
            
        }
        
        
        
        /// <summary>
        /// Total Results
        /// </summary>
        /// <value>Total Results</value>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public long? TotalResults { get; private set; }
        
        
        
        /// <summary>
        /// Start index
        /// </summary>
        /// <value>Start index</value>
        [DataMember(Name="startIndex", EmitDefaultValue=false)]
        public long? StartIndex { get; private set; }
        
        
        
        /// <summary>
        /// Items per Page
        /// </summary>
        /// <value>Items per Page</value>
        [DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
        public long? ItemsPerPage { get; private set; }
        
        
        
        /// <summary>
        /// Resources
        /// </summary>
        /// <value>Resources</value>
        [DataMember(Name="Resources", EmitDefaultValue=false)]
        public List<ScimV2User> Resources { get; set; }
        
        
        
        /// <summary>
        /// schemas supported
        /// </summary>
        /// <value>schemas supported</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimUserListResponse {\n");
            
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
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
            return this.Equals(obj as ScimUserListResponse);
        }

        /// <summary>
        /// Returns true if ScimUserListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimUserListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimUserListResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalResults == other.TotalResults ||
                    this.TotalResults != null &&
                    this.TotalResults.Equals(other.TotalResults)
                ) &&
                (
                    this.StartIndex == other.StartIndex ||
                    this.StartIndex != null &&
                    this.StartIndex.Equals(other.StartIndex)
                ) &&
                (
                    this.ItemsPerPage == other.ItemsPerPage ||
                    this.ItemsPerPage != null &&
                    this.ItemsPerPage.Equals(other.ItemsPerPage)
                ) &&
                (
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(other.Resources)
                ) &&
                (
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
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
                
                if (this.TotalResults != null)
                    hash = hash * 59 + this.TotalResults.GetHashCode();
                
                if (this.StartIndex != null)
                    hash = hash * 59 + this.StartIndex.GetHashCode();
                
                if (this.ItemsPerPage != null)
                    hash = hash * 59 + this.ItemsPerPage.GetHashCode();
                
                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                return hash;
            }
        }
    }

}
