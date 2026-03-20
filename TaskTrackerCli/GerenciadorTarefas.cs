using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TaskTrackerCli
{
    public class GerenciadorTarefas
    {
        private List<Tarefa> _tarefas = new();
        private const string Arquivo = "tarefas.json";

        // Construtor: carrega as tarefas salvas assim que o programa inicia
        public GerenciadorTarefas()
        {
            if (File.Exists(Arquivo))
            {
                string json = File.ReadAllText(Arquivo);
                _tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();
            }
        }

        public void Adicionar(string descricao)
        {
            int novoId = _tarefas.Count > 0 ? _tarefas.Max(t => t.Id) + 1 : 1;
            _tarefas.Add(new Tarefa { Id = novoId, Descricao = descricao, Concluida = false });
            Salvar();
        }

        public List<Tarefa> Listar() => _tarefas;

        private void Salvar()
        {
            var json = JsonSerializer.Serialize(_tarefas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Arquivo, json);
        }
    }
}