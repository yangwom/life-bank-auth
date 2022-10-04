# Boas-vindas ao repositório do Projeto `Life Bank Auth`

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project/project-life-bank-auth.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project/project-life-bank-auth`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-0x-project/project-life-bank-auth`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-0x-project/project-life-bank-auth`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project/project-life-bank-auth/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project/project-life-bank-auth/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um vídeo explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Olá, Tryber! Você foi a pessoa desenvolvedora escolhida para criar um serviço para um dos clientes da Trybe, a `Life Bank`, um banco digital que vem crescendo exponencialmente com o passar dos anos. 

Essa é uma responsabilidade muito grande, e atualmente muitos de seus serviços estão criados em `.NET` utilizando `C#`. A base desse serviço que foi solicitado é a realização de uma `WEB API` que possua algumas rotas com autorização, outras com autorização baseada em `Claims` e também rotas anônimas. 

A autenticação deve ser realizada utilizando o método `JWT`, ou seja, um Token deve ser retornado para realização de requisições futuras com autorizações.

Uma de nossas pessoas analistas já levantou os requisitos com o time da `Life Bank`, então, se atente aos detalhes e um ótimo desenvolvimento!
 
## Configurações de Projeto

<details>
  <summary>Adicione as configurações necessárias para trabalhar com autenticação e autorização na aplicação </summary><br />

Os pacotes necessários já estão inclusos no arquivo de configuração de projeto no diretório `life-bank-auth`.

`life-bank-auth.csproj`:

```csharp
    <PackageReference Include="Microsoft.AspNetCore.Authentication" Version="2.2.0" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.6" />
```

Porém, para utilização desses processos, é necessário realizar algumas configurações na classe `Program.cs`.

- Preenchimento do segredo `JWT` para preenchimento da chave `Signature`.
- Comando para uso de Autenticação.
- Comando para uso de Autorização.

Vai haver comentários indicando a localização de cada preenchimento no código.
  
</details>

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
  <summary>Testes Unitários para Serviço Gerador de Token</summary><br />

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
  <summary>Criar Testes para Endpoint Anônimo </summary><br />

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
  <summary>Criar Testes para Endpoint com Autorização </summary><br />

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
  <summary>Criar teste de Falha em função TestPlataformWelcomeFail()</summary><br />

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
  <summary>Criar Testes para Endpoint com Autorização baseada em `Claims`</summary><br />

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
  <summary>Criar teste de Falha em função TestNewPromoAlertFail()</summary><br />

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

