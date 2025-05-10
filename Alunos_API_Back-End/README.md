# API CRUD de Alunos
Este projeto é uma API RESTful desenvolvida com ASP.NET Core que permite a criação, leitura, atualização e exclusão (CRUD) de informações de alunos. A API também oferece a possibilidade de buscar alunos por nome ou ID, além de realizar operações de alteração e exclusão.

## Funcionalidades
Listar alunos: Retorna uma lista com todos os alunos cadastrados.  
Buscar aluno por ID: Retorna os detalhes de um aluno específico com base no ID.  
Buscar aluno por nome: Retorna uma lista de alunos que contenham o nome buscado (busca parcial).  
Criar aluno: Permite a criação de um novo aluno.  
Atualizar aluno: Atualiza as informações de um aluno existente.  
Deletar aluno: Remove um aluno do banco de dados.  

## Tecnologias Utilizadas
-ASP.NET Core: Framework para desenvolvimento de APIs web escaláveis.  
-Entity Framework Core: ORM utilizado para comunicação com o banco de dados.  
-SQL Server/MySQL: Banco de dados para armazenar os registros dos alunos.  
-Swagger: Interface para documentação e teste das rotas da API.  

### Como Executar o Projeto

Clone o repositório:
git clone https://github.com/seu-usuario/seu-repositorio.git

Navegue até a pasta do projeto:
cd nome-do-projeto

Configure o banco de dados:  
No arquivo appsettings.json, configure a string de conexão com o banco de dados de sua preferência.  
Exemplo:  
json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=AlunosDb;User Id=seu-usuario;Password=sua-senha;"
}

Restaurar as dependências:  
dotnet restore

Executar as migrações para criar o banco de dados:  
dotnet ef database update  

Iniciar a aplicação:  
dotnet run  
Acessar a documentação da API:  

Abra seu navegador e vá até o endereço: http://localhost:5000/swagger para visualizar e testar as rotas da API.

### Endpoints  
GET /api/alunos  
Retorna uma lista com todos os alunos.  

GET /api/alunos/{id}  
Retorna os detalhes de um aluno específico com base no ID.  

GET /api/alunos?nome={nome}  
Busca alunos pelo nome.  

POST /api/alunos  
Cria um novo aluno.  

Body:
json
Copy code
{
  "nome": "João Silva",
  "email": "joao.silva@email.com",
  "idade": "25"
}
PUT /api/alunos/{id}
Atualiza as informações de um aluno existente.

Body:
json
Copy code
{
  "nome": "João Silva",
  "email": "joao.silva@email.com",
  "idade": "26"
}
DELETE /api/alunos/{id}
Remove um aluno do banco de dados.
