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
    public interface ITextbotsApi : IApiAccessor
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Issue a bot flow turn event
        /// </summary>
        /// <remarks>
        /// Send a turn event to an executing bot flow and produce the next action to take.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>TextBotFlowTurnResponse</returns>
        TextBotFlowTurnResponse PostTextbotsBotflowsSessionTurns (string sessionId, TextBotFlowTurnRequest turnRequest);

        /// <summary>
        /// Issue a bot flow turn event
        /// </summary>
        /// <remarks>
        /// Send a turn event to an executing bot flow and produce the next action to take.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>ApiResponse of TextBotFlowTurnResponse</returns>
        ApiResponse<TextBotFlowTurnResponse> PostTextbotsBotflowsSessionTurnsWithHttpInfo (string sessionId, TextBotFlowTurnRequest turnRequest);
        
        /// <summary>
        /// Create an execution instance of a bot flow definition.
        /// </summary>
        /// <remarks>
        /// The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>TextBotFlowLaunchResponse</returns>
        TextBotFlowLaunchResponse PostTextbotsBotflowsSessions (TextBotFlowLaunchRequest launchRequest);

        /// <summary>
        /// Create an execution instance of a bot flow definition.
        /// </summary>
        /// <remarks>
        /// The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>ApiResponse of TextBotFlowLaunchResponse</returns>
        ApiResponse<TextBotFlowLaunchResponse> PostTextbotsBotflowsSessionsWithHttpInfo (TextBotFlowLaunchRequest launchRequest);
        
        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text
        /// </summary>
        /// <remarks>
        /// This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>PostTextResponse</returns>
        PostTextResponse PostTextbotsBotsExecute (PostTextRequest postTextRequest);

        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text
        /// </summary>
        /// <remarks>
        /// This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>ApiResponse of PostTextResponse</returns>
        ApiResponse<PostTextResponse> PostTextbotsBotsExecuteWithHttpInfo (PostTextRequest postTextRequest);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Issue a bot flow turn event
        /// </summary>
        /// <remarks>
        /// Send a turn event to an executing bot flow and produce the next action to take.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>Task of TextBotFlowTurnResponse</returns>
        System.Threading.Tasks.Task<TextBotFlowTurnResponse> PostTextbotsBotflowsSessionTurnsAsync (string sessionId, TextBotFlowTurnRequest turnRequest);

        /// <summary>
        /// Issue a bot flow turn event
        /// </summary>
        /// <remarks>
        /// Send a turn event to an executing bot flow and produce the next action to take.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>Task of ApiResponse (TextBotFlowTurnResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextBotFlowTurnResponse>> PostTextbotsBotflowsSessionTurnsAsyncWithHttpInfo (string sessionId, TextBotFlowTurnRequest turnRequest);
        
        /// <summary>
        /// Create an execution instance of a bot flow definition.
        /// </summary>
        /// <remarks>
        /// The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>Task of TextBotFlowLaunchResponse</returns>
        System.Threading.Tasks.Task<TextBotFlowLaunchResponse> PostTextbotsBotflowsSessionsAsync (TextBotFlowLaunchRequest launchRequest);

        /// <summary>
        /// Create an execution instance of a bot flow definition.
        /// </summary>
        /// <remarks>
        /// The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>Task of ApiResponse (TextBotFlowLaunchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextBotFlowLaunchResponse>> PostTextbotsBotflowsSessionsAsyncWithHttpInfo (TextBotFlowLaunchRequest launchRequest);
        
        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text
        /// </summary>
        /// <remarks>
        /// This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>Task of PostTextResponse</returns>
        System.Threading.Tasks.Task<PostTextResponse> PostTextbotsBotsExecuteAsync (PostTextRequest postTextRequest);

        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text
        /// </summary>
        /// <remarks>
        /// This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>Task of ApiResponse (PostTextResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostTextResponse>> PostTextbotsBotsExecuteAsyncWithHttpInfo (PostTextRequest postTextRequest);
        
        #endregion Asynchronous Operations
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TextbotsApi : ITextbotsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextbotsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TextbotsApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextbotsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TextbotsApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
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
        /// Issue a bot flow turn event Send a turn event to an executing bot flow and produce the next action to take.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>TextBotFlowTurnResponse</returns>
        public TextBotFlowTurnResponse PostTextbotsBotflowsSessionTurns (string sessionId, TextBotFlowTurnRequest turnRequest)
        {
             ApiResponse<TextBotFlowTurnResponse> localVarResponse = PostTextbotsBotflowsSessionTurnsWithHttpInfo(sessionId, turnRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Issue a bot flow turn event Send a turn event to an executing bot flow and produce the next action to take.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>ApiResponse of TextBotFlowTurnResponse</returns>
        public ApiResponse< TextBotFlowTurnResponse > PostTextbotsBotflowsSessionTurnsWithHttpInfo (string sessionId, TextBotFlowTurnRequest turnRequest)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling TextbotsApi->PostTextbotsBotflowsSessionTurns");
            // verify the required parameter 'turnRequest' is set
            if (turnRequest == null)
                throw new ApiException(400, "Missing required parameter 'turnRequest' when calling TextbotsApi->PostTextbotsBotflowsSessionTurns");

            var localVarPath = "/api/v2/textbots/botflows/sessions/{sessionId}/turns";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (turnRequest != null && turnRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(turnRequest); // http body (model) parameter
            else
                localVarPostBody = turnRequest; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessionTurns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessionTurns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TextBotFlowTurnResponse>(localVarStatusCode,
                localVarHeaders,
                (TextBotFlowTurnResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TextBotFlowTurnResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Issue a bot flow turn event Send a turn event to an executing bot flow and produce the next action to take.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>Task of TextBotFlowTurnResponse</returns>
        public async System.Threading.Tasks.Task<TextBotFlowTurnResponse> PostTextbotsBotflowsSessionTurnsAsync (string sessionId, TextBotFlowTurnRequest turnRequest)
        {
             ApiResponse<TextBotFlowTurnResponse> localVarResponse = await PostTextbotsBotflowsSessionTurnsAsyncWithHttpInfo(sessionId, turnRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Issue a bot flow turn event Send a turn event to an executing bot flow and produce the next action to take.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId">The bot flow session ID, typically obtained from &#39;POST /api/v2/textbots/botflows/sessions&#39;</param>
        /// <param name="turnRequest"></param>
        /// <returns>Task of ApiResponse (TextBotFlowTurnResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextBotFlowTurnResponse>> PostTextbotsBotflowsSessionTurnsAsyncWithHttpInfo (string sessionId, TextBotFlowTurnRequest turnRequest)
        { 
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling TextbotsApi->PostTextbotsBotflowsSessionTurns");
            
            // verify the required parameter 'turnRequest' is set
            if (turnRequest == null)
                throw new ApiException(400, "Missing required parameter 'turnRequest' when calling TextbotsApi->PostTextbotsBotflowsSessionTurns");
            

            var localVarPath = "/api/v2/textbots/botflows/sessions/{sessionId}/turns";
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
            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (turnRequest != null && turnRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(turnRequest); // http body (model) parameter
            else
                localVarPostBody = turnRequest; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessionTurns: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessionTurns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TextBotFlowTurnResponse>(localVarStatusCode,
                localVarHeaders,
                (TextBotFlowTurnResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TextBotFlowTurnResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Create an execution instance of a bot flow definition. The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>TextBotFlowLaunchResponse</returns>
        public TextBotFlowLaunchResponse PostTextbotsBotflowsSessions (TextBotFlowLaunchRequest launchRequest)
        {
             ApiResponse<TextBotFlowLaunchResponse> localVarResponse = PostTextbotsBotflowsSessionsWithHttpInfo(launchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an execution instance of a bot flow definition. The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>ApiResponse of TextBotFlowLaunchResponse</returns>
        public ApiResponse< TextBotFlowLaunchResponse > PostTextbotsBotflowsSessionsWithHttpInfo (TextBotFlowLaunchRequest launchRequest)
        { 
            // verify the required parameter 'launchRequest' is set
            if (launchRequest == null)
                throw new ApiException(400, "Missing required parameter 'launchRequest' when calling TextbotsApi->PostTextbotsBotflowsSessions");

            var localVarPath = "/api/v2/textbots/botflows/sessions";
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
            if (launchRequest != null && launchRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(launchRequest); // http body (model) parameter
            else
                localVarPostBody = launchRequest; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TextBotFlowLaunchResponse>(localVarStatusCode,
                localVarHeaders,
                (TextBotFlowLaunchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TextBotFlowLaunchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Create an execution instance of a bot flow definition. The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>Task of TextBotFlowLaunchResponse</returns>
        public async System.Threading.Tasks.Task<TextBotFlowLaunchResponse> PostTextbotsBotflowsSessionsAsync (TextBotFlowLaunchRequest launchRequest)
        {
             ApiResponse<TextBotFlowLaunchResponse> localVarResponse = await PostTextbotsBotflowsSessionsAsyncWithHttpInfo(launchRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an execution instance of a bot flow definition. The launch is asynchronous; use the returned instance ID to post turns to it using &#39;POST /api/v2/textbots/botflows/sessions/{sessionId}/turns&#39;.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="launchRequest"></param>
        /// <returns>Task of ApiResponse (TextBotFlowLaunchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextBotFlowLaunchResponse>> PostTextbotsBotflowsSessionsAsyncWithHttpInfo (TextBotFlowLaunchRequest launchRequest)
        { 
            // verify the required parameter 'launchRequest' is set
            if (launchRequest == null)
                throw new ApiException(400, "Missing required parameter 'launchRequest' when calling TextbotsApi->PostTextbotsBotflowsSessions");
            

            var localVarPath = "/api/v2/textbots/botflows/sessions";
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
            if (launchRequest != null && launchRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(launchRequest); // http body (model) parameter
            else
                localVarPostBody = launchRequest; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotflowsSessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TextBotFlowLaunchResponse>(localVarStatusCode,
                localVarHeaders,
                (TextBotFlowLaunchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TextBotFlowLaunchResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>PostTextResponse</returns>
        public PostTextResponse PostTextbotsBotsExecute (PostTextRequest postTextRequest)
        {
             ApiResponse<PostTextResponse> localVarResponse = PostTextbotsBotsExecuteWithHttpInfo(postTextRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>ApiResponse of PostTextResponse</returns>
        public ApiResponse< PostTextResponse > PostTextbotsBotsExecuteWithHttpInfo (PostTextRequest postTextRequest)
        { 
            // verify the required parameter 'postTextRequest' is set
            if (postTextRequest == null)
                throw new ApiException(400, "Missing required parameter 'postTextRequest' when calling TextbotsApi->PostTextbotsBotsExecute");

            var localVarPath = "/api/v2/textbots/bots/execute";
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
            if (postTextRequest != null && postTextRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(postTextRequest); // http body (model) parameter
            else
                localVarPostBody = postTextRequest; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotsExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotsExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostTextResponse>(localVarStatusCode,
                localVarHeaders,
                (PostTextResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostTextResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>Task of PostTextResponse</returns>
        public async System.Threading.Tasks.Task<PostTextResponse> PostTextbotsBotsExecuteAsync (PostTextRequest postTextRequest)
        {
             ApiResponse<PostTextResponse> localVarResponse = await PostTextbotsBotsExecuteAsyncWithHttpInfo(postTextRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an intent to a bot to start a dialog/interact with it via text This will either start a bot with the given id or relay a communication to an existing bot session.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postTextRequest"></param>
        /// <returns>Task of ApiResponse (PostTextResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostTextResponse>> PostTextbotsBotsExecuteAsyncWithHttpInfo (PostTextRequest postTextRequest)
        { 
            // verify the required parameter 'postTextRequest' is set
            if (postTextRequest == null)
                throw new ApiException(400, "Missing required parameter 'postTextRequest' when calling TextbotsApi->PostTextbotsBotsExecute");
            

            var localVarPath = "/api/v2/textbots/bots/execute";
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
            if (postTextRequest != null && postTextRequest.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(postTextRequest); // http body (model) parameter
            else
                localVarPostBody = postTextRequest; // byte array
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotsExecute: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostTextbotsBotsExecute: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PostTextResponse>(localVarStatusCode,
                localVarHeaders,
                (PostTextResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PostTextResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }

        
        
    }
    
}
