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
    /// CampaignRuleEntities
    /// </summary>
    [DataContract]
    public partial class CampaignRuleEntities :  IEquatable<CampaignRuleEntities>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleEntities" /> class.
        /// </summary>
        /// <param name="Campaigns">The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign..</param>
        /// <param name="Sequences">The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence..</param>
        public CampaignRuleEntities(List<UriReference> Campaigns = null, List<UriReference> Sequences = null)
        {
            this.Campaigns = Campaigns;
            this.Sequences = Sequences;
            
        }
        
        
        
        /// <summary>
        /// The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign.
        /// </summary>
        /// <value>The list of campaigns for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a campaign.</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<UriReference> Campaigns { get; set; }
        
        
        
        /// <summary>
        /// The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence.
        /// </summary>
        /// <value>The list of sequences for a CampaignRule to monitor. Required if the CampaignRule has any conditions that run on a sequence.</value>
        [DataMember(Name="sequences", EmitDefaultValue=false)]
        public List<UriReference> Sequences { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleEntities {\n");
            
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Sequences: ").Append(Sequences).Append("\n");
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
            return this.Equals(obj as CampaignRuleEntities);
        }

        /// <summary>
        /// Returns true if CampaignRuleEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaigns == other.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(other.Campaigns)
                ) &&
                (
                    this.Sequences == other.Sequences ||
                    this.Sequences != null &&
                    this.Sequences.SequenceEqual(other.Sequences)
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
                
                if (this.Campaigns != null)
                    hash = hash * 59 + this.Campaigns.GetHashCode();
                
                if (this.Sequences != null)
                    hash = hash * 59 + this.Sequences.GetHashCode();
                
                return hash;
            }
        }
    }

}
