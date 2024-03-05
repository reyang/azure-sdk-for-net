// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="SupportTicketChatTranscriptResource"/> and their operations.
    /// Each <see cref="SupportTicketChatTranscriptResource"/> in the collection will belong to the same instance of <see cref="SubscriptionSupportTicketResource"/>.
    /// To get a <see cref="SupportTicketChatTranscriptCollection"/> instance call the GetSupportTicketChatTranscripts method from an instance of <see cref="SubscriptionSupportTicketResource"/>.
    /// </summary>
    public partial class SupportTicketChatTranscriptCollection : ArmCollection, IEnumerable<SupportTicketChatTranscriptResource>, IAsyncEnumerable<SupportTicketChatTranscriptResource>
    {
        private readonly ClientDiagnostics _supportTicketChatTranscriptChatTranscriptsClientDiagnostics;
        private readonly ChatTranscriptsRestOperations _supportTicketChatTranscriptChatTranscriptsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketChatTranscriptCollection"/> class for mocking. </summary>
        protected SupportTicketChatTranscriptCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketChatTranscriptCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupportTicketChatTranscriptCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketChatTranscriptChatTranscriptsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SupportTicketChatTranscriptResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportTicketChatTranscriptResource.ResourceType, out string supportTicketChatTranscriptChatTranscriptsApiVersion);
            _supportTicketChatTranscriptChatTranscriptsRestClient = new ChatTranscriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketChatTranscriptChatTranscriptsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.Support/supportTickets")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.Support/supportTickets"), nameof(id));
        }

        /// <summary>
        /// Returns chatTranscript details for a support ticket under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        public virtual async Task<Response<SupportTicketChatTranscriptResource>> GetAsync(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            if (chatTranscriptName == null)
            {
                throw new ArgumentNullException(nameof(chatTranscriptName));
            }
            if (chatTranscriptName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(chatTranscriptName));
            }

            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptCollection.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketChatTranscriptChatTranscriptsRestClient.GetAsync(Id.SubscriptionId, Id.Name, chatTranscriptName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketChatTranscriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns chatTranscript details for a support ticket under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        public virtual Response<SupportTicketChatTranscriptResource> Get(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            if (chatTranscriptName == null)
            {
                throw new ArgumentNullException(nameof(chatTranscriptName));
            }
            if (chatTranscriptName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(chatTranscriptName));
            }

            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptCollection.Get");
            scope.Start();
            try
            {
                var response = _supportTicketChatTranscriptChatTranscriptsRestClient.Get(Id.SubscriptionId, Id.Name, chatTranscriptName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketChatTranscriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all chat transcripts for a support ticket under subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupportTicketChatTranscriptResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupportTicketChatTranscriptResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _supportTicketChatTranscriptChatTranscriptsRestClient.CreateListRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _supportTicketChatTranscriptChatTranscriptsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SupportTicketChatTranscriptResource(Client, ChatTranscriptDetailData.DeserializeChatTranscriptDetailData(e)), _supportTicketChatTranscriptChatTranscriptsClientDiagnostics, Pipeline, "SupportTicketChatTranscriptCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all chat transcripts for a support ticket under subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupportTicketChatTranscriptResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupportTicketChatTranscriptResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _supportTicketChatTranscriptChatTranscriptsRestClient.CreateListRequest(Id.SubscriptionId, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _supportTicketChatTranscriptChatTranscriptsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SupportTicketChatTranscriptResource(Client, ChatTranscriptDetailData.DeserializeChatTranscriptDetailData(e)), _supportTicketChatTranscriptChatTranscriptsClientDiagnostics, Pipeline, "SupportTicketChatTranscriptCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            if (chatTranscriptName == null)
            {
                throw new ArgumentNullException(nameof(chatTranscriptName));
            }
            if (chatTranscriptName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(chatTranscriptName));
            }

            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptCollection.Exists");
            scope.Start();
            try
            {
                var response = await _supportTicketChatTranscriptChatTranscriptsRestClient.GetAsync(Id.SubscriptionId, Id.Name, chatTranscriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        public virtual Response<bool> Exists(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            if (chatTranscriptName == null)
            {
                throw new ArgumentNullException(nameof(chatTranscriptName));
            }
            if (chatTranscriptName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(chatTranscriptName));
            }

            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptCollection.Exists");
            scope.Start();
            try
            {
                var response = _supportTicketChatTranscriptChatTranscriptsRestClient.Get(Id.SubscriptionId, Id.Name, chatTranscriptName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        public virtual async Task<NullableResponse<SupportTicketChatTranscriptResource>> GetIfExistsAsync(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            if (chatTranscriptName == null)
            {
                throw new ArgumentNullException(nameof(chatTranscriptName));
            }
            if (chatTranscriptName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(chatTranscriptName));
            }

            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _supportTicketChatTranscriptChatTranscriptsRestClient.GetAsync(Id.SubscriptionId, Id.Name, chatTranscriptName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SupportTicketChatTranscriptResource>(response.GetRawResponse());
                return Response.FromValue(new SupportTicketChatTranscriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        public virtual NullableResponse<SupportTicketChatTranscriptResource> GetIfExists(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            if (chatTranscriptName == null)
            {
                throw new ArgumentNullException(nameof(chatTranscriptName));
            }
            if (chatTranscriptName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(chatTranscriptName));
            }

            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _supportTicketChatTranscriptChatTranscriptsRestClient.Get(Id.SubscriptionId, Id.Name, chatTranscriptName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SupportTicketChatTranscriptResource>(response.GetRawResponse());
                return Response.FromValue(new SupportTicketChatTranscriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupportTicketChatTranscriptResource> IEnumerable<SupportTicketChatTranscriptResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupportTicketChatTranscriptResource> IAsyncEnumerable<SupportTicketChatTranscriptResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
