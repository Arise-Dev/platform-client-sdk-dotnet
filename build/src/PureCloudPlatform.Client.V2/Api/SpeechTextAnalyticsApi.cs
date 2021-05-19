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
    public interface ISpeechTextAnalyticsApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns></returns>
        void DeleteSpeechandtextanalyticsProgram (string programId, bool? forceDelete = null);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSpeechandtextanalyticsProgramWithHttpInfo (string programId, bool? forceDelete = null);
        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns></returns>
        void DeleteSpeechandtextanalyticsTopic (string topicId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSpeechandtextanalyticsTopicWithHttpInfo (string topicId);
        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ConversationMetrics</returns>
        ConversationMetrics GetSpeechandtextanalyticsConversation (string conversationId);

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ApiResponse of ConversationMetrics</returns>
        ApiResponse<ConversationMetrics> GetSpeechandtextanalyticsConversationWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>TranscriptUrl</returns>
        TranscriptUrl GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId);

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>ApiResponse of TranscriptUrl</returns>
        ApiResponse<TranscriptUrl> GetSpeechandtextanalyticsConversationCommunicationTranscripturlWithHttpInfo (string conversationId, string communicationId);
        
        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> GetSpeechandtextanalyticsDialects ();

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> GetSpeechandtextanalyticsDialectsWithHttpInfo ();
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Program</returns>
        Program GetSpeechandtextanalyticsProgram (string programId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of Program</returns>
        ApiResponse<Program> GetSpeechandtextanalyticsProgramWithHttpInfo (string programId);
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ProgramsEntityListing</returns>
        ProgramsEntityListing GetSpeechandtextanalyticsPrograms (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of ProgramsEntityListing</returns>
        ApiResponse<ProgramsEntityListing> GetSpeechandtextanalyticsProgramsWithHttpInfo (string nextPage = null, int? pageSize = null);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>GeneralProgramJob</returns>
        GeneralProgramJob GetSpeechandtextanalyticsProgramsGeneralJob (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        ApiResponse<GeneralProgramJob> GetSpeechandtextanalyticsProgramsGeneralJobWithHttpInfo (string jobId);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ProgramJob</returns>
        ProgramJob GetSpeechandtextanalyticsProgramsPublishjob (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        ApiResponse<ProgramJob> GetSpeechandtextanalyticsProgramsPublishjobWithHttpInfo (string jobId);
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>UnpublishedProgramsEntityListing</returns>
        UnpublishedProgramsEntityListing GetSpeechandtextanalyticsProgramsUnpublished (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of UnpublishedProgramsEntityListing</returns>
        ApiResponse<UnpublishedProgramsEntityListing> GetSpeechandtextanalyticsProgramsUnpublishedWithHttpInfo (string nextPage = null, int? pageSize = null);
        
        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        SpeechTextAnalyticsSettingsResponse GetSpeechandtextanalyticsSettings ();

        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        ApiResponse<SpeechTextAnalyticsSettingsResponse> GetSpeechandtextanalyticsSettingsWithHttpInfo ();
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Topic</returns>
        Topic GetSpeechandtextanalyticsTopic (string topicId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Topic</returns>
        ApiResponse<Topic> GetSpeechandtextanalyticsTopicWithHttpInfo (string topicId);
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>TopicsEntityListing</returns>
        TopicsEntityListing GetSpeechandtextanalyticsTopics (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of TopicsEntityListing</returns>
        ApiResponse<TopicsEntityListing> GetSpeechandtextanalyticsTopicsWithHttpInfo (string nextPage = null, int? pageSize = null);
        
        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>GeneralTopicsEntityListing</returns>
        GeneralTopicsEntityListing GetSpeechandtextanalyticsTopicsGeneral (string dialect = null);

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of GeneralTopicsEntityListing</returns>
        ApiResponse<GeneralTopicsEntityListing> GetSpeechandtextanalyticsTopicsGeneralWithHttpInfo (string dialect = null);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>TopicJob</returns>
        TopicJob GetSpeechandtextanalyticsTopicsPublishjob (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>ApiResponse of TopicJob</returns>
        ApiResponse<TopicJob> GetSpeechandtextanalyticsTopicsPublishjobWithHttpInfo (string jobId);
        
        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        SpeechTextAnalyticsSettingsResponse PatchSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        ApiResponse<SpeechTextAnalyticsSettingsResponse> PatchSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Program</returns>
        Program PostSpeechandtextanalyticsPrograms (ProgramRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>ApiResponse of Program</returns>
        ApiResponse<Program> PostSpeechandtextanalyticsProgramsWithHttpInfo (ProgramRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>GeneralProgramJob</returns>
        GeneralProgramJob PostSpeechandtextanalyticsProgramsGeneralJobs (GeneralProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        ApiResponse<GeneralProgramJob> PostSpeechandtextanalyticsProgramsGeneralJobsWithHttpInfo (GeneralProgramJobRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ProgramJob</returns>
        ProgramJob PostSpeechandtextanalyticsProgramsPublishjobs (ProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        ApiResponse<ProgramJob> PostSpeechandtextanalyticsProgramsPublishjobsWithHttpInfo (ProgramJobRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Topic</returns>
        Topic PostSpeechandtextanalyticsTopics (TopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>ApiResponse of Topic</returns>
        ApiResponse<Topic> PostSpeechandtextanalyticsTopicsWithHttpInfo (TopicRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>TopicJob</returns>
        TopicJob PostSpeechandtextanalyticsTopicsPublishjobs (TopicJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>ApiResponse of TopicJob</returns>
        ApiResponse<TopicJob> PostSpeechandtextanalyticsTopicsPublishjobsWithHttpInfo (TopicJobRequest body);
        
        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>JsonSearchResponse</returns>
        JsonSearchResponse PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of JsonSearchResponse</returns>
        ApiResponse<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo (TranscriptSearchRequest body);
        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Program</returns>
        Program PutSpeechandtextanalyticsProgram (string programId, ProgramRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>ApiResponse of Program</returns>
        ApiResponse<Program> PutSpeechandtextanalyticsProgramWithHttpInfo (string programId, ProgramRequest body);
        
        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        SpeechTextAnalyticsSettingsResponse PutSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        ApiResponse<SpeechTextAnalyticsSettingsResponse> PutSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);
        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Topic</returns>
        Topic PutSpeechandtextanalyticsTopic (string topicId, TopicRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>ApiResponse of Topic</returns>
        ApiResponse<Topic> PutSpeechandtextanalyticsTopicWithHttpInfo (string topicId, TopicRequest body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsProgramAsync (string programId, bool? forceDelete = null);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, bool? forceDelete = null);
        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSpeechandtextanalyticsTopicAsync (string topicId);

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId);
        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ConversationMetrics</returns>
        System.Threading.Tasks.Task<ConversationMetrics> GetSpeechandtextanalyticsConversationAsync (string conversationId);

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ApiResponse (ConversationMetrics)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationMetrics>> GetSpeechandtextanalyticsConversationAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of TranscriptUrl</returns>
        System.Threading.Tasks.Task<TranscriptUrl> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsync (string conversationId, string communicationId);

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of ApiResponse (TranscriptUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<TranscriptUrl>> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsyncWithHttpInfo (string conversationId, string communicationId);
        
        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> GetSpeechandtextanalyticsDialectsAsync ();

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> GetSpeechandtextanalyticsDialectsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of Program</returns>
        System.Threading.Tasks.Task<Program> GetSpeechandtextanalyticsProgramAsync (string programId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        System.Threading.Tasks.Task<ApiResponse<Program>> GetSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId);
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ProgramsEntityListing</returns>
        System.Threading.Tasks.Task<ProgramsEntityListing> GetSpeechandtextanalyticsProgramsAsync (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (ProgramsEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProgramsEntityListing>> GetSpeechandtextanalyticsProgramsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of GeneralProgramJob</returns>
        System.Threading.Tasks.Task<GeneralProgramJob> GetSpeechandtextanalyticsProgramsGeneralJobAsync (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> GetSpeechandtextanalyticsProgramsGeneralJobAsyncWithHttpInfo (string jobId);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ProgramJob</returns>
        System.Threading.Tasks.Task<ProgramJob> GetSpeechandtextanalyticsProgramsPublishjobAsync (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProgramJob>> GetSpeechandtextanalyticsProgramsPublishjobAsyncWithHttpInfo (string jobId);
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of UnpublishedProgramsEntityListing</returns>
        System.Threading.Tasks.Task<UnpublishedProgramsEntityListing> GetSpeechandtextanalyticsProgramsUnpublishedAsync (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (UnpublishedProgramsEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnpublishedProgramsEntityListing>> GetSpeechandtextanalyticsProgramsUnpublishedAsyncWithHttpInfo (string nextPage = null, int? pageSize = null);
        
        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> GetSpeechandtextanalyticsSettingsAsync ();

        /// <summary>
        /// Get Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> GetSpeechandtextanalyticsSettingsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of Topic</returns>
        System.Threading.Tasks.Task<Topic> GetSpeechandtextanalyticsTopicAsync (string topicId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Topic>> GetSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId);
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of TopicsEntityListing</returns>
        System.Threading.Tasks.Task<TopicsEntityListing> GetSpeechandtextanalyticsTopicsAsync (string nextPage = null, int? pageSize = null);

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (TopicsEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicsEntityListing>> GetSpeechandtextanalyticsTopicsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null);
        
        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of GeneralTopicsEntityListing</returns>
        System.Threading.Tasks.Task<GeneralTopicsEntityListing> GetSpeechandtextanalyticsTopicsGeneralAsync (string dialect = null);

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (GeneralTopicsEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeneralTopicsEntityListing>> GetSpeechandtextanalyticsTopicsGeneralAsyncWithHttpInfo (string dialect = null);
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of TopicJob</returns>
        System.Threading.Tasks.Task<TopicJob> GetSpeechandtextanalyticsTopicsPublishjobAsync (string jobId);

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicJob>> GetSpeechandtextanalyticsTopicsPublishjobAsyncWithHttpInfo (string jobId);
        
        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PatchSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Patch Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PatchSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of Program</returns>
        System.Threading.Tasks.Task<Program> PostSpeechandtextanalyticsProgramsAsync (ProgramRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        System.Threading.Tasks.Task<ApiResponse<Program>> PostSpeechandtextanalyticsProgramsAsyncWithHttpInfo (ProgramRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of GeneralProgramJob</returns>
        System.Threading.Tasks.Task<GeneralProgramJob> PostSpeechandtextanalyticsProgramsGeneralJobsAsync (GeneralProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> PostSpeechandtextanalyticsProgramsGeneralJobsAsyncWithHttpInfo (GeneralProgramJobRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ProgramJob</returns>
        System.Threading.Tasks.Task<ProgramJob> PostSpeechandtextanalyticsProgramsPublishjobsAsync (ProgramJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProgramJob>> PostSpeechandtextanalyticsProgramsPublishjobsAsyncWithHttpInfo (ProgramJobRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of Topic</returns>
        System.Threading.Tasks.Task<Topic> PostSpeechandtextanalyticsTopicsAsync (TopicRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Topic>> PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo (TopicRequest body);
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of TopicJob</returns>
        System.Threading.Tasks.Task<TopicJob> PostSpeechandtextanalyticsTopicsPublishjobsAsync (TopicJobRequest body);

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicJob>> PostSpeechandtextanalyticsTopicsPublishjobsAsyncWithHttpInfo (TopicJobRequest body);
        
        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of JsonSearchResponse</returns>
        System.Threading.Tasks.Task<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchAsync (TranscriptSearchRequest body);

        /// <summary>
        /// Search resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (JsonSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonSearchResponse>> PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo (TranscriptSearchRequest body);
        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of Program</returns>
        System.Threading.Tasks.Task<Program> PutSpeechandtextanalyticsProgramAsync (string programId, ProgramRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        System.Threading.Tasks.Task<ApiResponse<Program>> PutSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, ProgramRequest body);
        
        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PutSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body);

        /// <summary>
        /// Update Speech And Text Analytics Settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PutSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body);
        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of Topic</returns>
        System.Threading.Tasks.Task<Topic> PutSpeechandtextanalyticsTopicAsync (string topicId, TopicRequest body);

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        System.Threading.Tasks.Task<ApiResponse<Topic>> PutSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId, TopicRequest body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SpeechTextAnalyticsApi : ISpeechTextAnalyticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTextAnalyticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SpeechTextAnalyticsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTextAnalyticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SpeechTextAnalyticsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
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
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
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
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns></returns>
        public void DeleteSpeechandtextanalyticsProgram (string programId, bool? forceDelete = null)
        {
             DeleteSpeechandtextanalyticsProgramWithHttpInfo(programId, forceDelete);
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSpeechandtextanalyticsProgramWithHttpInfo (string programId, bool? forceDelete = null)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params
            if (forceDelete != null) localVarQueryParams.Add(new Tuple<string, string>("forceDelete", this.Configuration.ApiClient.ParameterToString(forceDelete)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsProgramAsync (string programId, bool? forceDelete = null)
        {
             await DeleteSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId, forceDelete);

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="forceDelete">Indicates whether the program is forced to be deleted or not. Required when the program to delete is the default program. (optional, default to false)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, bool? forceDelete = null)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params
            if (forceDelete != null) localVarQueryParams.Add(new Tuple<string, string>("forceDelete", this.Configuration.ApiClient.ParameterToString(forceDelete)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns></returns>
        public void DeleteSpeechandtextanalyticsTopic (string topicId)
        {
             DeleteSpeechandtextanalyticsTopicWithHttpInfo(topicId);
        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSpeechandtextanalyticsTopicWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSpeechandtextanalyticsTopicAsync (string topicId)
        {
             await DeleteSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId);

        }

        /// <summary>
        /// Delete a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->DeleteSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ConversationMetrics</returns>
        public ConversationMetrics GetSpeechandtextanalyticsConversation (string conversationId)
        {
             ApiResponse<ConversationMetrics> localVarResponse = GetSpeechandtextanalyticsConversationWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>ApiResponse of ConversationMetrics</returns>
        public ApiResponse< ConversationMetrics > GetSpeechandtextanalyticsConversationWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversation");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationMetrics>(localVarStatusCode,
                localVarHeaders,
                (ConversationMetrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationMetrics)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ConversationMetrics</returns>
        public async System.Threading.Tasks.Task<ConversationMetrics> GetSpeechandtextanalyticsConversationAsync (string conversationId)
        {
             ApiResponse<ConversationMetrics> localVarResponse = await GetSpeechandtextanalyticsConversationAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Speech and Text Analytics for a specific conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation Id</param>
        /// <returns>Task of ApiResponse (ConversationMetrics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationMetrics>> GetSpeechandtextanalyticsConversationAsyncWithHttpInfo (string conversationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversation");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationMetrics>(localVarStatusCode,
                localVarHeaders,
                (ConversationMetrics) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationMetrics)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>TranscriptUrl</returns>
        public TranscriptUrl GetSpeechandtextanalyticsConversationCommunicationTranscripturl (string conversationId, string communicationId)
        {
             ApiResponse<TranscriptUrl> localVarResponse = GetSpeechandtextanalyticsConversationCommunicationTranscripturlWithHttpInfo(conversationId, communicationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>ApiResponse of TranscriptUrl</returns>
        public ApiResponse< TranscriptUrl > GetSpeechandtextanalyticsConversationCommunicationTranscripturlWithHttpInfo (string conversationId, string communicationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));
            if (communicationId != null) localVarPathParams.Add("communicationId", this.Configuration.ApiClient.ParameterToString(communicationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranscriptUrl>(localVarStatusCode,
                localVarHeaders,
                (TranscriptUrl) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranscriptUrl)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of TranscriptUrl</returns>
        public async System.Threading.Tasks.Task<TranscriptUrl> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsync (string conversationId, string communicationId)
        {
             ApiResponse<TranscriptUrl> localVarResponse = await GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsyncWithHttpInfo(conversationId, communicationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the pre-signed S3 URL for the transcript of a specific communication of a conversation 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="communicationId">Communication ID</param>
        /// <returns>Task of ApiResponse (TranscriptUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TranscriptUrl>> GetSpeechandtextanalyticsConversationCommunicationTranscripturlAsyncWithHttpInfo (string conversationId, string communicationId)
        { 
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");
            
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsConversationCommunicationTranscripturl");
            

            var localVarPath = "/api/v2/speechandtextanalytics/conversations/{conversationId}/communications/{communicationId}/transcripturl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (conversationId != null) localVarPathParams.Add("conversationId", this.Configuration.ApiClient.ParameterToString(conversationId));
            if (communicationId != null) localVarPathParams.Add("communicationId", this.Configuration.ApiClient.ParameterToString(communicationId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsConversationCommunicationTranscripturl: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TranscriptUrl>(localVarStatusCode,
                localVarHeaders,
                (TranscriptUrl) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TranscriptUrl)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> GetSpeechandtextanalyticsDialects ()
        {
             ApiResponse<List<Object>> localVarResponse = GetSpeechandtextanalyticsDialectsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > GetSpeechandtextanalyticsDialectsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/dialects";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarHeaders,
                (List<Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> GetSpeechandtextanalyticsDialectsAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await GetSpeechandtextanalyticsDialectsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of supported Speech &amp; Text Analytics dialects 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> GetSpeechandtextanalyticsDialectsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/dialects";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDialects: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsDialects: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarHeaders,
                (List<Object>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Program</returns>
        public Program GetSpeechandtextanalyticsProgram (string programId)
        {
             ApiResponse<Program> localVarResponse = GetSpeechandtextanalyticsProgramWithHttpInfo(programId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>ApiResponse of Program</returns>
        public ApiResponse< Program > GetSpeechandtextanalyticsProgramWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of Program</returns>
        public async System.Threading.Tasks.Task<Program> GetSpeechandtextanalyticsProgramAsync (string programId)
        {
             ApiResponse<Program> localVarResponse = await GetSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics program by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Program>> GetSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ProgramsEntityListing</returns>
        public ProgramsEntityListing GetSpeechandtextanalyticsPrograms (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<ProgramsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of ProgramsEntityListing</returns>
        public ApiResponse< ProgramsEntityListing > GetSpeechandtextanalyticsProgramsWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ProgramsEntityListing</returns>
        public async System.Threading.Tasks.Task<ProgramsEntityListing> GetSpeechandtextanalyticsProgramsAsync (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<ProgramsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsAsyncWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (ProgramsEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProgramsEntityListing>> GetSpeechandtextanalyticsProgramsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>GeneralProgramJob</returns>
        public GeneralProgramJob GetSpeechandtextanalyticsProgramsGeneralJob (string jobId)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = GetSpeechandtextanalyticsProgramsGeneralJobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        public ApiResponse< GeneralProgramJob > GetSpeechandtextanalyticsProgramsGeneralJobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsGeneralJob");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of GeneralProgramJob</returns>
        public async System.Threading.Tasks.Task<GeneralProgramJob> GetSpeechandtextanalyticsProgramsGeneralJobAsync (string jobId)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = await GetSpeechandtextanalyticsProgramsGeneralJobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics general program job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> GetSpeechandtextanalyticsProgramsGeneralJobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsGeneralJob");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsGeneralJob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ProgramJob</returns>
        public ProgramJob GetSpeechandtextanalyticsProgramsPublishjob (string jobId)
        {
             ApiResponse<ProgramJob> localVarResponse = GetSpeechandtextanalyticsProgramsPublishjobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        public ApiResponse< ProgramJob > GetSpeechandtextanalyticsProgramsPublishjobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsPublishjob");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ProgramJob</returns>
        public async System.Threading.Tasks.Task<ProgramJob> GetSpeechandtextanalyticsProgramsPublishjobAsync (string jobId)
        {
             ApiResponse<ProgramJob> localVarResponse = await GetSpeechandtextanalyticsProgramsPublishjobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish programs job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish programs job</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProgramJob>> GetSpeechandtextanalyticsProgramsPublishjobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsProgramsPublishjob");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>UnpublishedProgramsEntityListing</returns>
        public UnpublishedProgramsEntityListing GetSpeechandtextanalyticsProgramsUnpublished (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<UnpublishedProgramsEntityListing> localVarResponse = GetSpeechandtextanalyticsProgramsUnpublishedWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of UnpublishedProgramsEntityListing</returns>
        public ApiResponse< UnpublishedProgramsEntityListing > GetSpeechandtextanalyticsProgramsUnpublishedWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/unpublished";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnpublishedProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UnpublishedProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnpublishedProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of UnpublishedProgramsEntityListing</returns>
        public async System.Threading.Tasks.Task<UnpublishedProgramsEntityListing> GetSpeechandtextanalyticsProgramsUnpublishedAsync (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<UnpublishedProgramsEntityListing> localVarResponse = await GetSpeechandtextanalyticsProgramsUnpublishedAsyncWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics unpublished programs 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (UnpublishedProgramsEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnpublishedProgramsEntityListing>> GetSpeechandtextanalyticsProgramsUnpublishedAsyncWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/programs/unpublished";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsProgramsUnpublished: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UnpublishedProgramsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (UnpublishedProgramsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnpublishedProgramsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        public SpeechTextAnalyticsSettingsResponse GetSpeechandtextanalyticsSettings ()
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = GetSpeechandtextanalyticsSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        public ApiResponse< SpeechTextAnalyticsSettingsResponse > GetSpeechandtextanalyticsSettingsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> GetSpeechandtextanalyticsSettingsAsync ()
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = await GetSpeechandtextanalyticsSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> GetSpeechandtextanalyticsSettingsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Topic</returns>
        public Topic GetSpeechandtextanalyticsTopic (string topicId)
        {
             ApiResponse<Topic> localVarResponse = GetSpeechandtextanalyticsTopicWithHttpInfo(topicId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>ApiResponse of Topic</returns>
        public ApiResponse< Topic > GetSpeechandtextanalyticsTopicWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of Topic</returns>
        public async System.Threading.Tasks.Task<Topic> GetSpeechandtextanalyticsTopicAsync (string topicId)
        {
             ApiResponse<Topic> localVarResponse = await GetSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics topic by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> GetSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>TopicsEntityListing</returns>
        public TopicsEntityListing GetSpeechandtextanalyticsTopics (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<TopicsEntityListing> localVarResponse = GetSpeechandtextanalyticsTopicsWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>ApiResponse of TopicsEntityListing</returns>
        public ApiResponse< TopicsEntityListing > GetSpeechandtextanalyticsTopicsWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of TopicsEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicsEntityListing> GetSpeechandtextanalyticsTopicsAsync (string nextPage = null, int? pageSize = null)
        {
             ApiResponse<TopicsEntityListing> localVarResponse = await GetSpeechandtextanalyticsTopicsAsyncWithHttpInfo(nextPage, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Speech &amp; Text Analytics topics 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">The key for listing the next page (optional)</param>
        /// <param name="pageSize">The page size for the listing (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (TopicsEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicsEntityListing>> GetSpeechandtextanalyticsTopicsAsyncWithHttpInfo (string nextPage = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (nextPage != null) localVarQueryParams.Add(new Tuple<string, string>("nextPage", this.Configuration.ApiClient.ParameterToString(nextPage)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (TopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>GeneralTopicsEntityListing</returns>
        public GeneralTopicsEntityListing GetSpeechandtextanalyticsTopicsGeneral (string dialect = null)
        {
             ApiResponse<GeneralTopicsEntityListing> localVarResponse = GetSpeechandtextanalyticsTopicsGeneralWithHttpInfo(dialect);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>ApiResponse of GeneralTopicsEntityListing</returns>
        public ApiResponse< GeneralTopicsEntityListing > GetSpeechandtextanalyticsTopicsGeneralWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/general";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralTopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (GeneralTopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralTopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of GeneralTopicsEntityListing</returns>
        public async System.Threading.Tasks.Task<GeneralTopicsEntityListing> GetSpeechandtextanalyticsTopicsGeneralAsync (string dialect = null)
        {
             ApiResponse<GeneralTopicsEntityListing> localVarResponse = await GetSpeechandtextanalyticsTopicsGeneralAsyncWithHttpInfo(dialect);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Speech &amp; Text Analytics general topics for a given dialect 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dialect">The dialect of the general topics, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (optional)</param>
        /// <returns>Task of ApiResponse (GeneralTopicsEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeneralTopicsEntityListing>> GetSpeechandtextanalyticsTopicsGeneralAsyncWithHttpInfo (string dialect = null)
        { 

            var localVarPath = "/api/v2/speechandtextanalytics/topics/general";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (dialect != null) localVarQueryParams.Add(new Tuple<string, string>("dialect", this.Configuration.ApiClient.ParameterToString(dialect)));

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsGeneral: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralTopicsEntityListing>(localVarStatusCode,
                localVarHeaders,
                (GeneralTopicsEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralTopicsEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>TopicJob</returns>
        public TopicJob GetSpeechandtextanalyticsTopicsPublishjob (string jobId)
        {
             ApiResponse<TopicJob> localVarResponse = GetSpeechandtextanalyticsTopicsPublishjobWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>ApiResponse of TopicJob</returns>
        public ApiResponse< TopicJob > GetSpeechandtextanalyticsTopicsPublishjobWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopicsPublishjob");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of TopicJob</returns>
        public async System.Threading.Tasks.Task<TopicJob> GetSpeechandtextanalyticsTopicsPublishjobAsync (string jobId)
        {
             ApiResponse<TopicJob> localVarResponse = await GetSpeechandtextanalyticsTopicsPublishjobAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Speech &amp; Text Analytics publish topics job by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">The id of the publish topics job</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicJob>> GetSpeechandtextanalyticsTopicsPublishjobAsyncWithHttpInfo (string jobId)
        { 
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling SpeechTextAnalyticsApi->GetSpeechandtextanalyticsTopicsPublishjob");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs/{jobId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSpeechandtextanalyticsTopicsPublishjob: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        public SpeechTextAnalyticsSettingsResponse PatchSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = PatchSpeechandtextanalyticsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        public ApiResponse< SpeechTextAnalyticsSettingsResponse > PatchSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PatchSpeechandtextanalyticsSettings");

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PatchSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = await PatchSpeechandtextanalyticsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PatchSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PatchSpeechandtextanalyticsSettings");
            

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Program</returns>
        public Program PostSpeechandtextanalyticsPrograms (ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = PostSpeechandtextanalyticsProgramsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>ApiResponse of Program</returns>
        public ApiResponse< Program > PostSpeechandtextanalyticsProgramsWithHttpInfo (ProgramRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsPrograms");

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of Program</returns>
        public async System.Threading.Tasks.Task<Program> PostSpeechandtextanalyticsProgramsAsync (ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = await PostSpeechandtextanalyticsProgramsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The program to create</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Program>> PostSpeechandtextanalyticsProgramsAsyncWithHttpInfo (ProgramRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsPrograms");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsPrograms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>GeneralProgramJob</returns>
        public GeneralProgramJob PostSpeechandtextanalyticsProgramsGeneralJobs (GeneralProgramJobRequest body)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = PostSpeechandtextanalyticsProgramsGeneralJobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>ApiResponse of GeneralProgramJob</returns>
        public ApiResponse< GeneralProgramJob > PostSpeechandtextanalyticsProgramsGeneralJobsWithHttpInfo (GeneralProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsGeneralJobs");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of GeneralProgramJob</returns>
        public async System.Threading.Tasks.Task<GeneralProgramJob> PostSpeechandtextanalyticsProgramsGeneralJobsAsync (GeneralProgramJobRequest body)
        {
             ApiResponse<GeneralProgramJob> localVarResponse = await PostSpeechandtextanalyticsProgramsGeneralJobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics general program job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The general programs job to create</param>
        /// <returns>Task of ApiResponse (GeneralProgramJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeneralProgramJob>> PostSpeechandtextanalyticsProgramsGeneralJobsAsyncWithHttpInfo (GeneralProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsGeneralJobs");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/general/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsGeneralJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GeneralProgramJob>(localVarStatusCode,
                localVarHeaders,
                (GeneralProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeneralProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ProgramJob</returns>
        public ProgramJob PostSpeechandtextanalyticsProgramsPublishjobs (ProgramJobRequest body)
        {
             ApiResponse<ProgramJob> localVarResponse = PostSpeechandtextanalyticsProgramsPublishjobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>ApiResponse of ProgramJob</returns>
        public ApiResponse< ProgramJob > PostSpeechandtextanalyticsProgramsPublishjobsWithHttpInfo (ProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsPublishjobs");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ProgramJob</returns>
        public async System.Threading.Tasks.Task<ProgramJob> PostSpeechandtextanalyticsProgramsPublishjobsAsync (ProgramJobRequest body)
        {
             ApiResponse<ProgramJob> localVarResponse = await PostSpeechandtextanalyticsProgramsPublishjobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish programs job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish programs job to create</param>
        /// <returns>Task of ApiResponse (ProgramJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProgramJob>> PostSpeechandtextanalyticsProgramsPublishjobsAsyncWithHttpInfo (ProgramJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsProgramsPublishjobs");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/publishjobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsProgramsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProgramJob>(localVarStatusCode,
                localVarHeaders,
                (ProgramJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProgramJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Topic</returns>
        public Topic PostSpeechandtextanalyticsTopics (TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = PostSpeechandtextanalyticsTopicsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>ApiResponse of Topic</returns>
        public ApiResponse< Topic > PostSpeechandtextanalyticsTopicsWithHttpInfo (TopicRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopics");

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of Topic</returns>
        public async System.Threading.Tasks.Task<Topic> PostSpeechandtextanalyticsTopicsAsync (TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = await PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The topic to create</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> PostSpeechandtextanalyticsTopicsAsyncWithHttpInfo (TopicRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopics");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>TopicJob</returns>
        public TopicJob PostSpeechandtextanalyticsTopicsPublishjobs (TopicJobRequest body)
        {
             ApiResponse<TopicJob> localVarResponse = PostSpeechandtextanalyticsTopicsPublishjobsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>ApiResponse of TopicJob</returns>
        public ApiResponse< TopicJob > PostSpeechandtextanalyticsTopicsPublishjobsWithHttpInfo (TopicJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopicsPublishjobs");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of TopicJob</returns>
        public async System.Threading.Tasks.Task<TopicJob> PostSpeechandtextanalyticsTopicsPublishjobsAsync (TopicJobRequest body)
        {
             ApiResponse<TopicJob> localVarResponse = await PostSpeechandtextanalyticsTopicsPublishjobsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new Speech &amp; Text Analytics publish topics job 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The publish topics job to create</param>
        /// <returns>Task of ApiResponse (TopicJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicJob>> PostSpeechandtextanalyticsTopicsPublishjobsAsyncWithHttpInfo (TopicJobRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTopicsPublishjobs");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/publishjobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTopicsPublishjobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicJob>(localVarStatusCode,
                localVarHeaders,
                (TopicJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicJob)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>JsonSearchResponse</returns>
        public JsonSearchResponse PostSpeechandtextanalyticsTranscriptsSearch (TranscriptSearchRequest body)
        {
             ApiResponse<JsonSearchResponse> localVarResponse = PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of JsonSearchResponse</returns>
        public ApiResponse< JsonSearchResponse > PostSpeechandtextanalyticsTranscriptsSearchWithHttpInfo (TranscriptSearchRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTranscriptsSearch");

            var localVarPath = "/api/v2/speechandtextanalytics/transcripts/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of JsonSearchResponse</returns>
        public async System.Threading.Tasks.Task<JsonSearchResponse> PostSpeechandtextanalyticsTranscriptsSearchAsync (TranscriptSearchRequest body)
        {
             ApiResponse<JsonSearchResponse> localVarResponse = await PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (JsonSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonSearchResponse>> PostSpeechandtextanalyticsTranscriptsSearchAsyncWithHttpInfo (TranscriptSearchRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PostSpeechandtextanalyticsTranscriptsSearch");
            

            var localVarPath = "/api/v2/speechandtextanalytics/transcripts/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSpeechandtextanalyticsTranscriptsSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JsonSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (JsonSearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonSearchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Program</returns>
        public Program PutSpeechandtextanalyticsProgram (string programId, ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = PutSpeechandtextanalyticsProgramWithHttpInfo(programId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>ApiResponse of Program</returns>
        public ApiResponse< Program > PutSpeechandtextanalyticsProgramWithHttpInfo (string programId, ProgramRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of Program</returns>
        public async System.Threading.Tasks.Task<Program> PutSpeechandtextanalyticsProgramAsync (string programId, ProgramRequest body)
        {
             ApiResponse<Program> localVarResponse = await PutSpeechandtextanalyticsProgramAsyncWithHttpInfo(programId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics program 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="programId">The id of the program</param>
        /// <param name="body">The program to update</param>
        /// <returns>Task of ApiResponse (Program)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Program>> PutSpeechandtextanalyticsProgramAsyncWithHttpInfo (string programId, ProgramRequest body)
        { 
            // verify the required parameter 'programId' is set
            if (programId == null)
                throw new ApiException(400, "Missing required parameter 'programId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsProgram");
            

            var localVarPath = "/api/v2/speechandtextanalytics/programs/{programId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (programId != null) localVarPathParams.Add("programId", this.Configuration.ApiClient.ParameterToString(programId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsProgram: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Program>(localVarStatusCode,
                localVarHeaders,
                (Program) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Program)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>SpeechTextAnalyticsSettingsResponse</returns>
        public SpeechTextAnalyticsSettingsResponse PutSpeechandtextanalyticsSettings (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = PutSpeechandtextanalyticsSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>ApiResponse of SpeechTextAnalyticsSettingsResponse</returns>
        public ApiResponse< SpeechTextAnalyticsSettingsResponse > PutSpeechandtextanalyticsSettingsWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsSettings");

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of SpeechTextAnalyticsSettingsResponse</returns>
        public async System.Threading.Tasks.Task<SpeechTextAnalyticsSettingsResponse> PutSpeechandtextanalyticsSettingsAsync (SpeechTextAnalyticsSettingsRequest body)
        {
             ApiResponse<SpeechTextAnalyticsSettingsResponse> localVarResponse = await PutSpeechandtextanalyticsSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Speech And Text Analytics Settings 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Speech And Text Analytics Settings</param>
        /// <returns>Task of ApiResponse (SpeechTextAnalyticsSettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SpeechTextAnalyticsSettingsResponse>> PutSpeechandtextanalyticsSettingsAsyncWithHttpInfo (SpeechTextAnalyticsSettingsRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsSettings");
            

            var localVarPath = "/api/v2/speechandtextanalytics/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SpeechTextAnalyticsSettingsResponse>(localVarStatusCode,
                localVarHeaders,
                (SpeechTextAnalyticsSettingsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SpeechTextAnalyticsSettingsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Topic</returns>
        public Topic PutSpeechandtextanalyticsTopic (string topicId, TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = PutSpeechandtextanalyticsTopicWithHttpInfo(topicId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>ApiResponse of Topic</returns>
        public ApiResponse< Topic > PutSpeechandtextanalyticsTopicWithHttpInfo (string topicId, TopicRequest body)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of Topic</returns>
        public async System.Threading.Tasks.Task<Topic> PutSpeechandtextanalyticsTopicAsync (string topicId, TopicRequest body)
        {
             ApiResponse<Topic> localVarResponse = await PutSpeechandtextanalyticsTopicAsyncWithHttpInfo(topicId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update existing Speech &amp; Text Analytics topic 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="topicId">The id of the topic</param>
        /// <param name="body">The topic to update</param>
        /// <returns>Task of ApiResponse (Topic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Topic>> PutSpeechandtextanalyticsTopicAsyncWithHttpInfo (string topicId, TopicRequest body)
        { 
            // verify the required parameter 'topicId' is set
            if (topicId == null)
                throw new ApiException(400, "Missing required parameter 'topicId' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SpeechTextAnalyticsApi->PutSpeechandtextanalyticsTopic");
            

            var localVarPath = "/api/v2/speechandtextanalytics/topics/{topicId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (topicId != null) localVarPathParams.Add("topicId", this.Configuration.ApiClient.ParameterToString(topicId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSpeechandtextanalyticsTopic: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Topic>(localVarStatusCode,
                localVarHeaders,
                (Topic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Topic)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
