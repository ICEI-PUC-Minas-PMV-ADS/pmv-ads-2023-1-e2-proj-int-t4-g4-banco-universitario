# 2 - Especificações do Projeto


Levantamos a necessidade da criação de um sistema que atendesse às demandas financeiras de estudantes e universitários. Os membros da equipe passaram alguns dias em estabelecimentos a fim de entender, através de observações e entrevistas, quais eram os problemas enfrentados no dia a dia de um estudante universitário no que diz respeito a sua vida financeira e seus desejos em conseguir descontos especiais em empresas e softwares diversos. 


## 2.1 - Personas

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

## 2.2 - Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`   |
|--------------------|------------------------------------|--------------------------|
|João Astolfindo| conseguir acessar descontos para estudantes |poder escolher entre eles |
|João Astolfindo | Ver se a marca que eu gosto tem descontos exclusivamente para estudantes| poder adquirir seus serviços premium|
|João Astolfindo | Descobrir novas marcas | possam disponibilizar tempo de testes gratuitos em suas ferramentas e/ou softwares|
|João Astolfindo |Poder navegar pelas categorias de desconto|encontrar coisas novas|
|Ana Carolina|Poder indicar empresas que oferecem descontos para estudantes que não estão na plataforma |para outras pessoas poderem utilizar|
|Ana Carolina|Filtrar o histórico de descontos visitados/utilizados | fazer o controle de todos os sites visitados|
|Ana Carolina|Gostaria de, caso redirecionada para a página do desconto selecionado, poder confirmar ou não que utilizou o desconto |para manter um histórico ainda mais atualizado|
|Ana Carolina|||
|Julia Truliety |  ||
|Julia Truliety |Descontos em passagens áreas|para realizar o sonho de visitar seu filho no Canadá|
|Enzo Eduardo |ter acesso a programas de forma mais acessível para as atividades da faculdade |para realizar trabalhos e seminários|
|Enzo Eduardo |Descobrir jogos com descontos|poder gastar menos com seu hobbie|

## 2.3 - Requisitos

Com base nas Histórias de Usuário, enumeramos os requisitos da solução. Classificando esses requisitos em dois grupos:

- `Requisitos Funcionais (RF)`: correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- `Requisitos Não Funcionais (RNF)`: correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).

Lembrando que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### 2.3.1 - Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01|O sistema deve permitir que o usuário realize o cadastro informando a instituição de ensino.|Alta|
|RF-02|O sistema deve permitir através de uma barra de buscas que os usuários procurem por descontos específicos.|Alta|
|RF-03|O sistema deve pedir confirmação do usuário caso ele utilize um desconto que o sistema não tenha acesso direto. |Alta|
|RF-04|O sistema deve separar os descontos por categorias|Alta|
|RF-05|O sistema deve destacar parceiros|Alta|
|RF-06|O sistema deve gerar histórico de itens/descontos selecionados pelo usuário.|Média|
|RF-07|O sistema deve permitir recuperar senha através do E-mail ou Telefone celular (SMS).|Baixa| 
|RF-08|O sistema deve exibir descontos diferenciados para estudantes verificados.|Baixa|
|RF-09|O sistema deve permitir o usuário se tornar verificado através envio do comprovante de matrícula.|Média|
|RF-10|O sistema deve disponibilizar aplicativo e/ou site para o acesso dos usuários.|Alta|
|RF-11|O sistema deve fornecer descrição de cada produto/desconto e o link para redirecionamento.|	Baixa|
<!-- em construção e ajuste -->


### 2.3.2 - Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O sistema deverá ser Consistente e Padronizado por inteiro	|Alta|
|RNF-02| O sistema deve ser capaz de redirecionar o usuário para as páginas de desconto escolhidas em pelo menos 10 segundos.|Média|
|RNF-04| O sistema deve ser feito utilizando .NET Core em sua versão mais recente e estável	|Média|
|RNF-04| O software deve ser compatível com os principais browsers do mercado - Firefox, Chrome, Edge, Safari, Brave, etc.|Alta|
|RNF-05| O software deve ter um tempo de retorno para as consultas de até 10 segundos.|Média|
|RNF-06| O sistema deve ser capaz de rodar em diversos tamanhos de tela.|Alta|<!-- -->
|RNF-07|	O sistema deve ficar on-line sempre (24 horas por dia e 7 dias por semana).	|Alta|
|RNF-08|	O sistema não deverá ter linguagens diferentes na parte da APIs.	|Média|
|RNF-09|	O sistema deve estar em conformidade com as políticas de segurança e privacidade da empresa e com as leis e regulamentos bancários aplicáveis.	|Alta|
|RNF-10|	O sistema deve ser acessível para todos os usuários, independentemente de suas habilidades e deficiências seguindo as diretrizes de acessibilidade da Web (WCAG).|	Média|
|RNF-11|	Por padrão, o sistema não deverá repassar informações para plataformas externas. Somente as autorizadas pelo usuário.	|Média|

## 2.4 - Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser finalizado até o dia 19/06/2023|
|02| A equipe de desenvolvimento deve contar com 6 (seis) desenvolvedores|
|03| Deve haver ao menos 1 (uma) pessoa responsável pelo design do sistema|
|04| A equipe não pode trabalhar no projeto por mais de 4 (quatro) horas por dia|
|05| Deve haver pelo menos 1 (uma) reunião geral por semana, com duração de até 2 (duas) horas|
## 2.5 - Diagrama de Casos de Uso

![NovoUMLCasosDeUso drawio](https://user-images.githubusercontent.com/70844369/228082374-a9e0e9bd-15f3-4706-b920-4a4a81712f6e.png)

Figura 1 - Casos de uso do projeto - feito com a ferramenta draw.io


### Usando [draw.io](https://diagrams.net):
>
>Abra o site https://diagrams.net; ou faça download pelo [Link](https://github.com/jgraph/drawio-desktop/releases)
>
>Faça [Download](../docs/UML/) do nosso arquivo `.drawio`;
>
>Vá em `Start now` >>> `Abrir diagrama existente`
