namespace Tutorials;
public static class WorkWithStrings
{
    /* TUTORIAL_02: WorkWithStrings
     *  [x]  Trabalhar com Strings, utilizando métodos de manipulação de strings;
     *  [x]  Exemplo: Concatenação e interpolação de strings, quantidade de caracteres (Length)
     *  [x]  Exemplo: .ToUpper(), .ToLower(), .Trim(), .Substring(), .Replace(), .IndexOf()
     *  [x]  Exemplo: .Split(), .Join(), .Contains(), .StartsWith(), .EndsWith()
     */

    public static void Executar()
    {
        string primeiroNome = "Aurora Afera";
        string segundoNome = "Frederico Guduco";

        // interpolação de strings
        Console.WriteLine($"Tenho uma gata que se chama {primeiroNome} " +
                            $"e um gato que se chama  {segundoNome}");
        // Propriedade Lenght
        Console.WriteLine($"O nome {primeiroNome} tem {primeiroNome.Length} letras");
        Console.WriteLine($"O nome {segundoNome} tem {segundoNome.Length} letras");

        
        //
        // remover os caracteres em branco no inicio, final ou em ambos de uma string
        string cumprimento = "      HelloWwW WorldiA!         ";
        Console.WriteLine($"[{cumprimento}]");


    }
}
