namespace Scopus.Api.Client.Utils
{
    public static class Utilities
    {
        public static string GenerateRequestUri(string apiUrl, string endpoint, string apiKey, string parameters = null)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                return null;

             return apiUrl + endpoint + $"?apiKey={apiKey}" +(string.IsNullOrWhiteSpace(parameters) ? "" : $"&{parameters}");
        }

    }
}
