# Desafio T�cnico Senai - API

API desenvolvida em ASP.NET Core (.NET 9) para gest�o administrativa, autentica��o, usu�rios, colaboradores e reembolsos.

## Sum�rio

- [Vis�o Geral](#vis�o-geral)
- [Funcionalidades](#funcionalidades)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Como Executar](#como-executar)
- [Exemplos de Endpoints](#exemplos-de-endpoints)
- [Tratamento de Erros](#tratamento-de-erros)
- [Testes](#testes)
- [Observa��es](#observa��es)

---

## Vis�o Geral

Este projeto � uma API RESTful que oferece recursos para autentica��o de usu�rios, administra��o de cargos, fun��es, colaboradores e controle de reembolsos. Utiliza autentica��o JWT, FluentValidation, AutoMapper e Entity Framework Core.

---

## Funcionalidades

- **Autentica��o**: Login e registro de usu�rios com gera��o de JWT.
- **Administra��o**: CRUD de cargos e fun��es.
- **Usu�rios**: Gerenciamento de usu�rios do sistema.
- **Colaboradores**: Cadastro e manuten��o de colaboradores.
- **Reembolsos**: Solicita��o e acompanhamento de reembolsos.
- **Tratamento global de exce��es**: Middleware para respostas padronizadas de erro.

---

## Tecnologias Utilizadas

- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- AutoMapper
- FluentValidation
- Identity (autentica��o e autoriza��o)
- JWT Bearer Authentication
- xUnit & Moq (testes)

---

## Como Executar

1. **Pr�-requisitos**:
   - .NET 9 SDK
   - SQL Server (ou outro banco configurado)
2. **Configura��o**:
   - Ajuste as strings de conex�o e configura��es JWT no `appsettings.json`.
3. **Migra��es**:
   - Execute as migra��es do Entity Framework para criar o banco: ```bash
 dotnet ef database update --project DesafioTecnicoSenai.InfraData
 ```4. **Execu��o**:
   - Inicie a API: ```bash
 dotnet run --project DesafioTecnicoSenai.API
 ```5. **Swagger**:
   - Acesse a documenta��o interativa em: `http://localhost:<porta>/swagger`

---

## Exemplos de Endpoints

### Autentica��o

- **Login**
  - POST /api/Autenticacao/login ```json
    { 
      "email": "usuario@teste.com", 
      "password": "Senha123!" 
    }```
   **Resposta:** JWT Token

### Cargos

- **Listar cargos**
- GET /api/Cargo

- **Criar cargo**
POST /api/Cargo ```json
{ 
    "nome": "Analista", 
    "descricao": "Analista de Sistemas" 
}```
  **Resposta:** Cargo criado com sucesso

### Reembolsos

- **Solicitar reembolso**
POST /api/Reembolso ```json
{ 
    "colaboradorId": 1, 
    "valor": 100.00, 
    "descricao": "Reembolso de despesas" 
}```
  **Resposta:** Reembolso solicitado com sucesso

---

## Tratamento de Erros

A API utiliza um middleware global para capturar exce��es e retornar respostas padronizadas em JSON, facilitando o consumo e o debug.

---

## Testes

Os testes unit�rios e de integra��o est�o localizados na pasta `DesafioTecnicoSenai.Tests`. Para rodar os testes:
---

## Observa��es

- Para acessar endpoints protegidos, � necess�rio autenticar-se e fornecer o token JWT no header `Authorization`.
- O projeto segue boas pr�ticas de arquitetura, separando �reas, models, mapeamentos e valida��es.
- Para d�vidas ou sugest�es, utilize o reposit�rio ou entre em contato com o respons�vel pelo projeto.

---
