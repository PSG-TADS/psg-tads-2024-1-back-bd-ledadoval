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
As empresas de locação de veículo estão presentes na nossa sociedade e desempenham um papel crucial na mobilidade urbana atual. Com a crescente demanda de locação de veiculos, o desenvolvimento de sistemas eficientes para gestão desse negócio tornou-se primordial. Em resposta a essa demanda, surge o projeto LocaVeículas como uma solução abrangente projetada para otimizar o processo de aluguel de veículos.

Este projeto, desenvolvido usando C'\#' e aproveitando tecnologias como Entity Framework e SQL Express, visa revolucionar a maneira como os serviços de aluguel de veículos são gerenciados. Ao fornecer ferramentas intuitivas para gerenciar veículos, clientes e reservas, o LocaVeículas busca aprimorar a experiência geral de aluguel tanto para os clientes quanto para o pessoal da agência de aluguel.

Neste trabalho, exploramos as características, implementação e benefícios potenciais do sistema LocaVeículas, investigando suas capacidades em otimizar operações e melhorar a satisfação do cliente dentro da indústria de aluguel de veículos.

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

# Requisitos
## Requisitos Funcionais

**Gerenciamento de Veículos:**
- Cadastro de novos veículos no sistema, incluindo informações como modelo, marca, ano, placa, situação, tipo de combustível e tipo do veículo.
- Atualização e remoção de informações de veículos existentes.
- Visualização e busca rápida de veículos disponíveis para locação.

**Gerenciamento de Clientes:**
- Registro de novos clientes, incluindo detalhes como nome, telefone, endereço, email, se já cliente e quantos veículos ele já alugou.
- Edição e exclusão de informações de clientes.
- Possibilidade de manter registros de clientes frequentes para oferecer descontos ou promoções especiais, tendo em vista que registramos a frequência de locação de carros.

**Reservas:**
- Funcionalidade para criar novas reservas, especificando o veículo desejado, o período de locação, se irá estender o período de locação e o valor final.
- Visualização e gerenciamento de reservas existentes, incluindo a capacidade de editar ou cancelar reservas.

## Requisitos Não Funcionais

**Desempenho:**
- O sistema deve ser responsivo e rápido, mesmo com um grande volume de dados e usuários simultâneos.
- O tempo de resposta para consultas e operações do sistema deve ser mínimo, garantindo uma experiência eficiente para os usuários.

**Escalabilidade:**
- Capacidade de expansão do sistema para lidar com um aumento na demanda de usuários e crescimento da frota de veículos ao longo do tempo.
- Arquitetura flexível que permite adicionar novos recursos e funcionalidades conforme necessário.

**Confiabilidade:**
- Garantia de disponibilidade do sistema durante o horário comercial, minimizando o tempo de inatividade não planejado.

# Arquitetura do Sistema

## Descrição da Arquitetura

A arquitetura do sistema foi desenvolvida seguindo o padrão MVC (Model-View-Controller) para garantir uma separação clara de responsabilidades entre os diferentes componentes. Essa abordagem garante uma divisão clara de responsabilidades e facilita a manutenção e escalabilidade do sistema.

## Separação interna do projeto

A divisão de responsabilidades entre as camadas do sistema foi realizada da seguinte maneira:

- A camada de **Models** é responsável pela manipulação e persistência dos dados, incluindo a definição das entidades do banco de dados, mapeadas para classes C# usando o Entity Framework.
  
- A camada de **Context** é substituída por respostas JSON retornadas pelos endpoints da API. Essas respostas são serializações dos objetos retornados pelo modelo para representar os dados de forma estruturada.
  
- A camada de **Controller** é responsável por receber as requisições HTTP dos clientes, roteá-las para as ações apropriadas e retornar as respostas correspondentes. As controllers contêm a lógica de aplicação para processar as requisições e atualizar o modelo conforme necessário.

# Implementação Técnica

## Tecnologias Utilizadas

A implementação técnica do sistema foi realizada utilizando as seguintes tecnologias:

- **C# 8.0:** Linguagem de programação utilizada para o desenvolvimento da aplicação backend.
  
- **ASP.NET Core:** Framework utilizado para criar APIs web robustas e escaláveis.
  
- **Entity Framework:** ORM (Object-Relational Mapping) utilizado para mapear as entidades do banco de dados relacional para objetos em C#.
  
- **SQL Server:** Banco de dados relacional utilizado para armazenar e persistir os dados sobre as reservas de aluguel de veículos.
  
- **Swagger:** Ferramenta utilizada para documentar e testar APIs de forma interativa.

## Principais Classes e Responsabilidades

As principais classes do sistema e suas responsabilidades são:

