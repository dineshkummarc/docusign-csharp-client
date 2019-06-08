/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// BulkRecipient
    /// </summary>
    [DataContract]
    public partial class BulkRecipient :  IEquatable<BulkRecipient>, IValidatableObject
    {
        public BulkRecipient()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRecipient" /> class.
        /// </summary>
        /// <param name="AccessCode">If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required..</param>
        /// <param name="Email">Specifies the recipient&#39;s email address.   Maximum length: 100 characters..</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Identification">Specifies the authentication check used for the signer. If blank then no authentication check is required for the signer. Only one value can be used in this field.  The acceptable values are:  * KBA: Enables the normal ID check authentication set up for your account. * Phone: Enables phone authentication. * SMS: Enables SMS authentication..</param>
        /// <param name="Name">Specifies the recipient&#39;s name.   Maximum length: 50 characters..</param>
        /// <param name="Note">Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters..</param>
        /// <param name="PhoneNumber">This is only used if the Identification field value is Phone or SMS. The value for this field can be a valid telephone number or, if Phone, usersupplied (SMS authentication cannot use a user supplied number). Parenthesis and dashes can be used in the telephone number.  If &#x60;usersupplied&#x60; is used, the signer supplies his or her own telephone number..</param>
        /// <param name="RecipientSignatureProviderInfo">.</param>
        /// <param name="RowNumber">.</param>
        /// <param name="TabLabels">Specifies values used to populate recipient tabs with information. This allows each bulk recipient signer to have different values for their associated tabs. Any number of &#x60;tabLabel&#x60; columns can be added to the bulk recipient file.  The information used in the bulk recipient file header must be the same as the &#x60;tabLabel&#x60; for the tab.  The values entered in this column are automatically inserted into the corresponding tab for the recipient in the same row.  Note that this option cannot be used for tabs that do not have data or that are automatically populated data such as Signature, Full Name, Email Address, Company, Title, and Date Signed tabs..</param>
        public BulkRecipient(string AccessCode = default(string), string Email = default(string), List<ErrorDetails> ErrorDetails = default(List<ErrorDetails>), string Identification = default(string), string Name = default(string), string Note = default(string), string PhoneNumber = default(string), List<BulkRecipientSignatureProvider> RecipientSignatureProviderInfo = default(List<BulkRecipientSignatureProvider>), string RowNumber = default(string), List<BulkRecipientTabLabel> TabLabels = default(List<BulkRecipientTabLabel>))
        {
            this.AccessCode = AccessCode;
            this.Email = Email;
            this.ErrorDetails = ErrorDetails;
            this.Identification = Identification;
            this.Name = Name;
            this.Note = Note;
            this.PhoneNumber = PhoneNumber;
            this.RecipientSignatureProviderInfo = RecipientSignatureProviderInfo;
            this.RowNumber = RowNumber;
            this.TabLabels = TabLabels;
        }
        
        /// <summary>
        /// If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.
        /// </summary>
        /// <value>If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account&#39;s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required.</value>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
        /// <summary>
        /// Specifies the recipient&#39;s email address.   Maximum length: 100 characters.
        /// </summary>
        /// <value>Specifies the recipient&#39;s email address.   Maximum length: 100 characters.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<ErrorDetails> ErrorDetails { get; set; }
        /// <summary>
        /// Specifies the authentication check used for the signer. If blank then no authentication check is required for the signer. Only one value can be used in this field.  The acceptable values are:  * KBA: Enables the normal ID check authentication set up for your account. * Phone: Enables phone authentication. * SMS: Enables SMS authentication.
        /// </summary>
        /// <value>Specifies the authentication check used for the signer. If blank then no authentication check is required for the signer. Only one value can be used in this field.  The acceptable values are:  * KBA: Enables the normal ID check authentication set up for your account. * Phone: Enables phone authentication. * SMS: Enables SMS authentication.</value>
        [DataMember(Name="identification", EmitDefaultValue=false)]
        public string Identification { get; set; }
        /// <summary>
        /// Specifies the recipient&#39;s name.   Maximum length: 50 characters.
        /// </summary>
        /// <value>Specifies the recipient&#39;s name.   Maximum length: 50 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters.
        /// </summary>
        /// <value>Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// This is only used if the Identification field value is Phone or SMS. The value for this field can be a valid telephone number or, if Phone, usersupplied (SMS authentication cannot use a user supplied number). Parenthesis and dashes can be used in the telephone number.  If &#x60;usersupplied&#x60; is used, the signer supplies his or her own telephone number.
        /// </summary>
        /// <value>This is only used if the Identification field value is Phone or SMS. The value for this field can be a valid telephone number or, if Phone, usersupplied (SMS authentication cannot use a user supplied number). Parenthesis and dashes can be used in the telephone number.  If &#x60;usersupplied&#x60; is used, the signer supplies his or her own telephone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="recipientSignatureProviderInfo", EmitDefaultValue=false)]
        public List<BulkRecipientSignatureProvider> RecipientSignatureProviderInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="rowNumber", EmitDefaultValue=false)]
        public string RowNumber { get; set; }
        /// <summary>
        /// Specifies values used to populate recipient tabs with information. This allows each bulk recipient signer to have different values for their associated tabs. Any number of &#x60;tabLabel&#x60; columns can be added to the bulk recipient file.  The information used in the bulk recipient file header must be the same as the &#x60;tabLabel&#x60; for the tab.  The values entered in this column are automatically inserted into the corresponding tab for the recipient in the same row.  Note that this option cannot be used for tabs that do not have data or that are automatically populated data such as Signature, Full Name, Email Address, Company, Title, and Date Signed tabs.
        /// </summary>
        /// <value>Specifies values used to populate recipient tabs with information. This allows each bulk recipient signer to have different values for their associated tabs. Any number of &#x60;tabLabel&#x60; columns can be added to the bulk recipient file.  The information used in the bulk recipient file header must be the same as the &#x60;tabLabel&#x60; for the tab.  The values entered in this column are automatically inserted into the corresponding tab for the recipient in the same row.  Note that this option cannot be used for tabs that do not have data or that are automatically populated data such as Signature, Full Name, Email Address, Company, Title, and Date Signed tabs.</value>
        [DataMember(Name="tabLabels", EmitDefaultValue=false)]
        public List<BulkRecipientTabLabel> TabLabels { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkRecipient {\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  RecipientSignatureProviderInfo: ").Append(RecipientSignatureProviderInfo).Append("\n");
            sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  TabLabels: ").Append(TabLabels).Append("\n");
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
            return this.Equals(obj as BulkRecipient);
        }

        /// <summary>
        /// Returns true if BulkRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(other.ErrorDetails)
                ) && 
                (
                    this.Identification == other.Identification ||
                    this.Identification != null &&
                    this.Identification.Equals(other.Identification)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.RecipientSignatureProviderInfo == other.RecipientSignatureProviderInfo ||
                    this.RecipientSignatureProviderInfo != null &&
                    this.RecipientSignatureProviderInfo.SequenceEqual(other.RecipientSignatureProviderInfo)
                ) && 
                (
                    this.RowNumber == other.RowNumber ||
                    this.RowNumber != null &&
                    this.RowNumber.Equals(other.RowNumber)
                ) && 
                (
                    this.TabLabels == other.TabLabels ||
                    this.TabLabels != null &&
                    this.TabLabels.SequenceEqual(other.TabLabels)
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
                if (this.AccessCode != null)
                    hash = hash * 59 + this.AccessCode.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Identification != null)
                    hash = hash * 59 + this.Identification.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.RecipientSignatureProviderInfo != null)
                    hash = hash * 59 + this.RecipientSignatureProviderInfo.GetHashCode();
                if (this.RowNumber != null)
                    hash = hash * 59 + this.RowNumber.GetHashCode();
                if (this.TabLabels != null)
                    hash = hash * 59 + this.TabLabels.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
