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
    /// NluDetectionOutput
    /// </summary>
    [DataContract]
    public partial class NluDetectionOutput :  IEquatable<NluDetectionOutput>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NluDetectionOutput" /> class.
        /// </summary>
        /// <param name="Intents">The detected intents..</param>
        /// <param name="DialogActs">The detected dialog acts..</param>
        public NluDetectionOutput(List<DetectedIntent> Intents = null, List<DetectedDialogAct> DialogActs = null)
        {
            this.Intents = Intents;
            this.DialogActs = DialogActs;
            
        }
        
        
        
        /// <summary>
        /// The detected intents.
        /// </summary>
        /// <value>The detected intents.</value>
        [DataMember(Name="intents", EmitDefaultValue=false)]
        public List<DetectedIntent> Intents { get; set; }
        
        
        
        /// <summary>
        /// The detected dialog acts.
        /// </summary>
        /// <value>The detected dialog acts.</value>
        [DataMember(Name="dialogActs", EmitDefaultValue=false)]
        public List<DetectedDialogAct> DialogActs { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NluDetectionOutput {\n");
            
            sb.Append("  Intents: ").Append(Intents).Append("\n");
            sb.Append("  DialogActs: ").Append(DialogActs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as NluDetectionOutput);
        }

        /// <summary>
        /// Returns true if NluDetectionOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of NluDetectionOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NluDetectionOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Intents == other.Intents ||
                    this.Intents != null &&
                    this.Intents.SequenceEqual(other.Intents)
                ) &&
                (
                    this.DialogActs == other.DialogActs ||
                    this.DialogActs != null &&
                    this.DialogActs.SequenceEqual(other.DialogActs)
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
                
                if (this.Intents != null)
                    hash = hash * 59 + this.Intents.GetHashCode();
                
                if (this.DialogActs != null)
                    hash = hash * 59 + this.DialogActs.GetHashCode();
                
                return hash;
            }
        }
    }

}
