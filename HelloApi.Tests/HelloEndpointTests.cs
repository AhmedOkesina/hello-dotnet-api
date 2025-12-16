using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class HelloEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public HelloEndpointTests(WebApplicationFactory<Program> factory) => _factory = factory;

    [Fact]
    public async Task Hello_Returns_200()
    {
        var client = _factory.CreateClient();
        var resp = await client.GetAsync("/hello");
        Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
    }
}