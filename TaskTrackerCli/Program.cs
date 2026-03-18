using TaskTrackerCli;

List<Tarefa> tarefas = new List<Tarefa>();
int proximoId = 1;

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
        Console.Write("Digite a descrição: ");
        var desc = Console.ReadLine() ?? "";
        tarefas.Add(new Tarefa { Id = proximoId++, Descricao = desc });
        Console.WriteLine("Tarefa adicionada!");
    }
    else if (opcao == "2")
    {
        Console.WriteLine("\nSua Lista:");
        foreach (var t in tarefas)
        {
            Console.WriteLine($"[{t.Id}] {t.Descricao} - {(t.Concluida ? "Check" : "Pendente")}");
        }
    }
    else if (opcao == "3") break;
}