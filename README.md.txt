# 📌 Task Tracker CLI

Um Gerenciador de Tarefas simples e robusto executado via linha de comando (Console), desenvolvido em C#. Este projeto foi criado para demonstrar habilidades fundamentais de programação, organização de código e persistência de dados.

## 🚀 Funcionalidades

O sistema implementa um CRUD completo (Create, Read, Update, Delete) com as seguintes opções:

- **Adicionar Tarefa:** Cria uma nova tarefa com uma descrição.
- **Listar Tarefas:** Exibe todas as tarefas cadastradas e seus respectivos status (Pendente/Concluída).
- **Concluir Tarefa:** Altera o status de uma tarefa específica buscando pelo seu ID.
- **Excluir Tarefa:** Remove permanentemente uma tarefa da lista.
- **Persistência de Dados:** Salva automaticamente as tarefas em um arquivo `tarefas.json`, garantindo que os dados não sejam perdidos ao fechar o programa.

## 🛠️ Tecnologias Utilizadas

- **C# / .NET** (Console Application)
- **System.Text.Json** (Para serialização e manipulação do arquivo JSON)
- **LINQ** (Para consultas e manipulação eficiente das listas em memória)

## ⚙️ Arquitetura e Boas Práticas

- **Clean Code:** Lógica de negócio separada da interface do usuário (`Program.cs` vs `GerenciadorTarefas.cs`).
- **Tratamento de Exceções:** Validação de entradas do usuário para evitar "crashes" (ex: digitar letras onde se espera um número de ID).
- **Orientação a Objetos:** Uso de classes e encapsulamento para modelar o domínio (`Tarefa`).

## 💻 Como Executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado na sua máquina.
2. Clone este repositório:
   ```bash
   git clone URL_DO_SEU_REPOSITORIO AQUI