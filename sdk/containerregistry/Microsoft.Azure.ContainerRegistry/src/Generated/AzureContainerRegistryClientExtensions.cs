// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AzureContainerRegistryClient.
    /// </summary>
    public static partial class AzureContainerRegistryClientExtensions
    {
            /// <summary>
            /// Tells whether this Docker Registry instance supports Docker Registry HTTP
            /// API v2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetDockerRegistryV2SupportAsync(this IAzureContainerRegistryClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetDockerRegistryV2SupportWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Fetch the tags under the repository identified by 'name'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RepositoryTags> GetTagListAsync(this IAzureContainerRegistryClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTagListWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Pulls the image manifest file associated with the specified name and
            /// reference. Reference may be a tag or a digest
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Manifest> GetManifestAsync(this IAzureContainerRegistryClient operations, string name, string reference, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetManifestWithHttpMessagesAsync(name, reference, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List respositories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='last'>
            /// query parameter for the last item in previou query
            /// </param>
            /// <param name='n'>
            /// query parameter for max number of items
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Repositories> GetRepositoriesAsync(this IAzureContainerRegistryClient operations, string last = default(string), string n = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRepositoriesWithHttpMessagesAsync(last, n, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List respositories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='last'>
            /// query parameter for the last item in previou query
            /// </param>
            /// <param name='n'>
            /// query parameter for max number of items
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Repositories> GetAcrRepositoriesAsync(this IAzureContainerRegistryClient operations, string last = default(string), string n = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcrRepositoriesWithHttpMessagesAsync(last, n, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get respository attributes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RepositoryAttributes> GetAcrRepositoryAttributesAsync(this IAzureContainerRegistryClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcrRepositoryAttributesWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a respository
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeletedRepository> DeleteAcrRepositoryAsync(this IAzureContainerRegistryClient operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteAcrRepositoryWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update attributes of a repository
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='value'>
            /// Repository attribute value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAcrRepositoryAttributesAsync(this IAzureContainerRegistryClient operations, string name, ChangeableAttributes value = default(ChangeableAttributes), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateAcrRepositoryAttributesWithHttpMessagesAsync(name, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List tags of a repository
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='last'>
            /// query parameter for the last item in previou query
            /// </param>
            /// <param name='n'>
            /// query parameter for max number of items
            /// </param>
            /// <param name='orderby'>
            /// orderby query parameter
            /// </param>
            /// <param name='digest'>
            /// filter by digest
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AcrRepositoryTags> GetAcrTagsAsync(this IAzureContainerRegistryClient operations, string name, string last = default(string), string n = default(string), string orderby = default(string), string digest = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcrTagsWithHttpMessagesAsync(name, last, n, orderby, digest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get manifest attributes by tag
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag name of the image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AcrTagAttributes> GetAcrTagAttributesAsync(this IAzureContainerRegistryClient operations, string name, string reference, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcrTagAttributesWithHttpMessagesAsync(name, reference, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update tag attributes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag name of the image
            /// </param>
            /// <param name='value'>
            /// Changeable attribute value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAcrTagAttributesAsync(this IAzureContainerRegistryClient operations, string name, string reference, ChangeableAttributes value = default(ChangeableAttributes), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateAcrTagAttributesWithHttpMessagesAsync(name, reference, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete tag
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag name of the image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAcrTagAsync(this IAzureContainerRegistryClient operations, string name, string reference, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAcrTagWithHttpMessagesAsync(name, reference, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List manifests of a repository
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='last'>
            /// query parameter for the last item in previou query
            /// </param>
            /// <param name='n'>
            /// query parameter for max number of items
            /// </param>
            /// <param name='orderby'>
            /// orderby query parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AcrManifests> GetAcrManifestsAsync(this IAzureContainerRegistryClient operations, string name, string last = default(string), string n = default(string), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcrManifestsWithHttpMessagesAsync(name, last, n, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get manifest attributes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A digest pointing to a specific image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AcrManifestAttributes> GetAcrManifestAttributesAsync(this IAzureContainerRegistryClient operations, string name, string reference, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcrManifestAttributesWithHttpMessagesAsync(name, reference, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update attributes of a manifest
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='value'>
            /// Changeable attribute value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAcrManifestAttributesAsync(this IAzureContainerRegistryClient operations, string name, string reference, ChangeableAttributes value = default(ChangeableAttributes), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateAcrManifestAttributesWithHttpMessagesAsync(name, reference, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