- **ApplicationContext:** Classe responsável por configurar e fornecer acesso ao contexto do banco de dados utilizando o Entity Framework.
  
- **ClienteController:** Classe responsável por definir os endpoints da API relacionados aos clientes, incluindo operações CRUD (Create, Read, Update, Delete).
  
- **ReservaController:** Classe responsável por definir os endpoints da API relacionados às reservas de veículos.
  
- **VeiculoController:** Classe responsável por definir os endpoints da API relacionados aos veículos disponíveis para locação.
  
- **Outras classes de modelo:** Classes que representam as entidades do banco de dados, como Cliente, Reserva, Veiculo, entre outras. Essas classes contêm propriedades que correspondem aos campos das tabelas do banco de dados e métodos para manipular esses dados.

## Escolhas de Design e Padrões de Desenvolvimento

Durante o desenvolvimento do sistema, foram adotadas as seguintes escolhas de design e padrões de desenvolvimento:

- **Padrão MVC:** O sistema foi estruturado seguindo o padrão MVC (Model-View-Controller) para garantir uma separação clara de responsabilidades entre os diferentes componentes da aplicação.
  
- **Uso do Entity Framework:** O Entity Framework foi escolhido para facilitar o acesso e manipulação dos dados do banco de dados, utilizando abordagens de Code First ou Database First, dependendo das necessidades do projeto.
  
- **API RESTful:** A API foi projetada seguindo os princípios RESTful, utilizando verbos HTTP para operações CRUD e URLs amigáveis para representar recursos.
  
- **Documentação com Swagger:** A documentação da API foi feita utilizando o Swagger, que permite gerar automaticamente uma documentação interativa com descrições detalhadas de cada endpoint, parâmetros necessários e exemplos de respostas.

Essas escolhas de design e padrões de desenvolvimento foram adotadas para garantir a robustez, escalabilidade e manutenibilidade do sistema.

# Descrição do Banco de Dados

## Modelo de Dados

O modelo de dados utilizado no sistema é composto por várias entidades relacionadas entre si. Abaixo está a descrição das principais tabelas do banco de dados:

- **Tabela Cliente:** Armazena informações sobre os clientes da locadora de veículos, como nome, telefone, endereço, email, entre outros.
  
- **Tabela Veiculo:** Contém informações sobre os veículos disponíveis para locação, incluindo modelo, marca, ano, placa, tipo de combustível, entre outros.
  
- **Tabela Reserva:** Registra as reservas de veículos realizadas pelos clientes, incluindo o cliente associado, o veículo reservado, o período de locação, o valor total, entre outros.

## Relacionamentos

Existem vários relacionamentos entre as entidades do banco de dados:

- Um cliente pode ter várias reservas de veículos associadas a ele, mas uma reserva está associada a apenas um cliente.
  
- Um veículo pode estar associado a várias reservas, mas uma reserva está associada a apenas um veículo.

Esses relacionamentos são estabelecidos por meio de chaves estrangeiras nas tabelas do banco de dados.

# Documentação EndPoints

## API Cliente

Esta API fornece endpoints para realizar operações CRUD (Create, Read, Update, Delete) em relação aos clientes no LocaVeiculo.

### GET: api/Cliente

Retorna uma lista de todos os clientes cadastrados.

- **Método HTTP:** `GET`
- **Endpoint:** `GET /api/Cliente`
- **Descrição:** Retorna uma lista de todos os clientes cadastrados no sistema.
- **Resposta:** Uma lista de objetos JSON representando os clientes, ou um array vazio se não houver clientes cadastrados.
- **Código de Resposta:**
    - 200 OK: Requisição bem-sucedida.
    - 404 Not Found: Não foram encontrados clientes cadastrados.

### GET: api/Cliente/{id}

Retorna os detalhes de um cliente específico com o ID fornecido.

- **Método HTTP:** `GET`
- **Endpoint:** `GET /api/Cliente/{id}`
- **Descrição:** Retorna os detalhes de um cliente específico com o ID fornecido.
- **Parâmetros:** `id` - O ID do cliente a ser recuperado.
- **Resposta:** Um objeto JSON representando o cliente com o ID fornecido.
- **Código de Resposta:**
    - 200 OK: Requisição bem-sucedida.
    - 404 Not Found: Cliente não encontrado.

### PUT: api/Cliente/{id}

Atualiza os detalhes de um cliente existente com o ID fornecido.

