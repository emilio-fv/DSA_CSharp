using DSA_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the C# Algo Tester");
        Console.WriteLine("This a custom DSA runner and tester.");

        char[] input = { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' ' };
        var response = URLify.Solution1(input, 13);
        Console.WriteLine(response);
    }
}