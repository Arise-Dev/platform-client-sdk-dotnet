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
    /// BulkFetchContactsResponse
    /// </summary>
    [DataContract]
    public partial class BulkFetchContactsResponse :  IEquatable<BulkFetchContactsResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkFetchContactsResponse" /> class.
        /// </summary>
        /// <param name="Results">Results.</param>
        /// <param name="ErrorCount">ErrorCount.</param>
        /// <param name="ErrorIndexes">ErrorIndexes.</param>
        public BulkFetchContactsResponse(List<BulkResponseResultExternalContactEntity> Results = null, int? ErrorCount = null, List<int?> ErrorIndexes = null)
        {
            this.Results = Results;
            this.ErrorCount = ErrorCount;
            this.ErrorIndexes = ErrorIndexes;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<BulkResponseResultExternalContactEntity> Results { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorCount
        /// </summary>
        [DataMember(Name="errorCount", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorIndexes
        /// </summary>
        [DataMember(Name="errorIndexes", EmitDefaultValue=false)]
        public List<int?> ErrorIndexes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkFetchContactsResponse {\n");
            
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  ErrorIndexes: ").Append(ErrorIndexes).Append("\n");
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
            return this.Equals(obj as BulkFetchContactsResponse);
        }

        /// <summary>
        /// Returns true if BulkFetchContactsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkFetchContactsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkFetchContactsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.ErrorCount == other.ErrorCount ||
                    this.ErrorCount != null &&
                    this.ErrorCount.Equals(other.ErrorCount)
                ) &&
                (
                    this.ErrorIndexes == other.ErrorIndexes ||
                    this.ErrorIndexes != null &&
                    this.ErrorIndexes.SequenceEqual(other.ErrorIndexes)
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
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                if (this.ErrorCount != null)
                    hash = hash * 59 + this.ErrorCount.GetHashCode();
                
                if (this.ErrorIndexes != null)
                    hash = hash * 59 + this.ErrorIndexes.GetHashCode();
                
                return hash;
            }
        }
    }

}
