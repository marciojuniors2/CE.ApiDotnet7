# Cars.ApiDotnet7

#Descrição do Projeto
Essa api se trata do BackEnd da aplicação onde foi realizado o desenvolvimento de um sistema de vitrine de carros.

Vídeo do Projeto em funcionamento
[Watch the video
](https://1drv.ms/v/s!Am1Zv2Sr8JVMgUVUbVi1tQ34kjul?e=tWcfYP)

Tecnologias Utilizadas
.NET 7
Entity Framework (EF) Core
Auto Mapper
Fluent Validation
Jwt
SQL Server

Pré-requisitos
Antes de executar o projeto, certifique-se de ter instalado o seguinte:

.NET 7 SDK: Download .NET 7
SQL Server: Download SQL Server
Configuração do Banco de Dados
Certifique-se de ter o SQL Server instalado e em execução.
Crie um banco de dados vazio no SQL Server para o projeto.
Instruções de Configuração
No arquivo appsettings.json e appsettings.Development.json, insira a string de conexão com o banco de dados:
{
  "ConnectionStrings": {
    "DBConnection": "sua-string-de-conexao-aqui"
  }
}
Substitua "sua-string-de-conexao-aqui" pela string de conexão correta para o seu banco de dados SQL Server.

Migrations do Entity Framework
As migrations do Entity Framework permitem criar e atualizar o esquema do banco de dados de acordo com as alterações no modelo de dados.

Navegue até o diretório do projeto no terminal ou prompt de comando.
No terminal rode o comando abaixo para rodar as criar as tabelas no banco de dados e rodar as migrations:
dotnet ef database update
Instalação
Clone este repositório: git clone [https://github.com/rufedupo/verzel-test-api](https://github.com/marciojuniors2/CE.ApiDotnet7)
Navegue para o diretório do projeto

Executando a Aplicação
Para executar a aplicação, siga os passos abaixo:

Restaure as dependências do projeto: dotnet restore
Execute a aplicação: dotnet run
Arquitetura e Design
O projeto foi desenvolvido seguindo com uma base no Domain-Driven Design (DDD) e utilizando o .NET 7 como plataforma de desenvolvimento. A arquitetura segue uma abordagem modular, com uma divisão clara de responsabilidades entre as camadas da aplicação.


generated with gpt-3
