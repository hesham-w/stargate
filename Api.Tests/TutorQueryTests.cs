using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Api.Tests
{
    public class TutorQueryTests : BaseTests
    {
        private readonly HttpClient _client;

        public TutorQueryTests(WebApplicationFactory<Program> factory) : base(factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_WhenQueryIsEmpty_ShouldReturnAllTutors()
        {
            // Act
            var response = await _client.GetAsync("/Tutor");

            // Assert
            response.Should().NotBeNull();
        }
    }
}