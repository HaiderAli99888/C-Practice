using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

public class Program
{
    private static int CountCharacters()
    {
        int count = 0;
        using (StreamReader reader = new StreamReader("C:\\data\\data.txt"))
        {
            string content = reader.ReadToEnd();
            count = content.Length;
            Thread.Sleep(5000); // Simulating long processing time
        }
        return count;
    }

    public async static Task AA()
    {
        Task<int> task = new Task<int>(CountCharacters);
        task.Start();

        Console.WriteLine("Processing file. Please wait...");
        int count = await task;
        Console.WriteLine(count.ToString() + " characters in file");
    }

    public static void Main()
    {
        AA().GetAwaiter().GetResult();
    }
}
