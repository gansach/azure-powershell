// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>
    /// Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.
    /// </summary>
    public partial class PrivateEndpointDestination :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPrivateEndpointDestination,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPrivateEndpointDestinationInternal
    {

        /// <summary>Backing field for <see cref="ServiceResourceId" /> property.</summary>
        private string _serviceResourceId;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ServiceResourceId { get => this._serviceResourceId; set => this._serviceResourceId = value; }

        /// <summary>Backing field for <see cref="SparkEnabled" /> property.</summary>
        private bool? _sparkEnabled;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public bool? SparkEnabled { get => this._sparkEnabled; set => this._sparkEnabled = value; }

        /// <summary>Backing field for <see cref="SparkStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RuleStatus? _sparkStatus;

        /// <summary>Type of a managed network Outbound Rule of a machine learning workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RuleStatus? SparkStatus { get => this._sparkStatus; set => this._sparkStatus = value; }

        /// <summary>Backing field for <see cref="SubresourceTarget" /> property.</summary>
        private string _subresourceTarget;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string SubresourceTarget { get => this._subresourceTarget; set => this._subresourceTarget = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointDestination" /> instance.</summary>
        public PrivateEndpointDestination()
        {

        }
    }
    /// Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.
    public partial interface IPrivateEndpointDestination :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"serviceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceResourceId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sparkEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SparkEnabled { get; set; }
        /// <summary>Type of a managed network Outbound Rule of a machine learning workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of a managed network Outbound Rule of a machine learning workspace.",
        SerializedName = @"sparkStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RuleStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RuleStatus? SparkStatus { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subresourceTarget",
        PossibleTypes = new [] { typeof(string) })]
        string SubresourceTarget { get; set; }

    }
    /// Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine learning workspace.
    internal partial interface IPrivateEndpointDestinationInternal

    {
        string ServiceResourceId { get; set; }

        bool? SparkEnabled { get; set; }
        /// <summary>Type of a managed network Outbound Rule of a machine learning workspace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RuleStatus? SparkStatus { get; set; }

        string SubresourceTarget { get; set; }

    }
}