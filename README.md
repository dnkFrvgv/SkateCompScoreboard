# SkateCompScoreboard

Bem-vindo � API de Registro de Pontua��es para competi��es de skate, inspirada no estilo da Street League Skateboarding. Esta API permite o registro de competi��es, gerenciamento de competidores, registro de pontua��es e muito mais.

## Tecnologias Utilizadas

- .NET 7.0
- ASP.NET Core
- Entity Framework Core para acesso a dados
- SQL Server para armazenamento de dados
- Swagger para documenta��o da API

## EndPoints

1. **Competi��o**  - `api/competitions`
2. **Competidores**  - `api/competitors`
3. **Pontua��es**  - `api/scores`
4. **Rodadas**  - `api/rounds`
5. **Manobras** - `api/tricks`

## Requisitos da API 

1. **Registrar Competi��o**: Permitir a cria��o de novas competi��es com atributos, como data, hora, local e descri��o.
2. **Gerenciar Competidores**: Capacidade de adicionar, visualizar, atualizar e remover competidores que participar�o da competi��o.
3. **Registrar Pontua��es**: Registrar as pontua��es de cada competidor para cada manobra em cada rodada da competi��o.
4. **Visualizar Pontua��es**: Visualizar as pontua��es atuais de cada competidor em cada rodada, bem como a classifica��o geral.
5. **Gest�o de Rodadas**: Capacidade de criar diferentes rodadas (classificat�rias, finais, etc.) e gerenciar o fluxo da competi��o.
6. **Valida��o de Pontua��es**: Implementar regras de valida��o para garantir que as pontua��es atribu�das estejam dentro de um intervalo espec�fico e cumpram as diretrizes da competi��o.
7. **Autentica��o**: Implementar autentica��o de usu�rio e autoriza��o de acesso, para proteger os dados da competi��o e garantir que apenas usu�rios autorizados possam realizar determinadas a��es na API.

## Configura��o e Uso

Para executar este projeto em sua m�quina local, siga as etapas abaixo:

1. **Clone o Reposit�rio:** Use o comando `git clone` para clonar o reposit�rio em sua m�quina.
    
2. **Configura��o do Banco de Dados:** Configure sua conex�o com o SQL Server no arquivo `appsettings.json`.
    
3. **Migra��es e Banco de Dados:** Execute `dotnet ef database update` para aplicar as migra��es e criar o banco de dados.
    
4. **Executar o Projeto:** Use o comando `dotnet run` para iniciar a API. Acesse a documenta��o da API em `http://localhost:5000/swagger`.
    

## Contribui��o

Contribui��es s�o bem-vindas! Sinta-se � vontade para enviar pull requests ou relatar problemas encontrados.

## Licen�a

Este projeto est� licenciado sob a [MIT License](LICENSE).