- **Método HTTP:** `PUT`
- **Endpoint:** `PUT /api/Cliente/{id}`
- **Descrição:** Atualiza os detalhes de um cliente existente com o ID fornecido.
- **Parâmetros:** `id` - O ID do cliente a ser atualizado.
- **Corpo da Requisição:** Um objeto JSON contendo os novos detalhes do cliente.
- **Resposta:** Nenhuma resposta é retornada no corpo da resposta.
- **Código de Resposta:**
    - 204 No Content: Cliente atualizado com sucesso.
    - 400 Bad Request: O ID do cliente no corpo da requisição não corresponde ao ID fornecido nos parâmetros da URL.
    - 404 Not Found: Cliente não encontrado.

### POST: api/Cliente

Cria um novo cliente com os detalhes fornecidos.

- **Método HTTP:** `POST`
- **Endpoint:** `POST /api/Cliente`
- **Descrição:** Cria um novo cliente com os detalhes fornecidos.
- **Corpo da Requisição:** Um objeto JSON contendo os detalhes do novo cliente a ser criado.
- **Resposta:** Um objeto JSON representando o novo cliente criado.
- **Código de Resposta:**
    - 201 Created: Cliente criado com sucesso.
    - 409 Conflict: Já existe um cliente com o mesmo email ou telefone.

### DELETE: api/Cliente/{id}

Remove um cliente existente com o ID fornecido.

- **Método HTTP:** `DELETE`
- **Endpoint:** `DELETE /api/Cliente/{id}`
- **Descrição:** Remove um cliente existente com o ID fornecido.
- **Parâmetros:** `id` - O ID do cliente a ser removido.
- **Resposta:** Nenhuma resposta é retornada no corpo da resposta.
- **Código de Resposta:**
    - 204 No Content: Cliente removido com sucesso.
    - 404 Not Found: Cliente não encontrado.

## API Reserva

Esta API fornece endpoints para realizar operações CRUD (Create, Read, Update, Delete) em relação as reservas do sistema.

### GET: api/Reserva

Retorna uma lista de todas as reservas cadastradas.

- **Método HTTP:** `GET`
- **Endpoint:** `GET /api/Reserva`
- **Descrição:** Retorna uma lista de todas as reservas cadastradas no sistema.
- **Resposta:** Uma lista de objetos JSON representando as reservas, ou um array vazio se não houver reservas cadastradas.
- **Código de Resposta:**
    - 200 OK: Requisição bem-sucedida.
    - 404 Not Found: Não foram encontradas reservas cadastradas.

### GET: api/Reserva/{id}

Retorna os detalhes de uma reserva específica com o ID fornecido.

- **Método HTTP:** `GET`
- **Endpoint:** `GET /api/Reserva/{id}`
- **Descrição:** Retorna os detalhes de uma reserva específica com o ID fornecido.
- **Parâmetros:** `id` - O ID da reserva a ser recuperada.
- **Resposta:** Um objeto JSON representando a reserva com o ID fornecido.
- **Código de Resposta:**
    - 200 OK: Requisição bem-sucedida.
    - 404 Not Found: Reserva não encontrada.

### PUT: api/Reserva/{id}

Atualiza os detalhes de uma reserva existente com o ID fornecido.

- **Método HTTP:** `PUT`
- **Endpoint:** `PUT /api/Reserva/{id}`
- **Descrição:** Atualiza os detalhes de uma reserva existente com o ID fornecido.
- **Parâmetros:** `id` - O ID da reserva a ser atualizada.
- **Corpo da Requisição:** Um objeto JSON contendo os novos detalhes da reserva.
- **Resposta:** Nenhuma resposta é retornada no corpo da resposta.
- **Código de Resposta:**
    - 204 No Content: Reserva atualizada com sucesso.
    - 400 Bad Request: O ID da reserva no corpo da requisição não corresponde ao ID fornecido nos parâmetros da URL.
    - 404 Not Found: Reserva não encontrada.

### POST: api/Reserva

Cria uma nova reserva com os detalhes fornecidos.

- **Método HTTP:** `POST`
- **Endpoint:** `POST /api/Reserva`
- **Descrição:** Cria uma nova reserva com os detalhes fornecidos.
- **Corpo da Requisição:** Um objeto JSON contendo os detalhes da nova reserva a ser criada.
- **Resposta:** Um objeto JSON representando a nova reserva criada.
- **Código de Resposta:**
    - 201 Created: Reserva criada com sucesso.
    - 409 Conflict: Já existe uma reserva com o mesmo ID.

### DELETE: api/Reserva/{id}

Remove uma reserva existente com o ID fornecido.

- **Método HTTP:** `DELETE`
- **Endpoint:** `DELETE /api/Reserva/{id}`
- **Descrição:** Remove uma reserva existente com o ID fornecido.
- **Parâmetros:** `id` - O ID da reserva a ser removida.
- **Resposta:** Nenhuma resposta é retornada no corpo da resposta.
- **Código de Resposta:**
    - 204 No Content: Reserva removida com sucesso.
    - 404 Not Found: Reserva não encontrada.

