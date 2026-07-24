# Escola (Clean Architecture)

Resumo
-----
Projeto exemplo seguindo princípios de Clean Architecture, dividido em camadas claras para separar responsabilidades e facilitar manutenção e testes.

Estrutura do repositório
------------------------
- `Escola.API` — camada de apresentação / API (Web API)
- `Escola.Application` — regras de aplicação / casos de uso
- `Escola.Domain` — entidades e interfaces do domínio
- `Escola.InfraIoc` — composição de dependências / configuração de DI
- `Escola.Infra.Data` — implementação de persistência (Entity Framework)

Tecnologias
-----------
- .NET 10 (`net10.0`)
- ASP.NET Core (Web API)
- Entity Framework Core
- Docker (arquivo `Dockerfile` presente)
- Visual Studio 2026 (desenvolvimento local)

Pacotes NuGet usados (principais)
---------------------------------
- `Microsoft.AspNetCore.OpenApi` 10.0.10 — documentação OpenAPI / Swagger
- `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` 1.23.0 — suporte a contêiner no VS
- `Microsoft.EntityFrameworkCore` 10.0.10 — ORM para persistência

Por que isso segue Clean Architecture
-------------------------------------
- Camadas separadas: `Domain` contém regras e entidades; `Application` orquestra casos de uso; `API` expõe endpoints; `InfraData` contém detalhes de implementação de infraestrutura; `InfraIoc` mantém a composição de dependências isolada.
- Dependência aponta para dentro: projetos de infraestrutura referenciam `Domain`/`Application`, não o contrário.
- Testabilidade e substituibilidade: interfaces do domínio permitem trocar a infraestrutura (ex.: outro banco ou mock).

Como executar
-------------
1. Build: na raiz do repositório ou no Visual Studio use __Build Solution__.
2. Executar API localmente:
   - Via CLI: `dotnet run --project Escola.API`
   - Ou executar pelo Visual Studio (perfil padrão).
3. Docker: `docker build -t escola-api ./Escola.API` e `docker run ...` (ver `Dockerfile`).
