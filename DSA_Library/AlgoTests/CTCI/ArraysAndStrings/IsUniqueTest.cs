using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA_Library;

namespace AlgoTests.CTCI.ArraysAndStrings
{
	[TestClass]
	public class IsUniqueTest
	{
		public static readonly string input1 = "abcdefg";
		public static readonly string input2 = "abcdefga";
		public static readonly string input3 = "";

		[TestMethod]
		public void TestTrueS1()
		{
			bool result = IsUnique.Solution1(input1);
			Console.WriteLine("Output: " + result);
			Assert.IsTrue(result, string.Format("Expected for {0}: true; Actual: {1}", input1, result));
		}

		[TestMethod]
		public void TestFalseS1()
		{
			bool result = IsUnique.Solution1(input2);
            Console.WriteLine("Output: " + result);
            Assert.IsFalse(result, string.Format("Expected for {0}: false; Actual: {1}", input2, result));
        }

		[TestMethod]
		public void TestNullS1()
		{
			bool result = IsUnique.Solution1(null);
            Console.WriteLine("Output: " + result);
            Assert.IsFalse(result, string.Format("Expected for {0}: false; Actual: {1}", null, result));
		}

		[TestMethod]
		public void TestEmptyS1()
		{
			bool result = IsUnique.Solution1(input3);
            Console.WriteLine("Output: " + result);
            Assert.IsFalse(result, string.Format("Expected for {0}: false; Actual: {1}", null, result));
		}
	}
}