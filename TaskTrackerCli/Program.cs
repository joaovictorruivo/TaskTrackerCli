using System;
using TaskTrackerCli; // Garante que o Program enxerga a sua classe

var gerenciador = new GerenciadorTarefas();

while (true)
{
    Console.WriteLine("\n--- GERENCIADOR DE TAREFAS ---");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Listar Tarefas");
    Console.WriteLine("3. Concluir Tarefa");
    Console.WriteLine("4. Excluir Tarefa"); // A nova opção entra aqui
    Console.WriteLine("5. Sair");            // Sair passa a ser a opção 5
    Console.Write("Escolha uma opção: ");

    var opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.Write("Digite a descrição da tarefa: ");
        var desc = Console.ReadLine() ?? "";

        if (!string.IsNullOrWhiteSpace(desc))
        {
            gerenciador.Adicionar(desc);
            Console.WriteLine("Tarefa adicionada e salva com sucesso!");
        }
        else
        {
            Console.WriteLine("A descrição não pode ser vazia.");
        }
    }
    else if (opcao == "2")
    {
        Console.WriteLine("\nSua Lista de Tarefas:");
        var lista = gerenciador.Listar();

        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada ainda.");
        }
        else
        {
            foreach (var t in lista)
            {
                Console.WriteLine($"[{t.Id}] {t.Descricao} - {(t.Concluida ? "Concluída" : "Pendente")}");
            }
        }
    }
    else if (opcao == "3")
    {
        Console.Write("Digite o ID da tarefa que deseja concluir: ");
        if (int.TryParse(Console.ReadLine(), out int idParaConcluir))
        {
            gerenciador.Concluir(idParaConcluir);
            Console.WriteLine("Status da tarefa atualizado com sucesso!");
        }
        else
        {
            Console.WriteLine("ID inválido! Digite apenas números.");
        }
    }
    else if (opcao == "4")
    {
        Console.Write("Digite o ID da tarefa que deseja excluir: ");
        if (int.TryParse(Console.ReadLine(), out int idParaExcluir))
        {
            bool sucesso = gerenciador.Excluir(idParaExcluir);
            if (sucesso)
            {
                Console.WriteLine("Tarefa excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada na lista.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido! Digite apenas números.");
        }
    }
    else if (opcao == "5") // A opção Sair agora é a 5
    {
        Console.WriteLine("A sair...");
        break;
    }
}
