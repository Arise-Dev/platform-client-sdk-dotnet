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
    public interface IArchitectApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns></returns>
        void DeleteArchitectIvr (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteArchitectIvrWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns></returns>
        void DeleteArchitectPrompt (string promptId, bool? allResources = null);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteArchitectPromptWithHttpInfo (string promptId, bool? allResources = null);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns></returns>
        void DeleteArchitectPromptResource (string promptId, string languageCode);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteArchitectPromptResourceWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>Operation</returns>
        Operation DeleteArchitectPrompts (List<string> id);

        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>ApiResponse of Operation</returns>
        ApiResponse<Operation> DeleteArchitectPromptsWithHttpInfo (List<string> id);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns></returns>
        void DeleteArchitectSchedule (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteArchitectScheduleWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns></returns>
        void DeleteArchitectSchedulegroup (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteArchitectSchedulegroupWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns></returns>
        void DeleteArchitectSystempromptResource (string promptId, string languageCode);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteArchitectSystempromptResourceWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Delete flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns></returns>
        void DeleteFlow (string flowId);

        /// <summary>
        /// Delete flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFlowWithHttpInfo (string flowId);
        
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>Operation</returns>
        Operation DeleteFlows (List<string> id);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>ApiResponse of Operation</returns>
        ApiResponse<Operation> DeleteFlowsWithHttpInfo (List<string> id);
        
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>DependencyObjectEntityListing</returns>
        DependencyObjectEntityListing GetArchitectDependencytracking (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        ApiResponse<DependencyObjectEntityListing> GetArchitectDependencytrackingWithHttpInfo (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DependencyStatus</returns>
        DependencyStatus GetArchitectDependencytrackingBuild ();

        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DependencyStatus</returns>
        ApiResponse<DependencyStatus> GetArchitectDependencytrackingBuildWithHttpInfo ();
        
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>ConsumedResourcesEntityListing</returns>
        ConsumedResourcesEntityListing GetArchitectDependencytrackingConsumedresources (string id, string version, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>ApiResponse of ConsumedResourcesEntityListing</returns>
        ApiResponse<ConsumedResourcesEntityListing> GetArchitectDependencytrackingConsumedresourcesWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null);
        
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>ConsumingResourcesEntityListing</returns>
        ConsumingResourcesEntityListing GetArchitectDependencytrackingConsumingresources (string id, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>ApiResponse of ConsumingResourcesEntityListing</returns>
        ApiResponse<ConsumingResourcesEntityListing> GetArchitectDependencytrackingConsumingresourcesWithHttpInfo (string id, string objectType, List<string> resourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DependencyObjectEntityListing</returns>
        DependencyObjectEntityListing GetArchitectDependencytrackingDeletedresourceconsumers (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        ApiResponse<DependencyObjectEntityListing> GetArchitectDependencytrackingDeletedresourceconsumersWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>DependencyObject</returns>
        DependencyObject GetArchitectDependencytrackingObject (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>ApiResponse of DependencyObject</returns>
        ApiResponse<DependencyObject> GetArchitectDependencytrackingObjectWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
        
        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>DependencyType</returns>
        DependencyType GetArchitectDependencytrackingType (string typeId);

        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>ApiResponse of DependencyType</returns>
        ApiResponse<DependencyType> GetArchitectDependencytrackingTypeWithHttpInfo (string typeId);
        
        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DependencyTypeEntityListing</returns>
        DependencyTypeEntityListing GetArchitectDependencytrackingTypes (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DependencyTypeEntityListing</returns>
        ApiResponse<DependencyTypeEntityListing> GetArchitectDependencytrackingTypesWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DependencyObjectEntityListing</returns>
        DependencyObjectEntityListing GetArchitectDependencytrackingUpdatedresourceconsumers (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        ApiResponse<DependencyObjectEntityListing> GetArchitectDependencytrackingUpdatedresourceconsumersWithHttpInfo (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>IVR</returns>
        IVR GetArchitectIvr (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> GetArchitectIvrWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>IVREntityListing</returns>
        IVREntityListing GetArchitectIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>ApiResponse of IVREntityListing</returns>
        ApiResponse<IVREntityListing> GetArchitectIvrsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);
        
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Prompt</returns>
        Prompt GetArchitectPrompt (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> GetArchitectPromptWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>PromptAsset</returns>
        PromptAsset GetArchitectPromptResource (string promptId, string languageCode);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> GetArchitectPromptResourceWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>PromptAssetEntityListing</returns>
        PromptAssetEntityListing GetArchitectPromptResources (string promptId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        ApiResponse<PromptAssetEntityListing> GetArchitectPromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>PromptEntityListing</returns>
        PromptEntityListing GetArchitectPrompts (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>ApiResponse of PromptEntityListing</returns>
        ApiResponse<PromptEntityListing> GetArchitectPromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Schedule</returns>
        Schedule GetArchitectSchedule (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> GetArchitectScheduleWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup GetArchitectSchedulegroup (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> GetArchitectSchedulegroupWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>ScheduleGroupEntityListing</returns>
        ScheduleGroupEntityListing GetArchitectSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>ApiResponse of ScheduleGroupEntityListing</returns>
        ApiResponse<ScheduleGroupEntityListing> GetArchitectSchedulegroupsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);
        
        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>ScheduleEntityListing</returns>
        ScheduleEntityListing GetArchitectSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>ApiResponse of ScheduleEntityListing</returns>
        ApiResponse<ScheduleEntityListing> GetArchitectSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);
        
        /// <summary>
        /// Get a system prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>SystemPrompt</returns>
        SystemPrompt GetArchitectSystemprompt (string promptId);

        /// <summary>
        /// Get a system prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>ApiResponse of SystemPrompt</returns>
        ApiResponse<SystemPrompt> GetArchitectSystempromptWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset GetArchitectSystempromptResource (string promptId, string languageCode);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> GetArchitectSystempromptResourceWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Get system prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>SystemPromptAssetEntityListing</returns>
        SystemPromptAssetEntityListing GetArchitectSystempromptResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get system prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>ApiResponse of SystemPromptAssetEntityListing</returns>
        ApiResponse<SystemPromptAssetEntityListing> GetArchitectSystempromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get System Prompts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>SystemPromptEntityListing</returns>
        SystemPromptEntityListing GetArchitectSystemprompts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get System Prompts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>ApiResponse of SystemPromptEntityListing</returns>
        ApiResponse<SystemPromptEntityListing> GetArchitectSystempromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Flow</returns>
        Flow GetFlow (string flowId, bool? deleted = null);

        /// <summary>
        /// Get flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> GetFlowWithHttpInfo (string flowId, bool? deleted = null);
        
        /// <summary>
        /// Get generated flow history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>HistoryListing</returns>
        HistoryListing GetFlowHistoryHistoryId (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null);

        /// <summary>
        /// Get generated flow history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>ApiResponse of HistoryListing</returns>
        ApiResponse<HistoryListing> GetFlowHistoryHistoryIdWithHttpInfo (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null);
        
        /// <summary>
        /// Get the latest configuration for flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Object</returns>
        Object GetFlowLatestconfiguration (string flowId, bool? deleted = null);

        /// <summary>
        /// Get the latest configuration for flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetFlowLatestconfigurationWithHttpInfo (string flowId, bool? deleted = null);
        
        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>FlowVersion</returns>
        FlowVersion GetFlowVersion (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> GetFlowVersionWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Object</returns>
        Object GetFlowVersionConfiguration (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetFlowVersionConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>FlowVersionEntityListing</returns>
        FlowVersionEntityListing GetFlowVersions (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null);

        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>ApiResponse of FlowVersionEntityListing</returns>
        ApiResponse<FlowVersionEntityListing> GetFlowVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null);
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>FlowEntityListing</returns>
        FlowEntityListing GetFlows (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null);

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>ApiResponse of FlowEntityListing</returns>
        ApiResponse<FlowEntityListing> GetFlowsWithHttpInfo (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null);
        
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void PostArchitectDependencytrackingBuild ();

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostArchitectDependencytrackingBuildWithHttpInfo ();
        
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>IVR</returns>
        IVR PostArchitectIvrs (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PostArchitectIvrsWithHttpInfo (IVR body = null);
        
        /// <summary>
        /// Create a new user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PromptAsset</returns>
        PromptAsset PostArchitectPromptResources (string promptId, PromptAssetCreate body = null);

        /// <summary>
        /// Create a new user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PostArchitectPromptResourcesWithHttpInfo (string promptId, PromptAssetCreate body = null);
        
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Prompt</returns>
        Prompt PostArchitectPrompts (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PostArchitectPromptsWithHttpInfo (Prompt body = null);
        
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup PostArchitectSchedulegroups (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PostArchitectSchedulegroupsWithHttpInfo (ScheduleGroup body = null);
        
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Schedule</returns>
        Schedule PostArchitectSchedules (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PostArchitectSchedulesWithHttpInfo (Schedule body = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset PostArchitectSystempromptResources (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> PostArchitectSystempromptResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FlowVersion</returns>
        FlowVersion PostFlowVersions (string flowId, Object body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> PostFlowVersionsWithHttpInfo (string flowId, Object body = null);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Flow</returns>
        Flow PostFlows (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsCheckin (string flow);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsCheckinWithHttpInfo (string flow);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsCheckout (string flow);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsCheckoutWithHttpInfo (string flow);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsDeactivate (string flow);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsDeactivateWithHttpInfo (string flow);
        
        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>Operation</returns>
        Operation PostFlowsActionsPublish (string flow, string version = null);

        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>ApiResponse of Operation</returns>
        ApiResponse<Operation> PostFlowsActionsPublishWithHttpInfo (string flow, string version = null);
        
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsRevert (string flow);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsRevertWithHttpInfo (string flow);
        
        /// <summary>
        /// Unlock flow
        /// </summary>
        /// <remarks>
        /// Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsUnlock (string flow);

        /// <summary>
        /// Unlock flow
        /// </summary>
        /// <remarks>
        /// Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsUnlockWithHttpInfo (string flow);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>IVR</returns>
        IVR PutArchitectIvr (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PutArchitectIvrWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Prompt</returns>
        Prompt PutArchitectPrompt (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PutArchitectPromptWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PromptAsset</returns>
        PromptAsset PutArchitectPromptResource (string promptId, string languageCode, PromptAsset body = null);

        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PutArchitectPromptResourceWithHttpInfo (string promptId, string languageCode, PromptAsset body = null);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Schedule</returns>
        Schedule PutArchitectSchedule (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PutArchitectScheduleWithHttpInfo (string scheduleId, Schedule body = null);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup PutArchitectSchedulegroup (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PutArchitectSchedulegroupWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Updates a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset PutArchitectSystempromptResource (string promptId, string languageCode, SystemPromptAsset body = null);

        /// <summary>
        /// Updates a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> PutArchitectSystempromptResourceWithHttpInfo (string promptId, string languageCode, SystemPromptAsset body = null);
        
        /// <summary>
        /// Update flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Flow</returns>
        Flow PutFlow (string flowId, Flow body = null);

        /// <summary>
        /// Update flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PutFlowWithHttpInfo (string flowId, Flow body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteArchitectIvrAsync (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectIvrAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteArchitectPromptAsync (string promptId, bool? allResources = null);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectPromptAsyncWithHttpInfo (string promptId, bool? allResources = null);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteArchitectPromptResourceAsync (string promptId, string languageCode);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectPromptResourceAsyncWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>Task of Operation</returns>
        System.Threading.Tasks.Task<Operation> DeleteArchitectPromptsAsync (List<string> id);

        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>Task of ApiResponse (Operation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Operation>> DeleteArchitectPromptsAsyncWithHttpInfo (List<string> id);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteArchitectScheduleAsync (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectScheduleAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteArchitectSchedulegroupAsync (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectSchedulegroupAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteArchitectSystempromptResourceAsync (string promptId, string languageCode);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectSystempromptResourceAsyncWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Delete flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFlowAsync (string flowId);

        /// <summary>
        /// Delete flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowAsyncWithHttpInfo (string flowId);
        
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>Task of Operation</returns>
        System.Threading.Tasks.Task<Operation> DeleteFlowsAsync (List<string> id);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>Task of ApiResponse (Operation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Operation>> DeleteFlowsAsyncWithHttpInfo (List<string> id);
        
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        System.Threading.Tasks.Task<DependencyObjectEntityListing> GetArchitectDependencytrackingAsync (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> GetArchitectDependencytrackingAsyncWithHttpInfo (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DependencyStatus</returns>
        System.Threading.Tasks.Task<DependencyStatus> GetArchitectDependencytrackingBuildAsync ();

        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DependencyStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyStatus>> GetArchitectDependencytrackingBuildAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>Task of ConsumedResourcesEntityListing</returns>
        System.Threading.Tasks.Task<ConsumedResourcesEntityListing> GetArchitectDependencytrackingConsumedresourcesAsync (string id, string version, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>Task of ApiResponse (ConsumedResourcesEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsumedResourcesEntityListing>> GetArchitectDependencytrackingConsumedresourcesAsyncWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null);
        
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>Task of ConsumingResourcesEntityListing</returns>
        System.Threading.Tasks.Task<ConsumingResourcesEntityListing> GetArchitectDependencytrackingConsumingresourcesAsync (string id, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>Task of ApiResponse (ConsumingResourcesEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsumingResourcesEntityListing>> GetArchitectDependencytrackingConsumingresourcesAsyncWithHttpInfo (string id, string objectType, List<string> resourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        System.Threading.Tasks.Task<DependencyObjectEntityListing> GetArchitectDependencytrackingDeletedresourceconsumersAsync (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> GetArchitectDependencytrackingDeletedresourceconsumersAsyncWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of DependencyObject</returns>
        System.Threading.Tasks.Task<DependencyObject> GetArchitectDependencytrackingObjectAsync (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of ApiResponse (DependencyObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObject>> GetArchitectDependencytrackingObjectAsyncWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
        
        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of DependencyType</returns>
        System.Threading.Tasks.Task<DependencyType> GetArchitectDependencytrackingTypeAsync (string typeId);

        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of ApiResponse (DependencyType)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyType>> GetArchitectDependencytrackingTypeAsyncWithHttpInfo (string typeId);
        
        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DependencyTypeEntityListing</returns>
        System.Threading.Tasks.Task<DependencyTypeEntityListing> GetArchitectDependencytrackingTypesAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DependencyTypeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyTypeEntityListing>> GetArchitectDependencytrackingTypesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        System.Threading.Tasks.Task<DependencyObjectEntityListing> GetArchitectDependencytrackingUpdatedresourceconsumersAsync (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> GetArchitectDependencytrackingUpdatedresourceconsumersAsyncWithHttpInfo (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> GetArchitectIvrAsync (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> GetArchitectIvrAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>Task of IVREntityListing</returns>
        System.Threading.Tasks.Task<IVREntityListing> GetArchitectIvrsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>Task of ApiResponse (IVREntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> GetArchitectIvrsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);
        
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> GetArchitectPromptAsync (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> GetArchitectPromptAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> GetArchitectPromptResourceAsync (string promptId, string languageCode);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetArchitectPromptResourceAsyncWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of PromptAssetEntityListing</returns>
        System.Threading.Tasks.Task<PromptAssetEntityListing> GetArchitectPromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetArchitectPromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of PromptEntityListing</returns>
        System.Threading.Tasks.Task<PromptEntityListing> GetArchitectPromptsAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of ApiResponse (PromptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> GetArchitectPromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> GetArchitectScheduleAsync (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> GetArchitectScheduleAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> GetArchitectSchedulegroupAsync (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetArchitectSchedulegroupAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>Task of ScheduleGroupEntityListing</returns>
        System.Threading.Tasks.Task<ScheduleGroupEntityListing> GetArchitectSchedulegroupsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleGroupEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> GetArchitectSchedulegroupsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);
        
        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>Task of ScheduleEntityListing</returns>
        System.Threading.Tasks.Task<ScheduleEntityListing> GetArchitectSchedulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);

        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> GetArchitectSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null);
        
        /// <summary>
        /// Get a system prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>Task of SystemPrompt</returns>
        System.Threading.Tasks.Task<SystemPrompt> GetArchitectSystempromptAsync (string promptId);

        /// <summary>
        /// Get a system prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetArchitectSystempromptAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> GetArchitectSystempromptResourceAsync (string promptId, string languageCode);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetArchitectSystempromptResourceAsyncWithHttpInfo (string promptId, string languageCode);
        
        /// <summary>
        /// Get system prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of SystemPromptAssetEntityListing</returns>
        System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetArchitectSystempromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get system prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (SystemPromptAssetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetArchitectSystempromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get System Prompts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of SystemPromptEntityListing</returns>
        System.Threading.Tasks.Task<SystemPromptEntityListing> GetArchitectSystempromptsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get System Prompts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of ApiResponse (SystemPromptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptEntityListing>> GetArchitectSystempromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> GetFlowAsync (string flowId, bool? deleted = null);

        /// <summary>
        /// Get flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowAsyncWithHttpInfo (string flowId, bool? deleted = null);
        
        /// <summary>
        /// Get generated flow history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>Task of HistoryListing</returns>
        System.Threading.Tasks.Task<HistoryListing> GetFlowHistoryHistoryIdAsync (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null);

        /// <summary>
        /// Get generated flow history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>Task of ApiResponse (HistoryListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoryListing>> GetFlowHistoryHistoryIdAsyncWithHttpInfo (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null);
        
        /// <summary>
        /// Get the latest configuration for flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetFlowLatestconfigurationAsync (string flowId, bool? deleted = null);

        /// <summary>
        /// Get the latest configuration for flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowLatestconfigurationAsyncWithHttpInfo (string flowId, bool? deleted = null);
        
        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> GetFlowVersionAsync (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> GetFlowVersionAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetFlowVersionConfigurationAsync (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowVersionConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of FlowVersionEntityListing</returns>
        System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null);

        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of ApiResponse (FlowVersionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null);
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>Task of FlowEntityListing</returns>
        System.Threading.Tasks.Task<FlowEntityListing> GetFlowsAsync (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null);

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> GetFlowsAsyncWithHttpInfo (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null);
        
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostArchitectDependencytrackingBuildAsync ();

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostArchitectDependencytrackingBuildAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PostArchitectIvrsAsync (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PostArchitectIvrsAsyncWithHttpInfo (IVR body = null);
        
        /// <summary>
        /// Create a new user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> PostArchitectPromptResourcesAsync (string promptId, PromptAssetCreate body = null);

        /// <summary>
        /// Create a new user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostArchitectPromptResourcesAsyncWithHttpInfo (string promptId, PromptAssetCreate body = null);
        
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> PostArchitectPromptsAsync (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PostArchitectPromptsAsyncWithHttpInfo (Prompt body = null);
        
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> PostArchitectSchedulegroupsAsync (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PostArchitectSchedulegroupsAsyncWithHttpInfo (ScheduleGroup body = null);
        
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> PostArchitectSchedulesAsync (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PostArchitectSchedulesAsyncWithHttpInfo (Schedule body = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> PostArchitectSystempromptResourcesAsync (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostArchitectSystempromptResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> PostFlowVersionsAsync (string flowId, Object body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowVersionsAsyncWithHttpInfo (string flowId, Object body = null);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsAsync (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsAsyncWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckinAsync (string flow);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckinAsyncWithHttpInfo (string flow);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckoutAsync (string flow);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckoutAsyncWithHttpInfo (string flow);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsDeactivateAsync (string flow);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsDeactivateAsyncWithHttpInfo (string flow);
        
        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>Task of Operation</returns>
        System.Threading.Tasks.Task<Operation> PostFlowsActionsPublishAsync (string flow, string version = null);

        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>Task of ApiResponse (Operation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Operation>> PostFlowsActionsPublishAsyncWithHttpInfo (string flow, string version = null);
        
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsRevertAsync (string flow);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsRevertAsyncWithHttpInfo (string flow);
        
        /// <summary>
        /// Unlock flow
        /// </summary>
        /// <remarks>
        /// Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsUnlockAsync (string flow);

        /// <summary>
        /// Unlock flow
        /// </summary>
        /// <remarks>
        /// Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsUnlockAsyncWithHttpInfo (string flow);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PutArchitectIvrAsync (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PutArchitectIvrAsyncWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> PutArchitectPromptAsync (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PutArchitectPromptAsyncWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> PutArchitectPromptResourceAsync (string promptId, string languageCode, PromptAsset body = null);

        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutArchitectPromptResourceAsyncWithHttpInfo (string promptId, string languageCode, PromptAsset body = null);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> PutArchitectScheduleAsync (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PutArchitectScheduleAsyncWithHttpInfo (string scheduleId, Schedule body = null);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> PutArchitectSchedulegroupAsync (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutArchitectSchedulegroupAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Updates a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> PutArchitectSystempromptResourceAsync (string promptId, string languageCode, SystemPromptAsset body = null);

        /// <summary>
        /// Updates a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PutArchitectSystempromptResourceAsyncWithHttpInfo (string promptId, string languageCode, SystemPromptAsset body = null);
        
        /// <summary>
        /// Update flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PutFlowAsync (string flowId, Flow body = null);

        /// <summary>
        /// Update flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowAsyncWithHttpInfo (string flowId, Flow body = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ArchitectApi : IArchitectApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArchitectApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArchitectApi(Configuration configuration = null)
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
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns></returns>
        public void DeleteArchitectIvr (string ivrId)
        {
             DeleteArchitectIvrWithHttpInfo(ivrId);
        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteArchitectIvrWithHttpInfo (string ivrId)
        { 
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->DeleteArchitectIvr");

            var localVarPath = "/api/v2/architect/ivrs/{ivrId}";
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

            // Path params
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectIvr: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectIvr: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteArchitectIvrAsync (string ivrId)
        {
             await DeleteArchitectIvrAsyncWithHttpInfo(ivrId);

        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectIvrAsyncWithHttpInfo (string ivrId)
        { 
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->DeleteArchitectIvr");
            

            var localVarPath = "/api/v2/architect/ivrs/{ivrId}";
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

            // Path params
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectIvr: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectIvr: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns></returns>
        public void DeleteArchitectPrompt (string promptId, bool? allResources = null)
        {
             DeleteArchitectPromptWithHttpInfo(promptId, allResources);
        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteArchitectPromptWithHttpInfo (string promptId, bool? allResources = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteArchitectPrompt");

            var localVarPath = "/api/v2/architect/prompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params
            if (allResources != null) localVarQueryParams.Add(new Tuple<string, string>("allResources", Configuration.ApiClient.ParameterToString(allResources)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteArchitectPromptAsync (string promptId, bool? allResources = null)
        {
             await DeleteArchitectPromptAsyncWithHttpInfo(promptId, allResources);

        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="allResources">Whether or not to delete all the prompt resources (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectPromptAsyncWithHttpInfo (string promptId, bool? allResources = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteArchitectPrompt");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params
            if (allResources != null) localVarQueryParams.Add(new Tuple<string, string>("allResources", Configuration.ApiClient.ParameterToString(allResources)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns></returns>
        public void DeleteArchitectPromptResource (string promptId, string languageCode)
        {
             DeleteArchitectPromptResourceWithHttpInfo(promptId, languageCode);
        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteArchitectPromptResourceWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteArchitectPromptResource");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->DeleteArchitectPromptResource");

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteArchitectPromptResourceAsync (string promptId, string languageCode)
        {
             await DeleteArchitectPromptResourceAsyncWithHttpInfo(promptId, languageCode);

        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectPromptResourceAsyncWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteArchitectPromptResource");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->DeleteArchitectPromptResource");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>Operation</returns>
        public Operation DeleteArchitectPrompts (List<string> id)
        {
             ApiResponse<Operation> localVarResponse = DeleteArchitectPromptsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>ApiResponse of Operation</returns>
        public ApiResponse< Operation > DeleteArchitectPromptsWithHttpInfo (List<string> id)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeleteArchitectPrompts");

            var localVarPath = "/api/v2/architect/prompts";
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

            // Path params

            // Query params
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Operation>(localVarStatusCode,
                localVarHeaders,
                (Operation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Operation)));
            
        }

        
        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>Task of Operation</returns>
        public async System.Threading.Tasks.Task<Operation> DeleteArchitectPromptsAsync (List<string> id)
        {
             ApiResponse<Operation> localVarResponse = await DeleteArchitectPromptsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.  Asynchronous.  Notification topic: v2.architect.prompts.{promptId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <returns>Task of ApiResponse (Operation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Operation>> DeleteArchitectPromptsAsyncWithHttpInfo (List<string> id)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeleteArchitectPrompts");
            

            var localVarPath = "/api/v2/architect/prompts";
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

            // Path params

            // Query params
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Operation>(localVarStatusCode,
                localVarHeaders,
                (Operation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Operation)));
            
        }

        
        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns></returns>
        public void DeleteArchitectSchedule (string scheduleId)
        {
             DeleteArchitectScheduleWithHttpInfo(scheduleId);
        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteArchitectScheduleWithHttpInfo (string scheduleId)
        { 
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->DeleteArchitectSchedule");

            var localVarPath = "/api/v2/architect/schedules/{scheduleId}";
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

            // Path params
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteArchitectScheduleAsync (string scheduleId)
        {
             await DeleteArchitectScheduleAsyncWithHttpInfo(scheduleId);

        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectScheduleAsyncWithHttpInfo (string scheduleId)
        { 
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->DeleteArchitectSchedule");
            

            var localVarPath = "/api/v2/architect/schedules/{scheduleId}";
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

            // Path params
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns></returns>
        public void DeleteArchitectSchedulegroup (string scheduleGroupId)
        {
             DeleteArchitectSchedulegroupWithHttpInfo(scheduleGroupId);
        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteArchitectSchedulegroupWithHttpInfo (string scheduleGroupId)
        { 
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->DeleteArchitectSchedulegroup");

            var localVarPath = "/api/v2/architect/schedulegroups/{scheduleGroupId}";
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

            // Path params
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedulegroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedulegroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteArchitectSchedulegroupAsync (string scheduleGroupId)
        {
             await DeleteArchitectSchedulegroupAsyncWithHttpInfo(scheduleGroupId);

        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectSchedulegroupAsyncWithHttpInfo (string scheduleGroupId)
        { 
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->DeleteArchitectSchedulegroup");
            

            var localVarPath = "/api/v2/architect/schedulegroups/{scheduleGroupId}";
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

            // Path params
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedulegroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSchedulegroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns></returns>
        public void DeleteArchitectSystempromptResource (string promptId, string languageCode)
        {
             DeleteArchitectSystempromptResourceWithHttpInfo(promptId, languageCode);
        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteArchitectSystempromptResourceWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteArchitectSystempromptResource");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->DeleteArchitectSystempromptResource");

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSystempromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSystempromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteArchitectSystempromptResourceAsync (string promptId, string languageCode)
        {
             await DeleteArchitectSystempromptResourceAsyncWithHttpInfo(promptId, languageCode);

        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteArchitectSystempromptResourceAsyncWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteArchitectSystempromptResource");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->DeleteArchitectSystempromptResource");
            

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSystempromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteArchitectSystempromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Delete flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns></returns>
        public void DeleteFlow (string flowId)
        {
             DeleteFlowWithHttpInfo(flowId);
        }

        /// <summary>
        /// Delete flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFlowWithHttpInfo (string flowId)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->DeleteFlow");

            var localVarPath = "/api/v2/flows/{flowId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Delete flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFlowAsync (string flowId)
        {
             await DeleteFlowAsyncWithHttpInfo(flowId);

        }

        /// <summary>
        /// Delete flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowAsyncWithHttpInfo (string flowId)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->DeleteFlow");
            

            var localVarPath = "/api/v2/flows/{flowId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>Operation</returns>
        public Operation DeleteFlows (List<string> id)
        {
             ApiResponse<Operation> localVarResponse = DeleteFlowsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>ApiResponse of Operation</returns>
        public ApiResponse< Operation > DeleteFlowsWithHttpInfo (List<string> id)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeleteFlows");

            var localVarPath = "/api/v2/flows";
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

            // Path params

            // Query params
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Operation>(localVarStatusCode,
                localVarHeaders,
                (Operation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Operation)));
            
        }

        
        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>Task of Operation</returns>
        public async System.Threading.Tasks.Task<Operation> DeleteFlowsAsync (List<string> id)
        {
             ApiResponse<Operation> localVarResponse = await DeleteFlowsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.  Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <returns>Task of ApiResponse (Operation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Operation>> DeleteFlowsAsyncWithHttpInfo (List<string> id)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeleteFlows");
            

            var localVarPath = "/api/v2/flows";
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

            // Path params

            // Query params
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Operation>(localVarStatusCode,
                localVarHeaders,
                (Operation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Operation)));
            
        }

        
        
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>DependencyObjectEntityListing</returns>
        public DependencyObjectEntityListing GetArchitectDependencytracking (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObjectEntityListing> localVarResponse = GetArchitectDependencytrackingWithHttpInfo(name, pageNumber, pageSize, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        public ApiResponse< DependencyObjectEntityListing > GetArchitectDependencytrackingWithHttpInfo (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        { 
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ArchitectApi->GetArchitectDependencytracking");

            var localVarPath = "/api/v2/architect/dependencytracking";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (objectType != null) objectType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumingResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumingResourceType != null) consumingResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumingResourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytracking: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytracking: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObjectEntityListing)));
            
        }

        
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        public async System.Threading.Tasks.Task<DependencyObjectEntityListing> GetArchitectDependencytrackingAsync (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObjectEntityListing> localVarResponse = await GetArchitectDependencytrackingAsyncWithHttpInfo(name, pageNumber, pageSize, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Object name to search for</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Include resources each result item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume each result item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> GetArchitectDependencytrackingAsyncWithHttpInfo (string name, int? pageNumber = null, int? pageSize = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        { 
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ArchitectApi->GetArchitectDependencytracking");
            

            var localVarPath = "/api/v2/architect/dependencytracking";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (objectType != null) objectType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumingResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumingResourceType != null) consumingResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumingResourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytracking: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytracking: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObjectEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>DependencyStatus</returns>
        public DependencyStatus GetArchitectDependencytrackingBuild ()
        {
             ApiResponse<DependencyStatus> localVarResponse = GetArchitectDependencytrackingBuildWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of DependencyStatus</returns>
        public ApiResponse< DependencyStatus > GetArchitectDependencytrackingBuildWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/build";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingBuild: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingBuild: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyStatus>(localVarStatusCode,
                localVarHeaders,
                (DependencyStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyStatus)));
            
        }

        
        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of DependencyStatus</returns>
        public async System.Threading.Tasks.Task<DependencyStatus> GetArchitectDependencytrackingBuildAsync ()
        {
             ApiResponse<DependencyStatus> localVarResponse = await GetArchitectDependencytrackingBuildAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (DependencyStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyStatus>> GetArchitectDependencytrackingBuildAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/build";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingBuild: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingBuild: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyStatus>(localVarStatusCode,
                localVarHeaders,
                (DependencyStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyStatus)));
            
        }

        
        
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>ConsumedResourcesEntityListing</returns>
        public ConsumedResourcesEntityListing GetArchitectDependencytrackingConsumedresources (string id, string version, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumedResourcesEntityListing> localVarResponse = GetArchitectDependencytrackingConsumedresourcesWithHttpInfo(id, version, objectType, resourceType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>ApiResponse of ConsumedResourcesEntityListing</returns>
        public ApiResponse< ConsumedResourcesEntityListing > GetArchitectDependencytrackingConsumedresourcesWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetArchitectDependencytrackingConsumedresources");
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectApi->GetArchitectDependencytrackingConsumedresources");
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectApi->GetArchitectDependencytrackingConsumedresources");

            var localVarPath = "/api/v2/architect/dependencytracking/consumedresources";
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

            // Path params

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", Configuration.ApiClient.ParameterToString(version)));
            if (objectType != null) localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(objectType)));
            if (resourceType != null) resourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("resourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumedresources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumedresources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsumedResourcesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConsumedResourcesEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsumedResourcesEntityListing)));
            
        }

        
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>Task of ConsumedResourcesEntityListing</returns>
        public async System.Threading.Tasks.Task<ConsumedResourcesEntityListing> GetArchitectDependencytrackingConsumedresourcesAsync (string id, string version, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumedResourcesEntityListing> localVarResponse = await GetArchitectDependencytrackingConsumedresourcesAsyncWithHttpInfo(id, version, objectType, resourceType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type.  Only versioned types are allowed here.</param>
        /// <param name="resourceType">Types of consumed resources to show (optional)</param>
        /// <returns>Task of ApiResponse (ConsumedResourcesEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsumedResourcesEntityListing>> GetArchitectDependencytrackingConsumedresourcesAsyncWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetArchitectDependencytrackingConsumedresources");
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectApi->GetArchitectDependencytrackingConsumedresources");
            
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectApi->GetArchitectDependencytrackingConsumedresources");
            

            var localVarPath = "/api/v2/architect/dependencytracking/consumedresources";
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

            // Path params

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", Configuration.ApiClient.ParameterToString(version)));
            if (objectType != null) localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(objectType)));
            if (resourceType != null) resourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("resourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumedresources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumedresources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsumedResourcesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConsumedResourcesEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsumedResourcesEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>ConsumingResourcesEntityListing</returns>
        public ConsumingResourcesEntityListing GetArchitectDependencytrackingConsumingresources (string id, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumingResourcesEntityListing> localVarResponse = GetArchitectDependencytrackingConsumingresourcesWithHttpInfo(id, objectType, resourceType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>ApiResponse of ConsumingResourcesEntityListing</returns>
        public ApiResponse< ConsumingResourcesEntityListing > GetArchitectDependencytrackingConsumingresourcesWithHttpInfo (string id, string objectType, List<string> resourceType = null)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetArchitectDependencytrackingConsumingresources");
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectApi->GetArchitectDependencytrackingConsumingresources");

            var localVarPath = "/api/v2/architect/dependencytracking/consumingresources";
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

            // Path params

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
            if (objectType != null) localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(objectType)));
            if (resourceType != null) resourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("resourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumingresources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumingresources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsumingResourcesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConsumingResourcesEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsumingResourcesEntityListing)));
            
        }

        
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>Task of ConsumingResourcesEntityListing</returns>
        public async System.Threading.Tasks.Task<ConsumingResourcesEntityListing> GetArchitectDependencytrackingConsumingresourcesAsync (string id, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumingResourcesEntityListing> localVarResponse = await GetArchitectDependencytrackingConsumingresourcesAsyncWithHttpInfo(id, objectType, resourceType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show.  Only versioned types are allowed here. (optional)</param>
        /// <returns>Task of ApiResponse (ConsumingResourcesEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsumingResourcesEntityListing>> GetArchitectDependencytrackingConsumingresourcesAsyncWithHttpInfo (string id, string objectType, List<string> resourceType = null)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetArchitectDependencytrackingConsumingresources");
            
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectApi->GetArchitectDependencytrackingConsumingresources");
            

            var localVarPath = "/api/v2/architect/dependencytracking/consumingresources";
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

            // Path params

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
            if (objectType != null) localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(objectType)));
            if (resourceType != null) resourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("resourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumingresources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingConsumingresources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsumingResourcesEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConsumingResourcesEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsumingResourcesEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DependencyObjectEntityListing</returns>
        public DependencyObjectEntityListing GetArchitectDependencytrackingDeletedresourceconsumers (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyObjectEntityListing> localVarResponse = GetArchitectDependencytrackingDeletedresourceconsumersWithHttpInfo(name, objectType, flowFilter, consumedResources, consumedResourceType, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        public ApiResponse< DependencyObjectEntityListing > GetArchitectDependencytrackingDeletedresourceconsumersWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/deletedresourceconsumers";
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

            // Path params

            // Query params
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (objectType != null) objectType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(obj))); });
            if (flowFilter != null) localVarQueryParams.Add(new Tuple<string, string>("flowFilter", Configuration.ApiClient.ParameterToString(flowFilter)));
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingDeletedresourceconsumers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingDeletedresourceconsumers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObjectEntityListing)));
            
        }

        
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        public async System.Threading.Tasks.Task<DependencyObjectEntityListing> GetArchitectDependencytrackingDeletedresourceconsumersAsync (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyObjectEntityListing> localVarResponse = await GetArchitectDependencytrackingDeletedresourceconsumersAsyncWithHttpInfo(name, objectType, flowFilter, consumedResources, consumedResourceType, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="flowFilter">Show only checkedIn or published flows (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> GetArchitectDependencytrackingDeletedresourceconsumersAsyncWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/deletedresourceconsumers";
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

            // Path params

            // Query params
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (objectType != null) objectType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(obj))); });
            if (flowFilter != null) localVarQueryParams.Add(new Tuple<string, string>("flowFilter", Configuration.ApiClient.ParameterToString(flowFilter)));
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingDeletedresourceconsumers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingDeletedresourceconsumers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObjectEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>DependencyObject</returns>
        public DependencyObject GetArchitectDependencytrackingObject (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObject> localVarResponse = GetArchitectDependencytrackingObjectWithHttpInfo(id, version, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>ApiResponse of DependencyObject</returns>
        public ApiResponse< DependencyObject > GetArchitectDependencytrackingObjectWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetArchitectDependencytrackingObject");

            var localVarPath = "/api/v2/architect/dependencytracking/object";
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

            // Path params

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", Configuration.ApiClient.ParameterToString(version)));
            if (objectType != null) localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(objectType)));
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumingResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumingResourceType != null) consumingResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumingResourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingObject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingObject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObject>(localVarStatusCode,
                localVarHeaders,
                (DependencyObject) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObject)));
            
        }

        
        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of DependencyObject</returns>
        public async System.Threading.Tasks.Task<DependencyObject> GetArchitectDependencytrackingObjectAsync (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObject> localVarResponse = await GetArchitectDependencytrackingObjectAsyncWithHttpInfo(id, version, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version (optional)</param>
        /// <param name="objectType">Object type (optional)</param>
        /// <param name="consumedResources">Include resources this item consumes (optional)</param>
        /// <param name="consumingResources">Include resources that consume this item (optional)</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested (optional)</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested (optional)</param>
        /// <returns>Task of ApiResponse (DependencyObject)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObject>> GetArchitectDependencytrackingObjectAsyncWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        { 
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetArchitectDependencytrackingObject");
            

            var localVarPath = "/api/v2/architect/dependencytracking/object";
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

            // Path params

            // Query params
            if (id != null) localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(id)));
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", Configuration.ApiClient.ParameterToString(version)));
            if (objectType != null) localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(objectType)));
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumingResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumingResourceType != null) consumingResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumingResourceType", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingObject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingObject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObject>(localVarStatusCode,
                localVarHeaders,
                (DependencyObject) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObject)));
            
        }

        
        
        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>DependencyType</returns>
        public DependencyType GetArchitectDependencytrackingType (string typeId)
        {
             ApiResponse<DependencyType> localVarResponse = GetArchitectDependencytrackingTypeWithHttpInfo(typeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>ApiResponse of DependencyType</returns>
        public ApiResponse< DependencyType > GetArchitectDependencytrackingTypeWithHttpInfo (string typeId)
        { 
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling ArchitectApi->GetArchitectDependencytrackingType");

            var localVarPath = "/api/v2/architect/dependencytracking/types/{typeId}";
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

            // Path params
            if (typeId != null) localVarPathParams.Add("typeId", Configuration.ApiClient.ParameterToString(typeId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingType: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyType>(localVarStatusCode,
                localVarHeaders,
                (DependencyType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyType)));
            
        }

        
        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of DependencyType</returns>
        public async System.Threading.Tasks.Task<DependencyType> GetArchitectDependencytrackingTypeAsync (string typeId)
        {
             ApiResponse<DependencyType> localVarResponse = await GetArchitectDependencytrackingTypeAsyncWithHttpInfo(typeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of ApiResponse (DependencyType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyType>> GetArchitectDependencytrackingTypeAsyncWithHttpInfo (string typeId)
        { 
            // verify the required parameter 'typeId' is set
            if (typeId == null)
                throw new ApiException(400, "Missing required parameter 'typeId' when calling ArchitectApi->GetArchitectDependencytrackingType");
            

            var localVarPath = "/api/v2/architect/dependencytracking/types/{typeId}";
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

            // Path params
            if (typeId != null) localVarPathParams.Add("typeId", Configuration.ApiClient.ParameterToString(typeId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingType: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyType>(localVarStatusCode,
                localVarHeaders,
                (DependencyType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyType)));
            
        }

        
        
        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DependencyTypeEntityListing</returns>
        public DependencyTypeEntityListing GetArchitectDependencytrackingTypes (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyTypeEntityListing> localVarResponse = GetArchitectDependencytrackingTypesWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DependencyTypeEntityListing</returns>
        public ApiResponse< DependencyTypeEntityListing > GetArchitectDependencytrackingTypesWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/types";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingTypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyTypeEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyTypeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyTypeEntityListing)));
            
        }

        
        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DependencyTypeEntityListing</returns>
        public async System.Threading.Tasks.Task<DependencyTypeEntityListing> GetArchitectDependencytrackingTypesAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyTypeEntityListing> localVarResponse = await GetArchitectDependencytrackingTypesAsyncWithHttpInfo(pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DependencyTypeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyTypeEntityListing>> GetArchitectDependencytrackingTypesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/types";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingTypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingTypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyTypeEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyTypeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyTypeEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>DependencyObjectEntityListing</returns>
        public DependencyObjectEntityListing GetArchitectDependencytrackingUpdatedresourceconsumers (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyObjectEntityListing> localVarResponse = GetArchitectDependencytrackingUpdatedresourceconsumersWithHttpInfo(name, objectType, consumedResources, consumedResourceType, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        public ApiResponse< DependencyObjectEntityListing > GetArchitectDependencytrackingUpdatedresourceconsumersWithHttpInfo (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/updatedresourceconsumers";
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

            // Path params

            // Query params
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (objectType != null) objectType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingUpdatedresourceconsumers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingUpdatedresourceconsumers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObjectEntityListing)));
            
        }

        
        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        public async System.Threading.Tasks.Task<DependencyObjectEntityListing> GetArchitectDependencytrackingUpdatedresourceconsumersAsync (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyObjectEntityListing> localVarResponse = await GetArchitectDependencytrackingUpdatedresourceconsumersAsyncWithHttpInfo(name, objectType, consumedResources, consumedResourceType, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dependency Tracking objects that depend on updated resources 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name to search for (optional)</param>
        /// <param name="objectType">Object type(s) to search for (optional)</param>
        /// <param name="consumedResources">Return consumed resources? (optional, default to false)</param>
        /// <param name="consumedResourceType">Resource type(s) to return (optional)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> GetArchitectDependencytrackingUpdatedresourceconsumersAsyncWithHttpInfo (string name = null, List<string> objectType = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/updatedresourceconsumers";
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

            // Path params

            // Query params
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (objectType != null) objectType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("objectType", Configuration.ApiClient.ParameterToString(obj))); });
            if (consumedResources != null) localVarQueryParams.Add(new Tuple<string, string>("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)));
            if (consumedResourceType != null) consumedResourceType.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("consumedResourceType", Configuration.ApiClient.ParameterToString(obj))); });
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingUpdatedresourceconsumers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectDependencytrackingUpdatedresourceconsumers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(localVarStatusCode,
                localVarHeaders,
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DependencyObjectEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>IVR</returns>
        public IVR GetArchitectIvr (string ivrId)
        {
             ApiResponse<IVR> localVarResponse = GetArchitectIvrWithHttpInfo(ivrId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > GetArchitectIvrWithHttpInfo (string ivrId)
        { 
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->GetArchitectIvr");

            var localVarPath = "/api/v2/architect/ivrs/{ivrId}";
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

            // Path params
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvr: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvr: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarHeaders,
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> GetArchitectIvrAsync (string ivrId)
        {
             ApiResponse<IVR> localVarResponse = await GetArchitectIvrAsyncWithHttpInfo(ivrId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> GetArchitectIvrAsyncWithHttpInfo (string ivrId)
        { 
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->GetArchitectIvr");
            

            var localVarPath = "/api/v2/architect/ivrs/{ivrId}";
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

            // Path params
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvr: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvr: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarHeaders,
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>IVREntityListing</returns>
        public IVREntityListing GetArchitectIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        {
             ApiResponse<IVREntityListing> localVarResponse = GetArchitectIvrsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>ApiResponse of IVREntityListing</returns>
        public ApiResponse< IVREntityListing > GetArchitectIvrsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/architect/ivrs";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvrs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVREntityListing>(localVarStatusCode,
                localVarHeaders,
                (IVREntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVREntityListing)));
            
        }

        
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>Task of IVREntityListing</returns>
        public async System.Threading.Tasks.Task<IVREntityListing> GetArchitectIvrsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        {
             ApiResponse<IVREntityListing> localVarResponse = await GetArchitectIvrsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the IVR to filter by. (optional)</param>
        /// <returns>Task of ApiResponse (IVREntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> GetArchitectIvrsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/architect/ivrs";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvrs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVREntityListing>(localVarStatusCode,
                localVarHeaders,
                (IVREntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVREntityListing)));
            
        }

        
        
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Prompt</returns>
        public Prompt GetArchitectPrompt (string promptId)
        {
             ApiResponse<Prompt> localVarResponse = GetArchitectPromptWithHttpInfo(promptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > GetArchitectPromptWithHttpInfo (string promptId)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectPrompt");

            var localVarPath = "/api/v2/architect/prompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarHeaders,
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> GetArchitectPromptAsync (string promptId)
        {
             ApiResponse<Prompt> localVarResponse = await GetArchitectPromptAsyncWithHttpInfo(promptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> GetArchitectPromptAsyncWithHttpInfo (string promptId)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectPrompt");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarHeaders,
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        
        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>PromptAsset</returns>
        public PromptAsset GetArchitectPromptResource (string promptId, string languageCode)
        {
             ApiResponse<PromptAsset> localVarResponse = GetArchitectPromptResourceWithHttpInfo(promptId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > GetArchitectPromptResourceWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectPromptResource");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->GetArchitectPromptResource");

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarHeaders,
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> GetArchitectPromptResourceAsync (string promptId, string languageCode)
        {
             ApiResponse<PromptAsset> localVarResponse = await GetArchitectPromptResourceAsyncWithHttpInfo(promptId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetArchitectPromptResourceAsyncWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectPromptResource");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->GetArchitectPromptResource");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarHeaders,
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query parameters can be used for filtering.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>PromptAssetEntityListing</returns>
        public PromptAssetEntityListing GetArchitectPromptResources (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> localVarResponse = GetArchitectPromptResourcesWithHttpInfo(promptId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query parameters can be used for filtering.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        public ApiResponse< PromptAssetEntityListing > GetArchitectPromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectPromptResources");

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAssetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAssetEntityListing)));
            
        }

        
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query parameters can be used for filtering.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of PromptAssetEntityListing</returns>
        public async System.Threading.Tasks.Task<PromptAssetEntityListing> GetArchitectPromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> localVarResponse = await GetArchitectPromptResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query parameters can be used for filtering.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetArchitectPromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectPromptResources");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAssetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAssetEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>PromptEntityListing</returns>
        public PromptEntityListing GetArchitectPrompts (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> localVarResponse = GetArchitectPromptsWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>ApiResponse of PromptEntityListing</returns>
        public ApiResponse< PromptEntityListing > GetArchitectPromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        { 

            var localVarPath = "/api/v2/architect/prompts";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (description != null) localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
            if (nameOrDescription != null) localVarQueryParams.Add(new Tuple<string, string>("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptEntityListing)));
            
        }

        
        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of PromptEntityListing</returns>
        public async System.Threading.Tasks.Task<PromptEntityListing> GetArchitectPromptsAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> localVarResponse = await GetArchitectPromptsAsyncWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of ApiResponse (PromptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> GetArchitectPromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        { 

            var localVarPath = "/api/v2/architect/prompts";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (description != null) localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
            if (nameOrDescription != null) localVarQueryParams.Add(new Tuple<string, string>("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (PromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Schedule</returns>
        public Schedule GetArchitectSchedule (string scheduleId)
        {
             ApiResponse<Schedule> localVarResponse = GetArchitectScheduleWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > GetArchitectScheduleWithHttpInfo (string scheduleId)
        { 
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->GetArchitectSchedule");

            var localVarPath = "/api/v2/architect/schedules/{scheduleId}";
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

            // Path params
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarHeaders,
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> GetArchitectScheduleAsync (string scheduleId)
        {
             ApiResponse<Schedule> localVarResponse = await GetArchitectScheduleAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> GetArchitectScheduleAsyncWithHttpInfo (string scheduleId)
        { 
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->GetArchitectSchedule");
            

            var localVarPath = "/api/v2/architect/schedules/{scheduleId}";
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

            // Path params
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarHeaders,
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup GetArchitectSchedulegroup (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> localVarResponse = GetArchitectSchedulegroupWithHttpInfo(scheduleGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > GetArchitectSchedulegroupWithHttpInfo (string scheduleGroupId)
        { 
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->GetArchitectSchedulegroup");

            var localVarPath = "/api/v2/architect/schedulegroups/{scheduleGroupId}";
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

            // Path params
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> GetArchitectSchedulegroupAsync (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> localVarResponse = await GetArchitectSchedulegroupAsyncWithHttpInfo(scheduleGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetArchitectSchedulegroupAsyncWithHttpInfo (string scheduleGroupId)
        { 
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->GetArchitectSchedulegroup");
            

            var localVarPath = "/api/v2/architect/schedulegroups/{scheduleGroupId}";
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

            // Path params
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>ScheduleGroupEntityListing</returns>
        public ScheduleGroupEntityListing GetArchitectSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        {
             ApiResponse<ScheduleGroupEntityListing> localVarResponse = GetArchitectSchedulegroupsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>ApiResponse of ScheduleGroupEntityListing</returns>
        public ApiResponse< ScheduleGroupEntityListing > GetArchitectSchedulegroupsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/architect/schedulegroups";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroupEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroupEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>Task of ScheduleGroupEntityListing</returns>
        public async System.Threading.Tasks.Task<ScheduleGroupEntityListing> GetArchitectSchedulegroupsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        {
             ApiResponse<ScheduleGroupEntityListing> localVarResponse = await GetArchitectSchedulegroupsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule Group to filter by. (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleGroupEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> GetArchitectSchedulegroupsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/architect/schedulegroups";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroupEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroupEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>ScheduleEntityListing</returns>
        public ScheduleEntityListing GetArchitectSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        {
             ApiResponse<ScheduleEntityListing> localVarResponse = GetArchitectSchedulesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>ApiResponse of ScheduleEntityListing</returns>
        public ApiResponse< ScheduleEntityListing > GetArchitectSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/architect/schedules";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>Task of ScheduleEntityListing</returns>
        public async System.Threading.Tasks.Task<ScheduleEntityListing> GetArchitectSchedulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        {
             ApiResponse<ScheduleEntityListing> localVarResponse = await GetArchitectSchedulesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ASC)</param>
        /// <param name="name">Name of the Schedule to filter by. (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> GetArchitectSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null)
        { 

            var localVarPath = "/api/v2/architect/schedules";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a system prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>SystemPrompt</returns>
        public SystemPrompt GetArchitectSystemprompt (string promptId)
        {
             ApiResponse<SystemPrompt> localVarResponse = GetArchitectSystempromptWithHttpInfo(promptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a system prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>ApiResponse of SystemPrompt</returns>
        public ApiResponse< SystemPrompt > GetArchitectSystempromptWithHttpInfo (string promptId)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectSystemprompt");

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPrompt>(localVarStatusCode,
                localVarHeaders,
                (SystemPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPrompt)));
            
        }

        
        /// <summary>
        /// Get a system prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>Task of SystemPrompt</returns>
        public async System.Threading.Tasks.Task<SystemPrompt> GetArchitectSystempromptAsync (string promptId)
        {
             ApiResponse<SystemPrompt> localVarResponse = await GetArchitectSystempromptAsyncWithHttpInfo(promptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a system prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">promptId</param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetArchitectSystempromptAsyncWithHttpInfo (string promptId)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectSystemprompt");
            

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPrompt>(localVarStatusCode,
                localVarHeaders,
                (SystemPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPrompt)));
            
        }

        
        
        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset GetArchitectSystempromptResource (string promptId, string languageCode)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = GetArchitectSystempromptResourceWithHttpInfo(promptId, languageCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > GetArchitectSystempromptResourceWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectSystempromptResource");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->GetArchitectSystempromptResource");

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> GetArchitectSystempromptResourceAsync (string promptId, string languageCode)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = await GetArchitectSystempromptResourceAsyncWithHttpInfo(promptId, languageCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetArchitectSystempromptResourceAsyncWithHttpInfo (string promptId, string languageCode)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectSystempromptResource");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->GetArchitectSystempromptResource");
            

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        
        /// <summary>
        /// Get system prompt resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>SystemPromptAssetEntityListing</returns>
        public SystemPromptAssetEntityListing GetArchitectSystempromptResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> localVarResponse = GetArchitectSystempromptResourcesWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get system prompt resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>ApiResponse of SystemPromptAssetEntityListing</returns>
        public ApiResponse< SystemPromptAssetEntityListing > GetArchitectSystempromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectSystempromptResources");

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAssetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAssetEntityListing)));
            
        }

        
        /// <summary>
        /// Get system prompt resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of SystemPromptAssetEntityListing</returns>
        public async System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetArchitectSystempromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> localVarResponse = await GetArchitectSystempromptResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get system prompt resources. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <returns>Task of ApiResponse (SystemPromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetArchitectSystempromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetArchitectSystempromptResources");
            

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystempromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAssetEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAssetEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get System Prompts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>SystemPromptEntityListing</returns>
        public SystemPromptEntityListing GetArchitectSystemprompts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<SystemPromptEntityListing> localVarResponse = GetArchitectSystempromptsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get System Prompts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>ApiResponse of SystemPromptEntityListing</returns>
        public ApiResponse< SystemPromptEntityListing > GetArchitectSystempromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        { 

            var localVarPath = "/api/v2/architect/systemprompts";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (description != null) localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
            if (nameOrDescription != null) localVarQueryParams.Add(new Tuple<string, string>("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptEntityListing)));
            
        }

        
        /// <summary>
        /// Get System Prompts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of SystemPromptEntityListing</returns>
        public async System.Threading.Tasks.Task<SystemPromptEntityListing> GetArchitectSystempromptsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<SystemPromptEntityListing> localVarResponse = await GetArchitectSystempromptsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get System Prompts 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <returns>Task of ApiResponse (SystemPromptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptEntityListing>> GetArchitectSystempromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        { 

            var localVarPath = "/api/v2/architect/systemprompts";
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

            // Path params

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (description != null) localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
            if (nameOrDescription != null) localVarQueryParams.Add(new Tuple<string, string>("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetArchitectSystemprompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptEntityListing>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Flow</returns>
        public Flow GetFlow (string flowId, bool? deleted = null)
        {
             ApiResponse<Flow> localVarResponse = GetFlowWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > GetFlowWithHttpInfo (string flowId, bool? deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlow");

            var localVarPath = "/api/v2/flows/{flowId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Get flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> GetFlowAsync (string flowId, bool? deleted = null)
        {
             ApiResponse<Flow> localVarResponse = await GetFlowAsyncWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowAsyncWithHttpInfo (string flowId, bool? deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlow");
            

            var localVarPath = "/api/v2/flows/{flowId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Get generated flow history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>HistoryListing</returns>
        public HistoryListing GetFlowHistoryHistoryId (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)
        {
             ApiResponse<HistoryListing> localVarResponse = GetFlowHistoryHistoryIdWithHttpInfo(flowId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get generated flow history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>ApiResponse of HistoryListing</returns>
        public ApiResponse< HistoryListing > GetFlowHistoryHistoryIdWithHttpInfo (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowHistoryHistoryId");
            // verify the required parameter 'historyId' is set
            if (historyId == null)
                throw new ApiException(400, "Missing required parameter 'historyId' when calling ArchitectApi->GetFlowHistoryHistoryId");

            var localVarPath = "/api/v2/flows/{flowId}/history/{historyId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));
            if (historyId != null) localVarPathParams.Add("historyId", Configuration.ApiClient.ParameterToString(historyId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (action != null) action.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("action", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowHistoryHistoryId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowHistoryHistoryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoryListing>(localVarStatusCode,
                localVarHeaders,
                (HistoryListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoryListing)));
            
        }

        
        /// <summary>
        /// Get generated flow history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>Task of HistoryListing</returns>
        public async System.Threading.Tasks.Task<HistoryListing> GetFlowHistoryHistoryIdAsync (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)
        {
             ApiResponse<HistoryListing> localVarResponse = await GetFlowHistoryHistoryIdAsyncWithHttpInfo(flowId, historyId, pageNumber, pageSize, sortOrder, sortBy, action);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get generated flow history 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="historyId">History ID (generated history)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortOrder">Sort order (optional, default to desc)</param>
        /// <param name="sortBy">Sort by (optional, default to timestamp)</param>
        /// <param name="action">Flow actions to include (omit to include all) (optional)</param>
        /// <returns>Task of ApiResponse (HistoryListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoryListing>> GetFlowHistoryHistoryIdAsyncWithHttpInfo (string flowId, string historyId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, string sortBy = null, List<string> action = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowHistoryHistoryId");
            
            // verify the required parameter 'historyId' is set
            if (historyId == null)
                throw new ApiException(400, "Missing required parameter 'historyId' when calling ArchitectApi->GetFlowHistoryHistoryId");
            

            var localVarPath = "/api/v2/flows/{flowId}/history/{historyId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));
            if (historyId != null) localVarPathParams.Add("historyId", Configuration.ApiClient.ParameterToString(historyId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (action != null) action.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("action", Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowHistoryHistoryId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowHistoryHistoryId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoryListing>(localVarStatusCode,
                localVarHeaders,
                (HistoryListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoryListing)));
            
        }

        
        
        /// <summary>
        /// Get the latest configuration for flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Object</returns>
        public Object GetFlowLatestconfiguration (string flowId, bool? deleted = null)
        {
             ApiResponse<Object> localVarResponse = GetFlowLatestconfigurationWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the latest configuration for flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetFlowLatestconfigurationWithHttpInfo (string flowId, bool? deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowLatestconfiguration");

            var localVarPath = "/api/v2/flows/{flowId}/latestconfiguration";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowLatestconfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowLatestconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Get the latest configuration for flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetFlowLatestconfigurationAsync (string flowId, bool? deleted = null)
        {
             ApiResponse<Object> localVarResponse = await GetFlowLatestconfigurationAsyncWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the latest configuration for flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Include deleted flows (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowLatestconfigurationAsyncWithHttpInfo (string flowId, bool? deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowLatestconfiguration");
            

            var localVarPath = "/api/v2/flows/{flowId}/latestconfiguration";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowLatestconfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowLatestconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        
        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>FlowVersion</returns>
        public FlowVersion GetFlowVersion (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> localVarResponse = GetFlowVersionWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > GetFlowVersionWithHttpInfo (string flowId, string versionId, string deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowVersion");

            var localVarPath = "/api/v2/flows/{flowId}/versions/{versionId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarHeaders,
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }

        
        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of FlowVersion</returns>
        public async System.Threading.Tasks.Task<FlowVersion> GetFlowVersionAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> localVarResponse = await GetFlowVersionAsyncWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> GetFlowVersionAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowVersion");
            

            var localVarPath = "/api/v2/flows/{flowId}/versions/{versionId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarHeaders,
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }

        
        
        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Object</returns>
        public Object GetFlowVersionConfiguration (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<Object> localVarResponse = GetFlowVersionConfigurationWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetFlowVersionConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersionConfiguration");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowVersionConfiguration");

            var localVarPath = "/api/v2/flows/{flowId}/versions/{versionId}/configuration";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersionConfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersionConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetFlowVersionConfigurationAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<Object> localVarResponse = await GetFlowVersionConfigurationAsyncWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowVersionConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersionConfiguration");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowVersionConfiguration");
            

            var localVarPath = "/api/v2/flows/{flowId}/versions/{versionId}/configuration";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersionConfiguration: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersionConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        
        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>FlowVersionEntityListing</returns>
        public FlowVersionEntityListing GetFlowVersions (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> localVarResponse = GetFlowVersionsWithHttpInfo(flowId, pageNumber, pageSize, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>ApiResponse of FlowVersionEntityListing</returns>
        public ApiResponse< FlowVersionEntityListing > GetFlowVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersions");

            var localVarPath = "/api/v2/flows/{flowId}/versions";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FlowVersionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersionEntityListing)));
            
        }

        
        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of FlowVersionEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> localVarResponse = await GetFlowVersionsAsyncWithHttpInfo(flowId, pageNumber, pageSize, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="deleted">Include deleted flows (optional)</param>
        /// <returns>Task of ApiResponse (FlowVersionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, bool? deleted = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersions");
            

            var localVarPath = "/api/v2/flows/{flowId}/versions";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersionEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FlowVersionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersionEntityListing)));
            
        }

        
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>FlowEntityListing</returns>
        public FlowEntityListing GetFlows (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null)
        {
             ApiResponse<FlowEntityListing> localVarResponse = GetFlowsWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, secure, deleted, includeSchemas, publishedAfter, publishedBefore);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>ApiResponse of FlowEntityListing</returns>
        public ApiResponse< FlowEntityListing > GetFlowsWithHttpInfo (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null)
        { 
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling ArchitectApi->GetFlows");

            var localVarPath = "/api/v2/flows";
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

            // Path params

            // Query params
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", Configuration.ApiClient.ParameterToString(type)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (description != null) localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
            if (nameOrDescription != null) localVarQueryParams.Add(new Tuple<string, string>("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)));
            if (publishVersionId != null) localVarQueryParams.Add(new Tuple<string, string>("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)));
            if (editableBy != null) localVarQueryParams.Add(new Tuple<string, string>("editableBy", Configuration.ApiClient.ParameterToString(editableBy)));
            if (lockedBy != null) localVarQueryParams.Add(new Tuple<string, string>("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));
            if (includeSchemas != null) localVarQueryParams.Add(new Tuple<string, string>("includeSchemas", Configuration.ApiClient.ParameterToString(includeSchemas)));
            if (publishedAfter != null) localVarQueryParams.Add(new Tuple<string, string>("publishedAfter", Configuration.ApiClient.ParameterToString(publishedAfter)));
            if (publishedBefore != null) localVarQueryParams.Add(new Tuple<string, string>("publishedBefore", Configuration.ApiClient.ParameterToString(publishedBefore)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FlowEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowEntityListing)));
            
        }

        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>Task of FlowEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowEntityListing> GetFlowsAsync (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null)
        {
             ApiResponse<FlowEntityListing> localVarResponse = await GetFlowsAsyncWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, secure, deleted, includeSchemas, publishedAfter, publishedBefore);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="sortBy">Sort by (optional, default to id)</param>
        /// <param name="sortOrder">Sort order (optional, default to asc)</param>
        /// <param name="id">ID (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="description">Description (optional)</param>
        /// <param name="nameOrDescription">Name or description (optional)</param>
        /// <param name="publishVersionId">Publish version ID (optional)</param>
        /// <param name="editableBy">Editable by (optional)</param>
        /// <param name="lockedBy">Locked by (optional)</param>
        /// <param name="secure">Secure (optional)</param>
        /// <param name="deleted">Include deleted (optional, default to false)</param>
        /// <param name="includeSchemas">Include variable schemas (optional, default to false)</param>
        /// <param name="publishedAfter">Published after (optional)</param>
        /// <param name="publishedBefore">Published before (optional)</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> GetFlowsAsyncWithHttpInfo (string type, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, string secure = null, bool? deleted = null, bool? includeSchemas = null, string publishedAfter = null, string publishedBefore = null)
        { 
            // verify the required parameter 'type' is set
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling ArchitectApi->GetFlows");
            

            var localVarPath = "/api/v2/flows";
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

            // Path params

            // Query params
            if (type != null) localVarQueryParams.Add(new Tuple<string, string>("type", Configuration.ApiClient.ParameterToString(type)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", Configuration.ApiClient.ParameterToString(pageSize)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", Configuration.ApiClient.ParameterToString(sortBy)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)));
            if (id != null) id.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("id", Configuration.ApiClient.ParameterToString(obj))); });
            if (name != null) localVarQueryParams.Add(new Tuple<string, string>("name", Configuration.ApiClient.ParameterToString(name)));
            if (description != null) localVarQueryParams.Add(new Tuple<string, string>("description", Configuration.ApiClient.ParameterToString(description)));
            if (nameOrDescription != null) localVarQueryParams.Add(new Tuple<string, string>("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)));
            if (publishVersionId != null) localVarQueryParams.Add(new Tuple<string, string>("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)));
            if (editableBy != null) localVarQueryParams.Add(new Tuple<string, string>("editableBy", Configuration.ApiClient.ParameterToString(editableBy)));
            if (lockedBy != null) localVarQueryParams.Add(new Tuple<string, string>("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)));
            if (secure != null) localVarQueryParams.Add(new Tuple<string, string>("secure", Configuration.ApiClient.ParameterToString(secure)));
            if (deleted != null) localVarQueryParams.Add(new Tuple<string, string>("deleted", Configuration.ApiClient.ParameterToString(deleted)));
            if (includeSchemas != null) localVarQueryParams.Add(new Tuple<string, string>("includeSchemas", Configuration.ApiClient.ParameterToString(includeSchemas)));
            if (publishedAfter != null) localVarQueryParams.Add(new Tuple<string, string>("publishedAfter", Configuration.ApiClient.ParameterToString(publishedAfter)));
            if (publishedBefore != null) localVarQueryParams.Add(new Tuple<string, string>("publishedBefore", Configuration.ApiClient.ParameterToString(publishedBefore)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(localVarStatusCode,
                localVarHeaders,
                (FlowEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowEntityListing)));
            
        }

        
        
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void PostArchitectDependencytrackingBuild ()
        {
             PostArchitectDependencytrackingBuildWithHttpInfo();
        }

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostArchitectDependencytrackingBuildWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/build";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectDependencytrackingBuild: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectDependencytrackingBuild: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostArchitectDependencytrackingBuildAsync ()
        {
             await PostArchitectDependencytrackingBuildAsyncWithHttpInfo();

        }

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization Asynchronous.  Notification topic: v2.architect.dependencytracking.build
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostArchitectDependencytrackingBuildAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/architect/dependencytracking/build";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectDependencytrackingBuild: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectDependencytrackingBuild: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        
        
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>IVR</returns>
        public IVR PostArchitectIvrs (IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = PostArchitectIvrsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PostArchitectIvrsWithHttpInfo (IVR body = null)
        { 

            var localVarPath = "/api/v2/architect/ivrs";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectIvrs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarHeaders,
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PostArchitectIvrsAsync (IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = await PostArchitectIvrsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PostArchitectIvrsAsyncWithHttpInfo (IVR body = null)
        { 

            var localVarPath = "/api/v2/architect/ivrs";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectIvrs: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarHeaders,
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        
        /// <summary>
        /// Create a new user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PromptAsset</returns>
        public PromptAsset PostArchitectPromptResources (string promptId, PromptAssetCreate body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = PostArchitectPromptResourcesWithHttpInfo(promptId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PostArchitectPromptResourcesWithHttpInfo (string promptId, PromptAssetCreate body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostArchitectPromptResources");

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarHeaders,
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        /// <summary>
        /// Create a new user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> PostArchitectPromptResourcesAsync (string promptId, PromptAssetCreate body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = await PostArchitectPromptResourcesAsyncWithHttpInfo(promptId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostArchitectPromptResourcesAsyncWithHttpInfo (string promptId, PromptAssetCreate body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostArchitectPromptResources");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarHeaders,
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Prompt</returns>
        public Prompt PostArchitectPrompts (Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = PostArchitectPromptsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PostArchitectPromptsWithHttpInfo (Prompt body = null)
        { 

            var localVarPath = "/api/v2/architect/prompts";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPrompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarHeaders,
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> PostArchitectPromptsAsync (Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = await PostArchitectPromptsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PostArchitectPromptsAsyncWithHttpInfo (Prompt body = null)
        { 

            var localVarPath = "/api/v2/architect/prompts";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPrompts: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarHeaders,
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup PostArchitectSchedulegroups (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = PostArchitectSchedulegroupsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PostArchitectSchedulegroupsWithHttpInfo (ScheduleGroup body = null)
        { 

            var localVarPath = "/api/v2/architect/schedulegroups";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedulegroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> PostArchitectSchedulegroupsAsync (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = await PostArchitectSchedulegroupsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PostArchitectSchedulegroupsAsyncWithHttpInfo (ScheduleGroup body = null)
        { 

            var localVarPath = "/api/v2/architect/schedulegroups";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedulegroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Schedule</returns>
        public Schedule PostArchitectSchedules (Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = PostArchitectSchedulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PostArchitectSchedulesWithHttpInfo (Schedule body = null)
        { 

            var localVarPath = "/api/v2/architect/schedules";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarHeaders,
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> PostArchitectSchedulesAsync (Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = await PostArchitectSchedulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PostArchitectSchedulesAsyncWithHttpInfo (Schedule body = null)
        { 

            var localVarPath = "/api/v2/architect/schedules";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarHeaders,
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        
        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset PostArchitectSystempromptResources (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = PostArchitectSystempromptResourcesWithHttpInfo(promptId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > PostArchitectSystempromptResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostArchitectSystempromptResources");

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSystempromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSystempromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> PostArchitectSystempromptResourcesAsync (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = await PostArchitectSystempromptResourcesAsyncWithHttpInfo(promptId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostArchitectSystempromptResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostArchitectSystempromptResources");
            

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSystempromptResources: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostArchitectSystempromptResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        
        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>FlowVersion</returns>
        public FlowVersion PostFlowVersions (string flowId, Object body = null)
        {
             ApiResponse<FlowVersion> localVarResponse = PostFlowVersionsWithHttpInfo(flowId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > PostFlowVersionsWithHttpInfo (string flowId, Object body = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PostFlowVersions");

            var localVarPath = "/api/v2/flows/{flowId}/versions";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarHeaders,
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }

        
        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of FlowVersion</returns>
        public async System.Threading.Tasks.Task<FlowVersion> PostFlowVersionsAsync (string flowId, Object body = null)
        {
             ApiResponse<FlowVersion> localVarResponse = await PostFlowVersionsAsyncWithHttpInfo(flowId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowVersionsAsyncWithHttpInfo (string flowId, Object body = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PostFlowVersions");
            

            var localVarPath = "/api/v2/flows/{flowId}/versions";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowVersions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarHeaders,
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }

        
        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Flow</returns>
        public Flow PostFlows (Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = PostFlowsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsWithHttpInfo (Flow body = null)
        { 

            var localVarPath = "/api/v2/flows";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsAsync (Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = await PostFlowsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsAsyncWithHttpInfo (Flow body = null)
        { 

            var localVarPath = "/api/v2/flows";
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

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlows: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlows: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Check-in flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsCheckin (string flow)
        {
             ApiResponse<Flow> localVarResponse = PostFlowsActionsCheckinWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check-in flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsCheckinWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsCheckin");

            var localVarPath = "/api/v2/flows/actions/checkin";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Check-in flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckinAsync (string flow)
        {
             ApiResponse<Flow> localVarResponse = await PostFlowsActionsCheckinAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check-in flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckinAsyncWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsCheckin");
            

            var localVarPath = "/api/v2/flows/actions/checkin";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckin: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsCheckout (string flow)
        {
             ApiResponse<Flow> localVarResponse = PostFlowsActionsCheckoutWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsCheckoutWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsCheckout");

            var localVarPath = "/api/v2/flows/actions/checkout";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckout: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckout: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckoutAsync (string flow)
        {
             ApiResponse<Flow> localVarResponse = await PostFlowsActionsCheckoutAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckoutAsyncWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsCheckout");
            

            var localVarPath = "/api/v2/flows/actions/checkout";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckout: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsCheckout: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsDeactivate (string flow)
        {
             ApiResponse<Flow> localVarResponse = PostFlowsActionsDeactivateWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsDeactivateWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsDeactivate");

            var localVarPath = "/api/v2/flows/actions/deactivate";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsDeactivate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsDeactivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsDeactivateAsync (string flow)
        {
             ApiResponse<Flow> localVarResponse = await PostFlowsActionsDeactivateAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsDeactivateAsyncWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsDeactivate");
            

            var localVarPath = "/api/v2/flows/actions/deactivate";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsDeactivate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsDeactivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Publish flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>Operation</returns>
        public Operation PostFlowsActionsPublish (string flow, string version = null)
        {
             ApiResponse<Operation> localVarResponse = PostFlowsActionsPublishWithHttpInfo(flow, version);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>ApiResponse of Operation</returns>
        public ApiResponse< Operation > PostFlowsActionsPublishWithHttpInfo (string flow, string version = null)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsPublish");

            var localVarPath = "/api/v2/flows/actions/publish";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", Configuration.ApiClient.ParameterToString(version)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Operation>(localVarStatusCode,
                localVarHeaders,
                (Operation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Operation)));
            
        }

        
        /// <summary>
        /// Publish flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>Task of Operation</returns>
        public async System.Threading.Tasks.Task<Operation> PostFlowsActionsPublishAsync (string flow, string version = null)
        {
             ApiResponse<Operation> localVarResponse = await PostFlowsActionsPublishAsyncWithHttpInfo(flow, version);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish flow Asynchronous.  Notification topic: v2.flows.{flowId}
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <param name="version">version (optional)</param>
        /// <returns>Task of ApiResponse (Operation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Operation>> PostFlowsActionsPublishAsyncWithHttpInfo (string flow, string version = null)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsPublish");
            

            var localVarPath = "/api/v2/flows/actions/publish";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));
            if (version != null) localVarQueryParams.Add(new Tuple<string, string>("version", Configuration.ApiClient.ParameterToString(version)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsPublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Operation>(localVarStatusCode,
                localVarHeaders,
                (Operation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Operation)));
            
        }

        
        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsRevert (string flow)
        {
             ApiResponse<Flow> localVarResponse = PostFlowsActionsRevertWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsRevertWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsRevert");

            var localVarPath = "/api/v2/flows/actions/revert";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsRevert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsRevert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsRevertAsync (string flow)
        {
             ApiResponse<Flow> localVarResponse = await PostFlowsActionsRevertAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsRevertAsyncWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsRevert");
            

            var localVarPath = "/api/v2/flows/actions/revert";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsRevert: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsRevert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Unlock flow Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsUnlock (string flow)
        {
             ApiResponse<Flow> localVarResponse = PostFlowsActionsUnlockWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unlock flow Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsUnlockWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsUnlock");

            var localVarPath = "/api/v2/flows/actions/unlock";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsUnlock: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsUnlock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Unlock flow Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsUnlockAsync (string flow)
        {
             ApiResponse<Flow> localVarResponse = await PostFlowsActionsUnlockAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unlock flow Allows for unlocking a flow in the case where there is no flow configuration available, and thus a check-in will not unlock the flow. The user must have Architect Admin permissions to perform this action.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow ID</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsUnlockAsyncWithHttpInfo (string flow)
        { 
            // verify the required parameter 'flow' is set
            if (flow == null)
                throw new ApiException(400, "Missing required parameter 'flow' when calling ArchitectApi->PostFlowsActionsUnlock");
            

            var localVarPath = "/api/v2/flows/actions/unlock";
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

            // Path params

            // Query params
            if (flow != null) localVarQueryParams.Add(new Tuple<string, string>("flow", Configuration.ApiClient.ParameterToString(flow)));

            // Header params

            // Form params
            
            // Body param

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsUnlock: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowsActionsUnlock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>IVR</returns>
        public IVR PutArchitectIvr (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = PutArchitectIvrWithHttpInfo(ivrId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PutArchitectIvrWithHttpInfo (string ivrId, IVR body = null)
        { 
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->PutArchitectIvr");

            var localVarPath = "/api/v2/architect/ivrs/{ivrId}";
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

            // Path params
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectIvr: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectIvr: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarHeaders,
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PutArchitectIvrAsync (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = await PutArchitectIvrAsyncWithHttpInfo(ivrId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PutArchitectIvrAsyncWithHttpInfo (string ivrId, IVR body = null)
        { 
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->PutArchitectIvr");
            

            var localVarPath = "/api/v2/architect/ivrs/{ivrId}";
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

            // Path params
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectIvr: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectIvr: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarHeaders,
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        
        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Prompt</returns>
        public Prompt PutArchitectPrompt (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = PutArchitectPromptWithHttpInfo(promptId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PutArchitectPromptWithHttpInfo (string promptId, Prompt body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutArchitectPrompt");

            var localVarPath = "/api/v2/architect/prompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPrompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPrompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarHeaders,
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> PutArchitectPromptAsync (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = await PutArchitectPromptAsyncWithHttpInfo(promptId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PutArchitectPromptAsyncWithHttpInfo (string promptId, Prompt body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutArchitectPrompt");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPrompt: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPrompt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarHeaders,
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        
        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>PromptAsset</returns>
        public PromptAsset PutArchitectPromptResource (string promptId, string languageCode, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = PutArchitectPromptResourceWithHttpInfo(promptId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PutArchitectPromptResourceWithHttpInfo (string promptId, string languageCode, PromptAsset body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutArchitectPromptResource");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->PutArchitectPromptResource");

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarHeaders,
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> PutArchitectPromptResourceAsync (string promptId, string languageCode, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = await PutArchitectPromptResourceAsyncWithHttpInfo(promptId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutArchitectPromptResourceAsyncWithHttpInfo (string promptId, string languageCode, PromptAsset body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutArchitectPromptResource");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->PutArchitectPromptResource");
            

            var localVarPath = "/api/v2/architect/prompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectPromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarHeaders,
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        
        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Schedule</returns>
        public Schedule PutArchitectSchedule (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = PutArchitectScheduleWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PutArchitectScheduleWithHttpInfo (string scheduleId, Schedule body = null)
        { 
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->PutArchitectSchedule");

            var localVarPath = "/api/v2/architect/schedules/{scheduleId}";
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

            // Path params
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarHeaders,
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> PutArchitectScheduleAsync (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = await PutArchitectScheduleAsyncWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PutArchitectScheduleAsyncWithHttpInfo (string scheduleId, Schedule body = null)
        { 
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->PutArchitectSchedule");
            

            var localVarPath = "/api/v2/architect/schedules/{scheduleId}";
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

            // Path params
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarHeaders,
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        
        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup PutArchitectSchedulegroup (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = PutArchitectSchedulegroupWithHttpInfo(scheduleGroupId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PutArchitectSchedulegroupWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        { 
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->PutArchitectSchedulegroup");

            var localVarPath = "/api/v2/architect/schedulegroups/{scheduleGroupId}";
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

            // Path params
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedulegroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedulegroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> PutArchitectSchedulegroupAsync (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = await PutArchitectSchedulegroupAsyncWithHttpInfo(scheduleGroupId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutArchitectSchedulegroupAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        { 
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->PutArchitectSchedulegroup");
            

            var localVarPath = "/api/v2/architect/schedulegroups/{scheduleGroupId}";
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

            // Path params
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedulegroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSchedulegroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarHeaders,
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        
        /// <summary>
        /// Updates a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset PutArchitectSystempromptResource (string promptId, string languageCode, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = PutArchitectSystempromptResourceWithHttpInfo(promptId, languageCode, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > PutArchitectSystempromptResourceWithHttpInfo (string promptId, string languageCode, SystemPromptAsset body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutArchitectSystempromptResource");
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->PutArchitectSystempromptResource");

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSystempromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSystempromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        /// <summary>
        /// Updates a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> PutArchitectSystempromptResourceAsync (string promptId, string languageCode, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = await PutArchitectSystempromptResourceAsyncWithHttpInfo(promptId, languageCode, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a system prompt resource override. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="languageCode">Language</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PutArchitectSystempromptResourceAsyncWithHttpInfo (string promptId, string languageCode, SystemPromptAsset body = null)
        { 
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutArchitectSystempromptResource");
            
            // verify the required parameter 'languageCode' is set
            if (languageCode == null)
                throw new ApiException(400, "Missing required parameter 'languageCode' when calling ArchitectApi->PutArchitectSystempromptResource");
            

            var localVarPath = "/api/v2/architect/systemprompts/{promptId}/resources/{languageCode}";
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

            // Path params
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId));
            if (languageCode != null) localVarPathParams.Add("languageCode", Configuration.ApiClient.ParameterToString(languageCode));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSystempromptResource: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutArchitectSystempromptResource: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarHeaders,
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        
        /// <summary>
        /// Update flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Flow</returns>
        public Flow PutFlow (string flowId, Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = PutFlowWithHttpInfo(flowId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PutFlowWithHttpInfo (string flowId, Flow body = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PutFlow");

            var localVarPath = "/api/v2/flows/{flowId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutFlow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutFlow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Update flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PutFlowAsync (string flowId, Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = await PutFlowAsyncWithHttpInfo(flowId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update flow 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowAsyncWithHttpInfo (string flowId, Flow body = null)
        { 
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PutFlow");
            

            var localVarPath = "/api/v2/flows/{flowId}";
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

            // Path params
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PutFlow: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutFlow: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarHeaders,
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        
    }
    
}
