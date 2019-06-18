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
    /// DTO for the timestamp data.
    /// </summary>
    [DataContract]
    public partial class TimestampData :  IEquatable<TimestampData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampData" /> class.
        /// </summary>
        /// <param name="CurrencyId">0: Bitcoin.</param>
        /// <param name="PrivateKey">The private key represents the top hash in the Merkle Tree (see https://en.wikipedia.org/wiki/Merkle_tree ) or the hash of all hashes in the transaction..</param>
        /// <param name="SubmitStatus">The submit status of the hash:   0: the hash was not broadcasted yet  1: the hash was included into a transaction and broadcasted to the network, but not included into a block  2: the transaction was included into the latest block  3: the timestamp for your hash was successfully created..</param>
        /// <param name="Timestamp">The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. This is a true timestamp..</param>
        /// <param name="Transaction">If available: the transaction hash of the timestamp..</param>
        public TimestampData(int? CurrencyId = default(int?), string PrivateKey = default(string), long? SubmitStatus = default(long?), long? Timestamp = default(long?), string Transaction = default(string))
        {
            this.CurrencyId = CurrencyId;
            this.PrivateKey = PrivateKey;
            this.SubmitStatus = SubmitStatus;
            this.Timestamp = Timestamp;
            this.Transaction = Transaction;
        }
        
        /// <summary>
        /// 0: Bitcoin
        /// </summary>
        /// <value>0: Bitcoin</value>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
        public int? CurrencyId { get; set; }

        /// <summary>
        /// The private key represents the top hash in the Merkle Tree (see https://en.wikipedia.org/wiki/Merkle_tree ) or the hash of all hashes in the transaction.
        /// </summary>
        /// <value>The private key represents the top hash in the Merkle Tree (see https://en.wikipedia.org/wiki/Merkle_tree ) or the hash of all hashes in the transaction.</value>
        [DataMember(Name="private_key", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// The submit status of the hash:   0: the hash was not broadcasted yet  1: the hash was included into a transaction and broadcasted to the network, but not included into a block  2: the transaction was included into the latest block  3: the timestamp for your hash was successfully created.
        /// </summary>
        /// <value>The submit status of the hash:   0: the hash was not broadcasted yet  1: the hash was included into a transaction and broadcasted to the network, but not included into a block  2: the transaction was included into the latest block  3: the timestamp for your hash was successfully created.</value>
        [DataMember(Name="submit_status", EmitDefaultValue=false)]
        public long? SubmitStatus { get; set; }

        /// <summary>
        /// The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. This is a true timestamp.
        /// </summary>
        /// <value>The date is returned in the following format: [ms] since 1.1.1970 (unix epoch), timezone: UTC. This is a true timestamp.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// If available: the transaction hash of the timestamp.
        /// </summary>
        /// <value>If available: the transaction hash of the timestamp.</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public string Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimestampData {\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  SubmitStatus: ").Append(SubmitStatus).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as TimestampData);
        }

        /// <summary>
        /// Returns true if TimestampData instances are equal
        /// </summary>
        /// <param name="input">Instance of TimestampData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimestampData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.SubmitStatus == input.SubmitStatus ||
                    (this.SubmitStatus != null &&
                    this.SubmitStatus.Equals(input.SubmitStatus))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.SubmitStatus != null)
                    hashCode = hashCode * 59 + this.SubmitStatus.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
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
