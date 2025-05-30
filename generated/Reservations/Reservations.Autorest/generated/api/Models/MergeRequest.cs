// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>The request for reservation merge</summary>
    public partial class MergeRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeRequestInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.MergeProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeProperties _property;

        /// <summary>Properties for reservation merge</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.MergeProperties()); set => this._property = value; }

        /// <summary>
        /// Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Source { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergePropertiesInternal)Property).Source; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergePropertiesInternal)Property).Source = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="MergeRequest" /> instance.</summary>
        public MergeRequest()
        {

        }
    }
    /// The request for reservation merge
    public partial interface IMergeRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}",
        SerializedName = @"sources",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Source { get; set; }

    }
    /// The request for reservation merge
    internal partial interface IMergeRequestInternal

    {
        /// <summary>Properties for reservation merge</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IMergeProperties Property { get; set; }
        /// <summary>
        /// Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        System.Collections.Generic.List<string> Source { get; set; }

    }
}