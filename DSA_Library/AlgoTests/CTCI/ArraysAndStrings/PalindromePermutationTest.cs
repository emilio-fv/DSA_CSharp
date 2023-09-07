using DSA_Library;

namespace AlgoTests.CTCI.ArraysAndStrings
{
	[TestClass]
	public class PalindromePermutationTest
	{
		[TestMethod]
		public void TestTrueS1()
		{
			// Arrange
			string input = "Tact Coa";

			// Act
			var response = PalindromePermutation.Solution1(input);

			Console.WriteLine(response);
			// Assert
			Assert.IsTrue(response);
        }

		[TestMethod]
		public void TestFalseS1()
		{
			// Arrange
			string input = "Cato Tacs";

			// Act
			var response = PalindromePermutation.Solution1(input);

			// Assert
			Assert.IsFalse(response);
        }

		[TestMethod]
		public void TestNullS1()
		{
			// Arrange
			string? input = null;

			// Act
			var response = PalindromePermutation.Solution1(input);

			// Assert
			Assert.IsFalse(response);
		}

		[TestMethod]
		public void TestEmptyS1()
		{
			// Arrange
			string input = "";

			// Act
			var response = PalindromePermutation.Solution1(input);

			// Assert
			Assert.IsFalse(response);
		}

		[TestMethod]
		public void TestSingleChrS1()
		{
			// Arrange
			string input = "a";

			// Act
			var response = PalindromePermutation.Solution1(input);

			// Assert
			Assert.IsFalse(response);
		}
	}
}

