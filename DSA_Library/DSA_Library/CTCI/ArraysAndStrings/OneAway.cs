using System;
namespace DSA_Library.CTCI.ArraysAndStrings
{
	public class OneAway
	{
        public static readonly string name = "1.5 One Away";
        public static readonly string description = "There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character. given two strings, write a function to check if they are one or zero edits away";

        public static bool Solution1(string? str1, string? str2)
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine($"Inputs: {str1} {str2}");

            if (str1 is null || str2 is null)
            {
                return false;
            }

            if (Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }

            bool isEdited = false;

            for (int i = 0, j = 0; i < str1.Length && j < str2.Length; i++, j++)
            {
                if (str1[i] != str2[j])
                {
                    if (isEdited)
                    {
                        return false;
                    }

                    if (str1.Length > str2.Length)
                    {
                        --j;
                    }

                    if (str1.Length < str2.Length)
                    {
                        --i;
                    }

                    isEdited = true;
                }
            }

            return true;
        }
    }
}

