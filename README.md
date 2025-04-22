# Developer Evaluation Project

## Considerações:

1 – Feito com NetCore6, Visual Studio 22.

2 - Usei uma arquitetura DDD para tentar deixar o mais limpo possível, com separação dos projetos.

3 – O designer parttern eu optei pelo CQRS. Eu gosto muito pois faz uma separação entre buscas e ações (Update, Insert, Delete) no banco de dados, 
e com isso fornece uma melhor organização e facilita em futuras manutenções. Também facilita a comunicação com mais de um banco de dados. 
Ponto negativo talvez seja a maior quantidade de arquivos... Infelizmente não ficou 100% por falta de tempo e talvez conhecimento. 

4 - Para banco dados usei o SQL Express com Migrations: 
NO PACKAGE MANAGER CONSOLE RODAR O MIGRATIONS
PROJ:Adapters\Drivers\WebApi\Ambev.DeveloperEvaluation.WebApi
add-migration Inicio -Context Context -verbose
update-database Inicio 
 
5 - FALTOU FAZER:

5.1 - Cobertura testes de 80%
* Não tive tempo, caso desejem me deem mais dias que faço. 

5.2 - Relatórios de Desempenho:
* Não tive tempo, caso desejem me deem mais dias que faço. 

5.3 - Deleção Tarefas:
* Eu esqueci de fazer, caso desejem me deem mais dias que faço.

5.4 - Colocação no docker
* Dockfile foi feito mas eu não sou Administrador da minha máquina, o que impossibilitou eu fazer a imagem. 
No cmd:
c:\Projetos\TesteDigitas>docker build -t testeeclipseworks .
c:\Projetos\TesteDigitas>docker run -d -p 5001:80 --name web-api-container testeeclipseworks
Na imagem chamar swagger: http://localhost:5001/swagger/index.html

5.5 - Comentários das Tarefas:
* Fiz parcialmente, faltou colocar na implementação.  

6 - Testes:
6.1 - No projeto XUnit.Coverlet.Collector: 
dotnet test C:\Projetos\EclipseWorks.DeveloperEvaluation\tests\EclipseWorks.DeveloperEvaluation.Unit\EclipseWorks.DeveloperEvaluation.Collector.Unit\EclipseWorks.DeveloperEvaluation.Collector.Unit.csproj --collect:"XPlat Code Coverage"
6.2 - No projeto XUnit.Coverlet.MSBuild:
6.2.1 - dotnet tool update -g dotnet-reportgenerator-globaltool
6.2.2 - dotnet test C:\Projetos\EclipseWorks.DeveloperEvaluation\tests\EclipseWorks.DeveloperEvaluation.Unit\EclipseWorks.DeveloperEvaluation.MSBuild.Unit1\EclipseWorks.DeveloperEvaluation.MSBuild.Unit.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
6.2.3 - reportgenerator -reports:"C:\Projetos\EclipseWorks.DeveloperEvaluation\tests\EclipseWorks.DeveloperEvaluation.Unit\EclipseWorks.DeveloperEvaluation.Collector.Unit\TestResults\931eb173-2b7d-44ee-8906-ce95c1eb40f4\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html coverage_report\index.html


## Fase 2: Refinamento:
Poderiamos aprimorar os Relatórios de desempenho na segunda fase? 
Para segunda fase podemos dedicar parte do tempo para melhorar/fazer uma documentação? 
Teremos mais tempo para desenvolver com qualidade?

## Fase 3: Melhorias:
Melhoria seria rever o código e retirar possíveis redundancias que possam existir.




## Testes Swagger:
INSERIR USER:
{
  "username": "Teste",
  "password": "Aa@12345",
  "phone": "21987702255",
  "email": "sergfarias@gmail.com",
  "status": 1,
  "role": 1
}


INSERIR PROJETO SEM TAREFAS:
{
  "projectNumber": "10001",
  "projectDate": "2025-04-17T01:14:45.590Z",
  "userId": "929B432B-B443-4F1C-E96D-08DD81270A84",
  "status": 1
}


INSERIR PROJETO COM TAREFAS:
{
  "projectNumber": "10002",
  "projectDate": "2025-04-17T01:14:45.590Z",
  "userId": "929B432B-B443-4F1C-E96D-08DD81270A84",
  "status": 1,
  "tasks": [
    {
      "projectId": "D271498D-B92E-426E-8583-49FCE3CFB14A",
      "title": "Tarefa1",
	  "DueDate": "2025-04-17T01:14:45.590Z",
      "description": "Descrição tarefa1",
	  "details":"testes detalhes",
      "status": 1,
      "priority": 1
    },
	{
      "projectId": "D271498D-B92E-426E-8583-49FCE3CFB14A",
      "title": "Tarefa2",
	  "DueDate": "2025-04-17T01:14:45.590Z",
      "description": "Descrição tarefa2",
	  "details":"testes detalhes",
      "status": 1,
      "priority": 1
    }
  ]
}

PESQUISAR PROJETOS POR USUÁRIO: 929B432B-B443-4F1C-E96D-08DD81270A84



INSERIR SOMENTE TAREFA:
{
     "projectId": "D4D38361-3493-4B98-A9C2-D7F33A10D565",
     "title": "Tarefa3",
	 "details":"testes detalhes",
     "description": "Descrição tarefa3",
	 "DueDate": "2025-04-17T01:14:45.590Z",
     "priority": 1
}

ALTEAR TAREFA:
{
     "Id": "75E20427-99DB-403B-D34B-08DD812B4E6B",
     "details":"testes detalhes123",
     "status": 2
}




















