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
    /// ADFS
    /// </summary>
    [DataContract]
    public partial class ADFS :  IEquatable<ADFS>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ADFS" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Disabled">Disabled.</param>
        /// <param name="IssuerURI">IssuerURI.</param>
        /// <param name="SsoTargetURI">SsoTargetURI.</param>
        /// <param name="SloURI">SloURI.</param>
        /// <param name="SloBinding">SloBinding.</param>
        /// <param name="RelyingPartyIdentifier">RelyingPartyIdentifier.</param>
        /// <param name="Certificate">Certificate.</param>
        /// <param name="Certificates">Certificates.</param>
        public ADFS(string Name = null, bool? Disabled = null, string IssuerURI = null, string SsoTargetURI = null, string SloURI = null, string SloBinding = null, string RelyingPartyIdentifier = null, string Certificate = null, List<string> Certificates = null)
        {
            this.Name = Name;
            this.Disabled = Disabled;
            this.IssuerURI = IssuerURI;
            this.SsoTargetURI = SsoTargetURI;
            this.SloURI = SloURI;
            this.SloBinding = SloBinding;
            this.RelyingPartyIdentifier = RelyingPartyIdentifier;
            this.Certificate = Certificate;
            this.Certificates = Certificates;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IssuerURI
        /// </summary>
        [DataMember(Name="issuerURI", EmitDefaultValue=false)]
        public string IssuerURI { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SsoTargetURI
        /// </summary>
        [DataMember(Name="ssoTargetURI", EmitDefaultValue=false)]
        public string SsoTargetURI { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SloURI
        /// </summary>
        [DataMember(Name="sloURI", EmitDefaultValue=false)]
        public string SloURI { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SloBinding
        /// </summary>
        [DataMember(Name="sloBinding", EmitDefaultValue=false)]
        public string SloBinding { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RelyingPartyIdentifier
        /// </summary>
        [DataMember(Name="relyingPartyIdentifier", EmitDefaultValue=false)]
        public string RelyingPartyIdentifier { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Certificates
        /// </summary>
        [DataMember(Name="certificates", EmitDefaultValue=false)]
        public List<string> Certificates { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ADFS {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  IssuerURI: ").Append(IssuerURI).Append("\n");
            sb.Append("  SsoTargetURI: ").Append(SsoTargetURI).Append("\n");
            sb.Append("  SloURI: ").Append(SloURI).Append("\n");
            sb.Append("  SloBinding: ").Append(SloBinding).Append("\n");
            sb.Append("  RelyingPartyIdentifier: ").Append(RelyingPartyIdentifier).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ADFS);
        }

        /// <summary>
        /// Returns true if ADFS instances are equal
        /// </summary>
        /// <param name="other">Instance of ADFS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADFS other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) &&
                (
                    this.IssuerURI == other.IssuerURI ||
                    this.IssuerURI != null &&
                    this.IssuerURI.Equals(other.IssuerURI)
                ) &&
                (
                    this.SsoTargetURI == other.SsoTargetURI ||
                    this.SsoTargetURI != null &&
                    this.SsoTargetURI.Equals(other.SsoTargetURI)
                ) &&
                (
                    this.SloURI == other.SloURI ||
                    this.SloURI != null &&
                    this.SloURI.Equals(other.SloURI)
                ) &&
                (
                    this.SloBinding == other.SloBinding ||
                    this.SloBinding != null &&
                    this.SloBinding.Equals(other.SloBinding)
                ) &&
                (
                    this.RelyingPartyIdentifier == other.RelyingPartyIdentifier ||
                    this.RelyingPartyIdentifier != null &&
                    this.RelyingPartyIdentifier.Equals(other.RelyingPartyIdentifier)
                ) &&
                (
                    this.Certificate == other.Certificate ||
                    this.Certificate != null &&
                    this.Certificate.Equals(other.Certificate)
                ) &&
                (
                    this.Certificates == other.Certificates ||
                    this.Certificates != null &&
                    this.Certificates.SequenceEqual(other.Certificates)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                
                if (this.IssuerURI != null)
                    hash = hash * 59 + this.IssuerURI.GetHashCode();
                
                if (this.SsoTargetURI != null)
                    hash = hash * 59 + this.SsoTargetURI.GetHashCode();
                
                if (this.SloURI != null)
                    hash = hash * 59 + this.SloURI.GetHashCode();
                
                if (this.SloBinding != null)
                    hash = hash * 59 + this.SloBinding.GetHashCode();
                
                if (this.RelyingPartyIdentifier != null)
                    hash = hash * 59 + this.RelyingPartyIdentifier.GetHashCode();
                
                if (this.Certificate != null)
                    hash = hash * 59 + this.Certificate.GetHashCode();
                
                if (this.Certificates != null)
                    hash = hash * 59 + this.Certificates.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
