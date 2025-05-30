// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Contains the map of disk serial number to the disk details for import jobs.</summary>
    public partial class DataBoxCustomerDiskJobDetailsImportDiskDetailsCollection :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollectionInternal
    {

        /// <summary>
        /// Creates an new <see cref="DataBoxCustomerDiskJobDetailsImportDiskDetailsCollection" /> instance.
        /// </summary>
        public DataBoxCustomerDiskJobDetailsImportDiskDetailsCollection()
        {

        }
    }
    /// Contains the map of disk serial number to the disk details for import jobs.
    public partial interface IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IImportDiskDetails>
    {

    }
    /// Contains the map of disk serial number to the disk details for import jobs.
    internal partial interface IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollectionInternal

    {

    }
}