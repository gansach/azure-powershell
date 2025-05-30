// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// HubVirtualNetworkConnectionsOperations operations.
    /// </summary>
    public partial interface IHubVirtualNetworkConnectionsOperations
    {
        /// <summary>
        /// Creates a hub virtual network connection if it doesn&#39;t exist else updates
        /// the existing one.
        /// </summary>
        /// <remarks>
        /// Creates a hub virtual network connection if it doesn&#39;t exist else updates
        /// the existing one.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the HubVirtualNetworkConnection.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the HubVirtualNetworkConnection.
        /// </param>
        /// <param name='hubVirtualNetworkConnectionParameters'>
        /// Parameters supplied to create or update a hub virtual network connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HubVirtualNetworkConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string connectionName, HubVirtualNetworkConnection hubVirtualNetworkConnectionParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a HubVirtualNetworkConnection.
        /// </summary>
        /// <remarks>
        /// Deletes a HubVirtualNetworkConnection.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the HubVirtualNetworkConnection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string connectionName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the details of a HubVirtualNetworkConnection.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of a HubVirtualNetworkConnection.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the vpn connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HubVirtualNetworkConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string connectionName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the details of all HubVirtualNetworkConnections.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of all HubVirtualNetworkConnections.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<HubVirtualNetworkConnection>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a hub virtual network connection if it doesn&#39;t exist else updates
        /// the existing one.
        /// </summary>
        /// <remarks>
        /// Creates a hub virtual network connection if it doesn&#39;t exist else updates
        /// the existing one.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the HubVirtualNetworkConnection.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the HubVirtualNetworkConnection.
        /// </param>
        /// <param name='hubVirtualNetworkConnectionParameters'>
        /// Parameters supplied to create or update a hub virtual network connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HubVirtualNetworkConnection>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string connectionName, HubVirtualNetworkConnection hubVirtualNetworkConnectionParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a HubVirtualNetworkConnection.
        /// </summary>
        /// <remarks>
        /// Deletes a HubVirtualNetworkConnection.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the HubVirtualNetworkConnection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string connectionName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the details of all HubVirtualNetworkConnections.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of all HubVirtualNetworkConnections.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<HubVirtualNetworkConnection>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}