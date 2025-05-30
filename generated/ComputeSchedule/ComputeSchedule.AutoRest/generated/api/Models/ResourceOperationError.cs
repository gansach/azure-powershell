// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>These describe errors that occur at the resource level</summary>
    public partial class ResourceOperationError :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationErrorInternal
    {

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>Code for the error eg 404, 500</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private string _errorDetail;

        /// <summary>Detailed message about the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Creates an new <see cref="ResourceOperationError" /> instance.</summary>
        public ResourceOperationError()
        {

        }
    }
    /// These describe errors that occur at the resource level
    public partial interface IResourceOperationError :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>Code for the error eg 404, 500</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Code for the error eg 404, 500",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorCode { get; set; }
        /// <summary>Detailed message about the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Detailed message about the error",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetail { get; set; }

    }
    /// These describe errors that occur at the resource level
    internal partial interface IResourceOperationErrorInternal

    {
        /// <summary>Code for the error eg 404, 500</summary>
        string ErrorCode { get; set; }
        /// <summary>Detailed message about the error</summary>
        string ErrorDetail { get; set; }

    }
}