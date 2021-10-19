# Api Redux

Para a API optei por realizar uma API C# com o .NET Framework para realizar a implementação e o EntityFramework para realizar as comunicações com o banco de dados.

Escolhi estas opções por ja possuir experiencia em desenvolvimento de APIS nestas plataformas.

No projeto possuimos um controller com o nome de DesenvolvedoresController.cs localizado na pasta Controllers. 
  Controller responsavel por receber as solicitações de GET POST PUT DELETE e realizar as chamadas do EntityFramework para postagem no banco de dados.
  
Para o banco de dados optei peo SQL Server.
  Escolhi o SQL Server por ja possuir experiencia e pelo motivo de compatibilidade com a estrutura Microsoft escolhida para o desenvolvimento da API
  
  Nao consegui subir o banco de dados em Docker por alguns problemas em minha maquina e problemas com a imagem Windows e por isso estarei disponibilizando os
  scripts de inclusao do banco e tabela
  
  --------------------BANCO------------------------
  
  1. Criação do banco
  
    CREATE DATABASE API_REDUX
    GO
  
  2. Criação da tabela
  
    CREATE TABLE dbo.Desenvolvedor
    (
      Id int NOT NULL IDENTITY (1, 1),
      Nome varchar(255) NULL,
      Sexo char(50) NULL,
      Idade int NULL,
      Hobby varchar(255) NULL,
      DataNascimento date NULL
    )  ON [PRIMARY]
    GO
    
    3. Exemplo de insert manual para testes
    
       INSERT INTO DESENVOLVEDOR (Nome, Sexo, Idade, Hobby, DataNascimento)
       VALUES ('Pedro Henrique Dias', 'Masculino', 19, 'Jogar Playstation', '2002-01-17')
       
    4. Apos a criação do banco localize o arquivo Web.config no diretorio da API e procure a tag (linha 12) e substitua de acordo com sua configuracao
     <connectionStrings>
        <add name="ApiConectionString" connectionString="Data Source=DEV-01;Initial Catalog=API_REDUX;User Id=sa;Password=sa@051161;Connect Timeout=60"           providerName="System.Data.SqlClient" />
     </connectionStrings>
     
     connectionString="Data Source=!!SEU SERVIDOR!!;Initial Catalog=!! NOME DO BANCO!! (Padrao distribuido como API_REDUX);User Id=sa;Password=sa@051161;Connect Timeout=60"
       
       
 --------------------------------------------------------------
 
 Realizados os procedimentos de banco basta executar a API e executar os arquivos de Front para testar as requisições e as respostas.
       
       
       
