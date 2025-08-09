using System.Diagnostics;
using Tutorials;

// Dicionário com todos os Exemplos de código devidamente ordenados
Dictionary<string, Action> exemplos = new()
{
    ["1"] = DeclararVariaveis.Executar,
    ["2"] = WorkWithStrings.Executar
};



#region Lógica Para selecionar e Executar Exemplo

Run(exemplos);
static void Run(Dictionary<string, Action> exemplos)
{
    Console.WriteLine("\n                                 Ordem dos arquivos");
    Console.WriteLine("===================================================");
    Console.WriteLine(" [ID]   =  Nome do arquivo com o método estático");
    Console.WriteLine("===================================================");
    Console.WriteLine();


    foreach ( var exemplo in exemplos )
    {
        Console.WriteLine($"  [{exemplo.Key}]   =   {exemplo.Value.Method.DeclaringType?.Name}.cs");
    }



    Console.WriteLine("\n\n---------------------------------------------------\n");
    do
    {

        Console.Write("\n Entre com o Número de [ID]: ");
        var KeyInfo = Console.ReadKey();


        var opcao = KeyInfo.KeyChar.ToString();

        if ( exemplos.TryGetValue(opcao, out var executar) )
        {
            Console.Clear();
            Console.Write($"EXECUÇÃO {executar.Method.DeclaringType?.Name}.cs");
            Console.WriteLine("\n----------------------------------------------------------------------\n\n");
            Thread.Sleep(300);

            executar();

            FecharAplicacao();
        }
        else
        {
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"ENTRADA INVÁLIDA ( ID = [{opcao}])");



            Console.WriteLine("\n\n\n\nFalha na execução: código de saída (-1)");
            Environment.Exit(-1);
        }


    } while ( true );



    static void FecharAplicacao()
    {
        ;
        Console.WriteLine("\n\n\n\n\nExecução finalizada com sucesso: código de saída (0)");
        Environment.Exit(0);
    }
}
#endregion