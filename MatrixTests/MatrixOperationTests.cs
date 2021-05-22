using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    [TestClass]
    public class MatrixOperationTests
    {
        [DataRow(2, 2, 3, 4, 5, 6)]
        [DataRow(4, 3, 5, 6, 9, 9)]
        [DataRow(6, 5, 3, 4, 9, 9)]
        [DataTestMethod]
        public void SummTestOneRow(int a, int a1, int b, int b1, int c, int c1)
        {
            int[] arrayA = { a, a1 };
            int[] arrayB = { b, b1 };
            int[] actual = MatrixType.Matrix.SummarizeMatrix(arrayA, arrayB);
            int[] expected = { c, c1 };

            bool result = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    result = false;
                }
            }
            Assert.IsTrue(result);
        }

        [DataRow(2, 2, 2, 2, 3, 3, 3, 3, 5, 5, 5, 5)]
        [DataRow(1, 1, 1, 1, 3, 3, 3, 3, 4, 4, 4, 4)]
        [DataRow(3, 4, 5, 3, 1, 1, 1, 1, 4, 5, 6, 4)]
        [DataTestMethod]
        public void SummTestTwoRowArray(int a, int a1, int a2, int a3, int b, int b1, int b2, int b3, int c, int c1, int c2, int c3)
        {
            int[,] arrayA = { { a, a1, }, { a2, a3 } };
            int[,] arrayB = { { b, b1 }, { b2, b3 } };
            int[,] actual = MatrixType.Matrix.SummarizeMatrix(arrayA, arrayB);
            int[,] expected = { { c, c1 }, { c2, c3 } };
            bool result = true;
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (actual[i, j] != expected[i, j])
                    {
                        result = false;
                    }
                }
            }
            Assert.IsTrue(result);
        }

        [DataRow(2, 2, 2, 3, 3, 3, 5, 5, 5)]
        [DataRow(1, 1, 1, 1, 1, 1, 2, 2, 2)]
        [DataRow(2, 3, 4, 2, 3, 4, 4, 6, 8)]
        [DataTestMethod]
        public void SummarizeTestThreeRowArray(int a, int a1, int a2, int b, int b1, int b2, int c, int c1, int c2)
        {
            int[,] arrayA = { { a }, { a1 }, { a2 } };
            int[,] arrayB = { { b }, { b1 }, { b2 } };
            int[,] actual = MatrixType.Matrix.SummarizeMatrix(arrayA, arrayB);
            int[,] expected = { { c }, { c1 }, { c2 } };
            bool result = true;
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (actual[i, j] != expected[i, j])
                    {
                        result = false;
                    }
                }
            }
            Assert.IsTrue(result);
        }

        [DataRow(1, 1, 1, 6, 6, 6, 6)]
        [DataRow(2, 3, 4, 5, 10, 15, 20)]
        [DataTestMethod]
        public void MultiplyNumberTest(int a, int a1, int a2, int number, int b, int b1, int b2)
        {
            int[] arrayA = { a, a1, a2 };
            int[] actual = MatrixType.Matrix.MultiplyMatrixToNumber(arrayA, number);
            int[] expected = { b, b1, b2 };
            bool result = true;
            for (int i = 0; i < actual.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    result = false;
                }
            }
            Assert.IsTrue(result);
        }

        [DataRow(2, 3, 4, 2, 5, 10, 15, 20, 10)]
        [DataRow(4, 4, 4, 4, 2, 8, 8, 8, 8)]
        [DataRow(6, 6, 3, 3, 2, 12, 12, 6, 6)]
        [DataTestMethod]
        public void MultiplyNumberMultidimensionalTest(int a, int a1, int a2, int a3, int number, int b, int b1, int b2, int b3)
        {
            int[,] arrayA = { { a, a1 }, { a2, a3 } };
            int[,] actual = MatrixType.Matrix.MultiplyMatrixToNumber(arrayA, number);
            int[,] expected = { { b, b1 }, { b2, b3 } };
            bool result = true;
            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    if (actual[i, j] != expected[i, j])
                    {
                        result = false;
                    }
                }
            }
            Assert.IsTrue(result);
        }

        [DataRow(2, 2, 1, 1, 1, 1)]
        [DataRow(5, 4, 5, 4, 0, 0)]
        [DataRow(2, 1, 2, 2, 0, -1)]
        [DataTestMethod]
        public void SubtractMatrixTest(int a, int a1, int b, int b1, int c, int c1)
        {
            int[] arrayA = { a, a1 };
            int[] arrayB = { b, b1 };
            int[] expected = { c, c1 };
            int[] actual = MatrixType.Matrix.SubtractMatrix(arrayA, arrayB);
            bool result = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    result = false;
                }
            }
            Assert.IsTrue(result);
        }
        [DataRow(5, 5, 5, 2, 3, 1, 3, 2, 4)]
        [DataRow(2, 1, 3, 2, 2, 2, 0, -1, 1)]
        [DataRow(1, 1, 1, 3, 3, 3, -2, -2, -2)]
        [DataTestMethod]
        public void SubtractMultidimensionalMatrixTest(int a, int a1, int a2, int b, int b1, int b2, int c, int c1, int c2)
        {
            int[,] arrayA = { { a }, { a1 }, { a2 } };
            int[,] arrayB = { { b }, { b1 }, { b2 } };
            int[,] actual = MatrixType.Matrix.SubtractMatrix(arrayA, arrayB);
            int[,] expected = { { c }, { c1 }, { c2 } };
            bool result = true;
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (actual[i, j] != expected[i, j])
                    {
                        result = false;
                    }
                }
            }
            Assert.IsTrue(result);
        }

        [DataRow()]
        [DataTestMethod]
        public void MultiplyOneRowMatrixTest()
        {

        }

        [DataRow(-1, 3, 0, 1, 2, -2, 0, 2, 0, -1, 1, -3, 4, 0, 3, -11, 12, 1, 1, -3, 4, 0, -2, 10, -8, -2)]
        [DataRow(1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 7, 8, 11, 14, 17, 20, 23, 30, 37, 44, 35, 46, 57, 68)]
        [DataRow(0, -1, -2, -3, 0, -1, 2, 1, 2, 1, 1, 2, 1, 2, -1, -2, -1, -2, -7, -8, -7, -8, -1, -2, -1, -2)]
        [DataTestMethod]
        public void MultiplyMultidimentionalMatrixTest(int a, int a1, int a2, int a3, int a4, int a5,
                                                       int b, int b1, int b2, int b3, int b4, int b5, int b6, int b7,
                                                       int c, int c1, int c2, int c3, int c4, int c5, int c6, int c7,
                                                       int c8, int c9, int c10, int c11)
        {
            int[,] arrayA = { { a, a1 }, { a2, a3 }, { a4, a5 } };
            int[,] arrayB = { { b, b1, b2, b3 }, { b4, b5, b6, b7 } };
            int[,] actual = MatrixType.Matrix.MultiplyMatrix(arrayA, arrayB);
            int[,] expected = { { c, c1, c2, c3 }, { c4, c5, c6, c7 }, { c8, c9, c10, c11 } };
            bool result = true;
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (actual[i, j] != expected[i, j])
                    {
                        result = false;
                    }
                }
            }
            Assert.IsTrue(result);
        }
    }
}