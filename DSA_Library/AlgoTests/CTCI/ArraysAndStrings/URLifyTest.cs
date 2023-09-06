using DSA_Library;

namespace AlgoTests.CTCI.ArraysAndStrings
{
    [TestClass]
	public class URLifyTest
	{
        public static readonly char[] input1a = { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' ' };
        public static readonly int input1b = 13;
        public static readonly char[] input2 = Array.Empty<char>();

        // Test true
        [TestMethod]
        public void TestTrueS1()
        {
            var result = new string(URLify.Solution1(input1a, input1b));
            Console.WriteLine("Output: " + result);
            Assert.AreEqual(result, "Mr%20John%20Smith");
        }

        // Test false
        [TestMethod]
        public void TestFalseS1()
        {
            var result = new string(URLify.Solution1(input1a, input1b));
            Console.WriteLine("Output: " + result);
            Assert.AreNotEqual(result.ToString(), "Mr%20John%20Smith%20");
        }

        // Test null
        [TestMethod]
        public void TestNullS1()
        {
            Assert.ThrowsException<ArgumentException>(() => URLify.Solution1(null, input1b));
        }

        // Test empty
        [TestMethod]
        public void TestEmptyS1()
        {
            Assert.ThrowsException<ArgumentException>(() => URLify.Solution1(input2, input1b));
        }
    }
}

