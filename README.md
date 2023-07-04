# API Sistema de Tarefas

API para gerenciamento de tarefas por usuario

| :placard: Vitrine.Dev |     |
| -------------  | --- |
| :sparkles: Nome        | Sistema de Tarefas
| :label: Tecnologias | c#, .Net
| :rocket: URL         | 
| :fire: Desafio     | 

<!-- Inserir imagem com a #vitrinedev ao final do link -->
![](https://cdn.discordapp.com/attachments/769394667531534386/1125617033795604520/Captura_de_tela_2023-07-01_151344.png)

## Descrição do projeto

Este é um projeto de exemplo que demonstra um aplicativo web usando ASP.NET Core para realizar operações CRUD (Create, Read, Update, Delete) para tarefas e usuários. O aplicativo utiliza um banco de dados para armazenar os dados e fornece uma API para interação com o front-end.

## Tecnologias Utilizadas

- ASP.NET Core 7.0
- Entity Framework Core (EF Core)
- SQL Server (ou outro banco de dados de sua escolha)
- C#


## Pré-requisitos

- .NET Core SDK (versão 7.0 ou superior)
- SQL Server (ou outro banco de dados compatível)
- Um ambiente de desenvolvimento integrado (IDE) como Visual Studio ou Visual Studio Code


## Configuração do Banco de Dados

1. Instale o SQL Server e crie um banco de dados para o projeto.

2. Abra o arquivo `appsettings.json` na pasta raiz do projeto.

3. No arquivo `appsettings.json`, substitua a string de conexão do banco de dados pelos dados do seu banco recém-criado.


## Configuração do Projeto

1. Clone este repositório para sua máquina local.

2. Abra o projeto no seu IDE de escolha.
3. Aplique as migrações para criar as tabelas do banco de dados. No terminal, execute o seguinte comando:

    ```
    dotnet ef database update
    ```

4. Inicie o aplicativo. No terminal, execute o seguinte comando:

    ```
    dotnet run
    ```

6. Acesse a API através do navegador ou de uma ferramenta como o Postman. As rotas para interagir com as tarefas e usuários serão fornecidas pela API.


## Rotas da API

A API possui as seguintes rotas:

- GET `/api/task`: Retorna todas as tarefas.
- GET `/api/task/{id}`: Retorna uma tarefa específica pelo ID.
- POST `/api/task`: Cria uma nova tarefa.
- PUT `/api/task/{id}`: Atualiza uma tarefa existente pelo ID.
- DELETE `/api/task/{id}`: Exclui uma tarefa pelo ID.

- GET `/api/user`: Retorna todos os usuários.
- GET `/api/user/{id}`: Retorna um usuário específico pelo ID.
- POST `/api/user`: Cria um novo usuário.
- PUT `/api/user/{id}`: Atualiza um usuário existente pelo ID.
- DELETE `/api/user/{id}`: Exclui um usuário pelo ID.

## Contribuição

Contribuições são bem-vindas! Se você encontrar algum problema ou tiver sugestões, sinta-se à vontade para abrir uma issue neste repositório.

## Licença

:octocat: @pedrowill-dev
:octocat: @devlooppear

Linkedin:

@Iago Silva
@Pedro Willian
