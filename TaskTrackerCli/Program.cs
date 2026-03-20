using System;
using TaskTrackerCli; // Garante que o Program enxerga a sua classe

var gerenciador = new GerenciadorTarefas();

while (true)
{
    Console.WriteLine("\n--- GERENCIADOR DE TAREFAS ---");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Listar Tarefas");
    Console.WriteLine("3. Sair");
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
        Console.WriteLine("Saindo...");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida! Tente novamente.");
    }
}
