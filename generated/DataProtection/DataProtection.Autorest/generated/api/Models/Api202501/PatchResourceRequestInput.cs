// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Patch Request content for Microsoft.DataProtection resources</summary>
    public partial class PatchResourceRequestInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInput,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).AzureMonitorAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).AzureMonitorAlertsForAllJobFailure = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState)""); }

        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState? CrossRegionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).CrossRegionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).CrossRegionRestoreState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState)""); }

        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).CrossSubscriptionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).CrossSubscriptionRestoreState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState)""); }

        /// <summary>Customer Managed Key details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings EncryptionSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).EncryptionSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).EncryptionSetting = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetails _identity;

        /// <summary>Input Managed Identity Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetails Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DppIdentityDetails()); set => this._identity = value; }

        /// <summary>
        /// The object ID of the service principal object for the managed identity that is used to grant role-based access to an Azure
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).PrincipalId; }

        /// <summary>
        /// A Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).TenantId; }

        /// <summary>
        /// The identityType which can be either SystemAssigned, UserAssigned, 'SystemAssigned,UserAssigned' or None
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).Type = value ?? null; }

        /// <summary>Gets or sets the user assigned identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api40.IDppIdentityDetailsUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).ImmutabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).ImmutabilityState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState)""); }

        /// <summary>Internal Acessors for FeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.FeatureSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).FeatureSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).FeatureSetting = value; }

        /// <summary>Internal Acessors for FeatureSettingCrossRegionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.FeatureSettingCrossRegionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).FeatureSettingCrossRegionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).FeatureSettingCrossRegionRestoreSetting = value; }

        /// <summary>Internal Acessors for FeatureSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.FeatureSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).FeatureSettingCrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).FeatureSettingCrossSubscriptionRestoreSetting = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DppIdentityDetails()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetailsInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.MonitoringSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).MonitoringSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).MonitoringSetting = value; }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).MonitoringSettingAzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).MonitoringSettingAzureMonitorAlertSetting = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInput Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.PatchBackupVaultInput()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.SecuritySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SecuritySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SecuritySetting = value; }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SecuritySettingImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SecuritySettingImmutabilitySetting = value; }

        /// <summary>Internal Acessors for SoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputInternal.SoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SoftDeleteSetting = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInput _property;

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInput Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.PatchBackupVaultInput()); set => this._property = value; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string[] ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public double? SoftDeleteRetentionDurationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SoftDeleteRetentionDurationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SoftDeleteRetentionDurationInDay = value ?? default(double); }

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SoftDeleteState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInputInternal)Property).SoftDeleteState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState)""); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.PatchResourceRequestInputTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PatchResourceRequestInput" /> instance.</summary>
        public PatchResourceRequestInput()
        {

        }
    }
    /// Patch Request content for Microsoft.DataProtection resources
    public partial interface IPatchResourceRequestInput :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>CrossRegionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CrossRegionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState? CrossRegionRestoreState { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CrossSubscriptionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
        /// <summary>Customer Managed Key details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customer Managed Key details of the resource.",
        SerializedName = @"encryptionSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings EncryptionSetting { get; set; }
        /// <summary>
        /// The object ID of the service principal object for the managed identity that is used to grant role-based access to an Azure
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The object ID of the service principal object for the managed identity that is used to grant role-based access to an Azure resource.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// A Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// The identityType which can be either SystemAssigned, UserAssigned, 'SystemAssigned,UserAssigned' or None
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identityType which can be either SystemAssigned, UserAssigned, 'SystemAssigned,UserAssigned' or None",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityType { get; set; }
        /// <summary>Gets or sets the user assigned identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the user assigned identities.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api40.IDppIdentityDetailsUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api40.IDppIdentityDetailsUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Immutability state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceGuardOperationRequests on which LAC check will be performed",
        SerializedName = @"resourceGuardOperationRequests",
        PossibleTypes = new [] { typeof(string) })]
        string[] ResourceGuardOperationRequest { get; set; }
        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Soft delete retention duration",
        SerializedName = @"retentionDurationInDays",
        PossibleTypes = new [] { typeof(double) })]
        double? SoftDeleteRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of soft delete",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputTags Tag { get; set; }

    }
    /// Patch Request content for Microsoft.DataProtection resources
    internal partial interface IPatchResourceRequestInputInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>CrossRegionRestore state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossRegionRestoreState? CrossRegionRestoreState { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
        /// <summary>Customer Managed Key details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IEncryptionSettings EncryptionSetting { get; set; }
        /// <summary>Feature Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IFeatureSettings FeatureSetting { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossRegionRestoreSettings FeatureSettingCrossRegionRestoreSetting { get; set; }
        /// <summary>CrossSubscriptionRestore Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ICrossSubscriptionRestoreSettings FeatureSettingCrossSubscriptionRestoreSetting { get; set; }
        /// <summary>Input Managed Identity Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDppIdentityDetails Identity { get; set; }
        /// <summary>
        /// The object ID of the service principal object for the managed identity that is used to grant role-based access to an Azure
        /// resource.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// A Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// The identityType which can be either SystemAssigned, UserAssigned, 'SystemAssigned,UserAssigned' or None
        /// </summary>
        string IdentityType { get; set; }
        /// <summary>Gets or sets the user assigned identities.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api40.IDppIdentityDetailsUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Immutability state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get; set; }
        /// <summary>Monitoring Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IMonitoringSettings MonitoringSetting { get; set; }
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IAzureMonitorAlertSettings MonitoringSettingAzureMonitorAlertSetting { get; set; }
        /// <summary>Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchBackupVaultInput Property { get; set; }
        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        string[] ResourceGuardOperationRequest { get; set; }
        /// <summary>Security Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISecuritySettings SecuritySetting { get; set; }
        /// <summary>Immutability Settings at vault level</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IImmutabilitySettings SecuritySettingImmutabilitySetting { get; set; }
        /// <summary>Soft delete retention duration</summary>
        double? SoftDeleteRetentionDurationInDay { get; set; }
        /// <summary>Soft delete related settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISoftDeleteSettings SoftDeleteSetting { get; set; }
        /// <summary>State of soft delete</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IPatchResourceRequestInputTags Tag { get; set; }

    }
}