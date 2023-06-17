# Registro de Testes de Software
## Avaliação

| Caso de Uso  |  CT-01 – Cadastrar corretamente o usuário |
|---|---|
| Requisitos Associados  | RF-01 – O sistema deve permitir que o usuário realize o cadastro informando a instituição de ensino  |
||RF-01 – O sistema deve permitir que o usuário realize o cadastro informando a instituição de ensino|
|Objetivo do Teste|Verificar se o formulário de cadastro está aceitando corretamente todos os campos, inclusive o da instituição de ensino. Para que isso aconteça, haverá o site funcionando que permita a exibição da aplicação| 
|Passos|1-      Acessar o navegador|
||2-      Informar o endereço do site|
||3-      Utilizar a funcionalidade “Crie sua conta”|
|Critério de Êxito| - O site da aplicação está disponível|
|| - Os campos foram preenchidos com as devidas informações|
|| - Sucesso de login após o cadastro|
|**Êxito no teste?**| Sim (  ) Não (  )|
|Comentário||


|Caso de Teste|CT-02 – Aprimorar o nível de usuário|
|---|---|
|Requisitos Associados|RF-09 – O sistema deve permitir o usuário se tornar verificado através do envio do comprovante de matrícula|
|Objetivo do Teste|Verificar se o usuário ganhará o selo verificado após o envio do comprovante de matrícula|
|Passos|1.       Entrar no sistema como usuário já cadastrado|
||2.       Na área do usuário, solicitar o envio do comprovante de matrícula|
|Critério de Êxito|  - Sucesso no envio do comprovante de matrícula|
|| - Usuário agora é um Usuário Verificado|
||- Ter acesso a descontos especiais|
|**Êxito no teste?**| Sim (  ) Não (  )|
|Comentário||

|Caso de Teste|CT-03 – Buscar por descontos|
|---|---|
|Requisitos Associados|RF-02 – O sistema deve permitir através de uma barra de buscas que os usuários procurem por descontos específicos|
||RF-03 – O sistema deve pedir confirmação do usuário caso ele utilize um desconto que o sistema não tenha acesso direto|
||RF-04 – O sistema deve separar os descontos por categorias|
||RF-05 – O sistema deve destacar parceiros|
||RF-08 – O sistema deve exibir descontos diferenciados para estudantes verificados|
||RF-11 – O sistema deve fornecer descrição de cada produto/desconto e o link para redirecionamento|
|Objetivo do Teste|Verificar todas as funcionalidades relacionadas a busca pelos descontos e como eles aparecem como retorno, assim como suas descrições e disponibilizações|
|Passos|1.       Utilizar a barra de buscas dentro do site|
||2.       Digitar pelo produto: “Spotify” (exemplo)|
||3.       Selecionar a exibição por categorias|
||4.       Se usuário verificado, visualizar descontos especiais|
||5.       Clicar no link do desconto|
|Critério de Êxito|- A tela de exibição de descontos destaca os parceiros|
||- O ícone de organização por categorias funciona corretamente|
||- A barra de buscas está retornando o que se espera|
||- O sistema avisa o usuário do redirecionamento|
||- Descontos especiais para usuários verificados estão visualmente marcados|
||- A descrição de cada produto está correta|
|**Êxito no teste?**| Sim (  ) Não (  )|
|Comentário||

|Caso de Teste|CT-04 – Manusear o perfil|
|---|---|
|Requisitos Associados|RF-06 – O sistema deve gerar histórico de itens/descontos selecionados pelo usuário|
||RF-07 – O sistema deve permitir recuperar senha através do e-mail ou telefone celular (SMS)|
|Objetivo do Teste|Verificar se está funcionando corretamente a opção dentro do perfil do usuário de gerar histórico dos itens selecionados e outras funcionalidades como mudar a senha|
||Caso não seja possível fazer o login, verificar se o sistema permite recuperar a senha|
|Passos|1.       É possível entrar no sistema? Não. Selecionar a opção “Recuperar Acesso”|
||2.       Já logado no sistema, dentro do Perfil, utilizar as opções “Trocar a senha” e “Histórico de produtos”|
|Critério de Êxito| - O sistema permite recuperar o acesso|
|| - O histórico é gerado de forma fidedigna|
||- A senha é alterada com sucesso|
|**Êxito no teste?**| Sim (  ) Não (  )|
|Comentário||

