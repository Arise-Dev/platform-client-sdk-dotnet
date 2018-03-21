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
    public interface IObjectsApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>int?</returns>
        int? GetAuthorizationDivisionsLimit ();

        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of int?</returns>
        ApiResponse<int?> GetAuthorizationDivisionsLimitWithHttpInfo ();
        
        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>List&lt;AuthzTypedObject&gt;</returns>
        List<AuthzTypedObject> PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body);

        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>ApiResponse of List&lt;AuthzTypedObject&gt;</returns>
        ApiResponse<List<AuthzTypedObject>> PostAuthorizationDivisionObjectWithHttpInfo (string divisionId, string objectType, List<string> body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of int?</returns>
        System.Threading.Tasks.Task<int?> GetAuthorizationDivisionsLimitAsync ();

        /// <summary>
        /// Returns the maximum allowed number of divisions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (int?)</returns>
        System.Threading.Tasks.Task<ApiResponse<int?>> GetAuthorizationDivisionsLimitAsyncWithHttpInfo ();
        
        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of List&lt;AuthzTypedObject&gt;</returns>
        System.Threading.Tasks.Task<List<AuthzTypedObject>> PostAuthorizationDivisionObjectAsync (string divisionId, string objectType, List<string> body);

        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of ApiResponse (List&lt;AuthzTypedObject&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AuthzTypedObject>>> PostAuthorizationDivisionObjectAsyncWithHttpInfo (string divisionId, string objectType, List<string> body);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectsApi : IObjectsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Returns the maximum allowed number of divisions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>int?</returns>
        public int? GetAuthorizationDivisionsLimit ()
        {
             ApiResponse<int?> localVarResponse = GetAuthorizationDivisionsLimitWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of int?</returns>
        public ApiResponse< int? > GetAuthorizationDivisionsLimitWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/divisions/limit";
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

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<int?>(localVarStatusCode,
                localVarHeaders,
                (int?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        
        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of int?</returns>
        public async System.Threading.Tasks.Task<int?> GetAuthorizationDivisionsLimitAsync ()
        {
             ApiResponse<int?> localVarResponse = await GetAuthorizationDivisionsLimitAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the maximum allowed number of divisions. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (int?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<int?>> GetAuthorizationDivisionsLimitAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/authorization/divisions/limit";
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

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAuthorizationDivisionsLimit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<int?>(localVarStatusCode,
                localVarHeaders,
                (int?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(int?)));
            
        }

        
        
        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>List&lt;AuthzTypedObject&gt;</returns>
        public List<AuthzTypedObject> PostAuthorizationDivisionObject (string divisionId, string objectType, List<string> body)
        {
             ApiResponse<List<AuthzTypedObject>> localVarResponse = PostAuthorizationDivisionObjectWithHttpInfo(divisionId, objectType, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>ApiResponse of List&lt;AuthzTypedObject&gt;</returns>
        public ApiResponse< List<AuthzTypedObject> > PostAuthorizationDivisionObjectWithHttpInfo (string divisionId, string objectType, List<string> body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling ObjectsApi->PostAuthorizationDivisionObject");
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ObjectsApi->PostAuthorizationDivisionObject");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ObjectsApi->PostAuthorizationDivisionObject");

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/objects/{objectType}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (objectType != null) localVarPathParams.Add("objectType", this.Configuration.ApiClient.ParameterToString(objectType));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AuthzTypedObject>>(localVarStatusCode,
                localVarHeaders,
                (List<AuthzTypedObject>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AuthzTypedObject>)));
            
        }

        
        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of List&lt;AuthzTypedObject&gt;</returns>
        public async System.Threading.Tasks.Task<List<AuthzTypedObject>> PostAuthorizationDivisionObjectAsync (string divisionId, string objectType, List<string> body)
        {
             ApiResponse<List<AuthzTypedObject>> localVarResponse = await PostAuthorizationDivisionObjectAsyncWithHttpInfo(divisionId, objectType, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set the division of a list of objects. The objects must all be of the same type: CAMPAIGN, CONTACTLIST, DNCLIST, MANAGEMENTUNIT, FLOW, QUEUE, USER 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="divisionId">Division ID</param>
        /// <param name="objectType">The type of the objects. Must be one of the valid object types</param>
        /// <param name="body">Object Id List</param>
        /// <returns>Task of ApiResponse (List&lt;AuthzTypedObject&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AuthzTypedObject>>> PostAuthorizationDivisionObjectAsyncWithHttpInfo (string divisionId, string objectType, List<string> body)
        { 
            // verify the required parameter 'divisionId' is set
            if (divisionId == null)
                throw new ApiException(400, "Missing required parameter 'divisionId' when calling ObjectsApi->PostAuthorizationDivisionObject");
            
            // verify the required parameter 'objectType' is set
            if (objectType == null)
                throw new ApiException(400, "Missing required parameter 'objectType' when calling ObjectsApi->PostAuthorizationDivisionObject");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ObjectsApi->PostAuthorizationDivisionObject");
            

            var localVarPath = "/api/v2/authorization/divisions/{divisionId}/objects/{objectType}";
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
            if (divisionId != null) localVarPathParams.Add("divisionId", this.Configuration.ApiClient.ParameterToString(divisionId));
            if (objectType != null) localVarPathParams.Add("objectType", this.Configuration.ApiClient.ParameterToString(objectType));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array
            

            
            // authentication (PureCloud Auth) required
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
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAuthorizationDivisionObject: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<AuthzTypedObject>>(localVarStatusCode,
                localVarHeaders,
                (List<AuthzTypedObject>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AuthzTypedObject>)));
            
        }

        
        
    }
    
}
