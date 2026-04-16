# Biblioteca-WEB-II
Projeto trabalho no 1° bimestre de Programação WEB II
1. Certifique-se de que a framework .NET esteja instalado, pelo menos da versão 10 ou mais recente, não podemos garantir o funcionamento em versões mais antigas ou desatualizadas
2. certifique-se de que o MySQL esteja instalado
3. baixe, clone, ou use um pull, neste repositório em qualquer pasta desejada
4. Abra a pasta Biblioteca, clique com o botão direito e selecione "Abrir no Terminal", ou navegue pelo Prompt de Comando até chegar na pasta criada
5. escreva o seguinte comando: "dotnet run"
6. e procure por uma mensagem que aparecerá, que fornecerá um link, copie e cole o link em um navegador, ou segure a tecla Ctrl + clique no link
Caso haja um erro, entre na pasta da biblioteca e procure por "appsettings.json", abra esse arquivo em uma IDE ou em um compilador (ou renomei-o para "appsettigns.txt" para poder editar)
e no campo "DefaultConnection", edite a "port", para porta de conexção que o seu banco de dados esteja conectada,a "uid", para o nome do usuário da conexão do banco de dados, a "pwd", para a senha da conexão do seu banco de dados
e por fim, certifique-se de que haja um banco de dados nomeado "bibliotecadb", ou então, que o campo "database" esteje com o nome de um banco de dados já existente, de preferencia um que esteje vazio.

É importante lembrar que esta aplicação está sendo rodada em seu próprio computador, então toda a lógica de funcionamento e a dependencia de banco de dados, se dá pelo fato de que você se torna o servidor que hospedaria esses arquivos e dados
