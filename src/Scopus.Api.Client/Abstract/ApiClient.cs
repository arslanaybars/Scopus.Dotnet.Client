using Newtonsoft.Json;
using Scopus.Api.Client.Interfaces;
using Scopus.Api.Client.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Scopus.Api.Client.Abstract
{
    /// <summary>
    /// Abstract api client to be used in domains
    /// </summary>
    public abstract class ApiClient : IApiClient
    {
        /// <summary>
        /// API url.
        /// </summary>
        public readonly string _apiUrl = "";

        /// <summary>
        /// API key.
        /// </summary>
        public readonly string _apiKey = "";

        /// <summary>
        /// HttpClient to be used to call the API.
        /// </summary>
        public readonly HttpClient _httpClient;

        public ApiClient(string apiUrl, string apiKey)
        {
            _apiUrl = apiUrl;
            _apiKey = apiKey;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_apiUrl)
            };
        }

        public T Get<T>(string endpoint, string parameters = null)
        {
            return GetAsync<T>(Utilities.GenerateRequestUri(_apiUrl, endpoint, _apiKey, parameters)).GetAwaiter().GetResult();
        }

        public async Task<T> GetAsync<T>(string endpoint, string parameters = null)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(Utilities.GenerateRequestUri(_apiUrl, endpoint, _apiKey, parameters));
            string strContent = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(strContent);
        }
    }
}
