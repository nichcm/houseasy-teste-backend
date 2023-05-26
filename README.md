# README

# Descrição
Este repositório contém um código em C# que utiliza o .NET Entity Framework e Migrations. Ele fornece uma base para construir aplicativos que exigem operações e migrações de banco de dados.

# Tecnologias Utilizadas
- C#
- .NET Framework
- Entity Framework
- Migrations

# Pré-requisitos
- Visual Studio (ou qualquer IDE compatível) com o .NET Framework instalado.
- SQL Server (ou qualquer outro servidor de banco de dados suportado).

# Instruções de Configuração
1) Clone o repositório em sua máquina local usando o seguinte comando:
  ```
  git clone https://github.com/nichcm/houseasy-teste-backend.git
  ```
2) Abra o arquivo de solução (TesteHouseEasy.sln) no Visual Studio.
3) Restaure os pacotes do NuGet clicando com o botão direito na solução no Solution Explorer e selecionando "Restaurar Pacotes do NuGet".
4) Configure a string de conexão no arquivo appsettings.json. Atualize o valor Database com os detalhes do seu servidor de banco de dados.
5) Abra o Package Manager Console no Visual Studio indo em Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes.
6) Execute o seguinte comando no Package Manager Console para aplicar a migração 
```
cd .\TesteHouseEasy\
dotnet ef database update --context SistemaDbContext
```
    
7)Compile a solução para garantir que tudo esteja configurado corretamente.
8)Execute o aplicativo e explore o código fornecido para entender sua estrutura e funcionalidade.


# Utilização
Este código pode servir como ponto de partida para o desenvolvimento de aplicativos que exigem operações de banco de dados usando o Entity Framework e Migrations. Ele fornece um conjunto de modelos de banco de dados preconfigurados, migrações e configurações de conexão para facilitar o processo de desenvolvimento.

Sinta-se à vontade para modificar e estender o código de acordo com seus requisitos específicos. Você pode adicionar mais modelos, definir migrações adicionais e personalizar as operações de banco de dados conforme necessário.

# Contribuições
Contribuições são bem-vindas! Se você deseja contribuir para este projeto, siga estas etapas:

Faça um fork do repositório.
Crie um novo branch para sua funcionalidade ou correção de bug.
Faça suas alterações e as cometa.
Envie suas alterações para o seu repositório forkado.
Envie um pull request explicando suas alterações.
        
