using DSA_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the C# Algo Tester");

        string name = CheckPermutation.name;
        Console.WriteLine("Problem: " + name);

        string description = CheckPermutation.description;
        Console.WriteLine("Description: " + description);

        bool output = CheckPermutation.Solution1(CheckPermutation.input1, CheckPermutation.input3);
        Console.WriteLine("Output: " + output);
    }
}