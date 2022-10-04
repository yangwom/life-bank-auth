using LifeBankAuth.Models;
using LifeBankAuth.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Headers;

namespace LifeBankAuth.Test;

public class TestClientController : LifeBankConfiguration, IClassFixture<WebApplicationFactory<Program>>
{   
    private readonly WebApplicationFactory<Program> _factory;
    private const string controllerName = "client";

    public TestClientController(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "3 - Criar Endpoint Autorização")]
    [Theory(DisplayName = "Teste para PlataformWelcome com Status Ok")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Luiz", false, CurrencyEnum.Euro)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Ricardo", false, CurrencyEnum.Dolar)]
    [InlineData("Trybe", true, CurrencyEnum.Real)]
    public async Task TestPlataformWelcomeSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        throw new NotImplementedException();
    }

    [Trait("Category", "3 - Criar Endpoint Autorização")]
    [Theory(DisplayName = "Teste para PlataformWelcome com Status Unauthorized")]
    [InlineData("123456789")]
    [InlineData("Teste123456")]
    [InlineData("INVALIDTOKEN")]

    public async Task TestPlataformWelcomeFail(string invalidToken)
    {   
        throw new NotImplementedException();
    }
}
public class TestClientController2 : LifeBankConfiguration, IClassFixture<WebApplicationFactory<Program>>
{   
    private readonly WebApplicationFactory<Program> _factory;
    private const string controllerName = "client";

    public TestClientController2(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "4 - Criar Endpoint com Autorização baseada em Claims")]
    [Theory(DisplayName = "Teste para NewPromoAlert com Status Ok")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Geni", false, CurrencyEnum.Real)]
    [InlineData("Helena", false, CurrencyEnum.Peso)]
    public async Task TestNewPromoAlertSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        throw new NotImplementedException();
    }

    [Trait("Category", "4 - Criar Endpoint com Autorização baseada em Claims")]
    [Theory(DisplayName = "Teste para NewPromoAlert com Status Forbidden")]
    [InlineData("Luiz", false, CurrencyEnum.Euro)]
    [InlineData("Ricardo", false, CurrencyEnum.Dolar)]
    [InlineData("Trybe", true, CurrencyEnum.Real)]
    [InlineData("Paula", true, CurrencyEnum.Dolar)]
    public async Task TestNewPromoAlertFail(string name, bool isCompany, CurrencyEnum currency)
    {
        throw new NotImplementedException();
    }
}
