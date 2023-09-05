using DSA_Library;

namespace AlgoTests.CTCI.ArraysAndStrings
{
	[TestClass]
	public class CheckPermutationTest
	{
		[TestMethod]
		public void TestTrue()
		{
			string str1 = "abcdefg";
			string str2 = "defgabc";
			bool result = CheckPermutation.Solution1(str1, str2);
			Assert.IsTrue(result, string.Format("Expected for {0} and {1}: true; Actual: {2}", str1, str2, result));
		}

		[TestMethod]
		public void TestFalse()
		{
            string str1 = "abcdefg";
			string str2 = "defgabd";
			bool result = CheckPermutation.Solution1(str1, str2);
			Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", str1, str2, result));
        }

		[TestMethod]
		public void TestDifferentLengths()
		{
            string str1 = "abcdefg";
            string str2 = "defgabcx";
			bool result = CheckPermutation.Solution1(str1, str2);
			Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", str1, str2, result));
        }

		[TestMethod]
		public void TestNullValues()
		{
			string str1 = "";
			string? str2 = null;
			bool result = CheckPermutation.Solution1(str1, str2);
			Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", str1, str2, result));
		}
	}
}

