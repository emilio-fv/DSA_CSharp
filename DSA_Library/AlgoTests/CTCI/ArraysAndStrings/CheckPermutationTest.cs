using DSA_Library;

namespace AlgoTests.CTCI.ArraysAndStrings
{
	[TestClass]
	public class CheckPermutationTest
	{
		public static readonly string input1 = "abcdefg";
		public static readonly string input2 = "defgabc";
		public static readonly string input3 = "defgabd";
		public static readonly string input4 = "defgabcx";
		public static readonly string input5 = "";
		
		[TestMethod]
		public void TestTrue()
		{
			bool result = CheckPermutation.Solution1(input1, input2);
			Assert.IsTrue(result, string.Format("Expected for {0} and {1}: true; Actual: {2}", input1, input2, result));
		}

		[TestMethod]
		public void TestFalse()
		{
			bool result = CheckPermutation.Solution1(input1, input3);
			Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", input1, input3, result));
        }

		[TestMethod]
		public void TestDifferentLengths()
		{
			bool result = CheckPermutation.Solution1(input1, input4);
			Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", input1, input4, result));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            bool result = CheckPermutation.Solution1(input1, input5);
            Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", input1, input5, result));
        }

        [TestMethod]
		public void TestNullValues()
		{
			bool result = CheckPermutation.Solution1(input1, null);
			Assert.IsFalse(result, string.Format("Expected for {0} and {1}: false; Actual: {2}", input1, null, result));
		}
	}
}

