using System;
namespace DSA_Library
{
	public class IsUnique
	{
        public static readonly string name = "1.1 Is Unique";
        public static readonly string description = "Implement an algorithm to determine if a string has all unique characters. What if you cannot user additional data structures?";

        public static bool Solution1(string? str)
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine("Input: " + str);

            // Edge cases: null value
            if (str is null)
            {
                return false;
            }

            // Edge cases: empty string
            if (str.Length == 0)
            {
                return false;
            }

            // Use array of booleans to track each ASCII value
            bool[] chars = new bool[256];

            // Iterate over string
            for (int i = 0; i < str.Length; i++)
            {
                // Convert character to ASCII value
                int value = (int)str[i];

                // Check if character in array
                if (chars[value])
                {
                    return false;
                }

                // Add character to array
                chars[value] = true;
            }

            // Return true if no duplicate characters found
            return true;
        }

        public static bool Solution2(string str)
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine("Input: " + str);

            // Edge cases: empty string, one character string, longer than 256 chrs
            if (str.Length <= 1 || str.Length > 256)
            {
                return true;
            }

            // Iterate over string with outer & inner loop to compare each combination of characters
            for (int outer = 0; outer < (str.Length - 1); outer++)
            {
                for (int inner = outer + 1; inner < str.Length; inner++)
                {
                    // Check if characters match
                    if (str[outer] == str[inner])
                    {
                        return false;
                    }
                }
            }

            // Return true if no duplicate characters found
            return true;
        }
    }
}

