using DSA_Library.CTCI.ArraysAndStrings;

namespace AlgoTests.CTCI.ArraysAndStrings
{
	[TestClass]
	public class OneAwayTest
	{
		[TestMethod]
		public void TestTrueInsertS1()
		{
			// Arrange
			string str1 = "pale";
			string str2 = "ple";

			// Act
			bool response = OneAway.Solution1(str1, str2);

			// Assert
			Assert.IsTrue(response);
		}

		[TestMethod]
		public void TestTrueRemoveS1()
		{
            // Arrange
            string str1 = "pales";
            string str2 = "pale";

            // Act
            bool response = OneAway.Solution1(str1, str2);

            // Assert
            Assert.IsTrue(response);
        }

		[TestMethod]
		public void TestTrueReplaceS1()
		{
			// Arrange
			string str1 = "pale";
			string str2 = "bale";

            // Act
            bool response = OneAway.Solution1(str1, str2);

            // Assert
            Assert.IsTrue(response);

        }

		[TestMethod]
		public void TestFalseS1()
		{
			// Arrange
			string str1 = "ple";
			string str2 = "pales";

            // Act
            bool response = OneAway.Solution1(str1, str2);

            // Assert
            Assert.IsFalse(response);
        }
	}
}

