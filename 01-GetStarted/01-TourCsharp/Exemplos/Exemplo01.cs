namespace TourCsharp.Exemplos;
public static class Exemplo01
{
    // Exemplo da utilização da sintaxe de correspondencia de Padrões
    public static void Run()
    {
        // Sintaxe para a Operação OU
        static bool OU(bool valor1, bool valor2) =>
            (valor1, valor2) switch
            {
                (true, true) => true,
                (true, false) => true,
                (false, true) => true,
                (false, false) => false,

            };

        // Sintaxe Reduzida Para a Operação OU
        static bool OUzinho(bool v1, bool v2) =>
            (v1, v2) switch
            {
                (false, false) => true,
                (_, _) => false
            };

        // Sintaxe Reduzida Para a Operação And
        static bool E(bool v1, bool v2) =>
            (v1, v2) switch
            {
                (true, true) => true,
                (_, _) => false
            };

        // Sistaxe Normal XOU (BR é complicado rsrs!) (da Xuxa)!
        static bool XOU(bool b1, bool b2) =>
            (b1, b2) switch // bananas de pijamas
            {
                (true, true) => true,
                (true, false) => true,
                (false, false) => false,
                (false, true) => false
            };

        Console.WriteLine(OU(true, false));
        Console.WriteLine(OUzinho(true, false));
        Console.WriteLine(OUzinho(false, false));
        Console.WriteLine(E(false, false));
        Console.WriteLine(XOU(true, false));
        Console.WriteLine(XOU(false, false));
        Console.WriteLine(XOU(false, true));

    }
}
