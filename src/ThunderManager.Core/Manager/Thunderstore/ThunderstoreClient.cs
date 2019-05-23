using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using ThunderManager.Core.Manager.Thunderstore.Models;

namespace ThunderManager.Core.Manager.Thunderstore
{
    public class ThunderstoreClient : IDisposable
    {
        private const string BaseUrl = "https://thunderstore.io/api/";
        private const string EndpointPackages = "v1/package/";

        private readonly FlurlClient _client;

        public ThunderstoreClient()
        {
            _client = new FlurlClient(BaseUrl);
            _client.WithHeader("User-Agent", "github.com/AeonLucid/ThunderManager");
        }

        public async Task<ModPackage> GetPackageAsync(Guid uuid)
        {
            return await EndpointPackages
                .AppendPathSegment(uuid.ToString())
                .WithClient(_client)
                .GetJsonAsync<ModPackage>();
        }

        public async Task<List<ModPackage>> GetPackagesAsync()
        {
            return await EndpointPackages
                .WithClient(_client)
                .GetJsonAsync<List<ModPackage>>();
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
