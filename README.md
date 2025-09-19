# TicketsAPI

API RESTful desenvolvida em C# no framework .NET seguindo os princípios da Clean Architecture e o padrão CQRS (Command Query Responsibility Segregation). 
O projeto permite gerenciar tickets, incluindo criação, atualização, exclusão e consulta de tickets.

## 🛠️ Tecnologias Utilizadas
- **C#**
- **.NET 8**
- **SQL Server**

## 🧪 Endpoints Principais

- `POST /api/tickets`: Cria um novo ticket.
- `GET /api/tickets`: Retorna todos os tickets.  
- `GET /api/tickets/{id}`: Retorna um ticket específico.  
- `PUT /api/tickets/{id}`: Atualiza um ticket existente.  
- `DELETE /api/tickets/{id}`: Deleta um ticket.
