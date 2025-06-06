// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.PowerShell;

    /// <summary>Mongo source and target database and collection details.</summary>
    [System.ComponentModel.TypeConverter(typeof(MongoMigrationCollectionTypeConverter))]
    public partial class MongoMigrationCollection
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationCollection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollection"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MongoMigrationCollection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationCollection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollection"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollection DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MongoMigrationCollection(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MongoMigrationCollection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MongoMigrationCollection" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollection FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationCollection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MongoMigrationCollection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MigrationProgressDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetails) content.GetValueForProperty("MigrationProgressDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetail, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationProgressDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceDatabase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceDatabase = (string) content.GetValueForProperty("SourceDatabase",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceDatabase, global::System.Convert.ToString);
            }
            if (content.Contains("SourceCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceCollection = (string) content.GetValueForProperty("SourceCollection",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceCollection, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDatabase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetDatabase = (string) content.GetValueForProperty("TargetDatabase",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetDatabase, global::System.Convert.ToString);
            }
            if (content.Contains("TargetCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetCollection = (string) content.GetValueForProperty("TargetCollection",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetCollection, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationProgressDetailMigrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus?) content.GetValueForProperty("MigrationProgressDetailMigrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationStatus, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus.CreateFrom);
            }
            if (content.Contains("MigrationProgressDetailMigrationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationError = (string) content.GetValueForProperty("MigrationProgressDetailMigrationError",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationError, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationProgressDetailSourceDocumentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailSourceDocumentCount = (long?) content.GetValueForProperty("MigrationProgressDetailSourceDocumentCount",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailSourceDocumentCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationProgressDetailProcessedDocumentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailProcessedDocumentCount = (long?) content.GetValueForProperty("MigrationProgressDetailProcessedDocumentCount",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailProcessedDocumentCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationProgressDetailDurationInSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailDurationInSecond = (int?) content.GetValueForProperty("MigrationProgressDetailDurationInSecond",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailDurationInSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationCollection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MongoMigrationCollection(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MigrationProgressDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetails) content.GetValueForProperty("MigrationProgressDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetail, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationProgressDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceDatabase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceDatabase = (string) content.GetValueForProperty("SourceDatabase",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceDatabase, global::System.Convert.ToString);
            }
            if (content.Contains("SourceCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceCollection = (string) content.GetValueForProperty("SourceCollection",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).SourceCollection, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDatabase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetDatabase = (string) content.GetValueForProperty("TargetDatabase",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetDatabase, global::System.Convert.ToString);
            }
            if (content.Contains("TargetCollection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetCollection = (string) content.GetValueForProperty("TargetCollection",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).TargetCollection, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationProgressDetailMigrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationStatus = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus?) content.GetValueForProperty("MigrationProgressDetailMigrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationStatus, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus.CreateFrom);
            }
            if (content.Contains("MigrationProgressDetailMigrationError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationError = (string) content.GetValueForProperty("MigrationProgressDetailMigrationError",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailMigrationError, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationProgressDetailSourceDocumentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailSourceDocumentCount = (long?) content.GetValueForProperty("MigrationProgressDetailSourceDocumentCount",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailSourceDocumentCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationProgressDetailProcessedDocumentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailProcessedDocumentCount = (long?) content.GetValueForProperty("MigrationProgressDetailProcessedDocumentCount",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailProcessedDocumentCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationProgressDetailDurationInSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailDurationInSecond = (int?) content.GetValueForProperty("MigrationProgressDetailDurationInSecond",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal)this).MigrationProgressDetailDurationInSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Mongo source and target database and collection details.
    [System.ComponentModel.TypeConverter(typeof(MongoMigrationCollectionTypeConverter))]
    public partial interface IMongoMigrationCollection

    {

    }
}