using TourCsharp.Exemplos;

// Pra não dar azar!!
Console.WriteLine("Hellow Povão do WoorldiMeuDeus!!");
Console.WriteLine();


#if false

// Expressões de Correspondência
Exemplo01.Run();


// Expressões de coleção
Exemplo02.Run();


// consulta integrada a Linguagem LINQ
Exemplo03.Run();
#else
//  modelo de programação assíncrona baseado em tarefas 
Exemplo04.Run();

#endif

