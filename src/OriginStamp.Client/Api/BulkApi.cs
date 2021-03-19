/*
 * OriginStamp Client
 *
 * OpenAPI spec version: 3.0
 * OriginStamp Documentation: https://docs.originstamp.com
 * Contact: mail@originstamp.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using OriginStamp.Client.Client;
using OriginStamp.Client.Model;

namespace OriginStamp.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulkApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Bulk Submission
        /// </summary>
        /// <remarks>
        /// With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>List<DefaultOfTimestampResponse></returns>
        List<DefaultOfTimestampResponse> CreateBulkTimestamp (string authorization, TimestampBulkRequest timestampBulkRequest);

        /// <summary>
        /// Bulk Submission
        /// </summary>
        /// <remarks>
        /// With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>ApiResponse of List<DefaultOfTimestampResponse></returns>
        ApiResponse<List<DefaultOfTimestampResponse>> CreateBulkTimestampWithHttpInfo (string authorization, TimestampBulkRequest timestampBulkRequest);
        /// <summary>
        /// Seed Status
        /// </summary>
        /// <remarks>
        /// With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>DefaultOfTimestampData</returns>
        DefaultOfTimestampData GetSeedStatus (string authorization, string seedId);

        /// <summary>
        /// Seed Status
        /// </summary>
        /// <remarks>
        /// With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>ApiResponse of DefaultOfTimestampData</returns>
        ApiResponse<DefaultOfTimestampData> GetSeedStatusWithHttpInfo (string authorization, string seedId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Bulk Submission
        /// </summary>
        /// <remarks>
        /// With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>Task of List<DefaultOfTimestampResponse></returns>
        System.Threading.Tasks.Task<List<DefaultOfTimestampResponse>> CreateBulkTimestampAsync (string authorization, TimestampBulkRequest timestampBulkRequest);

        /// <summary>
        /// Bulk Submission
        /// </summary>
        /// <remarks>
        /// With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>Task of ApiResponse (List<DefaultOfTimestampResponse>)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DefaultOfTimestampResponse>>> CreateBulkTimestampAsyncWithHttpInfo (string authorization, TimestampBulkRequest timestampBulkRequest);
        /// <summary>
        /// Seed Status
        /// </summary>
        /// <remarks>
        /// With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>Task of DefaultOfTimestampData</returns>
        System.Threading.Tasks.Task<DefaultOfTimestampData> GetSeedStatusAsync (string authorization, string seedId);

        /// <summary>
        /// Seed Status
        /// </summary>
        /// <remarks>
        /// With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </remarks>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>Task of ApiResponse (DefaultOfTimestampData)</returns>
        System.Threading.Tasks.Task<ApiResponse<DefaultOfTimestampData>> GetSeedStatusAsyncWithHttpInfo (string authorization, string seedId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BulkApi : IBulkApi
    {
        private OriginStamp.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BulkApi(String basePath)
        {
            this.Configuration = new OriginStamp.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = OriginStamp.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BulkApi(OriginStamp.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = OriginStamp.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = OriginStamp.Client.Client.Configuration.DefaultExceptionFactory;
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
        public OriginStamp.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public OriginStamp.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Bulk Submission With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>List<DefaultOfTimestampResponse></returns>
        public List<DefaultOfTimestampResponse> CreateBulkTimestamp (string authorization, TimestampBulkRequest timestampBulkRequest)
        {
             ApiResponse<List<DefaultOfTimestampResponse>> localVarResponse = CreateBulkTimestampWithHttpInfo(authorization, timestampBulkRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk Submission With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>ApiResponse of List<DefaultOfTimestampResponse></returns>
        public ApiResponse< List<DefaultOfTimestampResponse> > CreateBulkTimestampWithHttpInfo (string authorization, TimestampBulkRequest timestampBulkRequest)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling BulkApi->CreateBulkTimestamp");
            // verify the required parameter 'timestampBulkRequest' is set
            if (timestampBulkRequest == null)
                throw new ApiException(400, "Missing required parameter 'timestampBulkRequest' when calling BulkApi->CreateBulkTimestamp");

            var localVarPath = "/v4/timestamp/bulk/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
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

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (timestampBulkRequest != null && timestampBulkRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(timestampBulkRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = timestampBulkRequest; // byte array
            }

            // authentication (API Key Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateBulkTimestamp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DefaultOfTimestampResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DefaultOfTimestampResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DefaultOfTimestampResponse>)));
        }

        /// <summary>
        /// Bulk Submission With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>Task of List<DefaultOfTimestampResponse></returns>
        public async System.Threading.Tasks.Task<List<DefaultOfTimestampResponse>> CreateBulkTimestampAsync (string authorization, TimestampBulkRequest timestampBulkRequest)
        {
             ApiResponse<List<DefaultOfTimestampResponse>> localVarResponse = await CreateBulkTimestampAsyncWithHttpInfo(authorization, timestampBulkRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk Submission With this interface you can submit multiple hashes at once. If your API key is valid, your hashes are added to seeds and scheduled for timestamping. You are also able to submit additional information with every hash, such as a comment or notification target. If the hash already exists, the &#39;created&#39; field in the response is set to &#39;false&#39; and the notification(s) of the corresponding hash will be ignored. To later query the status of any hash for a certain blockchain you can use the &#39;seed_id&#39; field of its inner timestamp structure. This field can be used to query the timestamping status of the selected seed. This is recommended if a large number of hashes were transmitted in a certain time frame. Once a hash is successfully created for a certain crypto currency, we can notify your desired target with the timestamp information (via POST Request). A webhook for a submitted hash is triggered as soon as the tamper-proof timestamp with the selected crypto currency has been created. 
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="timestampBulkRequest">DTO for the bulk hash submission. Add all relevant information concerning your hash submissions.</param>
        /// <returns>Task of ApiResponse (List<DefaultOfTimestampResponse>)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DefaultOfTimestampResponse>>> CreateBulkTimestampAsyncWithHttpInfo (string authorization, TimestampBulkRequest timestampBulkRequest)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling BulkApi->CreateBulkTimestamp");
            // verify the required parameter 'timestampBulkRequest' is set
            if (timestampBulkRequest == null)
                throw new ApiException(400, "Missing required parameter 'timestampBulkRequest' when calling BulkApi->CreateBulkTimestamp");

            var localVarPath = "/v4/timestamp/bulk/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
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

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (timestampBulkRequest != null && timestampBulkRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(timestampBulkRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = timestampBulkRequest; // byte array
            }

            // authentication (API Key Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateBulkTimestamp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DefaultOfTimestampResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DefaultOfTimestampResponse>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DefaultOfTimestampResponse>)));
        }

        /// <summary>
        /// Seed Status With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>DefaultOfTimestampData</returns>
        public DefaultOfTimestampData GetSeedStatus (string authorization, string seedId)
        {
             ApiResponse<DefaultOfTimestampData> localVarResponse = GetSeedStatusWithHttpInfo(authorization, seedId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Seed Status With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>ApiResponse of DefaultOfTimestampData</returns>
        public ApiResponse< DefaultOfTimestampData > GetSeedStatusWithHttpInfo (string authorization, string seedId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling BulkApi->GetSeedStatus");
            // verify the required parameter 'seedId' is set
            if (seedId == null)
                throw new ApiException(400, "Missing required parameter 'seedId' when calling BulkApi->GetSeedStatus");

            var localVarPath = "/v4/timestamp/status/seed/{seed_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (seedId != null) localVarPathParams.Add("seed_id", this.Configuration.ApiClient.ParameterToString(seedId)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // authentication (API Key Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSeedStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DefaultOfTimestampData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultOfTimestampData) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultOfTimestampData)));
        }

        /// <summary>
        /// Seed Status With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>Task of DefaultOfTimestampData</returns>
        public async System.Threading.Tasks.Task<DefaultOfTimestampData> GetSeedStatusAsync (string authorization, string seedId)
        {
             ApiResponse<DefaultOfTimestampData> localVarResponse = await GetSeedStatusAsyncWithHttpInfo(authorization, seedId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Seed Status With this interface you can request the status for a certain seed. This is used when checking the status of previously submitted hashes and avoids sending individual status requests for each hash.
        /// </summary>
        /// <exception cref="OriginStamp.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">A valid API key is essential for authorization to handle the request.</param>
        /// <param name="seedId">ID of the timestamp seed</param>
        /// <returns>Task of ApiResponse (DefaultOfTimestampData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DefaultOfTimestampData>> GetSeedStatusAsyncWithHttpInfo (string authorization, string seedId)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling BulkApi->GetSeedStatus");
            // verify the required parameter 'seedId' is set
            if (seedId == null)
                throw new ApiException(400, "Missing required parameter 'seedId' when calling BulkApi->GetSeedStatus");

            var localVarPath = "/v4/timestamp/status/seed/{seed_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (seedId != null) localVarPathParams.Add("seed_id", this.Configuration.ApiClient.ParameterToString(seedId)); // path parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter

            // authentication (API Key Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSeedStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DefaultOfTimestampData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DefaultOfTimestampData) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DefaultOfTimestampData)));
        }

    }
}