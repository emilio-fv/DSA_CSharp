using System;
namespace DSA_Library
{
	public class URLify
	{
		public static readonly string name = "1.3 URLify";
		public static readonly string description = "Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end to hold the additional characters, and that you are given the 'true' length of the string";

		public static char[] Solution1(char[]? str, int length)
		{
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine("Input 1: " + str);
            Console.WriteLine("Input 2: " + length);

			// Edge cases: null, empty string
			if (str is null)
			{
				throw new ArgumentException("Input cannot be null", nameof(str));
			}

			if (str?.Length == 0)
			{
				throw new ArgumentException("Input cannot be empty", nameof(str));
			}

			int spaces = 0;
			// Iterate over the true length of the string to count the number of spaces
			for (int i = 0; i < length; i++)
			{
				if (str[i] == ' ')
				{
					spaces++;
				}
			}

			// Calculate new index for each character
			int newIndex = length - 1 + spaces * 2;
			Console.WriteLine(newIndex);

			// Iterate backwords over the true length of the string, relocating each cahracter as needed
			for (int i = length - 1; i > 0; i--)
			{
				if (str[i] == ' ')
				{
					str[newIndex] = '0';
					str[newIndex - 1] = '2';
					str[newIndex - 2] = '%';
					newIndex -= 3;
				}
				else
				{
					str[newIndex] = str[i];
					newIndex--;
				}

			}

			return str;
		}
	}
}