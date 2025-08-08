
namespace TourCsharp.Exemplos;

public static class Exemplo02
{
    // Exemplos de Código - Expressões de Coleção
    public static void Run()
    {


        //---------- B E F O I ------------

        int[] num1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] num2 = new int[10];

        num2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];



        // ---------N O W G O R A ------------

        // compilador converte a expressão no tipo de coleção necessária
        // dispensa o uso de new int[] {};
        int[] numeros = [-1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        IEnumerable<int> maisNumeros = [-3, -2, .. numeros, 11, 12, 13];
        IEnumerable<string> empty = [];

        //---------- B E F O I ------------
        // instancia
        List<string> nomes1 = new List<string>();

        // inst e inicializa
        List<string> nomes2 = new List<string>() { "Alice", "Bob", "Charlie", "David" };

        // ---------NOWGORA ------------
        List<string> nomes3 = []; // TCharaaam

        // ai add na fé q to fora!
        nomes3.Add("Alice");
        nomes3.Add("Charlie");

        // Mas se já der pra inicializar:
        List<string> nomesGatos = ["Dalila Mendonça", "Aurora QueFera", "Frederico Guduco",
                      "Lady Gauss", "Bibi Maritaca", "Apollo Dezoito", "Aisha Maria",
                      "E Tem O Bob Que Eh Dog"];

        // --
        // usar expressões de índice e intervalo para recuperar
        // um ou mais elementos de uma coleção indexável:

        // index baseado em 0
        string segundoNome = nomesGatos[1];
        Console.WriteLine($"Segundo nome da Lista [index = 1]:{segundoNome}");

        // ^1 é o último elemento da Lista
        string ultimoNome = nomesGatos[^1];
        Console.WriteLine($"Nome Do Último Gato [index ^1]:{ultimoNome}");

        // passando um slice como index - ultimo valor não inclusivo
        int[] menoresNumeros = numeros[0..3];
        Console.WriteLine($"Menores Números [index 0..3]: [{string.Join(',', menoresNumeros)}]");

    }
}
