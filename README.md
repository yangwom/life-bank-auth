## 1 - Crie o Serviço Gerador de Token

<details>
  <summary>Preencha função Generate() da classe TokenGenerator </summary><br />

Crie o serviço gerador de Token na pasta Services, com uma classe de responsabilidade única denominada TokenGenerator.cs.

Crie a função `Generate()`, que vai gerar um Token JWT e retornar um valor do tipo string, o Token.

Relembrando🧠: Objeto `JwtSecurityTokenHandler` pode ser de suma importância para a criação desse Serviço, juntamente com `SecurityTokenDescriptor`.

</details>

<details>
  <summary>Preencha a função AddClaims() da classe TokenGenerator </summary><br />

Na criação do Token, vai ser necessário o preenchimento das `Claims` na propriedade Subject, onde existe uma função que poderá ser chamada, no caso `AddClaims()`, onde o objeto da pessoa cliente é passado como parâmetro. 

Para preenchimento das `Claims`, considere adicionar os campos:

- Name
- Currency 
- ClientType

Os valores passados para tais declarações se encontram no objeto `Client`, os valores de `Claim` esperam uma `string`.

Para o `ClientType` considere a seguinte lógica:

- Se o valor da propriedade booleana do objeto `Client` denominada `IsCompany` for verdadeira, o valor preenchido para a `Claim` deve ser uma `string` de `ClientTypeEnum.PessoaJuridica`. Se não, deverá ser `ClientTypeEnum.PessoaFisica`.

Relembrando🧠: Essas declarações vão lhe ajudar a futuramente criar regras de autorização personalizadas baseadas nelas.

</details>

<details>
  <summary>Crie Testes Unitários para Serviço Gerador de Token</summary><br />

Utilize a classe TestTokenGenerator.cs para os testes do serviço gerador de Token 

Para garantir eficiência na geração de Token, crie testes unitários para função TestTokenGeneratorSuccess() e `TestTokenGeneratorKeysSuccess()`.

A função `TestTokenGeneratorSuccess()` deve apenas validar que o retorno do serviço gerador de Token não é vazio ou nulo.

Relembrando🧠: Nessa situação, pode-se utilizar a função `response.Should().NotBeNullOrEmpty();` da biblioteca `FluentAssertions`.

A `TestTokenGeneratorKeysSuccess()` deve verificar se o Token está realmente respeitando o formato `JWT`.

Relembrando🧠: Um token `JWT` é composto por três partes: header, payload e signature. E juntas elas formam o Token. Ah, e cada elemento é separado por um ponto.

Certifique-se de que o Token retornado tem três partes, como deveria.

De olho na dica👀: Pode ser utilizada a função `Split()` da classe String para essa verificação.
  
</details>


## 2 - Criar Endpoint Anônimo

<details>
  <summary>Criar função CreateAccountUntilFriday() da classe HomeController </summary><br />


No controlador `HomeController`, adicionar a função `CreateAccountUntilFriday()`, que, por sua vez, não precisará de autorização.

- A rota dessa função deve ser: `MessageForEveryone`.

- Deve retornar uma string com valor `Crie sua conta na Like Bank até sexta-feira!`.

- Tipo Get de requisição HTTP.

</details>

<details>
  <summary>Crie Testes para Endpoint Anônimo </summary><br />

Na classe `TestHomeController`, adicionar a função `TestMessageForEveryoneSuccess()`. 

- Utilize a função `ApiGetRequest()` da classe `WebApplication` para realização da requisição `HTTP` passando a rota requerida como parâmetro. Nesse caso, a rota será: `Home/MessageForEveryone`.

- Utilize funções da biblioteca *FluentAssertions* para validar `StatusCode` retornado da requisição à `API`. Nesse caso de sucesso, o valor deve ser `System.Net.HttpStatusCode.Ok`. 

</details>

## 3 - Criar Endpoint Autorização

<details>
  <summary>Criar função PlataformWelcome() da classe ClientController </summary><br />


No controlador `ClientController`, adicionar a função `PlataformWelcome()`, que, por sua vez, precisará de autorização.

- A rota dessa função deve ser: `PlataformWelcome`.

- Deve retornar uma string com valor `Que ótimo ter você aqui novamente, sinta-se a vontade!`.

- Tipo Get de requisição HTTP.

</details>

<details>
  <summary>Crie Testes para Endpoint com Autorização </summary><br />

Na classe `TestClientController`, adicionar a função `TestPlataformWelcomeSuccess()`. 

- Devem ser passados três parâmetros utilizando o atributo `[InlineData]`: Name, IsCompany e Currency.

- Os parâmetros passados informam:

1. Name - O nome da pessoa cliente.
2. IsCompany - Se a pessoa cliente é uma empresa ou pessoa física.
3. Currency - Qual a moeda utilizada pela pessoa física. Exemplo: Real, Dólar, Euro.

- Deve montar objeto de `Client`, utilizando parâmetros passados.

- Chamar serviço de geração de Token passando objeto de `Client`.

