using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Models;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Backomm.IntegrationTests
{
    public class GroupControllerTest : IntegrationTest
    {
        [Fact]
        public async Task GetAll_WithoutAnyGroup_ReturnsEmptyResponse()
        {
            // Arrange
            await AuthenticateAsync();

            // Act
            var response = await TestClient.GetAsync(ApiRoutes.Group.Get);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            (await response.Content.ReadAsAsync<List<Group>>()).Should().BeEmpty();
        }

        
    }
}