using System;
namespace DSA_Library
{
	public class CheckPermutation
	{
        public static readonly string name = "1.2 Check Permutation";
        public static readonly string description = "Given two strings, write a method to decide if one is a permutation of the other";

        public static bool Solution1(string str1, string str2)
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine("Input1: " + str1);
            Console.WriteLine("Input2: " + str2);

            // Edge cases: different lengths, null values, empty string
            if (string.IsNullOrEmpty(str1) | string.IsNullOrEmpty(str2))
            {
                return false;
            }

            if (str1.Length != str2.Length)
            {
                return false;
            }

            // Iterate over string 2 and search for first letter of string 1
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1[0] == str2[i])
                {
                    // Split up string 2 at index, rearrange, & compare to first string
                    if (str1 == str2[i..] + str2[..i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

