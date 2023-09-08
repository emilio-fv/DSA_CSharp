using System;
namespace DSA_Library
{
	public class PalindromePermutation
	{
		public static readonly string name = "1.4 Palindrome Permutation";
		public static readonly string description = "Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words. You can ignore casing and non-letter characters.";

        public static bool Solution1(string? str) 
		{
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine("Input: " + str);

            // Edge cases: null, empty string, one character
            if (str is null || str.Length <= 1)
			{
				return false;
			}

			// Data structure to track each insstance of each character & character count
			Dictionary<string, bool> chrs = new Dictionary<string, bool>();
			int count = 0;

			// Iterate over string, adding or removing instances as needed
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] != ' ')
				{
					count++;
					string chr = str[i].ToString().ToLower();;
					if (chrs.ContainsKey(chr))
					{
						chrs.Remove(chr);
					}
					else
					{
						chrs.Add(chr, true);
					}
				}
			}

			// Check length of string and number of values in chrs data structure
			if (count % 2 == 0)
			{
				return chrs.Count == 0;
			}
			else
			{
				return chrs.Count == 1;
			}
		}
	}
}

 