# MicroServiceBase

Um reposit�rio para estudo/teste de microsservi�os com .NET

## Ambiente

* Postgres
* Kafka + Zookeeper
* ElasticSearch + Kibana

Na raiz da solu��o:

```console
$ cd docker
$ docker-compose -f docker-compose-dev.yml --env-file .env.dev up -d
```

## Roadmap

### Arquitetura / Repositorio

- [ ]  README
  - [x] Ambiente
  - [x] Organizar Roadmap
  - [ ] Documenta��o Arquitetura
  - [ ] Documenta��o Core
  - [ ] Documenta��o Aditoria
  - [ ] Documenta��o Cadastro
  - [ ] Documenta��o Email
- [ ] Separar DBs por Service
- [ ] Separar Services em Reposit�rios
  - [ ] Reposit�rio Pai com Docker e Docs
  - [ ] Services em Submodules
  
### Core

- [x]  EntidadeBase / EntidadeAuditavel
- [x]  Suporte a Hateoas
- [x]  Mediator / CQRS
    - [x]  Command, Query, Event
    - [x]  ValidationPipeline
    - [x]  ExceptionPipeline
    - [x]  LogPipeline
- [ ]  Kafka
    - [x]  KafkaBroker com facilitadores
    - [x]  BackgroundService disparando Consumers Kafka
    - [ ]  Criar t�picos no statup da aplica��o
- [x]  EF Core
    - [x]  DbContextBase
    - [x]  Repositorios Gen�ricos
    - [x]  Pagina��o
- [ ]  Log
    - [x]  Serilog
    - [x]  ConsoleSink
    - [ ]  EllasticSearchSink

### Services

- [x]  Microsservi�o de Auditoria
  - [x] Extra��o de Auditoria no DbContextBase
  - [x] Implementar
- [ ]  Microsservi�o de Email
  - [X] Envio de email
  - [ ] Persist�ncia
  - [ ] Retry
- [ ]  Microsservico de Identidade
- [ ]  Autentica��o/Autoriza��o em endpoints
- [ ]  Gateway
  - [ ] Definir estrat�gia de Gateway
  - [ ] Implementar
