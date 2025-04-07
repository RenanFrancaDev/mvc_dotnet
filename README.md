Criação de um projeto base MVC
dotnet new mvc

Instalar Entity Framework
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

Criar Model
Contato.cs

Criat Contexto
criar pasta Context/AgendaContext.cs
criar construtor AgendaContext

Cadastrar String de conexão
appsettings.Development.json - ConnectionString


Configurar Program.cs
builder.Servises.AddDvContext(...)
importar app.MapControllerRoute

Migrations
dotnet ef migrations add AdicionaTabelaContato (seja literal) 
dotnet ef database update

Criar Controller
ContatoController.cs

Criar View
View/Contato

Configurar no Controllet para que a View consiga carregar os contatos através do Entity Framework

