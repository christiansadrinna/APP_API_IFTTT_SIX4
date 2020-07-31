/*
 * six4one
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BaseTriggerRequest : IEquatable<BaseTriggerRequest>
    { 
        /// <summary>
        /// A unique identifier for this set of trigger fields for a given Applet.
        /// </summary>
        /// <value>A unique identifier for this set of trigger fields for a given Applet.</value>
        [Required]
        [DataMember(Name="trigger_identity")]
        public string TriggerIdentity { get; set; }

        /// <summary>
        /// Maximum number of items to be returned, default 50.
        /// </summary>
        /// <value>Maximum number of items to be returned, default 50.</value>
        [DataMember(Name="limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user")]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets IftttSource
        /// </summary>
        [DataMember(Name="ifttt_source")]
        public IftttSource IftttSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseTriggerRequest {\n");
            sb.Append("  TriggerIdentity: ").Append(TriggerIdentity).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  IftttSource: ").Append(IftttSource).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BaseTriggerRequest)obj);
        }

        /// <summary>
        /// Returns true if BaseTriggerRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseTriggerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseTriggerRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TriggerIdentity == other.TriggerIdentity ||
                    TriggerIdentity != null &&
                    TriggerIdentity.Equals(other.TriggerIdentity)
                ) && 
                (
                    Limit == other.Limit ||
                    Limit != null &&
                    Limit.Equals(other.Limit)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    IftttSource == other.IftttSource ||
                    IftttSource != null &&
                    IftttSource.Equals(other.IftttSource)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (TriggerIdentity != null)
                    hashCode = hashCode * 59 + TriggerIdentity.GetHashCode();
                    if (Limit != null)
                    hashCode = hashCode * 59 + Limit.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (IftttSource != null)
                    hashCode = hashCode * 59 + IftttSource.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BaseTriggerRequest left, BaseTriggerRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseTriggerRequest left, BaseTriggerRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}