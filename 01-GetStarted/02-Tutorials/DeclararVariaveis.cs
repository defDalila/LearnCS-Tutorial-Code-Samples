namespace Tutorials;
public static class DeclararVariaveis
{
    /* TUTORIAL_01: DeclararVariaveis
     *  [x]- Declarar, atibuir e Utilizar uma variável dentro de um método;
     *  [x]  atribuir valores diferentes a variável Declarada
     *  [x] utilizar interpolação de string[$"momomo {file}"]
     */

    public static void Executar()
    {
        string umAmigo = "Billy The Bill";
        Console.WriteLine(umAmigo);
        Console.WriteLine();

        // atribuir valores diferentes às variáveis Declaradas
        // não é permitido declarar novamente mesmo nome da variável no mesmo escopo
        umAmigo = "Não è O Billy Mais, Agora é o Bull Boy";
        Console.WriteLine(umAmigo);
        Console.WriteLine();

        // alterar valor e concatenar a saída [+]
        umAmigo = "Lady Gauss Traidora";
        Console.WriteLine("... HelloOoOowwwWW... " + umAmigo + " ... U.u  !!" + "\n");

        // utilizando interpolação de string: [$"momomo {file}"]
        Console.WriteLine($"Que saudades a mamaezinha está da gatinha, {umAmigo}, dela...\n");

    }

}
