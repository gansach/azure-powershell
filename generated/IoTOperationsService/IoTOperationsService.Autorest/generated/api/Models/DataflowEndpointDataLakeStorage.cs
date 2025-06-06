// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Azure Data Lake endpoint properties</summary>
    public partial class DataflowEndpointDataLakeStorage :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorage,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageInternal
    {

        /// <summary>Token secret name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string AccessTokenSettingSecretRef { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).AccessTokenSettingSecretRef; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).AccessTokenSettingSecretRef = value ?? null; }

        /// <summary>Backing field for <see cref="Authentication" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthentication _authentication;

        /// <summary>
        /// Authentication configuration. NOTE - only authentication property is allowed per entry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthentication Authentication { get => (this._authentication = this._authentication ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowEndpointDataLakeStorageAuthentication()); set => this._authentication = value; }

        /// <summary>Mode of Authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string AuthenticationMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).Method; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).Method = value ; }

        /// <summary>Backing field for <see cref="Batching" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfiguration _batching;

        /// <summary>Azure Data Lake endpoint batching configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfiguration Batching { get => (this._batching = this._batching ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.BatchingConfiguration()); set => this._batching = value; }

        /// <summary>Batching latency in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public int? BatchingLatencySecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfigurationInternal)Batching).LatencySecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfigurationInternal)Batching).LatencySecond = value ?? default(int); }

        /// <summary>Maximum number of messages in a batch.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public int? BatchingMaxMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfigurationInternal)Batching).MaxMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfigurationInternal)Batching).MaxMessage = value ?? default(int); }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>Host of the Azure Data Lake in the form of <account>.blob.core.windows.net .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Internal Acessors for Authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthentication Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageInternal.Authentication { get => (this._authentication = this._authentication ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowEndpointDataLakeStorageAuthentication()); set { {_authentication = value;} } }

        /// <summary>Internal Acessors for AuthenticationAccessTokenSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationAccessToken Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageInternal.AuthenticationAccessTokenSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).AccessTokenSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).AccessTokenSetting = value; }

        /// <summary>Internal Acessors for AuthenticationSystemAssignedManagedIdentitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentity Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageInternal.AuthenticationSystemAssignedManagedIdentitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).SystemAssignedManagedIdentitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).SystemAssignedManagedIdentitySetting = value; }

        /// <summary>Internal Acessors for AuthenticationUserAssignedManagedIdentitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentity Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageInternal.AuthenticationUserAssignedManagedIdentitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySetting = value; }

        /// <summary>Internal Acessors for Batching</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfiguration Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageInternal.Batching { get => (this._batching = this._batching ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.BatchingConfiguration()); set { {_batching = value;} } }

        /// <summary>
        /// Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string SystemAssignedManagedIdentitySettingAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).SystemAssignedManagedIdentitySettingAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).SystemAssignedManagedIdentitySettingAudience = value ?? null; }

        /// <summary>Client ID for the user-assigned managed identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentitySettingClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySettingClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySettingClientId = value ?? null; }

        /// <summary>
        /// Resource identifier (application ID URI) of the resource, affixed with the .default suffix.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentitySettingScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySettingScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySettingScope = value ?? null; }

        /// <summary>Tenant ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentitySettingTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySettingTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthenticationInternal)Authentication).UserAssignedManagedIdentitySettingTenantId = value ?? null; }

        /// <summary>Creates an new <see cref="DataflowEndpointDataLakeStorage" /> instance.</summary>
        public DataflowEndpointDataLakeStorage()
        {

        }
    }
    /// Azure Data Lake endpoint properties
    public partial interface IDataflowEndpointDataLakeStorage :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>Token secret name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Token secret name.",
        SerializedName = @"secretRef",
        PossibleTypes = new [] { typeof(string) })]
        string AccessTokenSettingSecretRef { get; set; }
        /// <summary>Mode of Authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mode of Authentication.",
        SerializedName = @"method",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("SystemAssignedManagedIdentity", "UserAssignedManagedIdentity", "AccessToken")]
        string AuthenticationMethod { get; set; }
        /// <summary>Batching latency in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Batching latency in seconds.",
        SerializedName = @"latencySeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? BatchingLatencySecond { get; set; }
        /// <summary>Maximum number of messages in a batch.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum number of messages in a batch.",
        SerializedName = @"maxMessages",
        PossibleTypes = new [] { typeof(int) })]
        int? BatchingMaxMessage { get; set; }
        /// <summary>Host of the Azure Data Lake in the form of <account>.blob.core.windows.net .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Host of the Azure Data Lake in the form of <account>.blob.core.windows.net .",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>
        /// Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string SystemAssignedManagedIdentitySettingAudience { get; set; }
        /// <summary>Client ID for the user-assigned managed identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client ID for the user-assigned managed identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentitySettingClientId { get; set; }
        /// <summary>
        /// Resource identifier (application ID URI) of the resource, affixed with the .default suffix.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identifier (application ID URI) of the resource, affixed with the .default suffix.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentitySettingScope { get; set; }
        /// <summary>Tenant ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant ID.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentitySettingTenantId { get; set; }

    }
    /// Azure Data Lake endpoint properties
    internal partial interface IDataflowEndpointDataLakeStorageInternal

    {
        /// <summary>Token secret name.</summary>
        string AccessTokenSettingSecretRef { get; set; }
        /// <summary>
        /// Authentication configuration. NOTE - only authentication property is allowed per entry.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointDataLakeStorageAuthentication Authentication { get; set; }
        /// <summary>SAS token authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationAccessToken AuthenticationAccessTokenSetting { get; set; }
        /// <summary>Mode of Authentication.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("SystemAssignedManagedIdentity", "UserAssignedManagedIdentity", "AccessToken")]
        string AuthenticationMethod { get; set; }
        /// <summary>System-assigned managed identity authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentity AuthenticationSystemAssignedManagedIdentitySetting { get; set; }
        /// <summary>User-assigned managed identity authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentity AuthenticationUserAssignedManagedIdentitySetting { get; set; }
        /// <summary>Azure Data Lake endpoint batching configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IBatchingConfiguration Batching { get; set; }
        /// <summary>Batching latency in seconds.</summary>
        int? BatchingLatencySecond { get; set; }
        /// <summary>Maximum number of messages in a batch.</summary>
        int? BatchingMaxMessage { get; set; }
        /// <summary>Host of the Azure Data Lake in the form of <account>.blob.core.windows.net .</summary>
        string Host { get; set; }
        /// <summary>
        /// Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.
        /// </summary>
        string SystemAssignedManagedIdentitySettingAudience { get; set; }
        /// <summary>Client ID for the user-assigned managed identity.</summary>
        string UserAssignedManagedIdentitySettingClientId { get; set; }
        /// <summary>
        /// Resource identifier (application ID URI) of the resource, affixed with the .default suffix.
        /// </summary>
        string UserAssignedManagedIdentitySettingScope { get; set; }
        /// <summary>Tenant ID.</summary>
        string UserAssignedManagedIdentitySettingTenantId { get; set; }

    }
}