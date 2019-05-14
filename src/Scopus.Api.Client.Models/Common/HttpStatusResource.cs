using System.Net;

namespace Scopus.Api.Client.Models.Common
{
    public class HttpStatusResource
    {
        public HttpStatusCode StatusCode { get; set; }

        public bool IsSuccessStatusCode { get; set; }
    }
}