- Chamar função `ApiGetRequest()` da classe `WebApplication`, para realização da requisição `HTTP` passando a rota requerida como parâmetro e o Token retornado na função anterior. Nesse caso, a rota será: `Client/PlataformWelcome`.

- Utilize funções da biblioteca *FluentAssertions* para validar `StatusCode` retornado da requisição à `API`. Nesse caso de sucesso, o valor deve ser `System.Net.HttpStatusCode.OK`. 

</details>

<details>
  <summary>Crie teste de Falha em função TestPlataformWelcomeFail()</summary><br />

Na classe `TestClientController`, adicionar a função `TestPlataformWelcomeFail()`. 

- Deve passar um parâmetro utilizando o atributo `[InlineData]`: Token.

- O parâmetro passado deve ser uma string aleatória para simular um Token Inválido.

- Chamar função `ApiGetRequest()` da classe `WebApplication`, para realização da requisição `HTTP` passando a rota requerida como parâmetro e o Token passado como argumento. Nesse caso, a rota será: `Client/PlataformWelcome`.

- Utilize funções da biblioteca *FluentAssertions* para validar `StatusCode` retornado da requisição à `API`. Nesse caso de falha, o valor deve ser `System.Net.HttpStatusCode.Unauthorized`. 

</details>


## 4 - Criar Endpoint com Autorização baseada em `Claims`

<details>
  <summary>Criar função NewPromoAlert() da classe ClientController </summary><br />


No controlador `ClientController`, adicionar a função `NewPromoAlert()`, que, por sua vez, precisará de autorização.

- A rota dessa função deve ser: `NewPromoAlert`.

- Deve retornar uma string com valor `Aproveite a nova promoção da Life Bank agora mesmo!`.

- Tipo Get de requisição HTTP.

- Autorização aplicando política `NewPromo`. Para essa política, considere as seguintes regras:

1. A pessoa cliente deve ter como propriedade `Currency` a moeda `Real` ou `Peso`. O tipo utilizado para essa propriedade é um Enum denominado `CurrencyEnum`.
2. A pessoa cliente deve ser uma `Pessoa Física`, lembre-se de utilizar o Enum `ClientTypeEnum`.

Relembrando🧠: Para criação de `Policy` baseada em `Claims`, adicione a configuração na classe `Program.cs`.

</details>

<details>
  <summary>Crie Testes para Endpoint com Autorização baseada em `Claims`</summary><br />

Na classe `TestClientController`, adicionar a função `TestNewPromoAlertSuccess()`. 

- Devem ser passados três parâmetros utilizando o atributo `[InlineData]`: Name, IsCompany e Currency.

- Os parâmetros passados informam:

1. Name - O nome da pessoa cliente.
2. IsCompany - Se a pessoa cliente é uma empresa ou pessoa física.
3. Currency - Qual a moeda utilizada pela pessoa física. Exemplo: Real, Dólar, Euro.

- Nesse caso, os parâmetros passados devem seguir a política criada, ou seja, devem ser:

1. O valor do campo `IsCompany` igual a `false`. 
2. O valor de `Currency` igual a `Real` ou `Peso`.

- Deve montar objeto de `Client`, utilizando parâmetros passados.

- Chamar serviço de geração de Token passando objeto de `Client`.

- Chamar função `ApiGetRequest()` da classe `WebApplication`, para realização da requisição `HTTP` passando a rota requerida como parâmetro e o Token retornado na função anterior. Nesse caso, a rota será: `Client/NewPromoAlert`.

- Utilize funções da biblioteca *FluentAssertions* para validar `StatusCode` retornado da requisição à `API`. Nesse caso de sucesso, o valor deve ser `System.Net.HttpStatusCode.OK`. 

</details>

<details>
  <summary>Crie teste de Falha em função TestNewPromoAlertFail()</summary><br />

Na classe `TestClientController`, adicionar a função `TestNewPromoAlertFail()`. 

- Devem ser passados três parâmetros utilizando o atributo `[InlineData]`: Name, IsCompany e Currency.

- Os parâmetros passados informam:

1. Name - O nome da pessoa cliente.
2. IsCompany - Se a pessoa cliente é uma empresa ou pessoa física.
3. Currency - Qual a moeda utilizada pela pessoa física. Exemplo: Real, Dólar, Euro.

- Nesse caso, os parâmetros passados NÃO devem seguir a política criada, ou seja, não podem ser:

1. O valor do campo `IsCompany` igual a `false`. 
2. O valor de `Currency` igual a `Real` ou `Peso`.

- Deve montar objeto de `Client`, utilizando parâmetros passados.

- Chamar serviço de geração de Token passando objeto de `Client`.

- Chamar função `ApiGetRequest()` da classe `WebApplication`, para realização da requisição `HTTP` passando a rota requerida como parâmetro e o Token retornado na função anterior. Nesse caso, a rota será: `Client/NewPromoAlert`.

- Utilize funções da biblioteca *FluentAssertions* para validar `StatusCode` retornado da requisição à `API`. Nesse caso de sucesso, o valor deve ser `System.Net.HttpStatusCode.Forbidden`. 

</details>

