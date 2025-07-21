# 🚀 FluentMigrator Demo — Controle, Clareza e Automatização no .NET

Este projeto demonstra o uso do [FluentMigrator](https://fluentmigrator.github.io/) para controle de versionamento e aplicação de alterações no banco de dados de forma automatizada e rastreável, seguindo o estilo _code-first_ em aplicações .NET.

---

## ✨ Por que usar FluentMigrator?

Se você já precisou manter diferentes ambientes sincronizados, evitar scripts SQL soltos ou garantir histórico das alterações no banco de dados, o FluentMigrator é para você:

- ✅ **Versionamento claro** de cada alteração via atributo `[Migration(...)]`
- ✅ **Rollback simplificado** via método `Down`
- ✅ **Independente de ORM** (funciona com Dapper, ADO.NET, etc.)
- ✅ **Execução programável**, ideal para pipelines CI/CD
- ✅ **Leitura fluente** e compreensível das operações de schema

---

## 📦 Pacotes Necessários

Instale os seguintes pacotes no seu projeto:

```bash
dotnet add package FluentMigrator
dotnet add package FluentMigrator.Runner
dotnet add package Dapper
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

---

## 🏗️ Estrutura do Projeto

- `infrastructure/DataAccess/FluentMigratorDemoDbContext.cs`  
  ⤷ Classe de contexto e configuração do banco

- `infrastructure/DependencyInjectionExtension.cs`  
  ⤷ Configuração da injeção de dependência

- `infrastructure/Migrations/DatabaseMigration.cs`  
  ⤷ Runner manual das migrations (útil para CI/CD ou controle customizado)

- `infrastructure/Migrations/DatabaseVersions.cs`  
  ⤷ Convenção de versão com base na data (ex: `2025072101`)

- `infrastructure/Migrations/Versions/Version2025062001.cs`  
  ⤷ Migrations organizadas por versão

- `api/Program.cs`  
  ⤷ Execução automática das migrations na inicialização da API

---

## 🔢 Convenção de Versionamento

Utilize a seguinte convenção para facilitar rastreabilidade e ordenação:

```
[Migration(ANO + MÊS + DIA + INCREMENTO_DIARIO)]
Exemplo: [Migration(2025072101)]
```

---

## 🛠️ Execução Manual das Migrations

Você pode criar e executar o runner programaticamente, com total controle, ideal para uso em DevOps ou integrações internas.

---

## ✅ Resultado

Com o FluentMigrator você obtém:

- 💡 **Segurança** e controle das mudanças de banco
- 📜 **Histórico completo** de alterações
- 🧪 **Ambientes previsíveis** e sincronizados
- 🔁 **Rollback seguro** de alterações equivocadas

---

## 📌 Conclusão

O FluentMigrator traz ao seu banco de dados o mesmo nível de controle de versão que o Git traz para seu código. Se você deseja melhorar a rastreabilidade, integrar com pipelines e eliminar scripts manuais frágeis, essa é a ferramenta ideal para o seu projeto .NET.

---

> Desenvolvido por um FullStack .NET Developer apaixonado por organização e automação de infraestrutura.
