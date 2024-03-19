using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Novo!");
        Console.WriteLine("LazaCoder2");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
