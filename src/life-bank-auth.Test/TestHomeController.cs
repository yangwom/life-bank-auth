
using Microsoft.AspNetCore.Mvc.Testing;

namespace LifeBankAuth.Test;

public class TestHomeController : IClassFixture<WebApplicationFactory<Program>>
{   
    private readonly WebApplicationFactory<Program> _factory;
    public TestHomeController(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "2 - Criar Endpoint Anônimo")]
    [Fact(DisplayName = "Teste para MessageForEveryone com Status Ok")]    
    public async Task TestMessageForEveryoneSuccess()
    {   
        throw new NotImplementedException();
    }
}
