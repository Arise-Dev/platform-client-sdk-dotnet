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
    public interface ISCIMApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Empty</returns>
        Empty DeleteScimUser (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> DeleteScimUserWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Empty</returns>
        Empty DeleteScimV2User (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> DeleteScimV2UserWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group GetScimGroup (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> GetScimGroupWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ScimGroupListResponse</returns>
        ScimGroupListResponse GetScimGroups (int? startIndex = null, int? count = null, string filter = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ApiResponse of ScimGroupListResponse</returns>
        ApiResponse<ScimGroupListResponse> GetScimGroupsWithHttpInfo (int? startIndex = null, int? count = null, string filter = null);
        
        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>ScimConfigResourceType</returns>
        ScimConfigResourceType GetScimResourcetype (string resourceType);

        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>ApiResponse of ScimConfigResourceType</returns>
        ApiResponse<ScimConfigResourceType> GetScimResourcetypeWithHttpInfo (string resourceType);
        
        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScimConfigResourceTypesListResponse</returns>
        ScimConfigResourceTypesListResponse GetScimResourcetypes ();

        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScimConfigResourceTypesListResponse</returns>
        ApiResponse<ScimConfigResourceTypesListResponse> GetScimResourcetypesWithHttpInfo ();
        
        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ScimServiceProviderConfig</returns>
        ScimServiceProviderConfig GetScimServiceproviderconfig (string ifNoneMatch = null);

        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ApiResponse of ScimServiceProviderConfig</returns>
        ApiResponse<ScimServiceProviderConfig> GetScimServiceproviderconfigWithHttpInfo (string ifNoneMatch = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User GetScimUser (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> GetScimUserWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ScimUserListResponse</returns>
        ScimUserListResponse GetScimUsers (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimUserListResponse</returns>
        ApiResponse<ScimUserListResponse> GetScimUsersWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group GetScimV2Group (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> GetScimV2GroupWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ScimGroupListResponse</returns>
        ScimGroupListResponse GetScimV2Groups (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimGroupListResponse</returns>
        ApiResponse<ScimGroupListResponse> GetScimV2GroupsWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>ScimConfigResourceType</returns>
        ScimConfigResourceType GetScimV2Resourcetype (string resourceType);

        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>ApiResponse of ScimConfigResourceType</returns>
        ApiResponse<ScimConfigResourceType> GetScimV2ResourcetypeWithHttpInfo (string resourceType);
        
        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScimConfigResourceTypesListResponse</returns>
        ScimConfigResourceTypesListResponse GetScimV2Resourcetypes ();

        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScimConfigResourceTypesListResponse</returns>
        ApiResponse<ScimConfigResourceTypesListResponse> GetScimV2ResourcetypesWithHttpInfo ();
        
        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ScimServiceProviderConfig</returns>
        ScimServiceProviderConfig GetScimV2Serviceproviderconfig (string ifNoneMatch = null);

        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ApiResponse of ScimServiceProviderConfig</returns>
        ApiResponse<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigWithHttpInfo (string ifNoneMatch = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User GetScimV2User (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> GetScimV2UserWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ScimUserListResponse</returns>
        ScimUserListResponse GetScimV2Users (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimUserListResponse</returns>
        ApiResponse<ScimUserListResponse> GetScimV2UsersWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PatchScimGroup (string groupId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PatchScimGroupWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PatchScimUser (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PatchScimUserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PatchScimV2Group (string groupId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PatchScimV2GroupWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PatchScimV2User (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PatchScimV2UserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PostScimUsers (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PostScimUsersWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PostScimV2Users (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PostScimV2UsersWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PutScimGroup (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PutScimGroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PutScimUser (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PutScimUserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        ScimV2Group PutScimV2Group (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        ApiResponse<ScimV2Group> PutScimV2GroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        ScimV2User PutScimV2User (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        ApiResponse<ScimV2User> PutScimV2UserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> DeleteScimUserAsync (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimUserAsyncWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> DeleteScimV2UserAsync (string userId, string ifMatch = null);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimV2UserAsyncWithHttpInfo (string userId, string ifMatch = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> GetScimGroupAsync (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimGroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ScimGroupListResponse</returns>
        System.Threading.Tasks.Task<ScimGroupListResponse> GetScimGroupsAsync (int? startIndex = null, int? count = null, string filter = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ApiResponse (ScimGroupListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimGroupListResponse>> GetScimGroupsAsyncWithHttpInfo (int? startIndex = null, int? count = null, string filter = null);
        
        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>Task of ScimConfigResourceType</returns>
        System.Threading.Tasks.Task<ScimConfigResourceType> GetScimResourcetypeAsync (string resourceType);

        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>Task of ApiResponse (ScimConfigResourceType)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceType>> GetScimResourcetypeAsyncWithHttpInfo (string resourceType);
        
        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScimConfigResourceTypesListResponse</returns>
        System.Threading.Tasks.Task<ScimConfigResourceTypesListResponse> GetScimResourcetypesAsync ();

        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScimConfigResourceTypesListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceTypesListResponse>> GetScimResourcetypesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ScimServiceProviderConfig</returns>
        System.Threading.Tasks.Task<ScimServiceProviderConfig> GetScimServiceproviderconfigAsync (string ifNoneMatch = null);

        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ApiResponse (ScimServiceProviderConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimServiceProviderConfig>> GetScimServiceproviderconfigAsyncWithHttpInfo (string ifNoneMatch = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> GetScimUserAsync (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimUserAsyncWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ScimUserListResponse</returns>
        System.Threading.Tasks.Task<ScimUserListResponse> GetScimUsersAsync (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimUserListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimUserListResponse>> GetScimUsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> GetScimV2GroupAsync (string groupId, string ifNoneMatch = null);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimV2GroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ScimGroupListResponse</returns>
        System.Threading.Tasks.Task<ScimGroupListResponse> GetScimV2GroupsAsync (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of groups
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimGroupListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimGroupListResponse>> GetScimV2GroupsAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>Task of ScimConfigResourceType</returns>
        System.Threading.Tasks.Task<ScimConfigResourceType> GetScimV2ResourcetypeAsync (string resourceType);

        /// <summary>
        /// Get a resource type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>Task of ApiResponse (ScimConfigResourceType)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceType>> GetScimV2ResourcetypeAsyncWithHttpInfo (string resourceType);
        
        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScimConfigResourceTypesListResponse</returns>
        System.Threading.Tasks.Task<ScimConfigResourceTypesListResponse> GetScimV2ResourcetypesAsync ();

        /// <summary>
        /// Get a list of resource types
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScimConfigResourceTypesListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceTypesListResponse>> GetScimV2ResourcetypesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ScimServiceProviderConfig</returns>
        System.Threading.Tasks.Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync (string ifNoneMatch = null);

        /// <summary>
        /// Get a service provider&#39;s configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ApiResponse (ScimServiceProviderConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimServiceProviderConfig>> GetScimV2ServiceproviderconfigAsyncWithHttpInfo (string ifNoneMatch = null);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> GetScimV2UserAsync (string userId, string ifNoneMatch = null);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimV2UserAsyncWithHttpInfo (string userId, string ifNoneMatch = null);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ScimUserListResponse</returns>
        System.Threading.Tasks.Task<ScimUserListResponse> GetScimV2UsersAsync (string filter, int? startIndex = null, int? count = null);

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimUserListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimUserListResponse>> GetScimV2UsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PatchScimGroupAsync (string groupId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimGroupAsyncWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PatchScimUserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimUserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PatchScimV2GroupAsync (string groupId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimV2GroupAsyncWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PatchScimV2UserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null);

        /// <summary>
        /// Modify a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimV2UserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PostScimUsersAsync (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimUsersAsyncWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PostScimV2UsersAsync (ScimV2CreateUser body);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimV2UsersAsyncWithHttpInfo (ScimV2CreateUser body);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PutScimGroupAsync (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimGroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PutScimUserAsync (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimUserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        System.Threading.Tasks.Task<ScimV2Group> PutScimV2GroupAsync (string groupId, ScimV2Group body, string ifMatch = null);

        /// <summary>
        /// Replace a group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimV2GroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null);
        
        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        System.Threading.Tasks.Task<ScimV2User> PutScimV2UserAsync (string userId, ScimV2User body, string ifMatch = null);

        /// <summary>
        /// Replace a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimV2UserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SCIMApi : ISCIMApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SCIMApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SCIMApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Empty</returns>
        public Empty DeleteScimUser (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = DeleteScimUserWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > DeleteScimUserWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> DeleteScimUserAsync (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = await DeleteScimUserAsyncWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimUserAsyncWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Empty</returns>
        public Empty DeleteScimV2User (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = DeleteScimV2UserWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > DeleteScimV2UserWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> DeleteScimV2UserAsync (string userId, string ifMatch = null)
        {
             ApiResponse<Empty> localVarResponse = await DeleteScimV2UserAsyncWithHttpInfo(userId, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> DeleteScimV2UserAsyncWithHttpInfo (string userId, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->DeleteScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group GetScimGroup (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = GetScimGroupWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > GetScimGroupWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimGroup");

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> GetScimGroupAsync (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await GetScimGroupAsyncWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimGroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimGroup");
            

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ScimGroupListResponse</returns>
        public ScimGroupListResponse GetScimGroups (int? startIndex = null, int? count = null, string filter = null)
        {
             ApiResponse<ScimGroupListResponse> localVarResponse = GetScimGroupsWithHttpInfo(startIndex, count, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>ApiResponse of ScimGroupListResponse</returns>
        public ApiResponse< ScimGroupListResponse > GetScimGroupsWithHttpInfo (int? startIndex = null, int? count = null, string filter = null)
        { 

            var localVarPath = "/api/v2/scim/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimGroupListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimGroupListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimGroupListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ScimGroupListResponse</returns>
        public async System.Threading.Tasks.Task<ScimGroupListResponse> GetScimGroupsAsync (int? startIndex = null, int? count = null, string filter = null)
        {
             ApiResponse<ScimGroupListResponse> localVarResponse = await GetScimGroupsAsyncWithHttpInfo(startIndex, count, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <param name="filter">Filters results. (optional)</param>
        /// <returns>Task of ApiResponse (ScimGroupListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimGroupListResponse>> GetScimGroupsAsyncWithHttpInfo (int? startIndex = null, int? count = null, string filter = null)
        { 

            var localVarPath = "/api/v2/scim/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimGroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimGroupListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimGroupListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimGroupListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>ScimConfigResourceType</returns>
        public ScimConfigResourceType GetScimResourcetype (string resourceType)
        {
             ApiResponse<ScimConfigResourceType> localVarResponse = GetScimResourcetypeWithHttpInfo(resourceType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>ApiResponse of ScimConfigResourceType</returns>
        public ApiResponse< ScimConfigResourceType > GetScimResourcetypeWithHttpInfo (string resourceType)
        { 
            // verify the required parameter 'resourceType' is set
            if (resourceType == null)
                throw new ApiException(400, "Missing required parameter 'resourceType' when calling SCIMApi->GetScimResourcetype");

            var localVarPath = "/api/v2/scim/resourcetypes/{resourceType}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (resourceType != null) localVarPathParams.Add("resourceType", this.Configuration.ApiClient.ParameterToString(resourceType));

            // Query params

            // Header params

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceType>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceType) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceType)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>Task of ScimConfigResourceType</returns>
        public async System.Threading.Tasks.Task<ScimConfigResourceType> GetScimResourcetypeAsync (string resourceType)
        {
             ApiResponse<ScimConfigResourceType> localVarResponse = await GetScimResourcetypeAsyncWithHttpInfo(resourceType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/resourcetypes.</param>
        /// <returns>Task of ApiResponse (ScimConfigResourceType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceType>> GetScimResourcetypeAsyncWithHttpInfo (string resourceType)
        { 
            // verify the required parameter 'resourceType' is set
            if (resourceType == null)
                throw new ApiException(400, "Missing required parameter 'resourceType' when calling SCIMApi->GetScimResourcetype");
            

            var localVarPath = "/api/v2/scim/resourcetypes/{resourceType}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (resourceType != null) localVarPathParams.Add("resourceType", this.Configuration.ApiClient.ParameterToString(resourceType));

            // Query params

            // Header params

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceType>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceType) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceType)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScimConfigResourceTypesListResponse</returns>
        public ScimConfigResourceTypesListResponse GetScimResourcetypes ()
        {
             ApiResponse<ScimConfigResourceTypesListResponse> localVarResponse = GetScimResourcetypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScimConfigResourceTypesListResponse</returns>
        public ApiResponse< ScimConfigResourceTypesListResponse > GetScimResourcetypesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/scim/resourcetypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceTypesListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceTypesListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceTypesListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScimConfigResourceTypesListResponse</returns>
        public async System.Threading.Tasks.Task<ScimConfigResourceTypesListResponse> GetScimResourcetypesAsync ()
        {
             ApiResponse<ScimConfigResourceTypesListResponse> localVarResponse = await GetScimResourcetypesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScimConfigResourceTypesListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceTypesListResponse>> GetScimResourcetypesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/scim/resourcetypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimResourcetypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceTypesListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceTypesListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceTypesListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ScimServiceProviderConfig</returns>
        public ScimServiceProviderConfig GetScimServiceproviderconfig (string ifNoneMatch = null)
        {
             ApiResponse<ScimServiceProviderConfig> localVarResponse = GetScimServiceproviderconfigWithHttpInfo(ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ApiResponse of ScimServiceProviderConfig</returns>
        public ApiResponse< ScimServiceProviderConfig > GetScimServiceproviderconfigWithHttpInfo (string ifNoneMatch = null)
        { 

            var localVarPath = "/api/v2/scim/serviceproviderconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimServiceproviderconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimServiceproviderconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimServiceProviderConfig>(localVarStatusCode,
                localVarHeaders,
                (ScimServiceProviderConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimServiceProviderConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ScimServiceProviderConfig</returns>
        public async System.Threading.Tasks.Task<ScimServiceProviderConfig> GetScimServiceproviderconfigAsync (string ifNoneMatch = null)
        {
             ApiResponse<ScimServiceProviderConfig> localVarResponse = await GetScimServiceproviderconfigAsyncWithHttpInfo(ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ApiResponse (ScimServiceProviderConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimServiceProviderConfig>> GetScimServiceproviderconfigAsyncWithHttpInfo (string ifNoneMatch = null)
        { 

            var localVarPath = "/api/v2/scim/serviceproviderconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimServiceproviderconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimServiceproviderconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimServiceProviderConfig>(localVarStatusCode,
                localVarHeaders,
                (ScimServiceProviderConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimServiceProviderConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User GetScimUser (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = GetScimUserWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > GetScimUserWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> GetScimUserAsync (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await GetScimUserAsyncWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimUserAsyncWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ScimUserListResponse</returns>
        public ScimUserListResponse GetScimUsers (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimUserListResponse> localVarResponse = GetScimUsersWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimUserListResponse</returns>
        public ApiResponse< ScimUserListResponse > GetScimUsersWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimUsers");

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimUserListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimUserListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimUserListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ScimUserListResponse</returns>
        public async System.Threading.Tasks.Task<ScimUserListResponse> GetScimUsersAsync (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimUserListResponse> localVarResponse = await GetScimUsersAsyncWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimUserListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimUserListResponse>> GetScimUsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimUsers");
            

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimUserListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimUserListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimUserListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group GetScimV2Group (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = GetScimV2GroupWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > GetScimV2GroupWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimV2Group");

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> GetScimV2GroupAsync (string groupId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await GetScimV2GroupAsyncWithHttpInfo(groupId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="ifNoneMatch">TThe ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> GetScimV2GroupAsyncWithHttpInfo (string groupId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->GetScimV2Group");
            

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ScimGroupListResponse</returns>
        public ScimGroupListResponse GetScimV2Groups (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimGroupListResponse> localVarResponse = GetScimV2GroupsWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimGroupListResponse</returns>
        public ApiResponse< ScimGroupListResponse > GetScimV2GroupsWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Groups");

            var localVarPath = "/api/v2/scim/v2/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimGroupListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimGroupListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimGroupListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ScimGroupListResponse</returns>
        public async System.Threading.Tasks.Task<ScimGroupListResponse> GetScimV2GroupsAsync (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimGroupListResponse> localVarResponse = await GetScimV2GroupsAsyncWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of groups 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimGroupListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimGroupListResponse>> GetScimV2GroupsAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Groups");
            

            var localVarPath = "/api/v2/scim/v2/groups";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Groups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimGroupListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimGroupListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimGroupListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>ScimConfigResourceType</returns>
        public ScimConfigResourceType GetScimV2Resourcetype (string resourceType)
        {
             ApiResponse<ScimConfigResourceType> localVarResponse = GetScimV2ResourcetypeWithHttpInfo(resourceType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>ApiResponse of ScimConfigResourceType</returns>
        public ApiResponse< ScimConfigResourceType > GetScimV2ResourcetypeWithHttpInfo (string resourceType)
        { 
            // verify the required parameter 'resourceType' is set
            if (resourceType == null)
                throw new ApiException(400, "Missing required parameter 'resourceType' when calling SCIMApi->GetScimV2Resourcetype");

            var localVarPath = "/api/v2/scim/v2/resourcetypes/{resourceType}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (resourceType != null) localVarPathParams.Add("resourceType", this.Configuration.ApiClient.ParameterToString(resourceType));

            // Query params

            // Header params

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceType>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceType) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceType)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>Task of ScimConfigResourceType</returns>
        public async System.Threading.Tasks.Task<ScimConfigResourceType> GetScimV2ResourcetypeAsync (string resourceType)
        {
             ApiResponse<ScimConfigResourceType> localVarResponse = await GetScimV2ResourcetypeAsyncWithHttpInfo(resourceType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a resource type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceType">The type of resource. Returned with GET /api/v2/scim/v2/resourcetypes.</param>
        /// <returns>Task of ApiResponse (ScimConfigResourceType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceType>> GetScimV2ResourcetypeAsyncWithHttpInfo (string resourceType)
        { 
            // verify the required parameter 'resourceType' is set
            if (resourceType == null)
                throw new ApiException(400, "Missing required parameter 'resourceType' when calling SCIMApi->GetScimV2Resourcetype");
            

            var localVarPath = "/api/v2/scim/v2/resourcetypes/{resourceType}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (resourceType != null) localVarPathParams.Add("resourceType", this.Configuration.ApiClient.ParameterToString(resourceType));

            // Query params

            // Header params

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetype: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceType>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceType) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceType)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ScimConfigResourceTypesListResponse</returns>
        public ScimConfigResourceTypesListResponse GetScimV2Resourcetypes ()
        {
             ApiResponse<ScimConfigResourceTypesListResponse> localVarResponse = GetScimV2ResourcetypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ScimConfigResourceTypesListResponse</returns>
        public ApiResponse< ScimConfigResourceTypesListResponse > GetScimV2ResourcetypesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/scim/v2/resourcetypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceTypesListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceTypesListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceTypesListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ScimConfigResourceTypesListResponse</returns>
        public async System.Threading.Tasks.Task<ScimConfigResourceTypesListResponse> GetScimV2ResourcetypesAsync ()
        {
             ApiResponse<ScimConfigResourceTypesListResponse> localVarResponse = await GetScimV2ResourcetypesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of resource types 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ScimConfigResourceTypesListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimConfigResourceTypesListResponse>> GetScimV2ResourcetypesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/scim/v2/resourcetypes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetypes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Resourcetypes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimConfigResourceTypesListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimConfigResourceTypesListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimConfigResourceTypesListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ScimServiceProviderConfig</returns>
        public ScimServiceProviderConfig GetScimV2Serviceproviderconfig (string ifNoneMatch = null)
        {
             ApiResponse<ScimServiceProviderConfig> localVarResponse = GetScimV2ServiceproviderconfigWithHttpInfo(ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>ApiResponse of ScimServiceProviderConfig</returns>
        public ApiResponse< ScimServiceProviderConfig > GetScimV2ServiceproviderconfigWithHttpInfo (string ifNoneMatch = null)
        { 

            var localVarPath = "/api/v2/scim/v2/serviceproviderconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimServiceProviderConfig>(localVarStatusCode,
                localVarHeaders,
                (ScimServiceProviderConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimServiceProviderConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ScimServiceProviderConfig</returns>
        public async System.Threading.Tasks.Task<ScimServiceProviderConfig> GetScimV2ServiceproviderconfigAsync (string ifNoneMatch = null)
        {
             ApiResponse<ScimServiceProviderConfig> localVarResponse = await GetScimV2ServiceproviderconfigAsyncWithHttpInfo(ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a service provider&#39;s configuration 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/serviceproviderconfig. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified.  (optional)</param>
        /// <returns>Task of ApiResponse (ScimServiceProviderConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimServiceProviderConfig>> GetScimV2ServiceproviderconfigAsyncWithHttpInfo (string ifNoneMatch = null)
        { 

            var localVarPath = "/api/v2/scim/v2/serviceproviderconfig";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // Form params
            
            // Body param

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Serviceproviderconfig: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimServiceProviderConfig>(localVarStatusCode,
                localVarHeaders,
                (ScimServiceProviderConfig) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimServiceProviderConfig)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User GetScimV2User (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = GetScimV2UserWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > GetScimV2UserWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> GetScimV2UserAsync (string userId, string ifNoneMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await GetScimV2UserAsyncWithHttpInfo(userId, ifNoneMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="ifNoneMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns the current configuration of the resource. If the ETag is current, returns 304 Not Modified. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> GetScimV2UserAsyncWithHttpInfo (string userId, string ifNoneMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->GetScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifNoneMatch != null) localVarHeaderParams.Add("If-None-Match", this.Configuration.ApiClient.ParameterToString(ifNoneMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ScimUserListResponse</returns>
        public ScimUserListResponse GetScimV2Users (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimUserListResponse> localVarResponse = GetScimV2UsersWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>ApiResponse of ScimUserListResponse</returns>
        public ApiResponse< ScimUserListResponse > GetScimV2UsersWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Users");

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimUserListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimUserListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimUserListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ScimUserListResponse</returns>
        public async System.Threading.Tasks.Task<ScimUserListResponse> GetScimV2UsersAsync (string filter, int? startIndex = null, int? count = null)
        {
             ApiResponse<ScimUserListResponse> localVarResponse = await GetScimV2UsersAsyncWithHttpInfo(filter, startIndex, count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of users 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filters results.</param>
        /// <param name="startIndex">The 1-based index of the first query result. (optional, default to 1)</param>
        /// <param name="count">The requested number of items per page. A value of 0 returns \&quot;totalResults\&quot;. (optional, default to 25)</param>
        /// <returns>Task of ApiResponse (ScimUserListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimUserListResponse>> GetScimV2UsersAsyncWithHttpInfo (string filter, int? startIndex = null, int? count = null)
        { 
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling SCIMApi->GetScimV2Users");
            

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startIndex != null) localVarQueryParams.Add(new Tuple<string, string>("startIndex", this.Configuration.ApiClient.ParameterToString(startIndex)));
            if (count != null) localVarQueryParams.Add(new Tuple<string, string>("count", this.Configuration.ApiClient.ParameterToString(count)));
            if (filter != null) localVarQueryParams.Add(new Tuple<string, string>("filter", this.Configuration.ApiClient.ParameterToString(filter)));

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
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimUserListResponse>(localVarStatusCode,
                localVarHeaders,
                (ScimUserListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimUserListResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PatchScimGroup (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PatchScimGroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PatchScimGroupWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimGroup");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimGroup");

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PatchScimGroupAsync (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PatchScimGroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimGroupAsyncWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimGroup");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimGroup");
            

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PatchScimUser (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PatchScimUserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PatchScimUserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimUser");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PatchScimUserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PatchScimUserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimUserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimUser");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PatchScimV2Group (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PatchScimV2GroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PatchScimV2GroupWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimV2Group");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2Group");

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PatchScimV2GroupAsync (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PatchScimV2GroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to modify a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PatchScimV2GroupAsyncWithHttpInfo (string groupId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PatchScimV2Group");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2Group");
            

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PatchScimV2User (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PatchScimV2UserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PatchScimV2UserWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimV2User");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PatchScimV2UserAsync (string userId, ScimV2PatchRequest body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PatchScimV2UserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Modify a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to modify a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PatchScimV2UserAsyncWithHttpInfo (string userId, ScimV2PatchRequest body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PatchScimV2User");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PatchScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PostScimUsers (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = PostScimUsersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PostScimUsersWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimUsers");

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PostScimUsersAsync (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = await PostScimUsersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimUsersAsyncWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimUsers");
            

            var localVarPath = "/api/v2/scim/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimUsers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PostScimV2Users (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = PostScimV2UsersWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PostScimV2UsersWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimV2Users");

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PostScimV2UsersAsync (ScimV2CreateUser body)
        {
             ApiResponse<ScimV2User> localVarResponse = await PostScimV2UsersAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The information used to create a user.</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PostScimV2UsersAsyncWithHttpInfo (ScimV2CreateUser body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PostScimV2Users");
            

            var localVarPath = "/api/v2/scim/v2/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
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
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostScimV2Users: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PutScimGroup (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PutScimGroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PutScimGroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimGroup");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimGroup");

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PutScimGroupAsync (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PutScimGroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimGroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimGroup");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimGroup");
            

            var localVarPath = "/api/v2/scim/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimGroup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PutScimUser (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PutScimUserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PutScimUserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimUser");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimUser");

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PutScimUserAsync (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PutScimUserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimUserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimUser");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimUser");
            

            var localVarPath = "/api/v2/scim/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2Group</returns>
        public ScimV2Group PutScimV2Group (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = PutScimV2GroupWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2Group</returns>
        public ApiResponse< ScimV2Group > PutScimV2GroupWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimV2Group");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2Group");

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2Group</returns>
        public async System.Threading.Tasks.Task<ScimV2Group> PutScimV2GroupAsync (string groupId, ScimV2Group body, string ifMatch = null)
        {
             ApiResponse<ScimV2Group> localVarResponse = await PutScimV2GroupAsyncWithHttpInfo(groupId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">The ID of a group. Returned with GET /api/v2/scim/v2/groups.</param>
        /// <param name="body">The information used to replace a group.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/groups/{groupId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2Group>> PutScimV2GroupAsyncWithHttpInfo (string groupId, ScimV2Group body, string ifMatch = null)
        { 
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling SCIMApi->PutScimV2Group");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2Group");
            

            var localVarPath = "/api/v2/scim/v2/groups/{groupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (groupId != null) localVarPathParams.Add("groupId", this.Configuration.ApiClient.ParameterToString(groupId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2Group: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2Group>(localVarStatusCode,
                localVarHeaders,
                (ScimV2Group) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2Group)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ScimV2User</returns>
        public ScimV2User PutScimV2User (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = PutScimV2UserWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>ApiResponse of ScimV2User</returns>
        public ApiResponse< ScimV2User > PutScimV2UserWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimV2User");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2User");

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ScimV2User</returns>
        public async System.Threading.Tasks.Task<ScimV2User> PutScimV2UserAsync (string userId, ScimV2User body, string ifMatch = null)
        {
             ApiResponse<ScimV2User> localVarResponse = await PutScimV2UserAsyncWithHttpInfo(userId, body, ifMatch);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of a user. Returned with GET /api/v2/scim/v2/users.</param>
        /// <param name="body">The information used to replace a user.</param>
        /// <param name="ifMatch">The ETag of a resource in double quotes. Returned as header and meta.version with initial call to GET /api/v2/scim/v2/users/{userId}. Example: \&quot;42\&quot;. If the ETag is different from the version on the server, returns 400 with a \&quot;scimType\&quot; of \&quot;invalidVers\&quot;. (optional)</param>
        /// <returns>Task of ApiResponse (ScimV2User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScimV2User>> PutScimV2UserAsyncWithHttpInfo (string userId, ScimV2User body, string ifMatch = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling SCIMApi->PutScimV2User");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling SCIMApi->PutScimV2User");
            

            var localVarPath = "/api/v2/scim/v2/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                
                "application/json", 
                
                "application/scim+json"
                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params
            if (ifMatch != null) localVarHeaderParams.Add("If-Match", this.Configuration.ApiClient.ParameterToString(ifMatch)); // header parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutScimV2User: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScimV2User>(localVarStatusCode,
                localVarHeaders,
                (ScimV2User) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScimV2User)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
