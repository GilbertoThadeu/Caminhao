# Caminhao
Para testar é preciso ter o visual studio 2019 ou superior. 
Abrir o arquivo Caminhao.sln.
Como solicitado o banco de dados é local para isso é preciso criar uma base de dados sem a necessidade de criar tabalas, pois o migration fará.
É necessario criar o banco de dados e colocar a configuração de conexão no arquivo appsetting.json, só substituir a configuração atual que está na variavel "cnstr",
Apague os arquivos que estão dentro da pasta Migrations.
Abrir o console do gerenciador de pacotes do nuget em Ferramentas -> Gerenciador de pacotes do nuget -> Console de gerenciador de pacotes
Digitar o comando: Add-Migration odata-v1
Depois digitar o comando: Update-Database
E apertar ctrl + F5 para recompilar e executar o projeto.

Caso ocorra algum erro é só clicar com o botão direito no visual studio em cima da Solução 'Caminhao' e escolher "clean soluction" ou "limpar solução", 
depois clicar com o botão direito no mesmo local e escolher a opção "Build Soluction" ou "Compilar Solução", 
aguarde o processo, e clique com o botão direito novamente no mesmo local e escolher a opção "Rebuild Soluction" ou "Recompilar Solução", execute o projeto.
