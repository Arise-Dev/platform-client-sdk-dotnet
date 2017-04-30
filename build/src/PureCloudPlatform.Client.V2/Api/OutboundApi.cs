using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOutboundApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns></returns>
        void DeleteOutboundAttemptlimit (string attemptLimitsId);

        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundAttemptlimitWithHttpInfo (string attemptLimitsId);
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns></returns>
        void DeleteOutboundCallabletimeset (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundCallabletimesetWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns></returns>
        void DeleteOutboundCallanalysisresponseset (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign DeleteOutboundCampaign (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> DeleteOutboundCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns></returns>
        void DeleteOutboundCampaignProgress (string campaignId);

        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundCampaignProgressWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns></returns>
        void DeleteOutboundCampaignrule (string campaignRuleId);

        /// <summary>
        /// Delete Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundCampaignruleWithHttpInfo (string campaignRuleId);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns></returns>
        void DeleteOutboundContactlist (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundContactlistWithHttpInfo (string contactListId);
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns></returns>
        void DeleteOutboundContactlistContact (string contactListId, string contactId);

        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundContactlistContactWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Delete contacts from a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns></returns>
        void DeleteOutboundContactlistContacts (string contactListId, List<string> contactIds);

        /// <summary>
        /// Delete contacts from a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundContactlistContactsWithHttpInfo (string contactListId, List<string> contactIds);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns></returns>
        void DeleteOutboundDnclist (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundDnclistWithHttpInfo (string dncListId);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns></returns>
        void DeleteOutboundRuleset (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundRulesetWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns></returns>
        void DeleteOutboundSchedulesCampaign (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundSchedulesCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns></returns>
        void DeleteOutboundSchedulesSequence (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundSchedulesSequenceWithHttpInfo (string sequenceId);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns></returns>
        void DeleteOutboundSequence (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOutboundSequenceWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>AttemptLimits</returns>
        AttemptLimits GetOutboundAttemptlimit (string attemptLimitsId);

        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        ApiResponse<AttemptLimits> GetOutboundAttemptlimitWithHttpInfo (string attemptLimitsId);
        /// <summary>
        /// Query attempt limits list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>AttemptLimitsEntityListing</returns>
        AttemptLimitsEntityListing GetOutboundAttemptlimits (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query attempt limits list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of AttemptLimitsEntityListing</returns>
        ApiResponse<AttemptLimitsEntityListing> GetOutboundAttemptlimitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet GetOutboundCallabletimeset (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> GetOutboundCallabletimesetWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CallableTimeSetEntityListing</returns>
        CallableTimeSetEntityListing GetOutboundCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CallableTimeSetEntityListing</returns>
        ApiResponse<CallableTimeSetEntityListing> GetOutboundCallabletimesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        ResponseSet GetOutboundCallanalysisresponseset (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> GetOutboundCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ResponseSetEntityListing</returns>
        ResponseSetEntityListing GetOutboundCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ResponseSetEntityListing</returns>
        ApiResponse<ResponseSetEntityListing> GetOutboundCallanalysisresponsesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign GetOutboundCampaign (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> GetOutboundCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        CampaignDiagnostics GetOutboundCampaignDiagnostics (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        ApiResponse<CampaignDiagnostics> GetOutboundCampaignDiagnosticsWithHttpInfo (string campaignId);
        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignInteractions</returns>
        CampaignInteractions GetOutboundCampaignInteractions (string campaignId);

        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignInteractions</returns>
        ApiResponse<CampaignInteractions> GetOutboundCampaignInteractionsWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignProgress</returns>
        CampaignProgress GetOutboundCampaignProgress (string campaignId);

        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignProgress</returns>
        ApiResponse<CampaignProgress> GetOutboundCampaignProgressWithHttpInfo (string campaignId);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        CampaignStats GetOutboundCampaignStats (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        ApiResponse<CampaignStats> GetOutboundCampaignStatsWithHttpInfo (string campaignId);
        /// <summary>
        /// Get Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>CampaignRule</returns>
        CampaignRule GetOutboundCampaignrule (string campaignRuleId);

        /// <summary>
        /// Get Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>ApiResponse of CampaignRule</returns>
        ApiResponse<CampaignRule> GetOutboundCampaignruleWithHttpInfo (string campaignRuleId);
        /// <summary>
        /// Query Campaign Rule list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignRuleEntityListing</returns>
        CampaignRuleEntityListing GetOutboundCampaignrules (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query Campaign Rule list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignRuleEntityListing</returns>
        ApiResponse<CampaignRuleEntityListing> GetOutboundCampaignrulesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignEntityListing</returns>
        CampaignEntityListing GetOutboundCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignEntityListing</returns>
        ApiResponse<CampaignEntityListing> GetOutboundCampaignsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        ContactList GetOutboundContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> GetOutboundContactlistWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>DialerContact</returns>
        DialerContact GetOutboundContactlistContact (string contactListId, string contactId);

        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of DialerContact</returns>
        ApiResponse<DialerContact> GetOutboundContactlistContactWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        ExportUri GetOutboundContactlistExport (string contactListId, string download = null);

        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        ApiResponse<ExportUri> GetOutboundContactlistExportWithHttpInfo (string contactListId, string download = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetOutboundContactlistImportstatus (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetOutboundContactlistImportstatusWithHttpInfo (string contactListId);
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ContactListEntityListing</returns>
        ContactListEntityListing GetOutboundContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        ApiResponse<ContactListEntityListing> GetOutboundContactlistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        DncList GetOutboundDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> GetOutboundDnclistWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        ExportUri GetOutboundDnclistExport (string dncListId, string download = null);

        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        ApiResponse<ExportUri> GetOutboundDnclistExportWithHttpInfo (string dncListId, string download = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetOutboundDnclistImportstatus (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetOutboundDnclistImportstatusWithHttpInfo (string dncListId);
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>DncListEntityListing</returns>
        DncListEntityListing GetOutboundDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        ApiResponse<DncListEntityListing> GetOutboundDnclistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get Dialer Event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>EventLog</returns>
        EventLog GetOutboundEvent (string eventId);

        /// <summary>
        /// Get Dialer Event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>ApiResponse of EventLog</returns>
        ApiResponse<EventLog> GetOutboundEventWithHttpInfo (string eventId);
        /// <summary>
        /// Query Event Logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>DialerEventEntityListing</returns>
        DialerEventEntityListing GetOutboundEvents (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query Event Logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of DialerEventEntityListing</returns>
        ApiResponse<DialerEventEntityListing> GetOutboundEventsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        RuleSet GetOutboundRuleset (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> GetOutboundRulesetWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>RuleSetEntityListing</returns>
        RuleSetEntityListing GetOutboundRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of RuleSetEntityListing</returns>
        ApiResponse<RuleSetEntityListing> GetOutboundRulesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule GetOutboundSchedulesCampaign (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> GetOutboundSchedulesCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        List<CampaignSchedule> GetOutboundSchedulesCampaigns ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        ApiResponse<List<CampaignSchedule>> GetOutboundSchedulesCampaignsWithHttpInfo ();
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule GetOutboundSchedulesSequence (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> GetOutboundSchedulesSequenceWithHttpInfo (string sequenceId);
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        List<SequenceSchedule> GetOutboundSchedulesSequences ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        ApiResponse<List<SequenceSchedule>> GetOutboundSchedulesSequencesWithHttpInfo ();
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence GetOutboundSequence (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> GetOutboundSequenceWithHttpInfo (string sequenceId);
        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignSequenceEntityListing</returns>
        CampaignSequenceEntityListing GetOutboundSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignSequenceEntityListing</returns>
        ApiResponse<CampaignSequenceEntityListing> GetOutboundSequencesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping GetOutboundWrapupcodemappings ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> GetOutboundWrapupcodemappingsWithHttpInfo ();
        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        AttemptLimits PostOutboundAttemptlimits (AttemptLimits body);

        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        ApiResponse<AttemptLimits> PostOutboundAttemptlimitsWithHttpInfo (AttemptLimits body);
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>AuditSearchResult</returns>
        AuditSearchResult PostOutboundAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        ApiResponse<AuditSearchResult> PostOutboundAuditsWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PostOutboundCallabletimesets (CallableTimeSet body);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PostOutboundCallabletimesetsWithHttpInfo (CallableTimeSet body);
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet PostOutboundCallanalysisresponsesets (ResponseSet body);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> PostOutboundCallanalysisresponsesetsWithHttpInfo (ResponseSet body);
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        ContactCallbackRequest PostOutboundCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        ApiResponse<ContactCallbackRequest> PostOutboundCampaignCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body);
        /// <summary>
        /// Create Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>CampaignRule</returns>
        CampaignRule PostOutboundCampaignrules (CampaignRule body);

        /// <summary>
        /// Create Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>ApiResponse of CampaignRule</returns>
        ApiResponse<CampaignRule> PostOutboundCampaignrulesWithHttpInfo (CampaignRule body);
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign PostOutboundCampaigns (Campaign body);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> PostOutboundCampaignsWithHttpInfo (Campaign body);
        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>List&lt;CampaignProgress&gt;</returns>
        List<CampaignProgress> PostOutboundCampaignsProgress (List<string> body);

        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>ApiResponse of List&lt;CampaignProgress&gt;</returns>
        ApiResponse<List<CampaignProgress>> PostOutboundCampaignsProgressWithHttpInfo (List<string> body);
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>List&lt;DialerContact&gt;</returns>
        List<DialerContact> PostOutboundContactlistContacts (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>ApiResponse of List&lt;DialerContact&gt;</returns>
        ApiResponse<List<DialerContact>> PostOutboundContactlistContactsWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>UriReference</returns>
        UriReference PostOutboundContactlistExport (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of UriReference</returns>
        ApiResponse<UriReference> PostOutboundContactlistExportWithHttpInfo (string contactListId);
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList PostOutboundContactlists (ContactList body);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> PostOutboundContactlistsWithHttpInfo (ContactList body);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        void PostOutboundConversationDnc (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostOutboundConversationDncWithHttpInfo (string conversationId);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>UriReference</returns>
        UriReference PostOutboundDnclistExport (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of UriReference</returns>
        ApiResponse<UriReference> PostOutboundDnclistExportWithHttpInfo (string dncListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns></returns>
        void PostOutboundDnclistPhonenumbers (string dncListId, List<string> body);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostOutboundDnclistPhonenumbersWithHttpInfo (string dncListId, List<string> body);
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList PostOutboundDnclists (DncListCreate body);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> PostOutboundDnclistsWithHttpInfo (DncListCreate body);
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet PostOutboundRulesets (RuleSet body);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> PostOutboundRulesetsWithHttpInfo (RuleSet body);
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence PostOutboundSequences (CampaignSequence body);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> PostOutboundSequencesWithHttpInfo (CampaignSequence body);
        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        AttemptLimits PutOutboundAttemptlimit (string attemptLimitsId, AttemptLimits body);

        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        ApiResponse<AttemptLimits> PutOutboundAttemptlimitWithHttpInfo (string attemptLimitsId, AttemptLimits body);
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PutOutboundCallabletimeset (string callableTimeSetId, CallableTimeSet body);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PutOutboundCallabletimesetWithHttpInfo (string callableTimeSetId, CallableTimeSet body);
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet PutOutboundCallanalysisresponseset (string callAnalysisSetId, ResponseSet body);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> PutOutboundCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId, ResponseSet body);
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign PutOutboundCampaign (string campaignId, Campaign body);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> PutOutboundCampaignWithHttpInfo (string campaignId, Campaign body);
        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>string</returns>
        string PutOutboundCampaignAgent (string campaignId, string userId, Agent body);

        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PutOutboundCampaignAgentWithHttpInfo (string campaignId, string userId, Agent body);
        /// <summary>
        /// Update Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>CampaignRule</returns>
        CampaignRule PutOutboundCampaignrule (string campaignRuleId, CampaignRule body);

        /// <summary>
        /// Update Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>ApiResponse of CampaignRule</returns>
        ApiResponse<CampaignRule> PutOutboundCampaignruleWithHttpInfo (string campaignRuleId, CampaignRule body);
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList PutOutboundContactlist (string contactListId, ContactList body);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> PutOutboundContactlistWithHttpInfo (string contactListId, ContactList body);
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>DialerContact</returns>
        DialerContact PutOutboundContactlistContact (string contactListId, string contactId, DialerContact body);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>ApiResponse of DialerContact</returns>
        ApiResponse<DialerContact> PutOutboundContactlistContactWithHttpInfo (string contactListId, string contactId, DialerContact body);
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList PutOutboundDnclist (string dncListId, DncList body);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> PutOutboundDnclistWithHttpInfo (string dncListId, DncList body);
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet PutOutboundRuleset (string ruleSetId, RuleSet body);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> PutOutboundRulesetWithHttpInfo (string ruleSetId, RuleSet body);
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule PutOutboundSchedulesCampaign (string campaignId, CampaignSchedule body);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> PutOutboundSchedulesCampaignWithHttpInfo (string campaignId, CampaignSchedule body);
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule PutOutboundSchedulesSequence (string sequenceId, SequenceSchedule body);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> PutOutboundSchedulesSequenceWithHttpInfo (string sequenceId, SequenceSchedule body);
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence PutOutboundSequence (string sequenceId, CampaignSequence body);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> PutOutboundSequenceWithHttpInfo (string sequenceId, CampaignSequence body);
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping PutOutboundWrapupcodemappings (WrapUpCodeMapping body);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> PutOutboundWrapupcodemappingsWithHttpInfo (WrapUpCodeMapping body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundAttemptlimitAsync (string attemptLimitsId);

        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundAttemptlimitAsyncWithHttpInfo (string attemptLimitsId);
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundCallabletimesetAsync (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCallabletimesetAsyncWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundCallanalysisresponsesetAsync (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> DeleteOutboundCampaignAsync (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> DeleteOutboundCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundCampaignProgressAsync (string campaignId);

        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCampaignProgressAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundCampaignruleAsync (string campaignRuleId);

        /// <summary>
        /// Delete Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCampaignruleAsyncWithHttpInfo (string campaignRuleId);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundContactlistAsync (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundContactlistAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundContactlistContactAsync (string contactListId, string contactId);

        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundContactlistContactAsyncWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Delete contacts from a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundContactlistContactsAsync (string contactListId, List<string> contactIds);

        /// <summary>
        /// Delete contacts from a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundContactlistContactsAsyncWithHttpInfo (string contactListId, List<string> contactIds);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundDnclistAsync (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundDnclistAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundRulesetAsync (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundRulesetAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundSchedulesCampaignAsync (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundSchedulesCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundSchedulesSequenceAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundSchedulesSequenceAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOutboundSequenceAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundSequenceAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of AttemptLimits</returns>
        System.Threading.Tasks.Task<AttemptLimits> GetOutboundAttemptlimitAsync (string attemptLimitsId);

        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> GetOutboundAttemptlimitAsyncWithHttpInfo (string attemptLimitsId);
        /// <summary>
        /// Query attempt limits list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of AttemptLimitsEntityListing</returns>
        System.Threading.Tasks.Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query attempt limits list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (AttemptLimitsEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimitsEntityListing>> GetOutboundAttemptlimitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> GetOutboundCallabletimesetAsync (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetOutboundCallabletimesetAsyncWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CallableTimeSetEntityListing</returns>
        System.Threading.Tasks.Task<CallableTimeSetEntityListing> GetOutboundCallabletimesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CallableTimeSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> GetOutboundCallabletimesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> GetOutboundCallanalysisresponsesetAsync (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetOutboundCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ResponseSetEntityListing</returns>
        System.Threading.Tasks.Task<ResponseSetEntityListing> GetOutboundCallanalysisresponsesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ResponseSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> GetOutboundCallanalysisresponsesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> GetOutboundCampaignAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> GetOutboundCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        System.Threading.Tasks.Task<CampaignDiagnostics> GetOutboundCampaignDiagnosticsAsync (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetOutboundCampaignDiagnosticsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignInteractions</returns>
        System.Threading.Tasks.Task<CampaignInteractions> GetOutboundCampaignInteractionsAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignInteractions)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignInteractions>> GetOutboundCampaignInteractionsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignProgress</returns>
        System.Threading.Tasks.Task<CampaignProgress> GetOutboundCampaignProgressAsync (string campaignId);

        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignProgress)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignProgress>> GetOutboundCampaignProgressAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        System.Threading.Tasks.Task<CampaignStats> GetOutboundCampaignStatsAsync (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetOutboundCampaignStatsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of CampaignRule</returns>
        System.Threading.Tasks.Task<CampaignRule> GetOutboundCampaignruleAsync (string campaignRuleId);

        /// <summary>
        /// Get Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of ApiResponse (CampaignRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignRule>> GetOutboundCampaignruleAsyncWithHttpInfo (string campaignRuleId);
        /// <summary>
        /// Query Campaign Rule list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignRuleEntityListing</returns>
        System.Threading.Tasks.Task<CampaignRuleEntityListing> GetOutboundCampaignrulesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query Campaign Rule list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignRuleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignRuleEntityListing>> GetOutboundCampaignrulesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignEntityListing</returns>
        System.Threading.Tasks.Task<CampaignEntityListing> GetOutboundCampaignsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> GetOutboundCampaignsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> GetOutboundContactlistAsync (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> GetOutboundContactlistAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of DialerContact</returns>
        System.Threading.Tasks.Task<DialerContact> GetOutboundContactlistContactAsync (string contactListId, string contactId);

        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerContact>> GetOutboundContactlistContactAsyncWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        System.Threading.Tasks.Task<ExportUri> GetOutboundContactlistExportAsync (string contactListId, string download = null);

        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetOutboundContactlistExportAsyncWithHttpInfo (string contactListId, string download = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetOutboundContactlistImportstatusAsync (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetOutboundContactlistImportstatusAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ContactListEntityListing</returns>
        System.Threading.Tasks.Task<ContactListEntityListing> GetOutboundContactlistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> GetOutboundContactlistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> GetOutboundDnclistAsync (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> GetOutboundDnclistAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        System.Threading.Tasks.Task<ExportUri> GetOutboundDnclistExportAsync (string dncListId, string download = null);

        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetOutboundDnclistExportAsyncWithHttpInfo (string dncListId, string download = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetOutboundDnclistImportstatusAsync (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetOutboundDnclistImportstatusAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of DncListEntityListing</returns>
        System.Threading.Tasks.Task<DncListEntityListing> GetOutboundDnclistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> GetOutboundDnclistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get Dialer Event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>Task of EventLog</returns>
        System.Threading.Tasks.Task<EventLog> GetOutboundEventAsync (string eventId);

        /// <summary>
        /// Get Dialer Event
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>Task of ApiResponse (EventLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventLog>> GetOutboundEventAsyncWithHttpInfo (string eventId);
        /// <summary>
        /// Query Event Logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of DialerEventEntityListing</returns>
        System.Threading.Tasks.Task<DialerEventEntityListing> GetOutboundEventsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query Event Logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (DialerEventEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerEventEntityListing>> GetOutboundEventsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> GetOutboundRulesetAsync (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetOutboundRulesetAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of RuleSetEntityListing</returns>
        System.Threading.Tasks.Task<RuleSetEntityListing> GetOutboundRulesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (RuleSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> GetOutboundRulesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> GetOutboundSchedulesCampaignAsync (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetOutboundSchedulesCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignSchedule>> GetOutboundSchedulesCampaignsAsync ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> GetOutboundSchedulesCampaignsAsyncWithHttpInfo ();
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> GetOutboundSchedulesSequenceAsync (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetOutboundSchedulesSequenceAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<SequenceSchedule>> GetOutboundSchedulesSequencesAsync ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> GetOutboundSchedulesSequencesAsyncWithHttpInfo ();
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> GetOutboundSequenceAsync (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetOutboundSequenceAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignSequenceEntityListing</returns>
        System.Threading.Tasks.Task<CampaignSequenceEntityListing> GetOutboundSequencesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignSequenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> GetOutboundSequencesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> GetOutboundWrapupcodemappingsAsync ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> GetOutboundWrapupcodemappingsAsyncWithHttpInfo ();
        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        System.Threading.Tasks.Task<AttemptLimits> PostOutboundAttemptlimitsAsync (AttemptLimits body);

        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PostOutboundAttemptlimitsAsyncWithHttpInfo (AttemptLimits body);
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of AuditSearchResult</returns>
        System.Threading.Tasks.Task<AuditSearchResult> PostOutboundAuditsAsync (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostOutboundAuditsAsyncWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PostOutboundCallabletimesetsAsync (CallableTimeSet body);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostOutboundCallabletimesetsAsyncWithHttpInfo (CallableTimeSet body);
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> PostOutboundCallanalysisresponsesetsAsync (ResponseSet body);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PostOutboundCallanalysisresponsesetsAsyncWithHttpInfo (ResponseSet body);
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        System.Threading.Tasks.Task<ContactCallbackRequest> PostOutboundCampaignCallbackScheduleAsync (string campaignId, ContactCallbackRequest body);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated)
        /// </summary>
        /// <remarks>
        /// This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostOutboundCampaignCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body);
        /// <summary>
        /// Create Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of CampaignRule</returns>
        System.Threading.Tasks.Task<CampaignRule> PostOutboundCampaignrulesAsync (CampaignRule body);

        /// <summary>
        /// Create Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of ApiResponse (CampaignRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignRule>> PostOutboundCampaignrulesAsyncWithHttpInfo (CampaignRule body);
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> PostOutboundCampaignsAsync (Campaign body);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PostOutboundCampaignsAsyncWithHttpInfo (Campaign body);
        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of List&lt;CampaignProgress&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignProgress>> PostOutboundCampaignsProgressAsync (List<string> body);

        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of ApiResponse (List&lt;CampaignProgress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignProgress>>> PostOutboundCampaignsProgressAsyncWithHttpInfo (List<string> body);
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>Task of List&lt;DialerContact&gt;</returns>
        System.Threading.Tasks.Task<List<DialerContact>> PostOutboundContactlistContactsAsync (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DialerContact&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DialerContact>>> PostOutboundContactlistContactsAsyncWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of UriReference</returns>
        System.Threading.Tasks.Task<UriReference> PostOutboundContactlistExportAsync (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (UriReference)</returns>
        System.Threading.Tasks.Task<ApiResponse<UriReference>> PostOutboundContactlistExportAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> PostOutboundContactlistsAsync (ContactList body);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PostOutboundContactlistsAsyncWithHttpInfo (ContactList body);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostOutboundConversationDncAsync (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostOutboundConversationDncAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of UriReference</returns>
        System.Threading.Tasks.Task<UriReference> PostOutboundDnclistExportAsync (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (UriReference)</returns>
        System.Threading.Tasks.Task<ApiResponse<UriReference>> PostOutboundDnclistExportAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostOutboundDnclistPhonenumbersAsync (string dncListId, List<string> body);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostOutboundDnclistPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body);
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> PostOutboundDnclistsAsync (DncListCreate body);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> PostOutboundDnclistsAsyncWithHttpInfo (DncListCreate body);
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> PostOutboundRulesetsAsync (RuleSet body);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PostOutboundRulesetsAsyncWithHttpInfo (RuleSet body);
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> PostOutboundSequencesAsync (CampaignSequence body);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PostOutboundSequencesAsyncWithHttpInfo (CampaignSequence body);
        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        System.Threading.Tasks.Task<AttemptLimits> PutOutboundAttemptlimitAsync (string attemptLimitsId, AttemptLimits body);

        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PutOutboundAttemptlimitAsyncWithHttpInfo (string attemptLimitsId, AttemptLimits body);
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PutOutboundCallabletimesetAsync (string callableTimeSetId, CallableTimeSet body);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutOutboundCallabletimesetAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body);
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> PutOutboundCallanalysisresponsesetAsync (string callAnalysisSetId, ResponseSet body);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutOutboundCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body);
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> PutOutboundCampaignAsync (string campaignId, Campaign body);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PutOutboundCampaignAsyncWithHttpInfo (string campaignId, Campaign body);
        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PutOutboundCampaignAgentAsync (string campaignId, string userId, Agent body);

        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PutOutboundCampaignAgentAsyncWithHttpInfo (string campaignId, string userId, Agent body);
        /// <summary>
        /// Update Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of CampaignRule</returns>
        System.Threading.Tasks.Task<CampaignRule> PutOutboundCampaignruleAsync (string campaignRuleId, CampaignRule body);

        /// <summary>
        /// Update Campaign Rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of ApiResponse (CampaignRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignRule>> PutOutboundCampaignruleAsyncWithHttpInfo (string campaignRuleId, CampaignRule body);
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> PutOutboundContactlistAsync (string contactListId, ContactList body);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PutOutboundContactlistAsyncWithHttpInfo (string contactListId, ContactList body);
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of DialerContact</returns>
        System.Threading.Tasks.Task<DialerContact> PutOutboundContactlistContactAsync (string contactListId, string contactId, DialerContact body);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerContact>> PutOutboundContactlistContactAsyncWithHttpInfo (string contactListId, string contactId, DialerContact body);
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> PutOutboundDnclistAsync (string dncListId, DncList body);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> PutOutboundDnclistAsyncWithHttpInfo (string dncListId, DncList body);
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> PutOutboundRulesetAsync (string ruleSetId, RuleSet body);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutOutboundRulesetAsyncWithHttpInfo (string ruleSetId, RuleSet body);
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> PutOutboundSchedulesCampaignAsync (string campaignId, CampaignSchedule body);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutOutboundSchedulesCampaignAsyncWithHttpInfo (string campaignId, CampaignSchedule body);
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> PutOutboundSchedulesSequenceAsync (string sequenceId, SequenceSchedule body);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutOutboundSchedulesSequenceAsyncWithHttpInfo (string sequenceId, SequenceSchedule body);
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> PutOutboundSequenceAsync (string sequenceId, CampaignSequence body);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutOutboundSequenceAsyncWithHttpInfo (string sequenceId, CampaignSequence body);
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> PutOutboundWrapupcodemappingsAsync (WrapUpCodeMapping body);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> PutOutboundWrapupcodemappingsAsyncWithHttpInfo (WrapUpCodeMapping body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OutboundApi : IOutboundApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OutboundApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OutboundApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns></returns>
        public void DeleteOutboundAttemptlimit (string attemptLimitsId)
        {
             DeleteOutboundAttemptlimitWithHttpInfo(attemptLimitsId);
        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundAttemptlimitWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->DeleteOutboundAttemptlimit");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundAttemptlimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundAttemptlimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundAttemptlimitAsync (string attemptLimitsId)
        {
             await DeleteOutboundAttemptlimitAsyncWithHttpInfo(attemptLimitsId);

        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundAttemptlimitAsyncWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->DeleteOutboundAttemptlimit");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundAttemptlimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundAttemptlimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns></returns>
        public void DeleteOutboundCallabletimeset (string callableTimeSetId)
        {
             DeleteOutboundCallabletimesetWithHttpInfo(callableTimeSetId);
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundCallabletimesetWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteOutboundCallabletimeset");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallabletimeset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundCallabletimesetAsync (string callableTimeSetId)
        {
             await DeleteOutboundCallabletimesetAsyncWithHttpInfo(callableTimeSetId);

        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCallabletimesetAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteOutboundCallabletimeset");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallabletimeset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns></returns>
        public void DeleteOutboundCallanalysisresponseset (string callAnalysisSetId)
        {
             DeleteOutboundCallanalysisresponsesetWithHttpInfo(callAnalysisSetId);
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteOutboundCallanalysisresponseset");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundCallanalysisresponsesetAsync (string callAnalysisSetId)
        {
             await DeleteOutboundCallanalysisresponsesetAsyncWithHttpInfo(callAnalysisSetId);

        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteOutboundCallanalysisresponseset");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        public Campaign DeleteOutboundCampaign (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = DeleteOutboundCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > DeleteOutboundCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteOutboundCampaign");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> DeleteOutboundCampaignAsync (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = await DeleteOutboundCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> DeleteOutboundCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteOutboundCampaign");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns></returns>
        public void DeleteOutboundCampaignProgress (string campaignId)
        {
             DeleteOutboundCampaignProgressWithHttpInfo(campaignId);
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundCampaignProgressWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteOutboundCampaignProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignProgress: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundCampaignProgressAsync (string campaignId)
        {
             await DeleteOutboundCampaignProgressAsyncWithHttpInfo(campaignId);

        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCampaignProgressAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteOutboundCampaignProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignProgress: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns></returns>
        public void DeleteOutboundCampaignrule (string campaignRuleId)
        {
             DeleteOutboundCampaignruleWithHttpInfo(campaignRuleId);
        }

        /// <summary>
        /// Delete Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundCampaignruleWithHttpInfo (string campaignRuleId)
        {
            // verify the required parameter 'campaignRuleId' is set
            if (campaignRuleId == null)
                throw new ApiException(400, "Missing required parameter 'campaignRuleId' when calling OutboundApi->DeleteOutboundCampaignrule");

            var localVarPath = "/api/v2/outbound/campaignrules/{campaignRuleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignRuleId != null) localVarPathParams.Add("campaignRuleId", Configuration.ApiClient.ParameterToString(campaignRuleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundCampaignruleAsync (string campaignRuleId)
        {
             await DeleteOutboundCampaignruleAsyncWithHttpInfo(campaignRuleId);

        }

        /// <summary>
        /// Delete Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundCampaignruleAsyncWithHttpInfo (string campaignRuleId)
        {
            // verify the required parameter 'campaignRuleId' is set
            if (campaignRuleId == null)
                throw new ApiException(400, "Missing required parameter 'campaignRuleId' when calling OutboundApi->DeleteOutboundCampaignrule");

            var localVarPath = "/api/v2/outbound/campaignrules/{campaignRuleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignRuleId != null) localVarPathParams.Add("campaignRuleId", Configuration.ApiClient.ParameterToString(campaignRuleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundCampaignrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns></returns>
        public void DeleteOutboundContactlist (string contactListId)
        {
             DeleteOutboundContactlistWithHttpInfo(contactListId);
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundContactlistWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteOutboundContactlist");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundContactlistAsync (string contactListId)
        {
             await DeleteOutboundContactlistAsyncWithHttpInfo(contactListId);

        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundContactlistAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteOutboundContactlist");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns></returns>
        public void DeleteOutboundContactlistContact (string contactListId, string contactId)
        {
             DeleteOutboundContactlistContactWithHttpInfo(contactListId, contactId);
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundContactlistContactWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteOutboundContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->DeleteOutboundContactlistContact");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundContactlistContactAsync (string contactListId, string contactId)
        {
             await DeleteOutboundContactlistContactAsyncWithHttpInfo(contactListId, contactId);

        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundContactlistContactAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteOutboundContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->DeleteOutboundContactlistContact");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete contacts from a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns></returns>
        public void DeleteOutboundContactlistContacts (string contactListId, List<string> contactIds)
        {
             DeleteOutboundContactlistContactsWithHttpInfo(contactListId, contactIds);
        }

        /// <summary>
        /// Delete contacts from a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundContactlistContactsWithHttpInfo (string contactListId, List<string> contactIds)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteOutboundContactlistContacts");
            // verify the required parameter 'contactIds' is set
            if (contactIds == null)
                throw new ApiException(400, "Missing required parameter 'contactIds' when calling OutboundApi->DeleteOutboundContactlistContacts");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactIds != null) localVarQueryParams.Add("contactIds", Configuration.ApiClient.ParameterToString(contactIds)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete contacts from a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundContactlistContactsAsync (string contactListId, List<string> contactIds)
        {
             await DeleteOutboundContactlistContactsAsyncWithHttpInfo(contactListId, contactIds);

        }

        /// <summary>
        /// Delete contacts from a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactIds">ContactIds to delete.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundContactlistContactsAsyncWithHttpInfo (string contactListId, List<string> contactIds)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteOutboundContactlistContacts");
            // verify the required parameter 'contactIds' is set
            if (contactIds == null)
                throw new ApiException(400, "Missing required parameter 'contactIds' when calling OutboundApi->DeleteOutboundContactlistContacts");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactIds != null) localVarQueryParams.Add("contactIds", Configuration.ApiClient.ParameterToString(contactIds)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundContactlistContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns></returns>
        public void DeleteOutboundDnclist (string dncListId)
        {
             DeleteOutboundDnclistWithHttpInfo(dncListId);
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundDnclistWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteOutboundDnclist");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundDnclist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundDnclistAsync (string dncListId)
        {
             await DeleteOutboundDnclistAsyncWithHttpInfo(dncListId);

        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundDnclistAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteOutboundDnclist");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundDnclist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns></returns>
        public void DeleteOutboundRuleset (string ruleSetId)
        {
             DeleteOutboundRulesetWithHttpInfo(ruleSetId);
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundRulesetWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteOutboundRuleset");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundRuleset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundRulesetAsync (string ruleSetId)
        {
             await DeleteOutboundRulesetAsyncWithHttpInfo(ruleSetId);

        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundRulesetAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteOutboundRuleset");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundRuleset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns></returns>
        public void DeleteOutboundSchedulesCampaign (string campaignId)
        {
             DeleteOutboundSchedulesCampaignWithHttpInfo(campaignId);
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundSchedulesCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteOutboundSchedulesCampaign");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundSchedulesCampaignAsync (string campaignId)
        {
             await DeleteOutboundSchedulesCampaignAsyncWithHttpInfo(campaignId);

        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundSchedulesCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteOutboundSchedulesCampaign");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns></returns>
        public void DeleteOutboundSchedulesSequence (string sequenceId)
        {
             DeleteOutboundSchedulesSequenceWithHttpInfo(sequenceId);
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundSchedulesSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteOutboundSchedulesSequence");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundSchedulesSequenceAsync (string sequenceId)
        {
             await DeleteOutboundSchedulesSequenceAsyncWithHttpInfo(sequenceId);

        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundSchedulesSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteOutboundSchedulesSequence");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns></returns>
        public void DeleteOutboundSequence (string sequenceId)
        {
             DeleteOutboundSequenceWithHttpInfo(sequenceId);
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOutboundSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteOutboundSequence");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOutboundSequenceAsync (string sequenceId)
        {
             await DeleteOutboundSequenceAsyncWithHttpInfo(sequenceId);

        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOutboundSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteOutboundSequence");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOutboundSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>AttemptLimits</returns>
        public AttemptLimits GetOutboundAttemptlimit (string attemptLimitsId)
        {
             ApiResponse<AttemptLimits> localVarResponse = GetOutboundAttemptlimitWithHttpInfo(attemptLimitsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        public ApiResponse< AttemptLimits > GetOutboundAttemptlimitWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->GetOutboundAttemptlimit");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of AttemptLimits</returns>
        public async System.Threading.Tasks.Task<AttemptLimits> GetOutboundAttemptlimitAsync (string attemptLimitsId)
        {
             ApiResponse<AttemptLimits> localVarResponse = await GetOutboundAttemptlimitAsyncWithHttpInfo(attemptLimitsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> GetOutboundAttemptlimitAsyncWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->GetOutboundAttemptlimit");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>AttemptLimitsEntityListing</returns>
        public AttemptLimitsEntityListing GetOutboundAttemptlimits (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AttemptLimitsEntityListing> localVarResponse = GetOutboundAttemptlimitsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of AttemptLimitsEntityListing</returns>
        public ApiResponse< AttemptLimitsEntityListing > GetOutboundAttemptlimitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimitsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimitsEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimitsEntityListing)));
            
        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of AttemptLimitsEntityListing</returns>
        public async System.Threading.Tasks.Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AttemptLimitsEntityListing> localVarResponse = await GetOutboundAttemptlimitsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (AttemptLimitsEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimitsEntityListing>> GetOutboundAttemptlimitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimitsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimitsEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimitsEntityListing)));
            
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet GetOutboundCallabletimeset (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = GetOutboundCallabletimesetWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > GetOutboundCallabletimesetWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetOutboundCallabletimeset");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimeset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> GetOutboundCallabletimesetAsync (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await GetOutboundCallabletimesetAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetOutboundCallabletimesetAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetOutboundCallabletimeset");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimeset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CallableTimeSetEntityListing</returns>
        public CallableTimeSetEntityListing GetOutboundCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> localVarResponse = GetOutboundCallabletimesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CallableTimeSetEntityListing</returns>
        public ApiResponse< CallableTimeSetEntityListing > GetOutboundCallabletimesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSetEntityListing)));
            
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CallableTimeSetEntityListing</returns>
        public async System.Threading.Tasks.Task<CallableTimeSetEntityListing> GetOutboundCallabletimesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> localVarResponse = await GetOutboundCallabletimesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CallableTimeSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> GetOutboundCallabletimesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSetEntityListing)));
            
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet GetOutboundCallanalysisresponseset (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = GetOutboundCallanalysisresponsesetWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > GetOutboundCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetOutboundCallanalysisresponseset");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarHeaders,
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> GetOutboundCallanalysisresponsesetAsync (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = await GetOutboundCallanalysisresponsesetAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetOutboundCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetOutboundCallanalysisresponseset");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarHeaders,
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ResponseSetEntityListing</returns>
        public ResponseSetEntityListing GetOutboundCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> localVarResponse = GetOutboundCallanalysisresponsesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ResponseSetEntityListing</returns>
        public ApiResponse< ResponseSetEntityListing > GetOutboundCallanalysisresponsesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSetEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ResponseSetEntityListing</returns>
        public async System.Threading.Tasks.Task<ResponseSetEntityListing> GetOutboundCallanalysisresponsesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> localVarResponse = await GetOutboundCallanalysisresponsesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ResponseSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> GetOutboundCallanalysisresponsesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSetEntityListing)));
            
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        public Campaign GetOutboundCampaign (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = GetOutboundCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > GetOutboundCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaign");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> GetOutboundCampaignAsync (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = await GetOutboundCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> GetOutboundCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaign");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        public CampaignDiagnostics GetOutboundCampaignDiagnostics (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = GetOutboundCampaignDiagnosticsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        public ApiResponse< CampaignDiagnostics > GetOutboundCampaignDiagnosticsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignDiagnostics");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/diagnostics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignDiagnostics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignDiagnostics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(localVarStatusCode,
                localVarHeaders,
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignDiagnostics)));
            
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        public async System.Threading.Tasks.Task<CampaignDiagnostics> GetOutboundCampaignDiagnosticsAsync (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = await GetOutboundCampaignDiagnosticsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetOutboundCampaignDiagnosticsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignDiagnostics");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/diagnostics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignDiagnostics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignDiagnostics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(localVarStatusCode,
                localVarHeaders,
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignDiagnostics)));
            
        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignInteractions</returns>
        public CampaignInteractions GetOutboundCampaignInteractions (string campaignId)
        {
             ApiResponse<CampaignInteractions> localVarResponse = GetOutboundCampaignInteractionsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignInteractions</returns>
        public ApiResponse< CampaignInteractions > GetOutboundCampaignInteractionsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignInteractions");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/interactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignInteractions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignInteractions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignInteractions>(localVarStatusCode,
                localVarHeaders,
                (CampaignInteractions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignInteractions)));
            
        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignInteractions</returns>
        public async System.Threading.Tasks.Task<CampaignInteractions> GetOutboundCampaignInteractionsAsync (string campaignId)
        {
             ApiResponse<CampaignInteractions> localVarResponse = await GetOutboundCampaignInteractionsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignInteractions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignInteractions>> GetOutboundCampaignInteractionsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignInteractions");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/interactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignInteractions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignInteractions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignInteractions>(localVarStatusCode,
                localVarHeaders,
                (CampaignInteractions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignInteractions)));
            
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignProgress</returns>
        public CampaignProgress GetOutboundCampaignProgress (string campaignId)
        {
             ApiResponse<CampaignProgress> localVarResponse = GetOutboundCampaignProgressWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignProgress</returns>
        public ApiResponse< CampaignProgress > GetOutboundCampaignProgressWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignProgress: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignProgress>(localVarStatusCode,
                localVarHeaders,
                (CampaignProgress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignProgress)));
            
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignProgress</returns>
        public async System.Threading.Tasks.Task<CampaignProgress> GetOutboundCampaignProgressAsync (string campaignId)
        {
             ApiResponse<CampaignProgress> localVarResponse = await GetOutboundCampaignProgressAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignProgress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignProgress>> GetOutboundCampaignProgressAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignProgress: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignProgress>(localVarStatusCode,
                localVarHeaders,
                (CampaignProgress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignProgress)));
            
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        public CampaignStats GetOutboundCampaignStats (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = GetOutboundCampaignStatsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        public ApiResponse< CampaignStats > GetOutboundCampaignStatsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignStats");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignStats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignStats>(localVarStatusCode,
                localVarHeaders,
                (CampaignStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignStats)));
            
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        public async System.Threading.Tasks.Task<CampaignStats> GetOutboundCampaignStatsAsync (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = await GetOutboundCampaignStatsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetOutboundCampaignStatsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundCampaignStats");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignStats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignStats>(localVarStatusCode,
                localVarHeaders,
                (CampaignStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignStats)));
            
        }

        /// <summary>
        /// Get Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>CampaignRule</returns>
        public CampaignRule GetOutboundCampaignrule (string campaignRuleId)
        {
             ApiResponse<CampaignRule> localVarResponse = GetOutboundCampaignruleWithHttpInfo(campaignRuleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>ApiResponse of CampaignRule</returns>
        public ApiResponse< CampaignRule > GetOutboundCampaignruleWithHttpInfo (string campaignRuleId)
        {
            // verify the required parameter 'campaignRuleId' is set
            if (campaignRuleId == null)
                throw new ApiException(400, "Missing required parameter 'campaignRuleId' when calling OutboundApi->GetOutboundCampaignrule");

            var localVarPath = "/api/v2/outbound/campaignrules/{campaignRuleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignRuleId != null) localVarPathParams.Add("campaignRuleId", Configuration.ApiClient.ParameterToString(campaignRuleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRule>(localVarStatusCode,
                localVarHeaders,
                (CampaignRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRule)));
            
        }

        /// <summary>
        /// Get Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of CampaignRule</returns>
        public async System.Threading.Tasks.Task<CampaignRule> GetOutboundCampaignruleAsync (string campaignRuleId)
        {
             ApiResponse<CampaignRule> localVarResponse = await GetOutboundCampaignruleAsyncWithHttpInfo(campaignRuleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <returns>Task of ApiResponse (CampaignRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignRule>> GetOutboundCampaignruleAsyncWithHttpInfo (string campaignRuleId)
        {
            // verify the required parameter 'campaignRuleId' is set
            if (campaignRuleId == null)
                throw new ApiException(400, "Missing required parameter 'campaignRuleId' when calling OutboundApi->GetOutboundCampaignrule");

            var localVarPath = "/api/v2/outbound/campaignrules/{campaignRuleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignRuleId != null) localVarPathParams.Add("campaignRuleId", Configuration.ApiClient.ParameterToString(campaignRuleId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRule>(localVarStatusCode,
                localVarHeaders,
                (CampaignRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRule)));
            
        }

        /// <summary>
        /// Query Campaign Rule list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignRuleEntityListing</returns>
        public CampaignRuleEntityListing GetOutboundCampaignrules (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignRuleEntityListing> localVarResponse = GetOutboundCampaignrulesWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query Campaign Rule list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignRuleEntityListing</returns>
        public ApiResponse< CampaignRuleEntityListing > GetOutboundCampaignrulesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/campaignrules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRuleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CampaignRuleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRuleEntityListing)));
            
        }

        /// <summary>
        /// Query Campaign Rule list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignRuleEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignRuleEntityListing> GetOutboundCampaignrulesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignRuleEntityListing> localVarResponse = await GetOutboundCampaignrulesAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query Campaign Rule list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignRuleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignRuleEntityListing>> GetOutboundCampaignrulesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/campaignrules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaignrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRuleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CampaignRuleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRuleEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignEntityListing</returns>
        public CampaignEntityListing GetOutboundCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> localVarResponse = GetOutboundCampaignsWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignEntityListing</returns>
        public ApiResponse< CampaignEntityListing > GetOutboundCampaignsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (contactListId != null) localVarQueryParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // query parameter
            if (dncListId != null) localVarQueryParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // query parameter
            if (distributionQueueId != null) localVarQueryParams.Add("distributionQueueId", Configuration.ApiClient.ParameterToString(distributionQueueId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (callAnalysisResponseSetId != null) localVarQueryParams.Add("callAnalysisResponseSetId", Configuration.ApiClient.ParameterToString(callAnalysisResponseSetId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaigns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignEntityListing> GetOutboundCampaignsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> localVarResponse = await GetOutboundCampaignsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> GetOutboundCampaignsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (contactListId != null) localVarQueryParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // query parameter
            if (dncListId != null) localVarQueryParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // query parameter
            if (distributionQueueId != null) localVarQueryParams.Add("distributionQueueId", Configuration.ApiClient.ParameterToString(distributionQueueId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (callAnalysisResponseSetId != null) localVarQueryParams.Add("callAnalysisResponseSetId", Configuration.ApiClient.ParameterToString(callAnalysisResponseSetId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaigns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignEntityListing)));
            
        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        public ContactList GetOutboundContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = GetOutboundContactlistWithHttpInfo(contactListId, includeImportStatus, includeSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > GetOutboundContactlistWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlist");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarHeaders,
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> GetOutboundContactlistAsync (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = await GetOutboundContactlistAsyncWithHttpInfo(contactListId, includeImportStatus, includeSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> GetOutboundContactlistAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlist");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarHeaders,
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>DialerContact</returns>
        public DialerContact GetOutboundContactlistContact (string contactListId, string contactId)
        {
             ApiResponse<DialerContact> localVarResponse = GetOutboundContactlistContactWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of DialerContact</returns>
        public ApiResponse< DialerContact > GetOutboundContactlistContactWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetOutboundContactlistContact");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarHeaders,
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of DialerContact</returns>
        public async System.Threading.Tasks.Task<DialerContact> GetOutboundContactlistContactAsync (string contactListId, string contactId)
        {
             ApiResponse<DialerContact> localVarResponse = await GetOutboundContactlistContactAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerContact>> GetOutboundContactlistContactAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetOutboundContactlistContact");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarHeaders,
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        public ExportUri GetOutboundContactlistExport (string contactListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = GetOutboundContactlistExportWithHttpInfo(contactListId, download);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        public ApiResponse< ExportUri > GetOutboundContactlistExportWithHttpInfo (string contactListId, string download = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlistExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarHeaders,
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        public async System.Threading.Tasks.Task<ExportUri> GetOutboundContactlistExportAsync (string contactListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = await GetOutboundContactlistExportAsyncWithHttpInfo(contactListId, download);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetOutboundContactlistExportAsyncWithHttpInfo (string contactListId, string download = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlistExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarHeaders,
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        public ImportStatus GetOutboundContactlistImportstatus (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = GetOutboundContactlistImportstatusWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetOutboundContactlistImportstatusWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlistImportstatus");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistImportstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarHeaders,
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> GetOutboundContactlistImportstatusAsync (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await GetOutboundContactlistImportstatusAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetOutboundContactlistImportstatusAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetOutboundContactlistImportstatus");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistImportstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarHeaders,
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ContactListEntityListing</returns>
        public ContactListEntityListing GetOutboundContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> localVarResponse = GetOutboundContactlistsWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        public ApiResponse< ContactListEntityListing > GetOutboundContactlistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListEntityListing)));
            
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ContactListEntityListing</returns>
        public async System.Threading.Tasks.Task<ContactListEntityListing> GetOutboundContactlistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> localVarResponse = await GetOutboundContactlistsAsyncWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> GetOutboundContactlistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListEntityListing)));
            
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        public DncList GetOutboundDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = GetOutboundDnclistWithHttpInfo(dncListId, includeImportStatus, includeSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > GetOutboundDnclistWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetOutboundDnclist");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarHeaders,
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> GetOutboundDnclistAsync (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = await GetOutboundDnclistAsyncWithHttpInfo(dncListId, includeImportStatus, includeSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> GetOutboundDnclistAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetOutboundDnclist");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarHeaders,
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        public ExportUri GetOutboundDnclistExport (string dncListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = GetOutboundDnclistExportWithHttpInfo(dncListId, download);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        public ApiResponse< ExportUri > GetOutboundDnclistExportWithHttpInfo (string dncListId, string download = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetOutboundDnclistExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarHeaders,
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        public async System.Threading.Tasks.Task<ExportUri> GetOutboundDnclistExportAsync (string dncListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = await GetOutboundDnclistExportAsyncWithHttpInfo(dncListId, download);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetOutboundDnclistExportAsyncWithHttpInfo (string dncListId, string download = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetOutboundDnclistExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarHeaders,
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        public ImportStatus GetOutboundDnclistImportstatus (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = GetOutboundDnclistImportstatusWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetOutboundDnclistImportstatusWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetOutboundDnclistImportstatus");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistImportstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarHeaders,
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> GetOutboundDnclistImportstatusAsync (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await GetOutboundDnclistImportstatusAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetOutboundDnclistImportstatusAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetOutboundDnclistImportstatus");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistImportstatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarHeaders,
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>DncListEntityListing</returns>
        public DncListEntityListing GetOutboundDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> localVarResponse = GetOutboundDnclistsWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        public ApiResponse< DncListEntityListing > GetOutboundDnclistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DncListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncListEntityListing)));
            
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of DncListEntityListing</returns>
        public async System.Threading.Tasks.Task<DncListEntityListing> GetOutboundDnclistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> localVarResponse = await GetOutboundDnclistsAsyncWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> GetOutboundDnclistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DncListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncListEntityListing)));
            
        }

        /// <summary>
        /// Get Dialer Event 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>EventLog</returns>
        public EventLog GetOutboundEvent (string eventId)
        {
             ApiResponse<EventLog> localVarResponse = GetOutboundEventWithHttpInfo(eventId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dialer Event 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>ApiResponse of EventLog</returns>
        public ApiResponse< EventLog > GetOutboundEventWithHttpInfo (string eventId)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null)
                throw new ApiException(400, "Missing required parameter 'eventId' when calling OutboundApi->GetOutboundEvent");

            var localVarPath = "/api/v2/outbound/events/{eventId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (eventId != null) localVarPathParams.Add("eventId", Configuration.ApiClient.ParameterToString(eventId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EventLog>(localVarStatusCode,
                localVarHeaders,
                (EventLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventLog)));
            
        }

        /// <summary>
        /// Get Dialer Event 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>Task of EventLog</returns>
        public async System.Threading.Tasks.Task<EventLog> GetOutboundEventAsync (string eventId)
        {
             ApiResponse<EventLog> localVarResponse = await GetOutboundEventAsyncWithHttpInfo(eventId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dialer Event 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventId">Event Log ID</param>
        /// <returns>Task of ApiResponse (EventLog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EventLog>> GetOutboundEventAsyncWithHttpInfo (string eventId)
        {
            // verify the required parameter 'eventId' is set
            if (eventId == null)
                throw new ApiException(400, "Missing required parameter 'eventId' when calling OutboundApi->GetOutboundEvent");

            var localVarPath = "/api/v2/outbound/events/{eventId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (eventId != null) localVarPathParams.Add("eventId", Configuration.ApiClient.ParameterToString(eventId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EventLog>(localVarStatusCode,
                localVarHeaders,
                (EventLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EventLog)));
            
        }

        /// <summary>
        /// Query Event Logs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>DialerEventEntityListing</returns>
        public DialerEventEntityListing GetOutboundEvents (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DialerEventEntityListing> localVarResponse = GetOutboundEventsWithHttpInfo(pageSize, pageNumber, filterType, category, level, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query Event Logs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of DialerEventEntityListing</returns>
        public ApiResponse< DialerEventEntityListing > GetOutboundEventsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/events";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (category != null) localVarQueryParams.Add("category", Configuration.ApiClient.ParameterToString(category)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerEventEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DialerEventEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerEventEntityListing)));
            
        }

        /// <summary>
        /// Query Event Logs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of DialerEventEntityListing</returns>
        public async System.Threading.Tasks.Task<DialerEventEntityListing> GetOutboundEventsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DialerEventEntityListing> localVarResponse = await GetOutboundEventsAsyncWithHttpInfo(pageSize, pageNumber, filterType, category, level, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query Event Logs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="category">Category (optional)</param>
        /// <param name="level">Level (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (DialerEventEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerEventEntityListing>> GetOutboundEventsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/events";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (category != null) localVarQueryParams.Add("category", Configuration.ApiClient.ParameterToString(category)); // query parameter
            if (level != null) localVarQueryParams.Add("level", Configuration.ApiClient.ParameterToString(level)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvents: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundEvents: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerEventEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DialerEventEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerEventEntityListing)));
            
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        public RuleSet GetOutboundRuleset (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = GetOutboundRulesetWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > GetOutboundRulesetWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetOutboundRuleset");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRuleset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarHeaders,
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> GetOutboundRulesetAsync (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = await GetOutboundRulesetAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetOutboundRulesetAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetOutboundRuleset");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRuleset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarHeaders,
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>RuleSetEntityListing</returns>
        public RuleSetEntityListing GetOutboundRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> localVarResponse = GetOutboundRulesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of RuleSetEntityListing</returns>
        public ApiResponse< RuleSetEntityListing > GetOutboundRulesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRulesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSetEntityListing)));
            
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of RuleSetEntityListing</returns>
        public async System.Threading.Tasks.Task<RuleSetEntityListing> GetOutboundRulesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> localVarResponse = await GetOutboundRulesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (RuleSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> GetOutboundRulesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRulesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSetEntityListing)));
            
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule GetOutboundSchedulesCampaign (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = GetOutboundSchedulesCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > GetOutboundSchedulesCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundSchedulesCampaign");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarHeaders,
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> GetOutboundSchedulesCampaignAsync (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await GetOutboundSchedulesCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetOutboundSchedulesCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetOutboundSchedulesCampaign");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarHeaders,
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        public List<CampaignSchedule> GetOutboundSchedulesCampaigns ()
        {
             ApiResponse<List<CampaignSchedule>> localVarResponse = GetOutboundSchedulesCampaignsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        public ApiResponse< List<CampaignSchedule> > GetOutboundSchedulesCampaignsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaigns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(localVarStatusCode,
                localVarHeaders,
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignSchedule>> GetOutboundSchedulesCampaignsAsync ()
        {
             ApiResponse<List<CampaignSchedule>> localVarResponse = await GetOutboundSchedulesCampaignsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> GetOutboundSchedulesCampaignsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaigns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(localVarStatusCode,
                localVarHeaders,
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignSchedule>)));
            
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule GetOutboundSchedulesSequence (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = GetOutboundSchedulesSequenceWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > GetOutboundSchedulesSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetOutboundSchedulesSequence");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarHeaders,
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> GetOutboundSchedulesSequenceAsync (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await GetOutboundSchedulesSequenceAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetOutboundSchedulesSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetOutboundSchedulesSequence");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarHeaders,
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        public List<SequenceSchedule> GetOutboundSchedulesSequences ()
        {
             ApiResponse<List<SequenceSchedule>> localVarResponse = GetOutboundSchedulesSequencesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        public ApiResponse< List<SequenceSchedule> > GetOutboundSchedulesSequencesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(localVarStatusCode,
                localVarHeaders,
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SequenceSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<SequenceSchedule>> GetOutboundSchedulesSequencesAsync ()
        {
             ApiResponse<List<SequenceSchedule>> localVarResponse = await GetOutboundSchedulesSequencesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> GetOutboundSchedulesSequencesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSchedulesSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(localVarStatusCode,
                localVarHeaders,
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SequenceSchedule>)));
            
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence GetOutboundSequence (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = GetOutboundSequenceWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > GetOutboundSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetOutboundSequence");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> GetOutboundSequenceAsync (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = await GetOutboundSequenceAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetOutboundSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetOutboundSequence");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignSequenceEntityListing</returns>
        public CampaignSequenceEntityListing GetOutboundSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> localVarResponse = GetOutboundSequencesWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignSequenceEntityListing</returns>
        public ApiResponse< CampaignSequenceEntityListing > GetOutboundSequencesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequenceEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignSequenceEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignSequenceEntityListing> GetOutboundSequencesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> localVarResponse = await GetOutboundSequencesAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to Prefix)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignSequenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> GetOutboundSequencesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequenceEntityListing)));
            
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping GetOutboundWrapupcodemappings ()
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = GetOutboundWrapupcodemappingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > GetOutboundWrapupcodemappingsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarHeaders,
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> GetOutboundWrapupcodemappingsAsync ()
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = await GetOutboundWrapupcodemappingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> GetOutboundWrapupcodemappingsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOutboundWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarHeaders,
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        public AttemptLimits PostOutboundAttemptlimits (AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = PostOutboundAttemptlimitsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        public ApiResponse< AttemptLimits > PostOutboundAttemptlimitsWithHttpInfo (AttemptLimits body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundAttemptlimits");

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAttemptlimits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        public async System.Threading.Tasks.Task<AttemptLimits> PostOutboundAttemptlimitsAsync (AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = await PostOutboundAttemptlimitsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PostOutboundAttemptlimitsAsyncWithHttpInfo (AttemptLimits body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundAttemptlimits");

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAttemptlimits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>AuditSearchResult</returns>
        public AuditSearchResult PostOutboundAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = PostOutboundAuditsWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        public ApiResponse< AuditSearchResult > PostOutboundAuditsWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundAudits");

            var localVarPath = "/api/v2/outbound/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (facetsOnly != null) localVarQueryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarHeaders,
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of AuditSearchResult</returns>
        public async System.Threading.Tasks.Task<AuditSearchResult> PostOutboundAuditsAsync (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = await PostOutboundAuditsAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostOutboundAuditsAsyncWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundAudits");

            var localVarPath = "/api/v2/outbound/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (facetsOnly != null) localVarQueryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAudits: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarHeaders,
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PostOutboundCallabletimesets (CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PostOutboundCallabletimesetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PostOutboundCallabletimesetsWithHttpInfo (CallableTimeSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCallabletimesets");

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallabletimesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PostOutboundCallabletimesetsAsync (CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PostOutboundCallabletimesetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostOutboundCallabletimesetsAsyncWithHttpInfo (CallableTimeSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCallabletimesets");

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallabletimesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet PostOutboundCallanalysisresponsesets (ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = PostOutboundCallanalysisresponsesetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PostOutboundCallanalysisresponsesetsWithHttpInfo (ResponseSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCallanalysisresponsesets");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarHeaders,
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> PostOutboundCallanalysisresponsesetsAsync (ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = await PostOutboundCallanalysisresponsesetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PostOutboundCallanalysisresponsesetsAsyncWithHttpInfo (ResponseSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCallanalysisresponsesets");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarHeaders,
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated) This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        public ContactCallbackRequest PostOutboundCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = PostOutboundCampaignCallbackScheduleWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated) This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        public ApiResponse< ContactCallbackRequest > PostOutboundCampaignCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostOutboundCampaignCallbackSchedule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaignCallbackSchedule");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/callback/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignCallbackSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignCallbackSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarHeaders,
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated) This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        public async System.Threading.Tasks.Task<ContactCallbackRequest> PostOutboundCampaignCallbackScheduleAsync (string campaignId, ContactCallbackRequest body)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = await PostOutboundCampaignCallbackScheduleAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign (Deprecated) This endpoint is deprecated and may have unexpected results. Please use \&quot;/conversations/{conversationId}/participants/{participantId}/callbacks instead.\&quot;
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostOutboundCampaignCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostOutboundCampaignCallbackSchedule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaignCallbackSchedule");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/callback/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignCallbackSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignCallbackSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarHeaders,
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
        }

        /// <summary>
        /// Create Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>CampaignRule</returns>
        public CampaignRule PostOutboundCampaignrules (CampaignRule body)
        {
             ApiResponse<CampaignRule> localVarResponse = PostOutboundCampaignrulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>ApiResponse of CampaignRule</returns>
        public ApiResponse< CampaignRule > PostOutboundCampaignrulesWithHttpInfo (CampaignRule body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaignrules");

            var localVarPath = "/api/v2/outbound/campaignrules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRule>(localVarStatusCode,
                localVarHeaders,
                (CampaignRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRule)));
            
        }

        /// <summary>
        /// Create Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of CampaignRule</returns>
        public async System.Threading.Tasks.Task<CampaignRule> PostOutboundCampaignrulesAsync (CampaignRule body)
        {
             ApiResponse<CampaignRule> localVarResponse = await PostOutboundCampaignrulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of ApiResponse (CampaignRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignRule>> PostOutboundCampaignrulesAsyncWithHttpInfo (CampaignRule body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaignrules");

            var localVarPath = "/api/v2/outbound/campaignrules";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignrules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignrules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRule>(localVarStatusCode,
                localVarHeaders,
                (CampaignRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRule)));
            
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        public Campaign PostOutboundCampaigns (Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = PostOutboundCampaignsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PostOutboundCampaignsWithHttpInfo (Campaign body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaigns");

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaigns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> PostOutboundCampaignsAsync (Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = await PostOutboundCampaignsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PostOutboundCampaignsAsyncWithHttpInfo (Campaign body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaigns");

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaigns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>List&lt;CampaignProgress&gt;</returns>
        public List<CampaignProgress> PostOutboundCampaignsProgress (List<string> body)
        {
             ApiResponse<List<CampaignProgress>> localVarResponse = PostOutboundCampaignsProgressWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>ApiResponse of List&lt;CampaignProgress&gt;</returns>
        public ApiResponse< List<CampaignProgress> > PostOutboundCampaignsProgressWithHttpInfo (List<string> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaignsProgress");

            var localVarPath = "/api/v2/outbound/campaigns/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignsProgress: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignsProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignProgress>>(localVarStatusCode,
                localVarHeaders,
                (List<CampaignProgress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignProgress>)));
            
        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of List&lt;CampaignProgress&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignProgress>> PostOutboundCampaignsProgressAsync (List<string> body)
        {
             ApiResponse<List<CampaignProgress>> localVarResponse = await PostOutboundCampaignsProgressAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of ApiResponse (List&lt;CampaignProgress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignProgress>>> PostOutboundCampaignsProgressAsyncWithHttpInfo (List<string> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundCampaignsProgress");

            var localVarPath = "/api/v2/outbound/campaigns/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignsProgress: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundCampaignsProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignProgress>>(localVarStatusCode,
                localVarHeaders,
                (List<CampaignProgress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignProgress>)));
            
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>List&lt;DialerContact&gt;</returns>
        public List<DialerContact> PostOutboundContactlistContacts (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null)
        {
             ApiResponse<List<DialerContact>> localVarResponse = PostOutboundContactlistContactsWithHttpInfo(contactListId, body, priority, clearSystemData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>ApiResponse of List&lt;DialerContact&gt;</returns>
        public ApiResponse< List<DialerContact> > PostOutboundContactlistContactsWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostOutboundContactlistContacts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundContactlistContacts");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (priority != null) localVarQueryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            if (clearSystemData != null) localVarQueryParams.Add("clearSystemData", Configuration.ApiClient.ParameterToString(clearSystemData)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DialerContact>>(localVarStatusCode,
                localVarHeaders,
                (List<DialerContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DialerContact>)));
            
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>Task of List&lt;DialerContact&gt;</returns>
        public async System.Threading.Tasks.Task<List<DialerContact>> PostOutboundContactlistContactsAsync (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null)
        {
             ApiResponse<List<DialerContact>> localVarResponse = await PostOutboundContactlistContactsAsyncWithHttpInfo(contactListId, body, priority, clearSystemData);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <param name="clearSystemData">Clear system data.  True means the system data stored on the contact will be cleared if the contact already exists (attempts, callable status, etc), false means it won&#39;t. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DialerContact&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DialerContact>>> PostOutboundContactlistContactsAsyncWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null, bool? clearSystemData = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostOutboundContactlistContacts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundContactlistContacts");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (priority != null) localVarQueryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            if (clearSystemData != null) localVarQueryParams.Add("clearSystemData", Configuration.ApiClient.ParameterToString(clearSystemData)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistContacts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DialerContact>>(localVarStatusCode,
                localVarHeaders,
                (List<DialerContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DialerContact>)));
            
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>UriReference</returns>
        public UriReference PostOutboundContactlistExport (string contactListId)
        {
             ApiResponse<UriReference> localVarResponse = PostOutboundContactlistExportWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of UriReference</returns>
        public ApiResponse< UriReference > PostOutboundContactlistExportWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostOutboundContactlistExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UriReference>(localVarStatusCode,
                localVarHeaders,
                (UriReference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UriReference)));
            
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of UriReference</returns>
        public async System.Threading.Tasks.Task<UriReference> PostOutboundContactlistExportAsync (string contactListId)
        {
             ApiResponse<UriReference> localVarResponse = await PostOutboundContactlistExportAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (UriReference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UriReference>> PostOutboundContactlistExportAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostOutboundContactlistExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UriReference>(localVarStatusCode,
                localVarHeaders,
                (UriReference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UriReference)));
            
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        public ContactList PostOutboundContactlists (ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = PostOutboundContactlistsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PostOutboundContactlistsWithHttpInfo (ContactList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundContactlists");

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarHeaders,
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> PostOutboundContactlistsAsync (ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = await PostOutboundContactlistsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PostOutboundContactlistsAsyncWithHttpInfo (ContactList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundContactlists");

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarHeaders,
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        public void PostOutboundConversationDnc (string conversationId)
        {
             PostOutboundConversationDncWithHttpInfo(conversationId);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostOutboundConversationDncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostOutboundConversationDnc");

            var localVarPath = "/api/v2/outbound/conversations/{conversationId}/dnc";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundConversationDnc: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundConversationDnc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostOutboundConversationDncAsync (string conversationId)
        {
             await PostOutboundConversationDncAsyncWithHttpInfo(conversationId);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostOutboundConversationDncAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostOutboundConversationDnc");

            var localVarPath = "/api/v2/outbound/conversations/{conversationId}/dnc";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundConversationDnc: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundConversationDnc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>UriReference</returns>
        public UriReference PostOutboundDnclistExport (string dncListId)
        {
             ApiResponse<UriReference> localVarResponse = PostOutboundDnclistExportWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of UriReference</returns>
        public ApiResponse< UriReference > PostOutboundDnclistExportWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostOutboundDnclistExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UriReference>(localVarStatusCode,
                localVarHeaders,
                (UriReference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UriReference)));
            
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of UriReference</returns>
        public async System.Threading.Tasks.Task<UriReference> PostOutboundDnclistExportAsync (string dncListId)
        {
             ApiResponse<UriReference> localVarResponse = await PostOutboundDnclistExportAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (UriReference)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UriReference>> PostOutboundDnclistExportAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostOutboundDnclistExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistExport: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UriReference>(localVarStatusCode,
                localVarHeaders,
                (UriReference) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UriReference)));
            
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns></returns>
        public void PostOutboundDnclistPhonenumbers (string dncListId, List<string> body)
        {
             PostOutboundDnclistPhonenumbersWithHttpInfo(dncListId, body);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostOutboundDnclistPhonenumbersWithHttpInfo (string dncListId, List<string> body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostOutboundDnclistPhonenumbers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundDnclistPhonenumbers");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/phonenumbers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistPhonenumbers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistPhonenumbers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostOutboundDnclistPhonenumbersAsync (string dncListId, List<string> body)
        {
             await PostOutboundDnclistPhonenumbersAsyncWithHttpInfo(dncListId, body);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostOutboundDnclistPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostOutboundDnclistPhonenumbers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundDnclistPhonenumbers");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/phonenumbers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistPhonenumbers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclistPhonenumbers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        public DncList PostOutboundDnclists (DncListCreate body)
        {
             ApiResponse<DncList> localVarResponse = PostOutboundDnclistsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PostOutboundDnclistsWithHttpInfo (DncListCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundDnclists");

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarHeaders,
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> PostOutboundDnclistsAsync (DncListCreate body)
        {
             ApiResponse<DncList> localVarResponse = await PostOutboundDnclistsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PostOutboundDnclistsAsyncWithHttpInfo (DncListCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundDnclists");

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclists: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarHeaders,
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        public RuleSet PostOutboundRulesets (RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = PostOutboundRulesetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PostOutboundRulesetsWithHttpInfo (RuleSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundRulesets");

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundRulesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarHeaders,
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> PostOutboundRulesetsAsync (RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = await PostOutboundRulesetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PostOutboundRulesetsAsyncWithHttpInfo (RuleSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundRulesets");

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundRulesets: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarHeaders,
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence PostOutboundSequences (CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = PostOutboundSequencesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PostOutboundSequencesWithHttpInfo (CampaignSequence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundSequences");

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundSequences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> PostOutboundSequencesAsync (CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = await PostOutboundSequencesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PostOutboundSequencesAsyncWithHttpInfo (CampaignSequence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostOutboundSequences");

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundSequences: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOutboundSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        public AttemptLimits PutOutboundAttemptlimit (string attemptLimitsId, AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = PutOutboundAttemptlimitWithHttpInfo(attemptLimitsId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        public ApiResponse< AttemptLimits > PutOutboundAttemptlimitWithHttpInfo (string attemptLimitsId, AttemptLimits body)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->PutOutboundAttemptlimit");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundAttemptlimit");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundAttemptlimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundAttemptlimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        public async System.Threading.Tasks.Task<AttemptLimits> PutOutboundAttemptlimitAsync (string attemptLimitsId, AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = await PutOutboundAttemptlimitAsyncWithHttpInfo(attemptLimitsId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PutOutboundAttemptlimitAsyncWithHttpInfo (string attemptLimitsId, AttemptLimits body)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->PutOutboundAttemptlimit");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundAttemptlimit");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundAttemptlimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundAttemptlimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarHeaders,
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PutOutboundCallabletimeset (string callableTimeSetId, CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PutOutboundCallabletimesetWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PutOutboundCallabletimesetWithHttpInfo (string callableTimeSetId, CallableTimeSet body)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutOutboundCallabletimeset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCallabletimeset");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallabletimeset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PutOutboundCallabletimesetAsync (string callableTimeSetId, CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PutOutboundCallabletimesetAsyncWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutOutboundCallabletimesetAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutOutboundCallabletimeset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCallabletimeset");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallabletimeset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarHeaders,
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet PutOutboundCallanalysisresponseset (string callAnalysisSetId, ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = PutOutboundCallanalysisresponsesetWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PutOutboundCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId, ResponseSet body)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutOutboundCallanalysisresponseset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCallanalysisresponseset");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarHeaders,
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> PutOutboundCallanalysisresponsesetAsync (string callAnalysisSetId, ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = await PutOutboundCallanalysisresponsesetAsyncWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutOutboundCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutOutboundCallanalysisresponseset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCallanalysisresponseset");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarHeaders,
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        public Campaign PutOutboundCampaign (string campaignId, Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = PutOutboundCampaignWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PutOutboundCampaignWithHttpInfo (string campaignId, Campaign body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutOutboundCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCampaign");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> PutOutboundCampaignAsync (string campaignId, Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = await PutOutboundCampaignAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PutOutboundCampaignAsyncWithHttpInfo (string campaignId, Campaign body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutOutboundCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCampaign");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarHeaders,
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>string</returns>
        public string PutOutboundCampaignAgent (string campaignId, string userId, Agent body)
        {
             ApiResponse<string> localVarResponse = PutOutboundCampaignAgentWithHttpInfo(campaignId, userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PutOutboundCampaignAgentWithHttpInfo (string campaignId, string userId, Agent body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutOutboundCampaignAgent");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutOutboundCampaignAgent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCampaignAgent");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/agents/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignAgent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PutOutboundCampaignAgentAsync (string campaignId, string userId, Agent body)
        {
             ApiResponse<string> localVarResponse = await PutOutboundCampaignAgentAsyncWithHttpInfo(campaignId, userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PutOutboundCampaignAgentAsyncWithHttpInfo (string campaignId, string userId, Agent body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutOutboundCampaignAgent");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutOutboundCampaignAgent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCampaignAgent");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/agents/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignAgent: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Update Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>CampaignRule</returns>
        public CampaignRule PutOutboundCampaignrule (string campaignRuleId, CampaignRule body)
        {
             ApiResponse<CampaignRule> localVarResponse = PutOutboundCampaignruleWithHttpInfo(campaignRuleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>ApiResponse of CampaignRule</returns>
        public ApiResponse< CampaignRule > PutOutboundCampaignruleWithHttpInfo (string campaignRuleId, CampaignRule body)
        {
            // verify the required parameter 'campaignRuleId' is set
            if (campaignRuleId == null)
                throw new ApiException(400, "Missing required parameter 'campaignRuleId' when calling OutboundApi->PutOutboundCampaignrule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCampaignrule");

            var localVarPath = "/api/v2/outbound/campaignrules/{campaignRuleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignRuleId != null) localVarPathParams.Add("campaignRuleId", Configuration.ApiClient.ParameterToString(campaignRuleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRule>(localVarStatusCode,
                localVarHeaders,
                (CampaignRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRule)));
            
        }

        /// <summary>
        /// Update Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of CampaignRule</returns>
        public async System.Threading.Tasks.Task<CampaignRule> PutOutboundCampaignruleAsync (string campaignRuleId, CampaignRule body)
        {
             ApiResponse<CampaignRule> localVarResponse = await PutOutboundCampaignruleAsyncWithHttpInfo(campaignRuleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Campaign Rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignRuleId">Campaign Rule ID</param>
        /// <param name="body">CampaignRule</param>
        /// <returns>Task of ApiResponse (CampaignRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignRule>> PutOutboundCampaignruleAsyncWithHttpInfo (string campaignRuleId, CampaignRule body)
        {
            // verify the required parameter 'campaignRuleId' is set
            if (campaignRuleId == null)
                throw new ApiException(400, "Missing required parameter 'campaignRuleId' when calling OutboundApi->PutOutboundCampaignrule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundCampaignrule");

            var localVarPath = "/api/v2/outbound/campaignrules/{campaignRuleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignRuleId != null) localVarPathParams.Add("campaignRuleId", Configuration.ApiClient.ParameterToString(campaignRuleId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignrule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundCampaignrule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignRule>(localVarStatusCode,
                localVarHeaders,
                (CampaignRule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignRule)));
            
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        public ContactList PutOutboundContactlist (string contactListId, ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = PutOutboundContactlistWithHttpInfo(contactListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PutOutboundContactlistWithHttpInfo (string contactListId, ContactList body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutOutboundContactlist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundContactlist");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarHeaders,
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> PutOutboundContactlistAsync (string contactListId, ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = await PutOutboundContactlistAsyncWithHttpInfo(contactListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PutOutboundContactlistAsyncWithHttpInfo (string contactListId, ContactList body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutOutboundContactlist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundContactlist");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarHeaders,
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>DialerContact</returns>
        public DialerContact PutOutboundContactlistContact (string contactListId, string contactId, DialerContact body)
        {
             ApiResponse<DialerContact> localVarResponse = PutOutboundContactlistContactWithHttpInfo(contactListId, contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>ApiResponse of DialerContact</returns>
        public ApiResponse< DialerContact > PutOutboundContactlistContactWithHttpInfo (string contactListId, string contactId, DialerContact body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutOutboundContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutOutboundContactlistContact");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundContactlistContact");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlistContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarHeaders,
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of DialerContact</returns>
        public async System.Threading.Tasks.Task<DialerContact> PutOutboundContactlistContactAsync (string contactListId, string contactId, DialerContact body)
        {
             ApiResponse<DialerContact> localVarResponse = await PutOutboundContactlistContactAsyncWithHttpInfo(contactListId, contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerContact>> PutOutboundContactlistContactAsyncWithHttpInfo (string contactListId, string contactId, DialerContact body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutOutboundContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutOutboundContactlistContact");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundContactlistContact");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlistContact: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarHeaders,
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        public DncList PutOutboundDnclist (string dncListId, DncList body)
        {
             ApiResponse<DncList> localVarResponse = PutOutboundDnclistWithHttpInfo(dncListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PutOutboundDnclistWithHttpInfo (string dncListId, DncList body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutOutboundDnclist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundDnclist");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundDnclist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarHeaders,
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> PutOutboundDnclistAsync (string dncListId, DncList body)
        {
             ApiResponse<DncList> localVarResponse = await PutOutboundDnclistAsyncWithHttpInfo(dncListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PutOutboundDnclistAsyncWithHttpInfo (string dncListId, DncList body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutOutboundDnclist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundDnclist");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundDnclist: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarHeaders,
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        public RuleSet PutOutboundRuleset (string ruleSetId, RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = PutOutboundRulesetWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PutOutboundRulesetWithHttpInfo (string ruleSetId, RuleSet body)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutOutboundRuleset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundRuleset");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundRuleset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarHeaders,
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> PutOutboundRulesetAsync (string ruleSetId, RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = await PutOutboundRulesetAsyncWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutOutboundRulesetAsyncWithHttpInfo (string ruleSetId, RuleSet body)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutOutboundRuleset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundRuleset");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundRuleset: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarHeaders,
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule PutOutboundSchedulesCampaign (string campaignId, CampaignSchedule body)
        {
             ApiResponse<CampaignSchedule> localVarResponse = PutOutboundSchedulesCampaignWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > PutOutboundSchedulesCampaignWithHttpInfo (string campaignId, CampaignSchedule body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutOutboundSchedulesCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundSchedulesCampaign");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarHeaders,
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> PutOutboundSchedulesCampaignAsync (string campaignId, CampaignSchedule body)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await PutOutboundSchedulesCampaignAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutOutboundSchedulesCampaignAsyncWithHttpInfo (string campaignId, CampaignSchedule body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutOutboundSchedulesCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundSchedulesCampaign");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarHeaders,
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule PutOutboundSchedulesSequence (string sequenceId, SequenceSchedule body)
        {
             ApiResponse<SequenceSchedule> localVarResponse = PutOutboundSchedulesSequenceWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > PutOutboundSchedulesSequenceWithHttpInfo (string sequenceId, SequenceSchedule body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutOutboundSchedulesSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundSchedulesSequence");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarHeaders,
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> PutOutboundSchedulesSequenceAsync (string sequenceId, SequenceSchedule body)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await PutOutboundSchedulesSequenceAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutOutboundSchedulesSequenceAsyncWithHttpInfo (string sequenceId, SequenceSchedule body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutOutboundSchedulesSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundSchedulesSequence");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarHeaders,
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence PutOutboundSequence (string sequenceId, CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = PutOutboundSequenceWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PutOutboundSequenceWithHttpInfo (string sequenceId, CampaignSequence body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutOutboundSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundSequence");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> PutOutboundSequenceAsync (string sequenceId, CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = await PutOutboundSequenceAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutOutboundSequenceAsyncWithHttpInfo (string sequenceId, CampaignSequence body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutOutboundSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundSequence");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSequence: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarHeaders,
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping PutOutboundWrapupcodemappings (WrapUpCodeMapping body)
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = PutOutboundWrapupcodemappingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > PutOutboundWrapupcodemappingsWithHttpInfo (WrapUpCodeMapping body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundWrapupcodemappings");

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarHeaders,
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> PutOutboundWrapupcodemappingsAsync (WrapUpCodeMapping body)
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = await PutOutboundWrapupcodemappingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> PutOutboundWrapupcodemappingsAsyncWithHttpInfo (WrapUpCodeMapping body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutOutboundWrapupcodemappings");

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOutboundWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarHeaders,
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

    }
}
