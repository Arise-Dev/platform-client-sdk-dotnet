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
    /// UnansweredPhraseGroupPatchRequestBody
    /// </summary>
    [DataContract]
    public partial class UnansweredPhraseGroupPatchRequestBody :  IEquatable<UnansweredPhraseGroupPatchRequestBody>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnansweredPhraseGroupPatchRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnansweredPhraseGroupPatchRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnansweredPhraseGroupPatchRequestBody" /> class.
        /// </summary>
        /// <param name="PhraseAssociations">List of phrases and documents to be linked (required).</param>
        public UnansweredPhraseGroupPatchRequestBody(List<PhraseAssociations> PhraseAssociations = null)
        {
            this.PhraseAssociations = PhraseAssociations;
            
        }
        


        /// <summary>
        /// List of phrases and documents to be linked
        /// </summary>
        /// <value>List of phrases and documents to be linked</value>
        [DataMember(Name="phraseAssociations", EmitDefaultValue=false)]
        public List<PhraseAssociations> PhraseAssociations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnansweredPhraseGroupPatchRequestBody {\n");

            sb.Append("  PhraseAssociations: ").Append(PhraseAssociations).Append("\n");
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
            return this.Equals(obj as UnansweredPhraseGroupPatchRequestBody);
        }

        /// <summary>
        /// Returns true if UnansweredPhraseGroupPatchRequestBody instances are equal
        /// </summary>
        /// <param name="other">Instance of UnansweredPhraseGroupPatchRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnansweredPhraseGroupPatchRequestBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PhraseAssociations == other.PhraseAssociations ||
                    this.PhraseAssociations != null &&
                    this.PhraseAssociations.SequenceEqual(other.PhraseAssociations)
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
                if (this.PhraseAssociations != null)
                    hash = hash * 59 + this.PhraseAssociations.GetHashCode();

                return hash;
            }
        }
    }

}