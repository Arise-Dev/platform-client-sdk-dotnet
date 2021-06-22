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
    public interface ILearningApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete a learning assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns></returns>
        void DeleteLearningAssignment (string assignmentId);

        /// <summary>
        /// Delete a learning assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLearningAssignmentWithHttpInfo (string assignmentId);
        
        /// <summary>
        /// Delete a learning module
        /// </summary>
        /// <remarks>
        /// This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns></returns>
        void DeleteLearningModule (string moduleId);

        /// <summary>
        /// Delete a learning module
        /// </summary>
        /// <remarks>
        /// This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLearningModuleWithHttpInfo (string moduleId);
        
        /// <summary>
        /// Get Learning Assignment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the assigned user of the learning assignment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>LearningAssignment</returns>
        LearningAssignment GetLearningAssignment (string assignmentId, List<string> expand = null);

        /// <summary>
        /// Get Learning Assignment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the assigned user of the learning assignment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>ApiResponse of LearningAssignment</returns>
        ApiResponse<LearningAssignment> GetLearningAssignmentWithHttpInfo (string assignmentId, List<string> expand = null);
        
        /// <summary>
        /// List of Learning module Assignments
        /// </summary>
        /// <remarks>
        /// Either moduleId or user value is required
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>LearningAssignmentsDomainEntity</returns>
        LearningAssignmentsDomainEntity GetLearningAssignments (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null);

        /// <summary>
        /// List of Learning module Assignments
        /// </summary>
        /// <remarks>
        /// Either moduleId or user value is required
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentsDomainEntity</returns>
        ApiResponse<LearningAssignmentsDomainEntity> GetLearningAssignmentsWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null);
        
        /// <summary>
        /// List of Learning Assignments assigned to current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>LearningAssignmentsDomainEntity</returns>
        LearningAssignmentsDomainEntity GetLearningAssignmentsMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null);

        /// <summary>
        /// List of Learning Assignments assigned to current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentsDomainEntity</returns>
        ApiResponse<LearningAssignmentsDomainEntity> GetLearningAssignmentsMeWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null);
        
        /// <summary>
        /// Get a learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>LearningModule</returns>
        LearningModule GetLearningModule (string moduleId, List<string> expand = null);

        /// <summary>
        /// Get a learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>ApiResponse of LearningModule</returns>
        ApiResponse<LearningModule> GetLearningModuleWithHttpInfo (string moduleId, List<string> expand = null);
        
        /// <summary>
        /// Get a learning module rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>LearningModuleRule</returns>
        LearningModuleRule GetLearningModuleRule (string moduleId);

        /// <summary>
        /// Get a learning module rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>ApiResponse of LearningModuleRule</returns>
        ApiResponse<LearningModuleRule> GetLearningModuleRuleWithHttpInfo (string moduleId);
        
        /// <summary>
        /// Get specific version of a published module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>LearningModule</returns>
        LearningModule GetLearningModuleVersion (string moduleId, string versionId, List<string> expand = null);

        /// <summary>
        /// Get specific version of a published module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>ApiResponse of LearningModule</returns>
        ApiResponse<LearningModule> GetLearningModuleVersionWithHttpInfo (string moduleId, string versionId, List<string> expand = null);
        
        /// <summary>
        /// Get all learning modules of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>LearningModulesDomainEntityListing</returns>
        LearningModulesDomainEntityListing GetLearningModules (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null);

        /// <summary>
        /// Get all learning modules of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>ApiResponse of LearningModulesDomainEntityListing</returns>
        ApiResponse<LearningModulesDomainEntityListing> GetLearningModulesWithHttpInfo (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null);
        
        /// <summary>
        /// Update Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>LearningAssignment</returns>
        LearningAssignment PatchLearningAssignment (string assignmentId, LearningAssignmentUpdate body = null);

        /// <summary>
        /// Update Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>ApiResponse of LearningAssignment</returns>
        ApiResponse<LearningAssignment> PatchLearningAssignmentWithHttpInfo (string assignmentId, LearningAssignmentUpdate body = null);
        
        /// <summary>
        /// Create Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>LearningAssignment</returns>
        LearningAssignment PostLearningAssignments (LearningAssignmentCreate body = null);

        /// <summary>
        /// Create Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>ApiResponse of LearningAssignment</returns>
        ApiResponse<LearningAssignment> PostLearningAssignmentsWithHttpInfo (LearningAssignmentCreate body = null);
        
        /// <summary>
        /// Retrieve aggregated assignment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>LearningAssignmentAggregateResponse</returns>
        LearningAssignmentAggregateResponse PostLearningAssignmentsAggregatesQuery (LearningAssignmentAggregateParam body);

        /// <summary>
        /// Retrieve aggregated assignment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>ApiResponse of LearningAssignmentAggregateResponse</returns>
        ApiResponse<LearningAssignmentAggregateResponse> PostLearningAssignmentsAggregatesQueryWithHttpInfo (LearningAssignmentAggregateParam body);
        
        /// <summary>
        /// Add multiple learning assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>LearningAssignmentBulkAddResponse</returns>
        LearningAssignmentBulkAddResponse PostLearningAssignmentsBulkadd (List<LearningAssignmentItem> body = null);

        /// <summary>
        /// Add multiple learning assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentBulkAddResponse</returns>
        ApiResponse<LearningAssignmentBulkAddResponse> PostLearningAssignmentsBulkaddWithHttpInfo (List<LearningAssignmentItem> body = null);
        
        /// <summary>
        /// Remove multiple Learning Assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>LearningAssignmentBulkRemoveResponse</returns>
        LearningAssignmentBulkRemoveResponse PostLearningAssignmentsBulkremove (List<string> body = null);

        /// <summary>
        /// Remove multiple Learning Assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentBulkRemoveResponse</returns>
        ApiResponse<LearningAssignmentBulkRemoveResponse> PostLearningAssignmentsBulkremoveWithHttpInfo (List<string> body = null);
        
        /// <summary>
        /// Publish a Learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>LearningModulePublishResponse</returns>
        LearningModulePublishResponse PostLearningModulePublish (string moduleId);

        /// <summary>
        /// Publish a Learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>ApiResponse of LearningModulePublishResponse</returns>
        ApiResponse<LearningModulePublishResponse> PostLearningModulePublishWithHttpInfo (string moduleId);
        
        /// <summary>
        /// Create a new learning module
        /// </summary>
        /// <remarks>
        /// This will create a new unpublished learning module with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>LearningModule</returns>
        LearningModule PostLearningModules (LearningModuleRequest body);

        /// <summary>
        /// Create a new learning module
        /// </summary>
        /// <remarks>
        /// This will create a new unpublished learning module with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>ApiResponse of LearningModule</returns>
        ApiResponse<LearningModule> PostLearningModulesWithHttpInfo (LearningModuleRequest body);
        
        /// <summary>
        /// Get users for learning module rule
        /// </summary>
        /// <remarks>
        /// This will get the users who matches the given rule.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>LearningAssignmentUserListing</returns>
        LearningAssignmentUserListing PostLearningRulesQuery (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body);

        /// <summary>
        /// Get users for learning module rule
        /// </summary>
        /// <remarks>
        /// This will get the users who matches the given rule.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>ApiResponse of LearningAssignmentUserListing</returns>
        ApiResponse<LearningAssignmentUserListing> PostLearningRulesQueryWithHttpInfo (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body);
        
        /// <summary>
        /// Update a learning module
        /// </summary>
        /// <remarks>
        /// This will update the name, description, completion time in days and inform steps for a learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>LearningModule</returns>
        LearningModule PutLearningModule (string moduleId, LearningModuleRequest body);

        /// <summary>
        /// Update a learning module
        /// </summary>
        /// <remarks>
        /// This will update the name, description, completion time in days and inform steps for a learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>ApiResponse of LearningModule</returns>
        ApiResponse<LearningModule> PutLearningModuleWithHttpInfo (string moduleId, LearningModuleRequest body);
        
        /// <summary>
        /// Update a learning module rule
        /// </summary>
        /// <remarks>
        /// This will update a learning module rule with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>LearningModuleRule</returns>
        LearningModuleRule PutLearningModuleRule (string moduleId, LearningModuleRule body);

        /// <summary>
        /// Update a learning module rule
        /// </summary>
        /// <remarks>
        /// This will update a learning module rule with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>ApiResponse of LearningModuleRule</returns>
        ApiResponse<LearningModuleRule> PutLearningModuleRuleWithHttpInfo (string moduleId, LearningModuleRule body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete a learning assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLearningAssignmentAsync (string assignmentId);

        /// <summary>
        /// Delete a learning assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLearningAssignmentAsyncWithHttpInfo (string assignmentId);
        
        /// <summary>
        /// Delete a learning module
        /// </summary>
        /// <remarks>
        /// This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLearningModuleAsync (string moduleId);

        /// <summary>
        /// Delete a learning module
        /// </summary>
        /// <remarks>
        /// This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLearningModuleAsyncWithHttpInfo (string moduleId);
        
        /// <summary>
        /// Get Learning Assignment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the assigned user of the learning assignment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>Task of LearningAssignment</returns>
        System.Threading.Tasks.Task<LearningAssignment> GetLearningAssignmentAsync (string assignmentId, List<string> expand = null);

        /// <summary>
        /// Get Learning Assignment
        /// </summary>
        /// <remarks>
        /// Permission not required if you are the assigned user of the learning assignment
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignment>> GetLearningAssignmentAsyncWithHttpInfo (string assignmentId, List<string> expand = null);
        
        /// <summary>
        /// List of Learning module Assignments
        /// </summary>
        /// <remarks>
        /// Either moduleId or user value is required
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of LearningAssignmentsDomainEntity</returns>
        System.Threading.Tasks.Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsAsync (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null);

        /// <summary>
        /// List of Learning module Assignments
        /// </summary>
        /// <remarks>
        /// Either moduleId or user value is required
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentsDomainEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignmentsDomainEntity>> GetLearningAssignmentsAsyncWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null);
        
        /// <summary>
        /// List of Learning Assignments assigned to current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of LearningAssignmentsDomainEntity</returns>
        System.Threading.Tasks.Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsMeAsync (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null);

        /// <summary>
        /// List of Learning Assignments assigned to current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentsDomainEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignmentsDomainEntity>> GetLearningAssignmentsMeAsyncWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null);
        
        /// <summary>
        /// Get a learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of LearningModule</returns>
        System.Threading.Tasks.Task<LearningModule> GetLearningModuleAsync (string moduleId, List<string> expand = null);

        /// <summary>
        /// Get a learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModule>> GetLearningModuleAsyncWithHttpInfo (string moduleId, List<string> expand = null);
        
        /// <summary>
        /// Get a learning module rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of LearningModuleRule</returns>
        System.Threading.Tasks.Task<LearningModuleRule> GetLearningModuleRuleAsync (string moduleId);

        /// <summary>
        /// Get a learning module rule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of ApiResponse (LearningModuleRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModuleRule>> GetLearningModuleRuleAsyncWithHttpInfo (string moduleId);
        
        /// <summary>
        /// Get specific version of a published module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of LearningModule</returns>
        System.Threading.Tasks.Task<LearningModule> GetLearningModuleVersionAsync (string moduleId, string versionId, List<string> expand = null);

        /// <summary>
        /// Get specific version of a published module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModule>> GetLearningModuleVersionAsyncWithHttpInfo (string moduleId, string versionId, List<string> expand = null);
        
        /// <summary>
        /// Get all learning modules of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of LearningModulesDomainEntityListing</returns>
        System.Threading.Tasks.Task<LearningModulesDomainEntityListing> GetLearningModulesAsync (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null);

        /// <summary>
        /// Get all learning modules of an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of ApiResponse (LearningModulesDomainEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModulesDomainEntityListing>> GetLearningModulesAsyncWithHttpInfo (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null);
        
        /// <summary>
        /// Update Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>Task of LearningAssignment</returns>
        System.Threading.Tasks.Task<LearningAssignment> PatchLearningAssignmentAsync (string assignmentId, LearningAssignmentUpdate body = null);

        /// <summary>
        /// Update Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignment>> PatchLearningAssignmentAsyncWithHttpInfo (string assignmentId, LearningAssignmentUpdate body = null);
        
        /// <summary>
        /// Create Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>Task of LearningAssignment</returns>
        System.Threading.Tasks.Task<LearningAssignment> PostLearningAssignmentsAsync (LearningAssignmentCreate body = null);

        /// <summary>
        /// Create Learning Assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignment>> PostLearningAssignmentsAsyncWithHttpInfo (LearningAssignmentCreate body = null);
        
        /// <summary>
        /// Retrieve aggregated assignment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of LearningAssignmentAggregateResponse</returns>
        System.Threading.Tasks.Task<LearningAssignmentAggregateResponse> PostLearningAssignmentsAggregatesQueryAsync (LearningAssignmentAggregateParam body);

        /// <summary>
        /// Retrieve aggregated assignment data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of ApiResponse (LearningAssignmentAggregateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignmentAggregateResponse>> PostLearningAssignmentsAggregatesQueryAsyncWithHttpInfo (LearningAssignmentAggregateParam body);
        
        /// <summary>
        /// Add multiple learning assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>Task of LearningAssignmentBulkAddResponse</returns>
        System.Threading.Tasks.Task<LearningAssignmentBulkAddResponse> PostLearningAssignmentsBulkaddAsync (List<LearningAssignmentItem> body = null);

        /// <summary>
        /// Add multiple learning assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentBulkAddResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignmentBulkAddResponse>> PostLearningAssignmentsBulkaddAsyncWithHttpInfo (List<LearningAssignmentItem> body = null);
        
        /// <summary>
        /// Remove multiple Learning Assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>Task of LearningAssignmentBulkRemoveResponse</returns>
        System.Threading.Tasks.Task<LearningAssignmentBulkRemoveResponse> PostLearningAssignmentsBulkremoveAsync (List<string> body = null);

        /// <summary>
        /// Remove multiple Learning Assignments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentBulkRemoveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignmentBulkRemoveResponse>> PostLearningAssignmentsBulkremoveAsyncWithHttpInfo (List<string> body = null);
        
        /// <summary>
        /// Publish a Learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of LearningModulePublishResponse</returns>
        System.Threading.Tasks.Task<LearningModulePublishResponse> PostLearningModulePublishAsync (string moduleId);

        /// <summary>
        /// Publish a Learning module
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of ApiResponse (LearningModulePublishResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModulePublishResponse>> PostLearningModulePublishAsyncWithHttpInfo (string moduleId);
        
        /// <summary>
        /// Create a new learning module
        /// </summary>
        /// <remarks>
        /// This will create a new unpublished learning module with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>Task of LearningModule</returns>
        System.Threading.Tasks.Task<LearningModule> PostLearningModulesAsync (LearningModuleRequest body);

        /// <summary>
        /// Create a new learning module
        /// </summary>
        /// <remarks>
        /// This will create a new unpublished learning module with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModule>> PostLearningModulesAsyncWithHttpInfo (LearningModuleRequest body);
        
        /// <summary>
        /// Get users for learning module rule
        /// </summary>
        /// <remarks>
        /// This will get the users who matches the given rule.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>Task of LearningAssignmentUserListing</returns>
        System.Threading.Tasks.Task<LearningAssignmentUserListing> PostLearningRulesQueryAsync (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body);

        /// <summary>
        /// Get users for learning module rule
        /// </summary>
        /// <remarks>
        /// This will get the users who matches the given rule.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>Task of ApiResponse (LearningAssignmentUserListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningAssignmentUserListing>> PostLearningRulesQueryAsyncWithHttpInfo (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body);
        
        /// <summary>
        /// Update a learning module
        /// </summary>
        /// <remarks>
        /// This will update the name, description, completion time in days and inform steps for a learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>Task of LearningModule</returns>
        System.Threading.Tasks.Task<LearningModule> PutLearningModuleAsync (string moduleId, LearningModuleRequest body);

        /// <summary>
        /// Update a learning module
        /// </summary>
        /// <remarks>
        /// This will update the name, description, completion time in days and inform steps for a learning module
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModule>> PutLearningModuleAsyncWithHttpInfo (string moduleId, LearningModuleRequest body);
        
        /// <summary>
        /// Update a learning module rule
        /// </summary>
        /// <remarks>
        /// This will update a learning module rule with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>Task of LearningModuleRule</returns>
        System.Threading.Tasks.Task<LearningModuleRule> PutLearningModuleRuleAsync (string moduleId, LearningModuleRule body);

        /// <summary>
        /// Update a learning module rule
        /// </summary>
        /// <remarks>
        /// This will update a learning module rule with the specified fields.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>Task of ApiResponse (LearningModuleRule)</returns>
        System.Threading.Tasks.Task<ApiResponse<LearningModuleRule>> PutLearningModuleRuleAsyncWithHttpInfo (string moduleId, LearningModuleRule body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LearningApi : ILearningApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LearningApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LearningApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a learning assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns></returns>
        public void DeleteLearningAssignment (string assignmentId)
        {
             DeleteLearningAssignmentWithHttpInfo(assignmentId);
        }

        /// <summary>
        /// Delete a learning assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLearningAssignmentWithHttpInfo (string assignmentId)
        { 
            // verify the required parameter 'assignmentId' is set
            if (assignmentId == null)
                throw new ApiException(400, "Missing required parameter 'assignmentId' when calling LearningApi->DeleteLearningAssignment");

            var localVarPath = "/api/v2/learning/assignments/{assignmentId}";
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
            if (assignmentId != null) localVarPathParams.Add("assignmentId", this.Configuration.ApiClient.ParameterToString(assignmentId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a learning assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLearningAssignmentAsync (string assignmentId)
        {
             await DeleteLearningAssignmentAsyncWithHttpInfo(assignmentId);

        }

        /// <summary>
        /// Delete a learning assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The Learning Assignment ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLearningAssignmentAsyncWithHttpInfo (string assignmentId)
        { 
            // verify the required parameter 'assignmentId' is set
            if (assignmentId == null)
                throw new ApiException(400, "Missing required parameter 'assignmentId' when calling LearningApi->DeleteLearningAssignment");
            

            var localVarPath = "/api/v2/learning/assignments/{assignmentId}";
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
            if (assignmentId != null) localVarPathParams.Add("assignmentId", this.Configuration.ApiClient.ParameterToString(assignmentId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a learning module This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns></returns>
        public void DeleteLearningModule (string moduleId)
        {
             DeleteLearningModuleWithHttpInfo(moduleId);
        }

        /// <summary>
        /// Delete a learning module This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLearningModuleWithHttpInfo (string moduleId)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->DeleteLearningModule");

            var localVarPath = "/api/v2/learning/modules/{moduleId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningModule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningModule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a learning module This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLearningModuleAsync (string moduleId)
        {
             await DeleteLearningModuleAsyncWithHttpInfo(moduleId);

        }

        /// <summary>
        /// Delete a learning module This will delete a learning module if it is unpublished or it will delete a published and archived learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLearningModuleAsyncWithHttpInfo (string moduleId)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->DeleteLearningModule");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningModule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLearningModule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null,
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get Learning Assignment Permission not required if you are the assigned user of the learning assignment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>LearningAssignment</returns>
        public LearningAssignment GetLearningAssignment (string assignmentId, List<string> expand = null)
        {
             ApiResponse<LearningAssignment> localVarResponse = GetLearningAssignmentWithHttpInfo(assignmentId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Learning Assignment Permission not required if you are the assigned user of the learning assignment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>ApiResponse of LearningAssignment</returns>
        public ApiResponse< LearningAssignment > GetLearningAssignmentWithHttpInfo (string assignmentId, List<string> expand = null)
        { 
            // verify the required parameter 'assignmentId' is set
            if (assignmentId == null)
                throw new ApiException(400, "Missing required parameter 'assignmentId' when calling LearningApi->GetLearningAssignment");

            var localVarPath = "/api/v2/learning/assignments/{assignmentId}";
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
            if (assignmentId != null) localVarPathParams.Add("assignmentId", this.Configuration.ApiClient.ParameterToString(assignmentId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignment>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get Learning Assignment Permission not required if you are the assigned user of the learning assignment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>Task of LearningAssignment</returns>
        public async System.Threading.Tasks.Task<LearningAssignment> GetLearningAssignmentAsync (string assignmentId, List<string> expand = null)
        {
             ApiResponse<LearningAssignment> localVarResponse = await GetLearningAssignmentAsyncWithHttpInfo(assignmentId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Learning Assignment Permission not required if you are the assigned user of the learning assignment
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="expand">Fields to expand in response (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignment>> GetLearningAssignmentAsyncWithHttpInfo (string assignmentId, List<string> expand = null)
        { 
            // verify the required parameter 'assignmentId' is set
            if (assignmentId == null)
                throw new ApiException(400, "Missing required parameter 'assignmentId' when calling LearningApi->GetLearningAssignment");
            

            var localVarPath = "/api/v2/learning/assignments/{assignmentId}";
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
            if (assignmentId != null) localVarPathParams.Add("assignmentId", this.Configuration.ApiClient.ParameterToString(assignmentId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignment>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// List of Learning module Assignments Either moduleId or user value is required
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>LearningAssignmentsDomainEntity</returns>
        public LearningAssignmentsDomainEntity GetLearningAssignments (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        {
             ApiResponse<LearningAssignmentsDomainEntity> localVarResponse = GetLearningAssignmentsWithHttpInfo(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, sortBy, userId, types, states, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of Learning module Assignments Either moduleId or user value is required
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentsDomainEntity</returns>
        public ApiResponse< LearningAssignmentsDomainEntity > GetLearningAssignmentsWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/learning/assignments";
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (states != null) states.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("states", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentsDomainEntity>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentsDomainEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentsDomainEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// List of Learning module Assignments Either moduleId or user value is required
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of LearningAssignmentsDomainEntity</returns>
        public async System.Threading.Tasks.Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsAsync (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        {
             ApiResponse<LearningAssignmentsDomainEntity> localVarResponse = await GetLearningAssignmentsAsyncWithHttpInfo(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, sortBy, userId, types, states, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of Learning module Assignments Either moduleId or user value is required
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs. (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentsDomainEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignmentsDomainEntity>> GetLearningAssignmentsAsyncWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> userId = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/learning/assignments";
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (userId != null) userId.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("userId", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (states != null) states.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("states", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentsDomainEntity>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentsDomainEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentsDomainEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// List of Learning Assignments assigned to current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>LearningAssignmentsDomainEntity</returns>
        public LearningAssignmentsDomainEntity GetLearningAssignmentsMe (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        {
             ApiResponse<LearningAssignmentsDomainEntity> localVarResponse = GetLearningAssignmentsMeWithHttpInfo(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, sortBy, types, states, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List of Learning Assignments assigned to current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentsDomainEntity</returns>
        public ApiResponse< LearningAssignmentsDomainEntity > GetLearningAssignmentsMeWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/learning/assignments/me";
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (states != null) states.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("states", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignmentsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignmentsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentsDomainEntity>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentsDomainEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentsDomainEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// List of Learning Assignments assigned to current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of LearningAssignmentsDomainEntity</returns>
        public async System.Threading.Tasks.Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsMeAsync (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        {
             ApiResponse<LearningAssignmentsDomainEntity> localVarResponse = await GetLearningAssignmentsMeAsyncWithHttpInfo(moduleId, interval, completionInterval, overdue, pageSize, pageNumber, sortOrder, sortBy, types, states, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List of Learning Assignments assigned to current user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID (optional)</param>
        /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (optional)</param>
        /// <param name="overdue">Specifies if only the non-overdue (overdue is \&quot;False\&quot;) or overdue (overdue is \&quot;True\&quot;) assignments are returned. If overdue is \&quot;Any\&quot; or if the overdue parameter is not supplied, all assignments are returned (optional, default to Any)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc) (optional, default to Desc)</param>
        /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate (optional)</param>
        /// <param name="types">Specifies the assignment types, currently not supported and will be ignored. For now, all learning assignments regardless of types will be returned (optional)</param>
        /// <param name="states">Specifies the assignment states to filter by (optional)</param>
        /// <param name="expand">Specifies the expand option for returning additional information (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentsDomainEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignmentsDomainEntity>> GetLearningAssignmentsMeAsyncWithHttpInfo (string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, List<string> types = null, List<string> states = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/learning/assignments/me";
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
            if (moduleId != null) localVarQueryParams.Add(new Tuple<string, string>("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId)));
            if (interval != null) localVarQueryParams.Add(new Tuple<string, string>("interval", this.Configuration.ApiClient.ParameterToString(interval)));
            if (completionInterval != null) localVarQueryParams.Add(new Tuple<string, string>("completionInterval", this.Configuration.ApiClient.ParameterToString(completionInterval)));
            if (overdue != null) localVarQueryParams.Add(new Tuple<string, string>("overdue", this.Configuration.ApiClient.ParameterToString(overdue)));
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (states != null) states.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("states", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignmentsMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningAssignmentsMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentsDomainEntity>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentsDomainEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentsDomainEntity)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>LearningModule</returns>
        public LearningModule GetLearningModule (string moduleId, List<string> expand = null)
        {
             ApiResponse<LearningModule> localVarResponse = GetLearningModuleWithHttpInfo(moduleId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>ApiResponse of LearningModule</returns>
        public ApiResponse< LearningModule > GetLearningModuleWithHttpInfo (string moduleId, List<string> expand = null)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->GetLearningModule");

            var localVarPath = "/api/v2/learning/modules/{moduleId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of LearningModule</returns>
        public async System.Threading.Tasks.Task<LearningModule> GetLearningModuleAsync (string moduleId, List<string> expand = null)
        {
             ApiResponse<LearningModule> localVarResponse = await GetLearningModuleAsyncWithHttpInfo(moduleId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModule>> GetLearningModuleAsyncWithHttpInfo (string moduleId, List<string> expand = null)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->GetLearningModule");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a learning module rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>LearningModuleRule</returns>
        public LearningModuleRule GetLearningModuleRule (string moduleId)
        {
             ApiResponse<LearningModuleRule> localVarResponse = GetLearningModuleRuleWithHttpInfo(moduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a learning module rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>ApiResponse of LearningModuleRule</returns>
        public ApiResponse< LearningModuleRule > GetLearningModuleRuleWithHttpInfo (string moduleId)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->GetLearningModuleRule");

            var localVarPath = "/api/v2/learning/modules/{moduleId}/rule";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModuleRule>(localVarStatusCode,
                localVarHeaders,
                (LearningModuleRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModuleRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a learning module rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of LearningModuleRule</returns>
        public async System.Threading.Tasks.Task<LearningModuleRule> GetLearningModuleRuleAsync (string moduleId)
        {
             ApiResponse<LearningModuleRule> localVarResponse = await GetLearningModuleRuleAsyncWithHttpInfo(moduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a learning module rule 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of ApiResponse (LearningModuleRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModuleRule>> GetLearningModuleRuleAsyncWithHttpInfo (string moduleId)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->GetLearningModuleRule");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}/rule";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModuleRule>(localVarStatusCode,
                localVarHeaders,
                (LearningModuleRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModuleRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get specific version of a published module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>LearningModule</returns>
        public LearningModule GetLearningModuleVersion (string moduleId, string versionId, List<string> expand = null)
        {
             ApiResponse<LearningModule> localVarResponse = GetLearningModuleVersionWithHttpInfo(moduleId, versionId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specific version of a published module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>ApiResponse of LearningModule</returns>
        public ApiResponse< LearningModule > GetLearningModuleVersionWithHttpInfo (string moduleId, string versionId, List<string> expand = null)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->GetLearningModuleVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling LearningApi->GetLearningModuleVersion");

            var localVarPath = "/api/v2/learning/modules/{moduleId}/versions/{versionId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get specific version of a published module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of LearningModule</returns>
        public async System.Threading.Tasks.Task<LearningModule> GetLearningModuleVersionAsync (string moduleId, string versionId, List<string> expand = null)
        {
             ApiResponse<LearningModule> localVarResponse = await GetLearningModuleVersionAsyncWithHttpInfo(moduleId, versionId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specific version of a published module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="versionId">The version of learning module</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModule>> GetLearningModuleVersionAsyncWithHttpInfo (string moduleId, string versionId, List<string> expand = null)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->GetLearningModuleVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling LearningApi->GetLearningModuleVersion");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}/versions/{versionId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));
            if (versionId != null) localVarPathParams.Add("versionId", this.Configuration.ApiClient.ParameterToString(versionId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleVersion: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModuleVersion: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get all learning modules of an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>LearningModulesDomainEntityListing</returns>
        public LearningModulesDomainEntityListing GetLearningModules (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null)
        {
             ApiResponse<LearningModulesDomainEntityListing> localVarResponse = GetLearningModulesWithHttpInfo(isArchived, types, pageSize, pageNumber, sortOrder, sortBy, searchTerm, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all learning modules of an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>ApiResponse of LearningModulesDomainEntityListing</returns>
        public ApiResponse< LearningModulesDomainEntityListing > GetLearningModulesWithHttpInfo (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/learning/modules";
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
            if (isArchived != null) localVarQueryParams.Add(new Tuple<string, string>("isArchived", this.Configuration.ApiClient.ParameterToString(isArchived)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (searchTerm != null) localVarQueryParams.Add(new Tuple<string, string>("searchTerm", this.Configuration.ApiClient.ParameterToString(searchTerm)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModulesDomainEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LearningModulesDomainEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModulesDomainEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get all learning modules of an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of LearningModulesDomainEntityListing</returns>
        public async System.Threading.Tasks.Task<LearningModulesDomainEntityListing> GetLearningModulesAsync (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null)
        {
             ApiResponse<LearningModulesDomainEntityListing> localVarResponse = await GetLearningModulesAsyncWithHttpInfo(isArchived, types, pageSize, pageNumber, sortOrder, sortBy, searchTerm, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all learning modules of an organization 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isArchived">Archive status (optional, default to false)</param>
        /// <param name="types">Specifies the module types. (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="searchTerm">Search Term (searchable by name) (optional)</param>
        /// <param name="expand">Fields to expand in response(case insensitive) (optional)</param>
        /// <returns>Task of ApiResponse (LearningModulesDomainEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModulesDomainEntityListing>> GetLearningModulesAsyncWithHttpInfo (bool? isArchived = null, List<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, List<string> expand = null)
        { 

            var localVarPath = "/api/v2/learning/modules";
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
            if (isArchived != null) localVarQueryParams.Add(new Tuple<string, string>("isArchived", this.Configuration.ApiClient.ParameterToString(isArchived)));
            if (types != null) types.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("types", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));
            if (sortOrder != null) localVarQueryParams.Add(new Tuple<string, string>("sortOrder", this.Configuration.ApiClient.ParameterToString(sortOrder)));
            if (sortBy != null) localVarQueryParams.Add(new Tuple<string, string>("sortBy", this.Configuration.ApiClient.ParameterToString(sortBy)));
            if (searchTerm != null) localVarQueryParams.Add(new Tuple<string, string>("searchTerm", this.Configuration.ApiClient.ParameterToString(searchTerm)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

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
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLearningModules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModulesDomainEntityListing>(localVarStatusCode,
                localVarHeaders,
                (LearningModulesDomainEntityListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModulesDomainEntityListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>LearningAssignment</returns>
        public LearningAssignment PatchLearningAssignment (string assignmentId, LearningAssignmentUpdate body = null)
        {
             ApiResponse<LearningAssignment> localVarResponse = PatchLearningAssignmentWithHttpInfo(assignmentId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>ApiResponse of LearningAssignment</returns>
        public ApiResponse< LearningAssignment > PatchLearningAssignmentWithHttpInfo (string assignmentId, LearningAssignmentUpdate body = null)
        { 
            // verify the required parameter 'assignmentId' is set
            if (assignmentId == null)
                throw new ApiException(400, "Missing required parameter 'assignmentId' when calling LearningApi->PatchLearningAssignment");

            var localVarPath = "/api/v2/learning/assignments/{assignmentId}";
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
            if (assignmentId != null) localVarPathParams.Add("assignmentId", this.Configuration.ApiClient.ParameterToString(assignmentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchLearningAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchLearningAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignment>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>Task of LearningAssignment</returns>
        public async System.Threading.Tasks.Task<LearningAssignment> PatchLearningAssignmentAsync (string assignmentId, LearningAssignmentUpdate body = null)
        {
             ApiResponse<LearningAssignment> localVarResponse = await PatchLearningAssignmentAsyncWithHttpInfo(assignmentId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assignmentId">The ID of Learning Assignment</param>
        /// <param name="body">The Learning Assignment to be updated (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignment>> PatchLearningAssignmentAsyncWithHttpInfo (string assignmentId, LearningAssignmentUpdate body = null)
        { 
            // verify the required parameter 'assignmentId' is set
            if (assignmentId == null)
                throw new ApiException(400, "Missing required parameter 'assignmentId' when calling LearningApi->PatchLearningAssignment");
            

            var localVarPath = "/api/v2/learning/assignments/{assignmentId}";
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
            if (assignmentId != null) localVarPathParams.Add("assignmentId", this.Configuration.ApiClient.ParameterToString(assignmentId));

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
                throw new ApiException (localVarStatusCode, "Error calling PatchLearningAssignment: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchLearningAssignment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignment>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>LearningAssignment</returns>
        public LearningAssignment PostLearningAssignments (LearningAssignmentCreate body = null)
        {
             ApiResponse<LearningAssignment> localVarResponse = PostLearningAssignmentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>ApiResponse of LearningAssignment</returns>
        public ApiResponse< LearningAssignment > PostLearningAssignmentsWithHttpInfo (LearningAssignmentCreate body = null)
        { 

            var localVarPath = "/api/v2/learning/assignments";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignment>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>Task of LearningAssignment</returns>
        public async System.Threading.Tasks.Task<LearningAssignment> PostLearningAssignmentsAsync (LearningAssignmentCreate body = null)
        {
             ApiResponse<LearningAssignment> localVarResponse = await PostLearningAssignmentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Learning Assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The Learning Assignment to be created (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignment>> PostLearningAssignmentsAsyncWithHttpInfo (LearningAssignmentCreate body = null)
        { 

            var localVarPath = "/api/v2/learning/assignments";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignments: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignments: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignment>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Retrieve aggregated assignment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>LearningAssignmentAggregateResponse</returns>
        public LearningAssignmentAggregateResponse PostLearningAssignmentsAggregatesQuery (LearningAssignmentAggregateParam body)
        {
             ApiResponse<LearningAssignmentAggregateResponse> localVarResponse = PostLearningAssignmentsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve aggregated assignment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>ApiResponse of LearningAssignmentAggregateResponse</returns>
        public ApiResponse< LearningAssignmentAggregateResponse > PostLearningAssignmentsAggregatesQueryWithHttpInfo (LearningAssignmentAggregateParam body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PostLearningAssignmentsAggregatesQuery");

            var localVarPath = "/api/v2/learning/assignments/aggregates/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentAggregateResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentAggregateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentAggregateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Retrieve aggregated assignment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of LearningAssignmentAggregateResponse</returns>
        public async System.Threading.Tasks.Task<LearningAssignmentAggregateResponse> PostLearningAssignmentsAggregatesQueryAsync (LearningAssignmentAggregateParam body)
        {
             ApiResponse<LearningAssignmentAggregateResponse> localVarResponse = await PostLearningAssignmentsAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve aggregated assignment data 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Aggregate Request</param>
        /// <returns>Task of ApiResponse (LearningAssignmentAggregateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignmentAggregateResponse>> PostLearningAssignmentsAggregatesQueryAsyncWithHttpInfo (LearningAssignmentAggregateParam body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PostLearningAssignmentsAggregatesQuery");
            

            var localVarPath = "/api/v2/learning/assignments/aggregates/query";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentAggregateResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentAggregateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentAggregateResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Add multiple learning assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>LearningAssignmentBulkAddResponse</returns>
        public LearningAssignmentBulkAddResponse PostLearningAssignmentsBulkadd (List<LearningAssignmentItem> body = null)
        {
             ApiResponse<LearningAssignmentBulkAddResponse> localVarResponse = PostLearningAssignmentsBulkaddWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add multiple learning assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentBulkAddResponse</returns>
        public ApiResponse< LearningAssignmentBulkAddResponse > PostLearningAssignmentsBulkaddWithHttpInfo (List<LearningAssignmentItem> body = null)
        { 

            var localVarPath = "/api/v2/learning/assignments/bulkadd";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkadd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkadd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentBulkAddResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentBulkAddResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentBulkAddResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Add multiple learning assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>Task of LearningAssignmentBulkAddResponse</returns>
        public async System.Threading.Tasks.Task<LearningAssignmentBulkAddResponse> PostLearningAssignmentsBulkaddAsync (List<LearningAssignmentItem> body = null)
        {
             ApiResponse<LearningAssignmentBulkAddResponse> localVarResponse = await PostLearningAssignmentsBulkaddAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add multiple learning assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning assignments to be created (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentBulkAddResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignmentBulkAddResponse>> PostLearningAssignmentsBulkaddAsyncWithHttpInfo (List<LearningAssignmentItem> body = null)
        { 

            var localVarPath = "/api/v2/learning/assignments/bulkadd";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkadd: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkadd: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentBulkAddResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentBulkAddResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentBulkAddResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Remove multiple Learning Assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>LearningAssignmentBulkRemoveResponse</returns>
        public LearningAssignmentBulkRemoveResponse PostLearningAssignmentsBulkremove (List<string> body = null)
        {
             ApiResponse<LearningAssignmentBulkRemoveResponse> localVarResponse = PostLearningAssignmentsBulkremoveWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove multiple Learning Assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>ApiResponse of LearningAssignmentBulkRemoveResponse</returns>
        public ApiResponse< LearningAssignmentBulkRemoveResponse > PostLearningAssignmentsBulkremoveWithHttpInfo (List<string> body = null)
        { 

            var localVarPath = "/api/v2/learning/assignments/bulkremove";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkremove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkremove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentBulkRemoveResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentBulkRemoveResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentBulkRemoveResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Remove multiple Learning Assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>Task of LearningAssignmentBulkRemoveResponse</returns>
        public async System.Threading.Tasks.Task<LearningAssignmentBulkRemoveResponse> PostLearningAssignmentsBulkremoveAsync (List<string> body = null)
        {
             ApiResponse<LearningAssignmentBulkRemoveResponse> localVarResponse = await PostLearningAssignmentsBulkremoveAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove multiple Learning Assignments 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The IDs of the learning assignments to be removed (optional)</param>
        /// <returns>Task of ApiResponse (LearningAssignmentBulkRemoveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignmentBulkRemoveResponse>> PostLearningAssignmentsBulkremoveAsyncWithHttpInfo (List<string> body = null)
        { 

            var localVarPath = "/api/v2/learning/assignments/bulkremove";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkremove: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningAssignmentsBulkremove: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentBulkRemoveResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentBulkRemoveResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentBulkRemoveResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Publish a Learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>LearningModulePublishResponse</returns>
        public LearningModulePublishResponse PostLearningModulePublish (string moduleId)
        {
             ApiResponse<LearningModulePublishResponse> localVarResponse = PostLearningModulePublishWithHttpInfo(moduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish a Learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>ApiResponse of LearningModulePublishResponse</returns>
        public ApiResponse< LearningModulePublishResponse > PostLearningModulePublishWithHttpInfo (string moduleId)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->PostLearningModulePublish");

            var localVarPath = "/api/v2/learning/modules/{moduleId}/publish";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModulePublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModulePublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModulePublishResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningModulePublishResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModulePublishResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Publish a Learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of LearningModulePublishResponse</returns>
        public async System.Threading.Tasks.Task<LearningModulePublishResponse> PostLearningModulePublishAsync (string moduleId)
        {
             ApiResponse<LearningModulePublishResponse> localVarResponse = await PostLearningModulePublishAsyncWithHttpInfo(moduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish a Learning module 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <returns>Task of ApiResponse (LearningModulePublishResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModulePublishResponse>> PostLearningModulePublishAsyncWithHttpInfo (string moduleId)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->PostLearningModulePublish");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}/publish";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModulePublish: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModulePublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModulePublishResponse>(localVarStatusCode,
                localVarHeaders,
                (LearningModulePublishResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModulePublishResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a new learning module This will create a new unpublished learning module with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>LearningModule</returns>
        public LearningModule PostLearningModules (LearningModuleRequest body)
        {
             ApiResponse<LearningModule> localVarResponse = PostLearningModulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new learning module This will create a new unpublished learning module with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>ApiResponse of LearningModule</returns>
        public ApiResponse< LearningModule > PostLearningModulesWithHttpInfo (LearningModuleRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PostLearningModules");

            var localVarPath = "/api/v2/learning/modules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a new learning module This will create a new unpublished learning module with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>Task of LearningModule</returns>
        public async System.Threading.Tasks.Task<LearningModule> PostLearningModulesAsync (LearningModuleRequest body)
        {
             ApiResponse<LearningModule> localVarResponse = await PostLearningModulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new learning module This will create a new unpublished learning module with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The learning module to be created</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModule>> PostLearningModulesAsyncWithHttpInfo (LearningModuleRequest body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PostLearningModules");
            

            var localVarPath = "/api/v2/learning/modules";
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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModules: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningModules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get users for learning module rule This will get the users who matches the given rule.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>LearningAssignmentUserListing</returns>
        public LearningAssignmentUserListing PostLearningRulesQuery (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body)
        {
             ApiResponse<LearningAssignmentUserListing> localVarResponse = PostLearningRulesQueryWithHttpInfo(pageSize, pageNumber, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get users for learning module rule This will get the users who matches the given rule.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>ApiResponse of LearningAssignmentUserListing</returns>
        public ApiResponse< LearningAssignmentUserListing > PostLearningRulesQueryWithHttpInfo (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body)
        { 
            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
                throw new ApiException(400, "Missing required parameter 'pageSize' when calling LearningApi->PostLearningRulesQuery");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling LearningApi->PostLearningRulesQuery");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PostLearningRulesQuery");

            var localVarPath = "/api/v2/learning/rules/query";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningRulesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningRulesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentUserListing>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentUserListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentUserListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get users for learning module rule This will get the users who matches the given rule.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>Task of LearningAssignmentUserListing</returns>
        public async System.Threading.Tasks.Task<LearningAssignmentUserListing> PostLearningRulesQueryAsync (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body)
        {
             ApiResponse<LearningAssignmentUserListing> localVarResponse = await PostLearningRulesQueryAsyncWithHttpInfo(pageSize, pageNumber, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get users for learning module rule This will get the users who matches the given rule.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="body">The learning module rule to fetch users</param>
        /// <returns>Task of ApiResponse (LearningAssignmentUserListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningAssignmentUserListing>> PostLearningRulesQueryAsyncWithHttpInfo (int? pageSize, int? pageNumber, LearningAssignmentUserQuery body)
        { 
            // verify the required parameter 'pageSize' is set
            if (pageSize == null)
                throw new ApiException(400, "Missing required parameter 'pageSize' when calling LearningApi->PostLearningRulesQuery");
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling LearningApi->PostLearningRulesQuery");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PostLearningRulesQuery");
            

            var localVarPath = "/api/v2/learning/rules/query";
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
            if (pageSize != null) localVarQueryParams.Add(new Tuple<string, string>("pageSize", this.Configuration.ApiClient.ParameterToString(pageSize)));
            if (pageNumber != null) localVarQueryParams.Add(new Tuple<string, string>("pageNumber", this.Configuration.ApiClient.ParameterToString(pageNumber)));

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
                throw new ApiException (localVarStatusCode, "Error calling PostLearningRulesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLearningRulesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningAssignmentUserListing>(localVarStatusCode,
                localVarHeaders,
                (LearningAssignmentUserListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningAssignmentUserListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a learning module This will update the name, description, completion time in days and inform steps for a learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>LearningModule</returns>
        public LearningModule PutLearningModule (string moduleId, LearningModuleRequest body)
        {
             ApiResponse<LearningModule> localVarResponse = PutLearningModuleWithHttpInfo(moduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a learning module This will update the name, description, completion time in days and inform steps for a learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>ApiResponse of LearningModule</returns>
        public ApiResponse< LearningModule > PutLearningModuleWithHttpInfo (string moduleId, LearningModuleRequest body)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->PutLearningModule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PutLearningModule");

            var localVarPath = "/api/v2/learning/modules/{moduleId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a learning module This will update the name, description, completion time in days and inform steps for a learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>Task of LearningModule</returns>
        public async System.Threading.Tasks.Task<LearningModule> PutLearningModuleAsync (string moduleId, LearningModuleRequest body)
        {
             ApiResponse<LearningModule> localVarResponse = await PutLearningModuleAsyncWithHttpInfo(moduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a learning module This will update the name, description, completion time in days and inform steps for a learning module
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module to be updated</param>
        /// <returns>Task of ApiResponse (LearningModule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModule>> PutLearningModuleAsyncWithHttpInfo (string moduleId, LearningModuleRequest body)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->PutLearningModule");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PutLearningModule");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModule>(localVarStatusCode,
                localVarHeaders,
                (LearningModule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Update a learning module rule This will update a learning module rule with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>LearningModuleRule</returns>
        public LearningModuleRule PutLearningModuleRule (string moduleId, LearningModuleRule body)
        {
             ApiResponse<LearningModuleRule> localVarResponse = PutLearningModuleRuleWithHttpInfo(moduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a learning module rule This will update a learning module rule with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>ApiResponse of LearningModuleRule</returns>
        public ApiResponse< LearningModuleRule > PutLearningModuleRuleWithHttpInfo (string moduleId, LearningModuleRule body)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->PutLearningModuleRule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PutLearningModuleRule");

            var localVarPath = "/api/v2/learning/modules/{moduleId}/rule";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModuleRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModuleRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModuleRule>(localVarStatusCode,
                localVarHeaders,
                (LearningModuleRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModuleRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Update a learning module rule This will update a learning module rule with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>Task of LearningModuleRule</returns>
        public async System.Threading.Tasks.Task<LearningModuleRule> PutLearningModuleRuleAsync (string moduleId, LearningModuleRule body)
        {
             ApiResponse<LearningModuleRule> localVarResponse = await PutLearningModuleRuleAsyncWithHttpInfo(moduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a learning module rule This will update a learning module rule with the specified fields.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleId">The ID of the learning module</param>
        /// <param name="body">The learning module rule to be updated</param>
        /// <returns>Task of ApiResponse (LearningModuleRule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LearningModuleRule>> PutLearningModuleRuleAsyncWithHttpInfo (string moduleId, LearningModuleRule body)
        { 
            // verify the required parameter 'moduleId' is set
            if (moduleId == null)
                throw new ApiException(400, "Missing required parameter 'moduleId' when calling LearningApi->PutLearningModuleRule");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LearningApi->PutLearningModuleRule");
            

            var localVarPath = "/api/v2/learning/modules/{moduleId}/rule";
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
            if (moduleId != null) localVarPathParams.Add("moduleId", this.Configuration.ApiClient.ParameterToString(moduleId));

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
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModuleRule: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLearningModuleRule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LearningModuleRule>(localVarStatusCode,
                localVarHeaders,
                (LearningModuleRule) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LearningModuleRule)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
