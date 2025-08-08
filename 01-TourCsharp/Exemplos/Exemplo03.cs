using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCsharp.Exemplos;
class Aluno
{
    // Cria Entidade Aluno  que mapeia os dados do Banco
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public double CRA { get; set; }
}

public static class Exemplo03
{
    // Exemplo sobre consulta integrada a Linguagem LINQ
    public static void Run()
    {
        // cria fonte de dados para ser possível rodar a query
        List<Aluno> Alunos = new()
        {
            new Aluno { Id = 1, Nome = "Alice", CRA = 6.9 },
            new Aluno { Id = 2, Nome = "Bob", CRA = 8.7 },
            new Aluno { Id = 3, Nome = "Carol", CRA = 7.9 },
            new Aluno { Id = 4, Nome = "Dave", CRA = 9.2 },
            new Aluno { Id = 5, Nome = "Miguel", CRA = 9.2 },
            new Aluno { Id = 6, Nome = "Laura", CRA = 5.2 },
            new Aluno { Id = 7, Nome = "Pedro", CRA = 7.2 },
            new Aluno { Id = 8, Nome = "Vulgo", CRA = 4.2 },
        };

        // gerar query de consulta
        IEnumerable<Aluno> meritosQuery = from aluno in Alunos
                                          where aluno.CRA > 8.0
                                          select aluno;

        // foreach para exibir resultado da query
        foreach (var i in meritosQuery)
        {
            Console.WriteLine($"Nome: {i.Nome}\tCRA: {i.CRA}");
        }
    }
}




