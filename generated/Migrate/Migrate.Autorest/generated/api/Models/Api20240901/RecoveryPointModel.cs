// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Recovery point model.</summary>
    public partial class RecoveryPointModel :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModel,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGenerated __resourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ResourceAutoGenerated();

        /// <summary>Discriminator property for RecoveryPointModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).CustomPropertyInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).CustomPropertyInstanceType = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelInternal.CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).CustomProperty = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.RecoveryPointModelProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.RecoveryPointModelProperties()); set => this._property = value; }

        /// <summary>Gets or sets the provisioning state of the recovery point item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets or sets the recovery point time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? RecoveryPointTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).RecoveryPointTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).RecoveryPointTime = value ?? default(global::System.DateTime); }

        /// <summary>Gets or sets the recovery point type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? RecoveryPointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).RecoveryPointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelPropertiesInternal)Property).RecoveryPointType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType)""); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="RecoveryPointModel" /> instance.</summary>
        public RecoveryPointModel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
        }
    }
    /// Recovery point model.
    public partial interface IRecoveryPointModel :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGenerated
    {
        /// <summary>Discriminator property for RecoveryPointModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Discriminator property for RecoveryPointModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the provisioning state of the recovery point item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the provisioning state of the recovery point item.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Gets or sets the recovery point time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the recovery point time.",
        SerializedName = @"recoveryPointTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecoveryPointTime { get; set; }
        /// <summary>Gets or sets the recovery point type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the recovery point type.",
        SerializedName = @"recoveryPointType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? RecoveryPointType { get; set; }

    }
    /// Recovery point model.
    internal partial interface IRecoveryPointModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api60.IResourceAutoGeneratedInternal
    {
        /// <summary>Recovery point model custom properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelCustomProperties CustomProperty { get; set; }
        /// <summary>Discriminator property for RecoveryPointModelCustomProperties.</summary>
        string CustomPropertyInstanceType { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IRecoveryPointModelProperties Property { get; set; }
        /// <summary>Gets or sets the provisioning state of the recovery point item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Gets or sets the recovery point time.</summary>
        global::System.DateTime? RecoveryPointTime { get; set; }
        /// <summary>Gets or sets the recovery point type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.RecoveryPointType? RecoveryPointType { get; set; }

    }
}