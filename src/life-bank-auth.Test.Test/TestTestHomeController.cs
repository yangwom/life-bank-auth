using Microsoft.AspNetCore.Mvc.Testing;

namespace LifeBankAuth.Test.Test;

public class TestTestHomeControllerTrait3
{
    WebApplicationFactory<Program> _factory = new WebApplicationFactory<Program>();

    [Trait("Category", "2 - Criar Endpoint Anônimo")]
    [Fact(DisplayName = "TestTestHomeController deve ser executado com sucesso")]
    public async Task TestSuccessTestTokenGeneratorSuccess()
    {
        TestHomeController instance = new(_factory);

        Func<Task> act = async () => await instance.TestMessageForEveryoneSuccess();
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}
