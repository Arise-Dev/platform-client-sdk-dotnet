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
    /// SCIM Enterprise User
    /// </summary>
    [DataContract]
    public partial class ScimV2EnterpriseUser :  IEquatable<ScimV2EnterpriseUser>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2EnterpriseUser" /> class.
        /// </summary>
        /// <param name="Division">User division name.</param>
        /// <param name="Department">User department name.</param>
        /// <param name="Manager">Manager.</param>
        public ScimV2EnterpriseUser(string Division = null, string Department = null, Manager Manager = null)
        {
            this.Division = Division;
            this.Department = Department;
            this.Manager = Manager;
            
        }
        
        
        
        /// <summary>
        /// User division name
        /// </summary>
        /// <value>User division name</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public string Division { get; set; }
        
        
        
        /// <summary>
        /// User department name
        /// </summary>
        /// <value>User department name</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        
        
        
        /// <summary>
        /// Manager
        /// </summary>
        /// <value>Manager</value>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public Manager Manager { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2EnterpriseUser {\n");
            
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
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
            return this.Equals(obj as ScimV2EnterpriseUser);
        }

        /// <summary>
        /// Returns true if ScimV2EnterpriseUser instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2EnterpriseUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2EnterpriseUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) &&
                (
                    this.Manager == other.Manager ||
                    this.Manager != null &&
                    this.Manager.Equals(other.Manager)
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
                
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                
                if (this.Manager != null)
                    hash = hash * 59 + this.Manager.GetHashCode();
                
                return hash;
            }
        }
    }

}