## API Veículo

Esta API fornece endpoints para realizar operações CRUD (Create, Read, Update, Delete) sobre os veículos no sistema da LocaVeiculos.

### GET: api/Veiculo

Retorna uma lista de todos os veículos cadastrados.

- **Método HTTP:** `GET`
- **Endpoint:** `GET /api/Veiculo`
- **Descrição:** Retorna uma lista de todos os veículos cadastrados no sistema.
- **Resposta:** Uma lista de objetos JSON representando os veículos, ou um array vazio se não houver veículos cadastrados.
- **Código de Resposta:**
    - 200 OK: Requisição bem-sucedida.
    - 404 Not Found: Não foram encontrados veículos cadastrados.

### GET: api/Veiculo/{id}

Retorna os detalhes de um veículo específico com o ID fornecido.

- **Método HTTP:** `GET`
- **Endpoint:** `GET /api/Veiculo/{id}`
- **Descrição:** Retorna os detalhes de um veículo específico com o ID fornecido.
- **Parâmetros:** `id` - O ID do veículo a ser recuperado.
- **Resposta:** Um objeto JSON representando o veículo com o ID fornecido.
- **Código de Resposta:**
    - 200 OK: Requisição bem-sucedida.
    - 404 Not Found: Veículo não encontrado.

### PUT: api/Veiculo/{id}

Atualiza os detalhes de um veículo existente com o ID fornecido.

- **Método HTTP:** `PUT`
- **Endpoint:** `PUT /api/Veiculo/{id}`
- **Descrição:** Atualiza os detalhes de um veículo existente com o ID fornecido.
- **Parâmetros:** `id` - O ID do veículo a ser atualizado.
- **Corpo da Requisição:** Um objeto JSON contendo os novos detalhes do veículo.
- **Resposta:** Nenhuma resposta é retornada no corpo da resposta.
- **Código de Resposta:**
    - 204 No Content: Veículo atualizado com sucesso.
    - 400 Bad Request: O ID do veículo no corpo da requisição não corresponde ao ID fornecido nos parâmetros da URL.
    - 404 Not Found: Veículo não encontrado.

### POST: api/Veiculo

Cria um novo veículo com os detalhes fornecidos.

- **Método HTTP:** `POST`
- **Endpoint:** `POST /api/Veiculo`
- **Descrição:** Cria um novo veículo com os detalhes fornecidos.
- **Corpo da Requisição:** Um objeto JSON contendo os detalhes do novo veículo a ser criado.
- **Resposta:** Um objeto JSON representando o novo veículo criado.
- **Código de Resposta:**
    - 201 Created: Veículo criado com sucesso.
    - 409 Conflict: Já existe um veículo com a mesma placa.

### DELETE: api/Veiculo/{id}

Remove um veículo existente com o ID fornecido.

- **Método HTTP:** `DELETE`
- **Endpoint:** `DELETE /api/Veiculo/{id}`
- **Descrição:** Remove um veículo existente com o ID fornecido.
- **Parâmetros:** `id` - O ID do veículo a ser removido.
- **Resposta:** Nenhuma resposta é retornada no corpo da resposta.
- **Código de Resposta:**
    - 204 No Content: Veículo removido com sucesso.
    - 404 Not Found: Veículo não encontrado.

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

# Considerações Finais

O sistema LocaVeículos, que foi desenvolvido para gerenciar locadoras de veículos, representa um avanço significativo na otimização de processos e na experiência do cliente. Utilizando tecnologias modernas, ele oferece uma solução robusta e escalável. Embora enfrentando desafios durante o desenvolvimento, como integração de componentes e garantia de desempenho, o LocaVeículos superou obstáculos e entregou um sistema eficiente.

Os benefícios do LocaVeículos são notáveis, automatizando processos manuais, melhorando a precisão dos dados e proporcionando agilidade no atendimento. Além disso, sua capacidade analítica oferece suporte à tomada de decisões estratégicas. Olhando para o futuro, vemos potencial para expansão e aprimoramento com a integração de novas tecnologias e feedback contínuo dos usuários.

Em suma, o LocaVeículos representa um passo significativo na evolução da indústria de aluguel de veículos, proporcionando benefícios tanto para empresas quanto para clientes, e contribuindo para um setor mais eficiente e centrado no cliente.

# Referências

- [Template SBC Conferences](https://www.overleaf.com/latex/templates/sbc-conferences-template/blbxwjwzdngr)
- [Documentação do ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-8.0)