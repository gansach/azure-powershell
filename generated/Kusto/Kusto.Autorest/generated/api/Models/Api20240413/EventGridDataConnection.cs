// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>Class representing an Event Grid data connection.</summary>
    public partial class EventGridDataConnection :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridDataConnection,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridDataConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection __dataConnection = new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.DataConnection();

        /// <summary>The name of blob storage event type to process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? BlobStorageEventType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).BlobStorageEventType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).BlobStorageEventType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType)""); }

        /// <summary>The event hub consumer group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ConsumerGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ConsumerGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ConsumerGroup = value ?? null; }

        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? DataFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).DataFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).DataFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat)""); }

        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).DatabaseRouting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).DatabaseRouting = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting)""); }

        /// <summary>
        /// The resource ID of the event grid that is subscribed to the storage account events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string EventGridResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).EventGridResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).EventGridResourceId = value ?? null; }

        /// <summary>The resource ID where the event grid is configured to send events.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string EventHubResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).EventHubResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).EventHubResourceId = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Id; }

        /// <summary>
        /// A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public bool? IgnoreFirstRecord { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).IgnoreFirstRecord; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).IgnoreFirstRecord = value ?? default(bool); }

        /// <summary>Kind of the endpoint for the data connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Kind = value ; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Location = value ?? null; }

        /// <summary>The object ID of managedIdentityResourceId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ManagedIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ManagedIdentityObjectId; }

        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ManagedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ManagedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ManagedIdentityResourceId = value ?? null; }

        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string MappingRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).MappingRuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).MappingRuleName = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Type = value; }

        /// <summary>Internal Acessors for ManagedIdentityObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridDataConnectionInternal.ManagedIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ManagedIdentityObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ManagedIdentityObjectId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridDataConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.EventGridConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridDataConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionProperties _property;

        /// <summary>The properties of the Event Grid data connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.EventGridConnectionProperties()); set => this._property = value; }

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The resource ID of the storage account where the data resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string StorageAccountResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).StorageAccountResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).StorageAccountResourceId = value ?? null; }

        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string TableName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).TableName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal)Property).TableName = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Type; }

        /// <summary>Creates an new <see cref="EventGridDataConnection" /> instance.</summary>
        public EventGridDataConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dataConnection), __dataConnection);
            await eventListener.AssertObjectIsValid(nameof(__dataConnection), __dataConnection);
        }
    }
    /// Class representing an Event Grid data connection.
    public partial interface IEventGridDataConnection :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection
    {
        /// <summary>The name of blob storage event type to process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of blob storage event type to process.",
        SerializedName = @"blobStorageEventType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? BlobStorageEventType { get; set; }
        /// <summary>The event hub consumer group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The event hub consumer group.",
        SerializedName = @"consumerGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumerGroup { get; set; }
        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data format of the message. Optionally the data format can be added to each message.",
        SerializedName = @"dataFormat",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? DataFormat { get; set; }
        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indication for database routing information from the data connection, by default only database routing information is allowed",
        SerializedName = @"databaseRouting",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get; set; }
        /// <summary>
        /// The resource ID of the event grid that is subscribed to the storage account events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the event grid that is subscribed to the storage account events.",
        SerializedName = @"eventGridResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventGridResourceId { get; set; }
        /// <summary>The resource ID where the event grid is configured to send events.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID where the event grid is configured to send events.",
        SerializedName = @"eventHubResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubResourceId { get; set; }
        /// <summary>
        /// A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file",
        SerializedName = @"ignoreFirstRecord",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IgnoreFirstRecord { get; set; }
        /// <summary>The object ID of managedIdentityResourceId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The object ID of managedIdentityResourceId",
        SerializedName = @"managedIdentityObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityObjectId { get;  }
        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage account.",
        SerializedName = @"managedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityResourceId { get; set; }
        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.",
        SerializedName = @"mappingRuleName",
        PossibleTypes = new [] { typeof(string) })]
        string MappingRuleName { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource ID of the storage account where the data resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the storage account where the data resides.",
        SerializedName = @"storageAccountResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountResourceId { get; set; }
        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The table where the data should be ingested. Optionally the table information can be added to each message.",
        SerializedName = @"tableName",
        PossibleTypes = new [] { typeof(string) })]
        string TableName { get; set; }

    }
    /// Class representing an Event Grid data connection.
    internal partial interface IEventGridDataConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal
    {
        /// <summary>The name of blob storage event type to process.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? BlobStorageEventType { get; set; }
        /// <summary>The event hub consumer group.</summary>
        string ConsumerGroup { get; set; }
        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? DataFormat { get; set; }
        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get; set; }
        /// <summary>
        /// The resource ID of the event grid that is subscribed to the storage account events.
        /// </summary>
        string EventGridResourceId { get; set; }
        /// <summary>The resource ID where the event grid is configured to send events.</summary>
        string EventHubResourceId { get; set; }
        /// <summary>
        /// A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file
        /// </summary>
        bool? IgnoreFirstRecord { get; set; }
        /// <summary>The object ID of managedIdentityResourceId</summary>
        string ManagedIdentityObjectId { get; set; }
        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        string ManagedIdentityResourceId { get; set; }
        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        string MappingRuleName { get; set; }
        /// <summary>The properties of the Event Grid data connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionProperties Property { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource ID of the storage account where the data resides.</summary>
        string StorageAccountResourceId { get; set; }
        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        string TableName { get; set; }

    }
}