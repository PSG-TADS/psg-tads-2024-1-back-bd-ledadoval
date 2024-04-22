# Informações do Projeto
`TÍTULO DO PROJETO`  

LocaVeículas

`CURSO` 

Tecnologia em Análise e Desenvolvimento de Sistemas

## Participantes

> Lêda Lacerda Bombinho do Val

# Estrutura do Documento

- [Informações do Projeto](#informações-do-projeto)
  - [Participantes](#participantes)
- [Estrutura do Documento](#estrutura-do-documento)
- [Introdução](#introdução)
  - [Problema](#problema)
  - [Objetivos](#objetivos)
  - [Justificativa](#justificativa)
  - [Público-Alvo](#público-alvo)
 - [Especificações do Projeto](#especificações-do-projeto)
  - [Personas e Mapas de Empatia](#personas-e-mapas-de-empatia)
  - [Histórias de Usuários](#histórias-de-usuários)
  - [Requisitos](#requisitos)
    - [Requisitos Funcionais](#requisitos-funcionais)
    - [Requisitos não Funcionais](#requisitos-não-funcionais)
  - [Arquitetura do Sistema](#arquitetura-do-sistema)
  - [Implementação Técnica](#implementação-técnica)
  - [Descrição do Banco de Dados](#descrição-do-banco-de-dados)
  - [Testes e Validação](#testes-e-validação)
  - [Resultados e Conclusões](#resultados-e-conclusões)
  - [Considerações Finais](#considerações-finais)
  - [Ferramentas](#ferramentas)
  - [Referências](#referências)
  - [Apêndices](#apêndices)


# Introdução

## Problema

Nesse cenário de gestão de uma locadora de automóveis, detectamos um problema em comum: gestão manual e desorganizada das operações da empresa. Tarefas como registro de locações, controle de estoque de veículos e acompanhamento de clientes eram realizadas de forma manual, o que resultava em erros, inconsistências nos dados e lentidão nos processos. Além disso, a falta de uma visão integrada e análise de dados dificultava a identificação de tendências de mercado e oportunidades de otimização. 

## Objetivos

O objetivo do LocaVeiculos é desenvolver uma plataforma eficiente para o gerenciamento completo das operações relacionadas à locação de veículos. Isso inclui o cadastro de veículos disponíveis para locação, registro de clientes, controle de reservas e acompanhamento do status dos veículos. Nosso foco é oferecer uma solução completa e integrada para a gestão de uma locadora de veículos, contribuindo para a eficiência operacional e o sucesso do negócio.

## Justificativa

O LocaVeiculos surge através da necessidade de modernizar e otimizar os processos operacionais de empresas de locação de veículos. A implementação desse sistema visa automatizar tarefas manuais, melhorar a eficiência operacional, aumentar a precisão e confiabilidade dos dados, proporcionar uma experiência mais satisfatória para os clientes e fornecer insights valiosos para tomada de decisões estratégicas. Essas melhorias são essenciais para manter a competitividade no mercado e garantir o sucesso do negócio a longo prazo.

## Público-Alvo

O público-alvo do LocaVeiculos inclui tanto a equipe interna da empresa quanto os clientes que utilizam os serviços da locadora.

> Equipe Interna:
- Gerentes e supervisores responsáveis pela gestão da locadora.
- Funcionários responsáveis pelo atendimento aos clientes, reservas de veículos e manutenção da frota.
- Equipe financeira encarregada do controle de pagamentos e faturamento.
- Administradores de sistema responsáveis pela manutenção e atualização do sistema.
> Clientes da Locadora:
- Indivíduos que desejam alugar veículos para viagens, trabalho ou necessidades pessoais.
- Empresas que necessitam de veículos para fins comerciais ou transporte de funcionários.
- Turistas que visitam a região e precisam de meios de transporte temporários.

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

> Com base nas Histórias de Usuário, enumere os requisitos da sua
> solução. Classifique esses requisitos em dois grupos:
>
> - [Requisitos Funcionais (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
>   correspondem a uma funcionalidade que deve estar presente na
>   plataforma (ex: cadastro de usuário).
>
> - [Requisitos Não Funcionais (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
>   correspondem a uma característica técnica, seja de usabilidade,
>   desempenho, confiabilidade, segurança ou outro (ex: suporte a
>   dispositivos iOS e Android).
>
> Lembre-se que cada requisito deve corresponder à uma e somente uma
> característica alvo da sua solução. Além disso, certifique-se de que
> todos os aspectos capturados nas Histórias de Usuário foram cobertos.
> 
> **Links Úteis**:
> 
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)


## Arquitetura do Sistema

......  COLOQUE AQUI O SEU TEXTO DE INTRODUÇÃO ......

> - Descrição da arquitetura utilizada, incluindo o padrão MVC (Model-View-Controller) ou similar.
- Explanação sobre a divisão de responsabilidades entre as camadas do sistema.
- Diagramas de arquitetura, se aplicável.


# Implementação Técnica

......  COLOQUE AQUI O SEU TEXTO DE INTRODUÇÃO ......

> - Detalhamento das tecnologias utilizadas, como C# 6.0 (ou superior), ASP.NET Core, Entity Framework, SQL Express, Swagger, entre outras.
- Explicação sobre as principais classes e suas responsabilidades.
- Discussão sobre as escolhas de design e padrões de desenvolvimento adotados.

## Descrição do Banco de Dados

......  INCLUA AQUI A DESCRIÇÃO DO BANCO DE DADOS ......

> - Apresentação do modelo de dados utilizado no sistema.
- Descrição das tabelas, relacionamentos e restrições de integridade.
- Exemplificação de consultas SQL relevantes.


## Teste e Validação

......  INCLUA AQUI OS TESTES E VALIDAÇÕES ......

> - Detalhamento dos testes realizados no sistema, tanto manuais quanto automatizados.
- Discussão sobre a cobertura de testes e a eficácia dos testes realizados.
- Relato de problemas encontrados durante os testes e como foram resolvidos.


# Resultados e Conclusões

......  COLOQUE AQUI OS RESULTADOS E CONCLUSÕES ......

> - Análise dos resultados obtidos com o desenvolvimento do sistema.
- Avaliação da conformidade dos requisitos do sistema.
- Conclusões sobre a eficácia do sistema desenvolvido em atender às necessidades da locadora de veículos.

## Considerações Finais

......  COLOQUE AQUI AS CONSIDERAÇÕES FINAIS ......

> - Reflexões sobre as experiências adquiridas durante o desenvolvimento do projeto.
- Sugestões para melhorias futuras no sistema.
- Agradecimentos, se aplicável.

# Referências

......  COLOQUE AQUI O SEU TEXTO ......

> Inclua todas as referências (livros, artigos, sites, etc) utilizados
> no desenvolvimento do trabalho.
> 
> **Links Úteis**:
> - [Formato ABNT](https://www.normastecnicas.com/abnt/trabalhos-academicos/referencias/)
> - [Referências Bibliográficas da ABNT](https://comunidade.rockcontent.com/referencia-bibliografica-abnt/)

## Apêndice

......  COLOQUE AQUI O SEU TEXTO ......

> - Documentação adicional, como diagramas UML, scripts SQL, entre outros, que complementam o entendimento do projeto.
