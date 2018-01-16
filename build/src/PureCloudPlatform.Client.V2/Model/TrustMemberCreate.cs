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
    /// TrustMemberCreate
    /// </summary>
    [DataContract]
    public partial class TrustMemberCreate :  IEquatable<TrustMemberCreate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustMemberCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustMemberCreate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustMemberCreate" /> class.
        /// </summary>
        
        
        /// <param name="Id">Trustee User or Group Id (required).</param>
        
        
        
        /// <param name="RoleIds">The list of trustor organization roles granting this user or group access. (required).</param>
        
        
        public TrustMemberCreate(string Id = null, List<string> RoleIds = null)
        {
            
            
            
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TrustMemberCreate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            
            
            
            
            
            // to ensure "RoleIds" is required (not null)
            if (RoleIds == null)
            {
                throw new InvalidDataException("RoleIds is a required property for TrustMemberCreate and cannot be null");
            }
            else
            {
                this.RoleIds = RoleIds;
            }
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Trustee User or Group Id
        /// </summary>
        /// <value>Trustee User or Group Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The list of trustor organization roles granting this user or group access.
        /// </summary>
        /// <value>The list of trustor organization roles granting this user or group access.</value>
        [DataMember(Name="roleIds", EmitDefaultValue=false)]
        public List<string> RoleIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustMemberCreate {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            
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
            return this.Equals(obj as TrustMemberCreate);
        }

        /// <summary>
        /// Returns true if TrustMemberCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustMemberCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustMemberCreate other)
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
                    this.RoleIds == other.RoleIds ||
                    this.RoleIds != null &&
                    this.RoleIds.SequenceEqual(other.RoleIds)
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
                
                if (this.RoleIds != null)
                    hash = hash * 59 + this.RoleIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
