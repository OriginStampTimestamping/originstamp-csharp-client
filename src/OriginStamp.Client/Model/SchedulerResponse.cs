/* 
 * OriginStamp Client
 * 
 * OpenAPI spec version: 3.0
 * OriginStamp Documentation: https://docs.originstamp.com
 * Contact: mail@originstamp.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = OriginStamp.Client.Client.SwaggerDateConverter;

namespace OriginStamp.Client.Model
{
    /// <summary>
    /// DTO which contains nxt submission time.
    /// </summary>
    [DataContract]
    public partial class SchedulerResponse :  IEquatable<SchedulerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerResponse" /> class.
        /// </summary>
        /// <param name="SubmissionTime">Next submission time. The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. The timezone is UTC..</param>
        public SchedulerResponse(long? SubmissionTime = default(long?))
        {
            this.SubmissionTime = SubmissionTime;
        }
        
        /// <summary>
        /// Next submission time. The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. The timezone is UTC.
        /// </summary>
        /// <value>Next submission time. The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. The timezone is UTC.</value>
        [DataMember(Name="submission_time", EmitDefaultValue=false)]
        public long? SubmissionTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulerResponse {\n");
            sb.Append("  SubmissionTime: ").Append(SubmissionTime).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchedulerResponse);
        }

        /// <summary>
        /// Returns true if SchedulerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SchedulerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchedulerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubmissionTime == input.SubmissionTime ||
                    (this.SubmissionTime != null &&
                    this.SubmissionTime.Equals(input.SubmissionTime))
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
                if (this.SubmissionTime != null)
                    hashCode = hashCode * 59 + this.SubmissionTime.GetHashCode();
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
