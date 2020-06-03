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
    /// UploadUrlRequest
    /// </summary>
    [DataContract]
    public partial class UploadUrlRequest :  IEquatable<UploadUrlRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadUrlRequest" /> class.
        /// </summary>
        /// <param name="FileName">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#|.</param>
        /// <param name="ContentMd5">Content MD-5 of the file to upload.</param>
        /// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds.</param>
        public UploadUrlRequest(string FileName = null, string ContentMd5 = null, int? SignedUrlTimeoutSeconds = null)
        {
            this.FileName = FileName;
            this.ContentMd5 = ContentMd5;
            this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;
            
        }
        
        
        
        /// <summary>
        /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#|
        /// </summary>
        /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%`]\&quot;&gt;[~&lt;#|</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
        
        
        
        /// <summary>
        /// Content MD-5 of the file to upload
        /// </summary>
        /// <value>Content MD-5 of the file to upload</value>
        [DataMember(Name="contentMd5", EmitDefaultValue=false)]
        public string ContentMd5 { get; set; }
        
        
        
        /// <summary>
        /// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
        /// </summary>
        /// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
        [DataMember(Name="signedUrlTimeoutSeconds", EmitDefaultValue=false)]
        public int? SignedUrlTimeoutSeconds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadUrlRequest {\n");
            
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
            sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
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
            return this.Equals(obj as UploadUrlRequest);
        }

        /// <summary>
        /// Returns true if UploadUrlRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UploadUrlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadUrlRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) &&
                (
                    this.ContentMd5 == other.ContentMd5 ||
                    this.ContentMd5 != null &&
                    this.ContentMd5.Equals(other.ContentMd5)
                ) &&
                (
                    this.SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
                    this.SignedUrlTimeoutSeconds != null &&
                    this.SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
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
                
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                
                if (this.ContentMd5 != null)
                    hash = hash * 59 + this.ContentMd5.GetHashCode();
                
                if (this.SignedUrlTimeoutSeconds != null)
                    hash = hash * 59 + this.SignedUrlTimeoutSeconds.GetHashCode();
                
                return hash;
            }
        }
    }

}
