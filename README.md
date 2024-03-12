# SkateCompScoreboard

Bem-vindo à API de Registro de Pontuações para competições de skate, inspirada no estilo da Street League Skateboarding. Esta API permite o registro de competições, gerenciamento de competidores, registro de pontuações e muito mais.

## Tecnologias Utilizadas

- .NET 7.0
- ASP.NET Core
- Entity Framework Core para acesso a dados
- SQL Server para armazenamento de dados
- Swagger para documentação da API

## EndPoints

1. **Competição**  - `api/competitions`
2. **Competidores**  - `api/competitors`
3. **Pontuações**  - `api/scores`
4. **Rodadas**  - `api/rounds`
5. **Manobras** - `api/tricks`

## Requisitos da API 

1. **Registrar Competição**: Permitir a criação de novas competições com atributos, como data, hora, local e descrição.
2. **Gerenciar Competidores**: Capacidade de adicionar, visualizar, atualizar e remover competidores que participarão da competição.
3. **Registrar Pontuações**: Registrar as pontuações de cada competidor para cada manobra em cada rodada da competição.
4. **Visualizar Pontuações**: Visualizar as pontuações atuais de cada competidor em cada rodada, bem como a classificação geral.
5. **Gestão de Rodadas**: Capacidade de criar diferentes rodadas (classificatórias, finais, etc.) e gerenciar o fluxo da competição.
6. **Validação de Pontuações**: Implementar regras de validação para garantir que as pontuações atribuídas estejam dentro de um intervalo específico e cumpram as diretrizes da competição.
7. **Autenticação**: Implementar autenticação de usuário e autorização de acesso, para proteger os dados da competição e garantir que apenas usuários autorizados possam realizar determinadas ações na API.

## Configuração e Uso

Para executar este projeto em sua máquina local, siga as etapas abaixo:

1. **Clone o Repositório:** Use o comando `git clone` para clonar o repositório em sua máquina.
    
2. **Configuração do Banco de Dados:** Configure sua conexão com o SQL Server no arquivo `appsettings.json`.
    
3. **Migrações e Banco de Dados:** Execute `dotnet ef database update` para aplicar as migrações e criar o banco de dados.
    
4. **Executar o Projeto:** Use o comando `dotnet run` para iniciar a API. Acesse a documentação da API em `http://localhost:5000/swagger`.
    

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou relatar problemas encontrados.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).