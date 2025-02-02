// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PolicyExemptionsOperations operations.
    /// </summary>
    public partial interface IPolicyExemptionsOperations
    {
        /// <summary>
        /// Deletes a policy exemption.
        /// </summary>
        /// <remarks>
        /// This operation deletes a policy exemption, given its name and the
        /// scope it was created in. The scope of a policy exemption is the
        /// part of its ID preceding
        /// '/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}'.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the policy exemption. Valid scopes are: management
        /// group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </param>
        /// <param name='policyExemptionName'>
        /// The name of the policy exemption to delete.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string scope, string policyExemptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a policy exemption.
        /// </summary>
        /// <remarks>
        /// This operation creates or updates a policy exemption with the given
        /// scope and name. Policy exemptions apply to all resources contained
        /// within their scope. For example, when you create a policy exemption
        /// at resource group scope for a policy assignment at the same or
        /// above level, the exemption exempts to all applicable resources in
        /// the resource group.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the policy exemption. Valid scopes are: management
        /// group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </param>
        /// <param name='policyExemptionName'>
        /// The name of the policy exemption to delete.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the policy exemption.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyExemption>> CreateOrUpdateWithHttpMessagesAsync(string scope, string policyExemptionName, PolicyExemption parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves a policy exemption.
        /// </summary>
        /// <remarks>
        /// This operation retrieves a single policy exemption, given its name
        /// and the scope it was created at.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the policy exemption. Valid scopes are: management
        /// group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </param>
        /// <param name='policyExemptionName'>
        /// The name of the policy exemption to delete.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyExemption>> GetWithHttpMessagesAsync(string scope, string policyExemptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a subscription.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// associated with the given subscription that match the optional
        /// given $filter. Valid values for $filter are: 'atScope()',
        /// 'atExactScope()', 'excludeExpired()' or 'policyAssignmentId eq
        /// '{value}''. If $filter is not provided, the unfiltered list
        /// includes all policy exemptions associated with the subscription,
        /// including those that apply directly or from management groups that
        /// contain the given subscription, as well as any applied to objects
        /// contained within the subscription.
        /// </remarks>
        /// <param name='filter'>
        /// The filter to apply on the operation. Valid values for $filter are:
        /// 'atScope()', 'atExactScope()', 'excludeExpired()' or
        /// 'policyAssignmentId eq '{value}''. If $filter is not provided, no
        /// filtering is performed. If $filter is not provided, the unfiltered
        /// list includes all policy exemptions associated with the scope,
        /// including those that apply directly or apply from containing
        /// scopes. If $filter=atScope() is provided, the returned list only
        /// includes all policy exemptions that apply to the scope, which is
        /// everything in the unfiltered list except those applied to sub
        /// scopes contained within the given scope. If $filter=atExactScope()
        /// is provided, the returned list only includes all policy exemptions
        /// that at the given scope. If $filter=excludeExpired() is provided,
        /// the returned list only includes all policy exemptions that either
        /// haven't expired or didn't set expiration date. If
        /// $filter=policyAssignmentId eq '{value}' is provided. the returned
        /// list only includes all policy exemptions that are associated with
        /// the give policyAssignmentId.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListWithHttpMessagesAsync(string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a resource group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// associated with the given resource group in the given subscription
        /// that match the optional given $filter. Valid values for $filter
        /// are: 'atScope()', 'atExactScope()', 'excludeExpired()' or
        /// 'policyAssignmentId eq '{value}''. If $filter is not provided, the
        /// unfiltered list includes all policy exemptions associated with the
        /// resource group, including those that apply directly or apply from
        /// containing scopes, as well as any applied to resources contained
        /// within the resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation. Valid values for $filter are:
        /// 'atScope()', 'atExactScope()', 'excludeExpired()' or
        /// 'policyAssignmentId eq '{value}''. If $filter is not provided, no
        /// filtering is performed. If $filter is not provided, the unfiltered
        /// list includes all policy exemptions associated with the scope,
        /// including those that apply directly or apply from containing
        /// scopes. If $filter=atScope() is provided, the returned list only
        /// includes all policy exemptions that apply to the scope, which is
        /// everything in the unfiltered list except those applied to sub
        /// scopes contained within the given scope. If $filter=atExactScope()
        /// is provided, the returned list only includes all policy exemptions
        /// that at the given scope. If $filter=excludeExpired() is provided,
        /// the returned list only includes all policy exemptions that either
        /// haven't expired or didn't set expiration date. If
        /// $filter=policyAssignmentId eq '{value}' is provided. the returned
        /// list only includes all policy exemptions that are associated with
        /// the give policyAssignmentId.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListForResourceGroupWithHttpMessagesAsync(string resourceGroupName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a resource.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// associated with the specified resource in the given resource group
        /// and subscription that match the optional given $filter. Valid
        /// values for $filter are: 'atScope()', 'atExactScope()',
        /// 'excludeExpired()' or 'policyAssignmentId eq '{value}''. If $filter
        /// is not provided, the unfiltered list includes all policy exemptions
        /// associated with the resource, including those that apply directly
        /// or from all containing scopes, as well as any applied to resources
        /// contained within the resource. Three parameters plus the resource
        /// name are used to identify a specific resource. If the resource is
        /// not part of a parent resource (the more common case), the parent
        /// resource path should not be provided (or provided as ''). For
        /// example a web app could be specified as
        /// ({resourceProviderNamespace} == 'Microsoft.Web',
        /// {parentResourcePath} == '', {resourceType} == 'sites',
        /// {resourceName} == 'MyWebApp'). If the resource is part of a parent
        /// resource, then all parameters should be provided. For example a
        /// virtual machine DNS name could be specified as
        /// ({resourceProviderNamespace} == 'Microsoft.Compute',
        /// {parentResourcePath} == 'virtualMachines/MyVirtualMachine',
        /// {resourceType} == 'domainNames', {resourceName} ==
        /// 'MyComputerName'). A convenient alternative to providing the
        /// namespace and type name separately is to provide both in the
        /// {resourceType} parameter, format: ({resourceProviderNamespace} ==
        /// '', {parentResourcePath} == '', {resourceType} ==
        /// 'Microsoft.Web/sites', {resourceName} == 'MyWebApp').
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider. For example, the namespace
        /// of a virtual machine is Microsoft.Compute (from
        /// Microsoft.Compute/virtualMachines)
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource path. Use empty string if there is none.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type name. For example the type name of a web app is
        /// 'sites' (from Microsoft.Web/sites).
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation. Valid values for $filter are:
        /// 'atScope()', 'atExactScope()', 'excludeExpired()' or
        /// 'policyAssignmentId eq '{value}''. If $filter is not provided, no
        /// filtering is performed. If $filter is not provided, the unfiltered
        /// list includes all policy exemptions associated with the scope,
        /// including those that apply directly or apply from containing
        /// scopes. If $filter=atScope() is provided, the returned list only
        /// includes all policy exemptions that apply to the scope, which is
        /// everything in the unfiltered list except those applied to sub
        /// scopes contained within the given scope. If $filter=atExactScope()
        /// is provided, the returned list only includes all policy exemptions
        /// that at the given scope. If $filter=excludeExpired() is provided,
        /// the returned list only includes all policy exemptions that either
        /// haven't expired or didn't set expiration date. If
        /// $filter=policyAssignmentId eq '{value}' is provided. the returned
        /// list only includes all policy exemptions that are associated with
        /// the give policyAssignmentId.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListForResourceWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a management group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// applicable to the management group that match the given $filter.
        /// Valid values for $filter are: 'atScope()', 'atExactScope()',
        /// 'excludeExpired()' or 'policyAssignmentId eq '{value}''. If
        /// $filter=atScope() is provided, the returned list includes all
        /// policy exemptions that are assigned to the management group or the
        /// management group's ancestors.
        /// </remarks>
        /// <param name='managementGroupId'>
        /// The ID of the management group.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation. Valid values for $filter are:
        /// 'atScope()', 'atExactScope()', 'excludeExpired()' or
        /// 'policyAssignmentId eq '{value}''. If $filter is not provided, no
        /// filtering is performed. If $filter is not provided, the unfiltered
        /// list includes all policy exemptions associated with the scope,
        /// including those that apply directly or apply from containing
        /// scopes. If $filter=atScope() is provided, the returned list only
        /// includes all policy exemptions that apply to the scope, which is
        /// everything in the unfiltered list except those applied to sub
        /// scopes contained within the given scope. If $filter=atExactScope()
        /// is provided, the returned list only includes all policy exemptions
        /// that at the given scope. If $filter=excludeExpired() is provided,
        /// the returned list only includes all policy exemptions that either
        /// haven't expired or didn't set expiration date. If
        /// $filter=policyAssignmentId eq '{value}' is provided. the returned
        /// list only includes all policy exemptions that are associated with
        /// the give policyAssignmentId.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListForManagementGroupWithHttpMessagesAsync(string managementGroupId, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a subscription.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// associated with the given subscription that match the optional
        /// given $filter. Valid values for $filter are: 'atScope()',
        /// 'atExactScope()', 'excludeExpired()' or 'policyAssignmentId eq
        /// '{value}''. If $filter is not provided, the unfiltered list
        /// includes all policy exemptions associated with the subscription,
        /// including those that apply directly or from management groups that
        /// contain the given subscription, as well as any applied to objects
        /// contained within the subscription.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a resource group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// associated with the given resource group in the given subscription
        /// that match the optional given $filter. Valid values for $filter
        /// are: 'atScope()', 'atExactScope()', 'excludeExpired()' or
        /// 'policyAssignmentId eq '{value}''. If $filter is not provided, the
        /// unfiltered list includes all policy exemptions associated with the
        /// resource group, including those that apply directly or apply from
        /// containing scopes, as well as any applied to resources contained
        /// within the resource group.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListForResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a resource.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// associated with the specified resource in the given resource group
        /// and subscription that match the optional given $filter. Valid
        /// values for $filter are: 'atScope()', 'atExactScope()',
        /// 'excludeExpired()' or 'policyAssignmentId eq '{value}''. If $filter
        /// is not provided, the unfiltered list includes all policy exemptions
        /// associated with the resource, including those that apply directly
        /// or from all containing scopes, as well as any applied to resources
        /// contained within the resource. Three parameters plus the resource
        /// name are used to identify a specific resource. If the resource is
        /// not part of a parent resource (the more common case), the parent
        /// resource path should not be provided (or provided as ''). For
        /// example a web app could be specified as
        /// ({resourceProviderNamespace} == 'Microsoft.Web',
        /// {parentResourcePath} == '', {resourceType} == 'sites',
        /// {resourceName} == 'MyWebApp'). If the resource is part of a parent
        /// resource, then all parameters should be provided. For example a
        /// virtual machine DNS name could be specified as
        /// ({resourceProviderNamespace} == 'Microsoft.Compute',
        /// {parentResourcePath} == 'virtualMachines/MyVirtualMachine',
        /// {resourceType} == 'domainNames', {resourceName} ==
        /// 'MyComputerName'). A convenient alternative to providing the
        /// namespace and type name separately is to provide both in the
        /// {resourceType} parameter, format: ({resourceProviderNamespace} ==
        /// '', {parentResourcePath} == '', {resourceType} ==
        /// 'Microsoft.Web/sites', {resourceName} == 'MyWebApp').
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListForResourceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy exemptions that apply to a management group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy exemptions
        /// applicable to the management group that match the given $filter.
        /// Valid values for $filter are: 'atScope()', 'atExactScope()',
        /// 'excludeExpired()' or 'policyAssignmentId eq '{value}''. If
        /// $filter=atScope() is provided, the returned list includes all
        /// policy exemptions that are assigned to the management group or the
        /// management group's ancestors.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyExemption>>> ListForManagementGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
