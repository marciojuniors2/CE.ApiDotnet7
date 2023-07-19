# Cars.ApiDotnet7


## Vídeo do Projeto 
[![Assista ao vídeo](LINK_DA_IMAGEM)](https://onedrive.live.com/?authkey=%21AFRtWLW1DfiSO6U&cid=4C95F0AB64BF596D&id=4C95F0AB64BF596D%21197&parId=root&o=OneUp)

## Tecnologias Utilizadas
- .NET 7
- Entity Framework Core
- AutoMapper
- Fluent Validation
- JWT (JSON Web Tokens)
- SQL Server

## Pré-requisitos
Antes de executar o projeto, certifique-se de ter instalado os seguintes componentes:

- SDK .NET 7: [Download do .NET 7](link_para_o_download_dotnet_7)
- SQL Server: [Download do SQL Server](link_para_o_download_sql_server)

## Configuração do Banco de Dados
É necessário ter o SQL Server instalado e em execução. Crie um novo banco de dados vazio no SQL Server para ser utilizado pelo projeto.

### Configurações
No arquivo `appsettings.json` e `appsettings.Development.json`, localize a seção de configuração da conexão com o banco de dados e insira a string de conexão adequada:

```json
{
  "ConnectionStrings": {
    "DBConnection": "sua-string-de-conexao-aqui"
  }
}
```

Substitua `"sua-string-de-conexao-aqui"` pela string de conexão correta para o seu banco de dados SQL Server.

## Migrations do Entity Framework
As migrações do Entity Framework são utilizadas para criar e atualizar o esquema do banco de dados de acordo com as alterações no modelo de dados.

Navegue até o diretório do projeto no terminal ou prompt de comando e execute o seguinte comando para criar as tabelas no banco de dados e aplicar as migrações:

```bash
dotnet ef database update
```

## Instalação
Siga as etapas abaixo para instalar e configurar o projeto:

1. Clone este repositório:
```bash
git clone https://github.com/marciojuniors2/CE.ApiDotnet7
```

2. Acesse o diretório do projeto.

## Executando a Aplicação
Para executar a aplicação, siga as instruções abaixo:

1. Restaure as dependências do projeto:
```bash
dotnet restore
```

2. Execute a aplicação:
```bash
dotnet run
```

## Arquitetura e Design
A Cars.ApiDotnet7 foi projetada seguindo uma arquitetura modular e adotando os princípios do Domain-Driven Design (DDD). A aplicação é desenvolvida na plataforma .NET 7, proporcionando uma estrutura flexível e escalável.

A arquitetura é dividida em camadas distintas, cada uma com responsabilidades bem definidas. A camada de Domínio contém as entidades de negócio, as regras de validação e os serviços principais. A camada de Infraestrutura é responsável pela persistência de dados, utilizando o Entity Framework Core para interagir com o banco de dados SQL Server. A camada de Apresentação consiste nos controladores da API, que lidam com as requisições e respostas HTTP.

Além disso, a API utiliza bibliotecas como AutoMapper para mapeamento de objetos, Fluent Validation para validação de dados, e JWT para autenticação e autorização. Essas tecnologias contribuem para a segurança e eficiência da aplicação.

Com essa arquitetura robusta e tecnologias modernas, a Cars.ApiDotnet7 é capaz de lidar com operações de gerenciamento de carros de forma eficiente e escalável, proporcionando uma experiência de usuário suave e confiável.

## Licença
Este projeto está licenciado sob a [MIT License](LICENSE).
