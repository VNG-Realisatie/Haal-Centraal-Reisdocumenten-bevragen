/* 
 * Reisdocumenten
 *
 * API voor het ontsluiten van gegevens van reisdocumenten uit de GBA en RNI.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// De Link Object zoals gespecificeerd in https://tools.ietf.org/html/draft-kelly-json-hal-08#section-5
    /// </summary>
    [DataContract]
    public partial class HalLink :  IEquatable<HalLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HalLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HalLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HalLink" /> class.
        /// </summary>
        /// <param name="href">href (required).</param>
        /// <param name="templated">templated.</param>
        /// <param name="title">Voor mens leesbaar label bij de link.</param>
        public HalLink(string href = default(string), bool templated = default(bool), string title = default(string))
        {
            // to ensure "href" is required (not null)
            this.Href = href ?? throw new ArgumentNullException("href is a required property for HalLink and cannot be null");
            this.Templated = templated;
            this.Title = title;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Templated
        /// </summary>
        [DataMember(Name="templated", EmitDefaultValue=false)]
        public bool Templated { get; set; }

        /// <summary>
        /// Voor mens leesbaar label bij de link
        /// </summary>
        /// <value>Voor mens leesbaar label bij de link</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HalLink {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Templated: ").Append(Templated).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HalLink);
        }

        /// <summary>
        /// Returns true if HalLink instances are equal
        /// </summary>
        /// <param name="input">Instance of HalLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HalLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Templated == input.Templated ||
                    this.Templated.Equals(input.Templated)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                hashCode = hashCode * 59 + this.Templated.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}