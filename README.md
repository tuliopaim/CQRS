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
  - [ ] Documenta��es ([#11](https://github.com/tuliopaim/MicroServiceBase/issues/11))
     - [ ] Arquitetura
     - [ ] Core
     - [ ] Aditoria
     - [ ] Cadastro
     - [ ] Email
- [ ] Separar DBs por Service ([#12](https://github.com/tuliopaim/MicroServiceBase/issues/12))
- [ ] Separar Services em Reposit�rios ([#13](https://github.com/tuliopaim/MicroServiceBase/issues/13))
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
- [x]  Kafka
    - [x]  KafkaBroker com facilitadores
    - [x]  BackgroundService disparando Consumers Kafka
    - [x]  Criar t�picos no statup da aplica��o ([#14](https://github.com/tuliopaim/MicroServiceBase/issues/14))
- [x]  EF Core
    - [x]  DbContextBase
    - [x]  Repositorios Gen�ricos
    - [x]  Pagina��o
- [ ]  Log
    - [x]  Serilog
    - [x]  ConsoleSink
    - [ ]  EllasticSearchSink ([#6](https://github.com/tuliopaim/MicroServiceBase/issues/6))

### Services

- [ ]  Microsservi�o de Auditoria
  - [x] Extra��o de Auditoria no DbContextBase
  - [x] Implementar
  - [ ] Queries ([#15](https://github.com/tuliopaim/MicroServiceBase/issues/15))
- [ ]  Microsservi�o de Email ([#7](https://github.com/tuliopaim/MicroServiceBase/issues/7))
  - [X] Envio de email
  - [ ] Persist�ncia
  - [ ] Retry
- [ ]  Microsservico de Identidade ([#8](https://github.com/tuliopaim/MicroServiceBase/issues/8))
- [ ]  Autentica��o/Autoriza��o em endpoints ([#9](https://github.com/tuliopaim/MicroServiceBase/issues/9))
- [ ]  Gateway ([#10](https://github.com/tuliopaim/MicroServiceBase/issues/10))
  - [ ] Definir estrat�gia de Gateway
  - [ ] Implementar
