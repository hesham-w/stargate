using Microsoft.AspNetCore.Mvc.Testing;

namespace Api.Tests
{
    public class BaseTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public BaseTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }
    }
}
