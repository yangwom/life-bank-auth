using Microsoft.AspNetCore.Mvc.Testing;

namespace LifeBankAuth.Test.Test;

public class TestTestClientControllerTrait4
{
    WebApplicationFactory<Program> _factory = new WebApplicationFactory<Program>();

    [Trait("Category", "3 - Criar Endpoint Autorização")]
    [Theory(DisplayName = "TestPlataformWelcomeSuccess deve ser executado com sucesso")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Luiz", false, CurrencyEnum.Euro)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Ricardo", false, CurrencyEnum.Dolar)]
    [InlineData("Trybe", true, CurrencyEnum.Real)]
    public async Task TestSuccessTestPlataformWelcomeSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        TestClientController instance = new(_factory);
        Func<Task> act = async () => await instance.TestPlataformWelcomeSuccess(name, isCompany, currency);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }

    [Trait("Category", "3 - Criar Endpoint Autorização")]
    [Theory(DisplayName = "TestPlataformWelcomeFail deve ser executado com sucesso")]
    [InlineData("123456789")]
    [InlineData("Teste123456")]
    [InlineData("INVALIDTOKEN")]
    public async Task TestSuccessTestPlataformWelcomeFail(string invalidToken)
    {
        TestClientController instance = new(_factory);
        Func<Task> act = async () => await instance.TestPlataformWelcomeFail(invalidToken);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}

public class TestTestClientControllerTrait6
{   
    WebApplicationFactory<Program> _factory = new WebApplicationFactory<Program>();
    
    [Trait("Category", "4 - Criar Endpoint com Autorização baseada em `Claims`")]
    [Theory(DisplayName = "TestNewPromoAlertSuccess deve ser executado com sucesso")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Geni", false, CurrencyEnum.Real)]
    [InlineData("Helena", false, CurrencyEnum.Peso)]
    public async Task TestSuccessTestNewPromoAlertSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        TestClientController2 instance = new(_factory);
        Func<Task> act = async () => await instance.TestNewPromoAlertSuccess(name, isCompany, currency);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }

    [Trait("Category", "4 - Criar Endpoint com Autorização baseada em `Claims`")]
    [Theory(DisplayName = "TestNewPromoAlertSuccess deve falhar com input de falha")]
    [InlineData("Luiz", false, CurrencyEnum.Euro)]
    [InlineData("Ricardo", false, CurrencyEnum.Dolar)]
    [InlineData("Trybe", true, CurrencyEnum.Real)]
    [InlineData("Paula", true, CurrencyEnum.Dolar)]
    public async Task TestFailTestNewPromoAlertSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        TestClientController2 instance = new(_factory);
        Func<Task> act = async () => await instance.TestNewPromoAlertSuccess(name, isCompany, currency);
        await act.Should().ThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }

    [Trait("Category", "4 - Criar Endpoint com Autorização baseada em `Claims`")]
    [Theory(DisplayName = "TestNewPromoAlertFail deve ser executado com sucesso")]
    [InlineData("Luiz", false, CurrencyEnum.Euro)]
    [InlineData("Ricardo", false, CurrencyEnum.Dolar)]
    [InlineData("Trybe", true, CurrencyEnum.Real)]
    [InlineData("Paula", true, CurrencyEnum.Dolar)]
    public async Task TestSuccessTestNewPromoAlertFail(string name, bool isCompany, CurrencyEnum currency)
    {
        TestClientController2 instance = new(_factory);
        Func<Task> act = async () => await instance.TestNewPromoAlertFail(name, isCompany, currency);
        await act.Should().NotThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }

    [Trait("Category", "4 - Criar Endpoint com Autorização baseada em `Claims`")]
    [Theory(DisplayName = "TestNewPromoAlertFail deve ser executado com sucesso")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Geni", false, CurrencyEnum.Real)]
    [InlineData("Helena", false, CurrencyEnum.Peso)]
    public async Task TestFailTestNewPromoAlertFail(string name, bool isCompany, CurrencyEnum currency)
    {
        TestClientController2 instance = new(_factory);
        Func<Task> act = async () => await instance.TestNewPromoAlertFail(name, isCompany, currency);
        await act.Should().ThrowAsync<Xunit.Sdk.XunitException>();
        await act.Should().NotThrowAsync<NotImplementedException>();
    }
}
