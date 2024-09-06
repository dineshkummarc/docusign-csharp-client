/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// EnvelopeViewSettings
    /// </summary>
    [DataContract]
    public partial class EnvelopeViewSettings :  IEquatable<EnvelopeViewSettings>, IValidatableObject
    {
        public EnvelopeViewSettings()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeViewSettings" /> class.
        /// </summary>
        /// <param name="BackButtonAction">BackButtonAction.</param>
        /// <param name="DocumentSettings">DocumentSettings.</param>
        /// <param name="EnvelopeCustomFieldSettings">EnvelopeCustomFieldSettings.</param>
        /// <param name="LockToken">LockToken.</param>
        /// <param name="RecipientSettings">RecipientSettings.</param>
        /// <param name="SendButtonAction">SendButtonAction.</param>
        /// <param name="ShowAdvancedOptions">ShowAdvancedOptions.</param>
        /// <param name="ShowBackButton">ShowBackButton.</param>
        /// <param name="ShowDiscardAction">ShowDiscardAction.</param>
        /// <param name="ShowHeaderActions">ShowHeaderActions.</param>
        /// <param name="StartingScreen">StartingScreen.</param>
        /// <param name="TaggerSettings">TaggerSettings.</param>
        /// <param name="TemplateSettings">TemplateSettings.</param>
        public EnvelopeViewSettings(string BackButtonAction = default(string), EnvelopeViewDocumentSettings DocumentSettings = default(EnvelopeViewDocumentSettings), EnvelopeViewEnvelopeCustomFieldSettings EnvelopeCustomFieldSettings = default(EnvelopeViewEnvelopeCustomFieldSettings), string LockToken = default(string), EnvelopeViewRecipientSettings RecipientSettings = default(EnvelopeViewRecipientSettings), string SendButtonAction = default(string), string ShowAdvancedOptions = default(string), string ShowBackButton = default(string), string ShowDiscardAction = default(string), string ShowHeaderActions = default(string), string StartingScreen = default(string), EnvelopeViewTaggerSettings TaggerSettings = default(EnvelopeViewTaggerSettings), EnvelopeViewTemplateSettings TemplateSettings = default(EnvelopeViewTemplateSettings))
        {
            this.BackButtonAction = BackButtonAction;
            this.DocumentSettings = DocumentSettings;
            this.EnvelopeCustomFieldSettings = EnvelopeCustomFieldSettings;
            this.LockToken = LockToken;
            this.RecipientSettings = RecipientSettings;
            this.SendButtonAction = SendButtonAction;
            this.ShowAdvancedOptions = ShowAdvancedOptions;
            this.ShowBackButton = ShowBackButton;
            this.ShowDiscardAction = ShowDiscardAction;
            this.ShowHeaderActions = ShowHeaderActions;
            this.StartingScreen = StartingScreen;
            this.TaggerSettings = TaggerSettings;
            this.TemplateSettings = TemplateSettings;
        }
        
        /// <summary>
        /// Gets or Sets BackButtonAction
        /// </summary>
        [DataMember(Name="backButtonAction", EmitDefaultValue=false)]
        public string BackButtonAction { get; set; }
        /// <summary>
        /// Gets or Sets DocumentSettings
        /// </summary>
        [DataMember(Name="documentSettings", EmitDefaultValue=false)]
        public EnvelopeViewDocumentSettings DocumentSettings { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeCustomFieldSettings
        /// </summary>
        [DataMember(Name="envelopeCustomFieldSettings", EmitDefaultValue=false)]
        public EnvelopeViewEnvelopeCustomFieldSettings EnvelopeCustomFieldSettings { get; set; }
        /// <summary>
        /// Gets or Sets LockToken
        /// </summary>
        [DataMember(Name="lockToken", EmitDefaultValue=false)]
        public string LockToken { get; set; }
        /// <summary>
        /// Gets or Sets RecipientSettings
        /// </summary>
        [DataMember(Name="recipientSettings", EmitDefaultValue=false)]
        public EnvelopeViewRecipientSettings RecipientSettings { get; set; }
        /// <summary>
        /// Gets or Sets SendButtonAction
        /// </summary>
        [DataMember(Name="sendButtonAction", EmitDefaultValue=false)]
        public string SendButtonAction { get; set; }
        /// <summary>
        /// Gets or Sets ShowAdvancedOptions
        /// </summary>
        [DataMember(Name="showAdvancedOptions", EmitDefaultValue=false)]
        public string ShowAdvancedOptions { get; set; }
        /// <summary>
        /// Gets or Sets ShowBackButton
        /// </summary>
        [DataMember(Name="showBackButton", EmitDefaultValue=false)]
        public string ShowBackButton { get; set; }
        /// <summary>
        /// Gets or Sets ShowDiscardAction
        /// </summary>
        [DataMember(Name="showDiscardAction", EmitDefaultValue=false)]
        public string ShowDiscardAction { get; set; }
        /// <summary>
        /// Gets or Sets ShowHeaderActions
        /// </summary>
        [DataMember(Name="showHeaderActions", EmitDefaultValue=false)]
        public string ShowHeaderActions { get; set; }
        /// <summary>
        /// Gets or Sets StartingScreen
        /// </summary>
        [DataMember(Name="startingScreen", EmitDefaultValue=false)]
        public string StartingScreen { get; set; }
        /// <summary>
        /// Gets or Sets TaggerSettings
        /// </summary>
        [DataMember(Name="taggerSettings", EmitDefaultValue=false)]
        public EnvelopeViewTaggerSettings TaggerSettings { get; set; }
        /// <summary>
        /// Gets or Sets TemplateSettings
        /// </summary>
        [DataMember(Name="templateSettings", EmitDefaultValue=false)]
        public EnvelopeViewTemplateSettings TemplateSettings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeViewSettings {\n");
            sb.Append("  BackButtonAction: ").Append(BackButtonAction).Append("\n");
            sb.Append("  DocumentSettings: ").Append(DocumentSettings).Append("\n");
            sb.Append("  EnvelopeCustomFieldSettings: ").Append(EnvelopeCustomFieldSettings).Append("\n");
            sb.Append("  LockToken: ").Append(LockToken).Append("\n");
            sb.Append("  RecipientSettings: ").Append(RecipientSettings).Append("\n");
            sb.Append("  SendButtonAction: ").Append(SendButtonAction).Append("\n");
            sb.Append("  ShowAdvancedOptions: ").Append(ShowAdvancedOptions).Append("\n");
            sb.Append("  ShowBackButton: ").Append(ShowBackButton).Append("\n");
            sb.Append("  ShowDiscardAction: ").Append(ShowDiscardAction).Append("\n");
            sb.Append("  ShowHeaderActions: ").Append(ShowHeaderActions).Append("\n");
            sb.Append("  StartingScreen: ").Append(StartingScreen).Append("\n");
            sb.Append("  TaggerSettings: ").Append(TaggerSettings).Append("\n");
            sb.Append("  TemplateSettings: ").Append(TemplateSettings).Append("\n");
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
            return this.Equals(obj as EnvelopeViewSettings);
        }

        /// <summary>
        /// Returns true if EnvelopeViewSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeViewSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeViewSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BackButtonAction == other.BackButtonAction ||
                    this.BackButtonAction != null &&
                    this.BackButtonAction.Equals(other.BackButtonAction)
                ) && 
                (
                    this.DocumentSettings == other.DocumentSettings ||
                    this.DocumentSettings != null &&
                    this.DocumentSettings.Equals(other.DocumentSettings)
                ) && 
                (
                    this.EnvelopeCustomFieldSettings == other.EnvelopeCustomFieldSettings ||
                    this.EnvelopeCustomFieldSettings != null &&
                    this.EnvelopeCustomFieldSettings.Equals(other.EnvelopeCustomFieldSettings)
                ) && 
                (
                    this.LockToken == other.LockToken ||
                    this.LockToken != null &&
                    this.LockToken.Equals(other.LockToken)
                ) && 
                (
                    this.RecipientSettings == other.RecipientSettings ||
                    this.RecipientSettings != null &&
                    this.RecipientSettings.Equals(other.RecipientSettings)
                ) && 
                (
                    this.SendButtonAction == other.SendButtonAction ||
                    this.SendButtonAction != null &&
                    this.SendButtonAction.Equals(other.SendButtonAction)
                ) && 
                (
                    this.ShowAdvancedOptions == other.ShowAdvancedOptions ||
                    this.ShowAdvancedOptions != null &&
                    this.ShowAdvancedOptions.Equals(other.ShowAdvancedOptions)
                ) && 
                (
                    this.ShowBackButton == other.ShowBackButton ||
                    this.ShowBackButton != null &&
                    this.ShowBackButton.Equals(other.ShowBackButton)
                ) && 
                (
                    this.ShowDiscardAction == other.ShowDiscardAction ||
                    this.ShowDiscardAction != null &&
                    this.ShowDiscardAction.Equals(other.ShowDiscardAction)
                ) && 
                (
                    this.ShowHeaderActions == other.ShowHeaderActions ||
                    this.ShowHeaderActions != null &&
                    this.ShowHeaderActions.Equals(other.ShowHeaderActions)
                ) && 
                (
                    this.StartingScreen == other.StartingScreen ||
                    this.StartingScreen != null &&
                    this.StartingScreen.Equals(other.StartingScreen)
                ) && 
                (
                    this.TaggerSettings == other.TaggerSettings ||
                    this.TaggerSettings != null &&
                    this.TaggerSettings.Equals(other.TaggerSettings)
                ) && 
                (
                    this.TemplateSettings == other.TemplateSettings ||
                    this.TemplateSettings != null &&
                    this.TemplateSettings.Equals(other.TemplateSettings)
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
                if (this.BackButtonAction != null)
                    hash = hash * 59 + this.BackButtonAction.GetHashCode();
                if (this.DocumentSettings != null)
                    hash = hash * 59 + this.DocumentSettings.GetHashCode();
                if (this.EnvelopeCustomFieldSettings != null)
                    hash = hash * 59 + this.EnvelopeCustomFieldSettings.GetHashCode();
                if (this.LockToken != null)
                    hash = hash * 59 + this.LockToken.GetHashCode();
                if (this.RecipientSettings != null)
                    hash = hash * 59 + this.RecipientSettings.GetHashCode();
                if (this.SendButtonAction != null)
                    hash = hash * 59 + this.SendButtonAction.GetHashCode();
                if (this.ShowAdvancedOptions != null)
                    hash = hash * 59 + this.ShowAdvancedOptions.GetHashCode();
                if (this.ShowBackButton != null)
                    hash = hash * 59 + this.ShowBackButton.GetHashCode();
                if (this.ShowDiscardAction != null)
                    hash = hash * 59 + this.ShowDiscardAction.GetHashCode();
                if (this.ShowHeaderActions != null)
                    hash = hash * 59 + this.ShowHeaderActions.GetHashCode();
                if (this.StartingScreen != null)
                    hash = hash * 59 + this.StartingScreen.GetHashCode();
                if (this.TaggerSettings != null)
                    hash = hash * 59 + this.TaggerSettings.GetHashCode();
                if (this.TemplateSettings != null)
                    hash = hash * 59 + this.TemplateSettings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}