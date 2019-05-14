using Scopus.Api.Client.Models.Common;
using System.Threading.Tasks;

namespace Scopus.Api.Client.Interfaces
{
    public interface IApiClient
    {
        T Get<T>(string endpoint, string parameters = null) where T : HttpStatusResource;

        Task<T> GetAsync<T>(string endpoint, string parameters = null) where T : HttpStatusResource;
    }
}
