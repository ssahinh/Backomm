using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Data;
using Backomm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Backomm.IntegrationTests
{
    public class IntegrationTest
    {
        protected readonly HttpClient TestClient;

        public IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                    {
                        builder.ConfigureServices(services =>
                        {
                            services.RemoveAll(typeof(DataContext));
                            services.AddDbContext<DataContext>(options => { options.UseInMemoryDatabase("TestDb"); });
                        });
                    });
            TestClient = appFactory.CreateClient();
        }

        protected async Task AuthenticateAsync()
        {
            TestClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", await GetJwtAsync());
        }

        private async Task<string> GetJwtAsync()
        {
            var response = TestClient.PostAsJsonAsync(ApiRoutes.Auth.Register, new UserRegistrationRequest
            {
                Email = "test@integration.com",
                Password = "Sahin123--",
            });

            var registrationResponse = await response.Result.Content.ReadAsAsync<AuthSuccessResponse>();
            return registrationResponse.Token;
        }
    }
}