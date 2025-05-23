// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.PowerShell;

    /// <summary>
    /// The properties of Azure Subscription ID to which the Organization of the logged in user belongs and gets billed into.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ElasticOrganizationToAzureSubscriptionMappingResponsePropertiesTypeConverter))]
    public partial class ElasticOrganizationToAzureSubscriptionMappingResponseProperties
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticOrganizationToAzureSubscriptionMappingResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponseProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ElasticOrganizationToAzureSubscriptionMappingResponseProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticOrganizationToAzureSubscriptionMappingResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponseProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ElasticOrganizationToAzureSubscriptionMappingResponseProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticOrganizationToAzureSubscriptionMappingResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ElasticOrganizationToAzureSubscriptionMappingResponseProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceSaasInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaasInfo = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfo) content.GetValueForProperty("MarketplaceSaasInfo",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaasInfo, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("BilledAzureSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).BilledAzureSubscriptionId = (string) content.GetValueForProperty("BilledAzureSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).BilledAzureSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationId = (string) content.GetValueForProperty("ElasticOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationName = (string) content.GetValueForProperty("ElasticOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceSubscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceSubscription = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfoMarketplaceSubscription) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceSubscription",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceSubscription, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoMarketplaceSubscriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceName = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceResourceId = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceStatus = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceStatus",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoBilledAzureSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId = (string) content.GetValueForProperty("MarketplaceSaaInfoBilledAzureSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoSubscribed = (bool?) content.GetValueForProperty("MarketplaceSaaInfoSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoSubscribed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticOrganizationToAzureSubscriptionMappingResponseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ElasticOrganizationToAzureSubscriptionMappingResponseProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceSaasInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaasInfo = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfo) content.GetValueForProperty("MarketplaceSaasInfo",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaasInfo, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("BilledAzureSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).BilledAzureSubscriptionId = (string) content.GetValueForProperty("BilledAzureSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).BilledAzureSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationId = (string) content.GetValueForProperty("ElasticOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticOrganizationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationName = (string) content.GetValueForProperty("ElasticOrganizationName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).ElasticOrganizationName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceSubscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceSubscription = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfoMarketplaceSubscription) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceSubscription",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceSubscription, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoMarketplaceSubscriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceName = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceResourceId = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceStatus = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceStatus",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoMarketplaceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoBilledAzureSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId = (string) content.GetValueForProperty("MarketplaceSaaInfoBilledAzureSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoSubscribed = (bool?) content.GetValueForProperty("MarketplaceSaaInfoSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSaaInfoSubscribed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponsePropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ElasticOrganizationToAzureSubscriptionMappingResponseProperties" />, deserializing
        /// the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ElasticOrganizationToAzureSubscriptionMappingResponseProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticOrganizationToAzureSubscriptionMappingResponseProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The properties of Azure Subscription ID to which the Organization of the logged in user belongs and gets billed into.
    [System.ComponentModel.TypeConverter(typeof(ElasticOrganizationToAzureSubscriptionMappingResponsePropertiesTypeConverter))]
    public partial interface IElasticOrganizationToAzureSubscriptionMappingResponseProperties

    {

    }
}