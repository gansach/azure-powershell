// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Adhoc backup tagging criteria</summary>
    [System.ComponentModel.TypeConverter(typeof(AdhocBasedTaggingCriteriaTypeConverter))]
    public partial class AdhocBasedTaggingCriteria
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AdhocBasedTaggingCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AdhocBasedTaggingCriteria(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TagInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IRetentionTag) content.GetValueForProperty("TagInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.RetentionTagTypeConverter.ConvertFrom);
            }
            if (content.Contains("TagInfoETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoETag = (string) content.GetValueForProperty("TagInfoETag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoETag, global::System.Convert.ToString);
            }
            if (content.Contains("TagInfoId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoId = (string) content.GetValueForProperty("TagInfoId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoId, global::System.Convert.ToString);
            }
            if (content.Contains("TagInfoTagName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoTagName = (string) content.GetValueForProperty("TagInfoTagName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoTagName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AdhocBasedTaggingCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AdhocBasedTaggingCriteria(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TagInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfo = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IRetentionTag) content.GetValueForProperty("TagInfo",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfo, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.RetentionTagTypeConverter.ConvertFrom);
            }
            if (content.Contains("TagInfoETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoETag = (string) content.GetValueForProperty("TagInfoETag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoETag, global::System.Convert.ToString);
            }
            if (content.Contains("TagInfoId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoId = (string) content.GetValueForProperty("TagInfoId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoId, global::System.Convert.ToString);
            }
            if (content.Contains("TagInfoTagName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoTagName = (string) content.GetValueForProperty("TagInfoTagName",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteriaInternal)this).TagInfoTagName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AdhocBasedTaggingCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteria"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteria DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AdhocBasedTaggingCriteria(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.AdhocBasedTaggingCriteria"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteria"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteria DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AdhocBasedTaggingCriteria(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdhocBasedTaggingCriteria" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AdhocBasedTaggingCriteria" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAdhocBasedTaggingCriteria FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Adhoc backup tagging criteria
    [System.ComponentModel.TypeConverter(typeof(AdhocBasedTaggingCriteriaTypeConverter))]
    public partial interface IAdhocBasedTaggingCriteria

    {

    }
}