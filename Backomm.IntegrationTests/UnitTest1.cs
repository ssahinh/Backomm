using System;
using System.Net.Http;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Backomm.IntegrationTests
{
    public class UnitTest1
    {
        private readonly HttpClient _client;
        
        public UnitTest1()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }
        
        [Fact]
        public async Task Test1()
        {
            var response = await _client.GetAsync(ApiRoutes.Group.GetById.Replace("{GroupId}", "1"));
        }
    }
}