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
    /// DefaultObjective
    /// </summary>
    [DataContract]
    public partial class DefaultObjective :  IEquatable<DefaultObjective>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultObjective" /> class.
        /// </summary>
        /// <param name="TemplateId">The id of this objective&#39;s base template.</param>
        /// <param name="Zones">Objective zone specifies min,max points and values for the associated metric.</param>
        /// <param name="Enabled">A flag for whether this objective is enabled for the related metric.</param>
        public DefaultObjective(string TemplateId = null, List<ObjectiveZone> Zones = null, bool? Enabled = null)
        {
            this.TemplateId = TemplateId;
            this.Zones = Zones;
            this.Enabled = Enabled;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The id of this objective&#39;s base template
        /// </summary>
        /// <value>The id of this objective&#39;s base template</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        
        
        
        /// <summary>
        /// Objective zone specifies min,max points and values for the associated metric
        /// </summary>
        /// <value>Objective zone specifies min,max points and values for the associated metric</value>
        [DataMember(Name="zones", EmitDefaultValue=false)]
        public List<ObjectiveZone> Zones { get; set; }
        
        
        
        /// <summary>
        /// A flag for whether this objective is enabled for the related metric
        /// </summary>
        /// <value>A flag for whether this objective is enabled for the related metric</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultObjective {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as DefaultObjective);
        }

        /// <summary>
        /// Returns true if DefaultObjective instances are equal
        /// </summary>
        /// <param name="other">Instance of DefaultObjective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultObjective other)
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
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) &&
                (
                    this.Zones == other.Zones ||
                    this.Zones != null &&
                    this.Zones.SequenceEqual(other.Zones)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                
                if (this.Zones != null)
                    hash = hash * 59 + this.Zones.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                return hash;
            }
        }
    }

}
