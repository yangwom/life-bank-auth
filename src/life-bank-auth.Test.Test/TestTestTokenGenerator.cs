namespace LifeBankAuth.Test.Test;

public class TestTestTokenGeneratorTrait1
{
    [Trait("Category", "1 - Crie o Serviço Gerador de Token")]
    [Theory(DisplayName = "TestTokenGeneratorSuccess deve ser executado com sucesso")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Geni", false, CurrencyEnum.Real)]
    [InlineData("Helena", false, CurrencyEnum.Peso)]
    public void TestSuccessTestTokenGeneratorSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        Action act = () => new TestTokenGenerator().TestTokenGeneratorSuccess(name, isCompany, currency);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
    }
}

public class TestTestTokenGeneratorTrait2
{
    [Trait("Category", "1 - Crie o Serviço Gerador de Token")]
    [Theory(DisplayName = "TestTokenGeneratorKeysSuccess deve ser executado com sucesso")]
    [InlineData("Mayara", false, CurrencyEnum.Real)]
    [InlineData("Patricia", false, CurrencyEnum.Peso)]
    [InlineData("Geni", false, CurrencyEnum.Real)]
    [InlineData("Helena", false, CurrencyEnum.Peso)]
    public void TestSuccessTestTokenGeneratorKeysSuccess(string name, bool isCompany, CurrencyEnum currency)
    {
        Action act = () => new TestTokenGenerator().TestTokenGeneratorKeysSuccess(name, isCompany, currency);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
    }
}