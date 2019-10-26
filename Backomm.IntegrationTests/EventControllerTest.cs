using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace Backomm.IntegrationTests
{
    public class EventControllerTest : IntegrationTest
    {
        [Fact]
        public async Task Event_Should_Return_Ok_With_Empty_Response_Success()
        {
            var expectedResult = string.Empty;
            var expectedStatusCode = HttpStatusCode.OK;
            
            // Arrange
            var user = AuthenticateAsync();

            var Event = new Event
            {
                About = "Event Test Integration",
            };
            var content = new StringContent(JsonConvert.SerializeObject(Event), Encoding.UTF8, "application/json");
            // Act
            var response = await TestClient.PostAsync(ApiRoutes.Event.CreateEvent, content);

            var actualStatusCode = response.StatusCode;
            var actualResult = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedStatusCode, actualStatusCode);
        }
    }
}