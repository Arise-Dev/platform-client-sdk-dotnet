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
    /// Attachment
    /// </summary>
    [DataContract]
    public partial class Attachment :  IEquatable<Attachment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// </summary>
        /// <param name="AttachmentId">The unique identifier for the attachment..</param>
        /// <param name="Name">The name of the attachment..</param>
        /// <param name="ContentUri">The content uri of the attachment. If set, this is commonly a public api download location..</param>
        /// <param name="ContentType">The type of file the attachment is..</param>
        /// <param name="ContentLength">The length of the attachment file..</param>
        /// <param name="InlineImage">Whether or not the attachment was attached inline.,.</param>
        public Attachment(string AttachmentId = null, string Name = null, string ContentUri = null, string ContentType = null, int? ContentLength = null, bool? InlineImage = null)
        {
            this.AttachmentId = AttachmentId;
            this.Name = Name;
            this.ContentUri = ContentUri;
            this.ContentType = ContentType;
            this.ContentLength = ContentLength;
            this.InlineImage = InlineImage;
            
        }
        


        /// <summary>
        /// The unique identifier for the attachment.
        /// </summary>
        /// <value>The unique identifier for the attachment.</value>
        [DataMember(Name="attachmentId", EmitDefaultValue=false)]
        public string AttachmentId { get; set; }



        /// <summary>
        /// The name of the attachment.
        /// </summary>
        /// <value>The name of the attachment.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The content uri of the attachment. If set, this is commonly a public api download location.
        /// </summary>
        /// <value>The content uri of the attachment. If set, this is commonly a public api download location.</value>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }



        /// <summary>
        /// The type of file the attachment is.
        /// </summary>
        /// <value>The type of file the attachment is.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// The length of the attachment file.
        /// </summary>
        /// <value>The length of the attachment file.</value>
        [DataMember(Name="contentLength", EmitDefaultValue=false)]
        public int? ContentLength { get; set; }



        /// <summary>
        /// Whether or not the attachment was attached inline.,
        /// </summary>
        /// <value>Whether or not the attachment was attached inline.,</value>
        [DataMember(Name="inlineImage", EmitDefaultValue=false)]
        public bool? InlineImage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");

            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  InlineImage: ").Append(InlineImage).Append("\n");
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
            return this.Equals(obj as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="other">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AttachmentId == other.AttachmentId ||
                    this.AttachmentId != null &&
                    this.AttachmentId.Equals(other.AttachmentId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.ContentLength == other.ContentLength ||
                    this.ContentLength != null &&
                    this.ContentLength.Equals(other.ContentLength)
                ) &&
                (
                    this.InlineImage == other.InlineImage ||
                    this.InlineImage != null &&
                    this.InlineImage.Equals(other.InlineImage)
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
                if (this.AttachmentId != null)
                    hash = hash * 59 + this.AttachmentId.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ContentUri != null)
                    hash = hash * 59 + this.ContentUri.GetHashCode();

                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.ContentLength != null)
                    hash = hash * 59 + this.ContentLength.GetHashCode();

                if (this.InlineImage != null)
                    hash = hash * 59 + this.InlineImage.GetHashCode();

                return hash;
            }
        }
    }

}
