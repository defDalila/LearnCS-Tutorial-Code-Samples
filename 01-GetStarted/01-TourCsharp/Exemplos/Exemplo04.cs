

namespace TourCsharp.Exemplos;

public static class Exemplo04
{
    public static void Run()
    {
        Console.WriteLine("Foi Triste Esse - no Aplicativo de Console");
    }
    public static async IAsyncEnumerable<int> ReadSequence()
    {
        int index = 0;
        while (index < 100)
        {
            int[] nextChunk = await GetNextChunk(index);
            if (nextChunk.Length == 0)
            {
                yield break;
            }
            foreach (var item in nextChunk)
            {
                yield return item;
            }
            index++;
        }

        await foreach (var number in ReadSequence())
        {
            Console.WriteLine(number);
        }
    }

    private static Task<int[]> GetNextChunk(int index)
    {
        throw new NotImplementedException();
    }
}




