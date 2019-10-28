using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;
using Xunit;

namespace Backomm.IntegrationTests
{
    public class EventControllerTest : IntegrationTest
    {
        [Fact]
        public async Task Event_Should_Return_Ok_With_Empty_Response_Success()
        {
            // Arrange
            var user = AuthenticateAsync();
            // Act
            var response = await TestClient.GetAsync(ApiRoutes.Event.Get);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}