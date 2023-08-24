using DSA_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the C# Algo Tester");

        // Define problem an I/O
        string name = IsUnique.name;
        string description = IsUnique.description;
        var input = IsUnique.input1;
        bool output = IsUnique.Solution1(IsUnique.input2);

        // Print problem details and I/O
        Console.WriteLine("Problem: " + name);
        Console.WriteLine("Description: " + description);
        Console.WriteLine("Input: " + input);
        Console.WriteLine("Output: " + output);
    }
}