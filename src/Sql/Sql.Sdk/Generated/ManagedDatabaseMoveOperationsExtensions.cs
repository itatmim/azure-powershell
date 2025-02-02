// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedDatabaseMoveOperations.
    /// </summary>
    public static partial class ManagedDatabaseMoveOperationsExtensions
    {
            /// <summary>
            /// Lists managed database move operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='onlyLatestPerDatabase'>
            /// Whether or not to only get the latest operation for each database. Has
            /// higher priority than $filter.
            /// </param>
            public static IPage<ManagedDatabaseMoveOperationResult> ListByLocation(this IManagedDatabaseMoveOperations operations, string resourceGroupName, string locationName, ODataQuery<ManagedDatabaseMoveOperationResult> odataQuery = default(ODataQuery<ManagedDatabaseMoveOperationResult>), bool? onlyLatestPerDatabase = default(bool?))
            {
                return operations.ListByLocationAsync(resourceGroupName, locationName, odataQuery, onlyLatestPerDatabase).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists managed database move operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='onlyLatestPerDatabase'>
            /// Whether or not to only get the latest operation for each database. Has
            /// higher priority than $filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedDatabaseMoveOperationResult>> ListByLocationAsync(this IManagedDatabaseMoveOperations operations, string resourceGroupName, string locationName, ODataQuery<ManagedDatabaseMoveOperationResult> odataQuery = default(ODataQuery<ManagedDatabaseMoveOperationResult>), bool? onlyLatestPerDatabase = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationWithHttpMessagesAsync(resourceGroupName, locationName, odataQuery, onlyLatestPerDatabase, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed database move operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='operationId'>
            /// </param>
            public static ManagedDatabaseMoveOperationResult Get(this IManagedDatabaseMoveOperations operations, string resourceGroupName, string locationName, System.Guid operationId)
            {
                return operations.GetAsync(resourceGroupName, locationName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed database move operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='locationName'>
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedDatabaseMoveOperationResult> GetAsync(this IManagedDatabaseMoveOperations operations, string resourceGroupName, string locationName, System.Guid operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, locationName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists managed database move operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedDatabaseMoveOperationResult> ListByLocationNext(this IManagedDatabaseMoveOperations operations, string nextPageLink)
            {
                return operations.ListByLocationNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists managed database move operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedDatabaseMoveOperationResult>> ListByLocationNextAsync(this IManagedDatabaseMoveOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
