# Cars.ApiDotnet7

## Descrição do Projeto
A Cars.ApiDotnet7 é uma API desenvolvida para gerenciar informações sobre carros em uma vitrine virtual. Ela fornece endpoints para realizar operações como criar, ler, atualizar e excluir carros do sistema.

## Demonstração em Vídeo
Confira o vídeo abaixo para visualizar o projeto em funcionamento:

[![Assista ao vídeo](![image](https://github.com/marciojuniors2/CE.ApiDotnet7/assets/81241546/40c7c2f7-0707-4c41-9f69-f1117f2dd53b)
)]([LINK_DO_VIDEO](https://onedrive.live.com/?authkey=%21AFRtWLW1DfiSO6U&cid=4C95F0AB64BF596D&id=4C95F0AB64BF596D%21197&parId=root&o=OneUp))

## Tecnologias Utilizadas
A API foi construída utilizando as seguintes tecnologias:

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
A arquitetura do projeto segue os princípios do Domain-Driven Design (DDD) e utiliza o .NET 7 como plataforma de desenvolvimento. possuindo uma clara separação de responsabilidades entre as diferentes camadas da aplicação.


Gerado com chat Gpt ! espero que ajude..
