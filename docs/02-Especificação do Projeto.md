# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Levantamos a necessidade da criação de um sistema que atendesse às demandas financeiras de estudantes e universitários. Os membros da equipe passaram alguns dias em estabelecimentos a fim de entender, através de observações e entrevistas, quais eram os problemas enfrentados no dia a dia de um estudante universitário no que diz respeito a sua vida financeira e seus desejos em conseguir descontos especiais em empresas e softwares diversos. 


## Personas

***

### **João Astolfindo**

**Idade**: 37

**Formação e ocupação**: Empresário no ramo de gastronomia há mais de 10 anos em busca de seguir o sonho de ser professor de Geografia.

**Objetivos**: João almeja se formar como Geógrafo e deseja realizar uma transição radical de carreira.

**Motivações**: Sua maior motivação é a paixão por viagens e lugares novos

**Medos**: Possui receio de não conseguir administrar e guardar dinheiro suficiente para a mudança de carreira de forma segura. 

**Hobbies**: Sua paixão por diferentes culturas o direcionaram a cursar Geografia.

***

### **Ana Carolina**

**Idade:** 24

**Formação e ocupação:** Estudante bolsista do terceiro ano de direito em uma excelente faculdade privada e revendedora de cosméticos.

**Objetivos:** Ana deseja se tornar uma advogada renomada e trabalhar em um grande escritório em São Paulo.

**Motivações:** Sua maior motivação é a família.

**Medos:** Possui receio de não  conseguir se manter até o término da faculdade.

**Hobbies:** Ama viajar e assistir séries criminais.

***

### **Julia Truliety**

**Idade:** 46

**Formação e ocupação:** Estudante de Pedagogia no período da noite e trabalha como empregada doméstica.

**Objetivos:** Julia deseja se tornar uma professora do jardim de infância.

**Motivações:** O seu grande alicerce é a família. Julia tem o sonho de visitar seu filho que está morando no Canadá há 2 anos.

**Medos:** Possui receio de não conseguir se manter até o término da faculdade.

**História e Hobbies:** Ama crianças e educação infantil.

***

### **Enzo Eduardo**

**Idade:** 19

**Formação e ocupação:** Estudante de Medicina em período integral

**Objetivos:** Enzo deseja se tornar um médico do programa Médicos sem Fronteiras.

**Motivações:** O seu grande sonho é se tornar médico. Ele também ama video games.

**Medos:** Possui receio de se manter dependente financeiramente até o término da faculdade.

**Hobbies:** Ama jogar online

***

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

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

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)
