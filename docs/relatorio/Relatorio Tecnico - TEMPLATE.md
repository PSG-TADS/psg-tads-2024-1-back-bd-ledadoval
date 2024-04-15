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

......  COLOQUE AQUI O SEU TEXTO ......

> Nesse momento você deve apresentar o problema que a sua aplicação deve
> resolver. No entanto, não é a hora de comentar sobre a aplicação.
> Descreva também o contexto em que essa aplicação será usada, se
> houver: empresa, tecnologias, etc. Novamente, descreva apenas o que de
> fato existir, pois ainda não é a hora de apresentar requisitos
> detalhados ou projetos.
>
> Nesse momento, o grupo pode optar por fazer uso
> de ferramentas como Design Thinking, que permite um olhar de ponta a
> ponta para o problema.
>
> **Links Úteis**:
> - [Objetivos, Problema de pesquisa e Justificativa](https://medium.com/@versioparole/objetivos-problema-de-pesquisa-e-justificativa-c98c8233b9c3)
> - [Matriz Certezas, Suposições e Dúvidas](https://medium.com/educa%C3%A7%C3%A3o-fora-da-caixa/matriz-certezas-suposi%C3%A7%C3%B5es-e-d%C3%BAvidas-fa2263633655)
> - [Brainstorming](https://www.euax.com.br/2018/09/brainstorming/)

## Objetivos

......  COLOQUE AQUI O SEU TEXTO ......

> Aqui você deve descrever os objetivos do trabalho indicando que o
> objetivo geral é desenvolver um software para solucionar o problema
> apresentado acima. Apresente também alguns (pelo menos 2) objetivos
> específicos dependendo de onde você vai querer concentrar a sua
> prática investigativa, ou como você vai aprofundar no seu trabalho.
> 
> **Links Úteis**:
> - [Objetivo geral e objetivo específico: como fazer e quais verbos utilizar](https://blog.mettzer.com/diferenca-entre-objetivo-geral-e-objetivo-especifico/)

## Justificativa

......  COLOQUE AQUI O SEU TEXTO ......

> Descreva a importância ou a motivação para trabalhar com esta aplicação
> que você escolheu. Indique as razões pelas quais você escolheu seus
> objetivos específicos ou as razões para aprofundar em certos aspectos
> do software.
> 
> O grupo de trabalho pode fazer uso de questionários, entrevistas e
> dados estatísticos, que podem ser apresentados, com o objetivo de
> esclarecer detalhes do problema que será abordado pelo grupo.
>
> **Links Úteis**:
> - [Como montar a justificativa](https://guiadamonografia.com.br/como-montar-justificativa-do-tcc/)

## Público-Alvo

......  COLOQUE AQUI O SEU TEXTO ......

> Descreva quem serão as pessoas que usarão a sua aplicação indicando os
> diferentes perfis. O objetivo aqui não é definir quem serão os
> clientes ou quais serão os papéis dos usuários na aplicação. A ideia
> é, dentro do possível, conhecer um pouco mais sobre o perfil dos
> usuários: conhecimentos prévios, relação com a tecnologia, relações
> hierárquicas, etc.
>
> Adicione informações sobre o público-alvo por meio de uma descrição
> textual, ou diagramas de personas, mapa de stakeholders, ou como o
> grupo achar mais conveniente.
> 
> **Links Úteis**:
> - [Público-alvo: o que é, tipos, como definir seu público e exemplos](https://klickpages.com.br/blog/publico-alvo-o-que-e/)
> - [Qual a diferença entre público-alvo e persona?](https://rockcontent.com/blog/diferenca-publico-alvo-e-persona/)

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
