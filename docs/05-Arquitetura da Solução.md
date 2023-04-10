# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Diagrama de Classes-PUC](https://user-images.githubusercontent.com/70844369/229944823-3a5d4fcb-8b1b-4f0b-b2a8-a07802911469.png)

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![Untitled Diagram drawio](https://user-images.githubusercontent.com/79220860/229956206-fa232741-37a2-48dc-beb0-bac447152687.png)


## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

Os elementos chave - ou entidades - da nossa aplicação são: Usuário, Produtos e Empresas. A seguir temos a imagem do modelo lógico com detalhes sobre as tabelas, relacionamentos, regras, metadados das colunas (tipo, tamanho, etc) seguido dos scripts para criação dessas tabelas/entidades no MySQL:

![Projeto Lógico](img/C%C3%B3pia%20de%20Diagrama%20de%20Classes-PUC.png)

create  table tabela_usuarios(
     nomeUsuario char(255) NOT NULL,
     email_Institucional char(255),
     email char(255) NOT NULL,
     instituicaoDeEnsino char(255),
     senha char(255),
     cpf int NOT NULL PRIMARY KEY,
     nMatricula int,
     estaValidado bool,
     clicou bool,
     dataInicio datetime,
     enviouComprovante bool

) ENGINE=storage_engine;

create  table tabela_produtos(
    idProduto int PRIMARY KEY,
    nomeProduto varchar(255) NOT NULL,
    descricaoProduto char(255) NOT NULL,
    categoria char(55),
    precoOriginal float,
    porcentagemDesconto float,
    link char(255)

) ENGINE=storage_engine;

create  table tabela_empresas(
    cnpj int NOT NULL PRIMARY KEY ,
    idEmpresa char(255),
    nomeEmpresa char(255),
    tipoNegocio char(255),
    cepEmpresa int,
    paisEmpresa char(55),
    descontoExclusivo char(255),
    inicioContratoParceria dateTime
) ENGINE=storage_engine;


## Tecnologias Utilizadas

As linguagens de programação utilizadas foram:
C# no desenvolvimento do backend da solução;
HTML, CSS e JavaScript no desenvolvimento do frontend da aplicação e a implementação de certas funcionalidades interativas;
MySQL no desenvolvimento do banco de dados.


## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
