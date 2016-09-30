namespace AlgorithmsForAnalyzingBiologicalSequences.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AlgorithmsForAnalyzingBiologicalSequences;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CalcLISTest1()
        {
            // arrange
            int[] source = { 4, 8, 2, 7, 3, 6, 9, 1, 10, 5 };
            int[] expected = { 2, 3, 6, 9, 10 };
            int[] actual;

            // act
            int lisLength = Program.CalcLIS(source, out actual);

            // assert
            Assert.IsTrue(expected.SequenceEqual(actual));
            Assert.AreEqual(lisLength, actual.Length);
        }

        [TestMethod]
        public void CalcLISTest2()
        {
            // arrange
            int[] source = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            int[] expected = { 0, 2, 6, 9, 11, 15 };
            int[] actual;

            // act
            int lisLength = Program.CalcLIS(source, out actual);

            // assert
            Assert.IsTrue(expected.SequenceEqual(actual));
            Assert.AreEqual(lisLength, actual.Length);
        }

        [TestMethod]
        public void CalcLISTest3()
        {
            // arrange
            int[] source = { 9, 2, 5, 3, 7, 11, 8, 10, 13, 6 };
            int[] expected = { 2, 3, 7, 8, 10, 13 };
            int[] actual;

            // act
            int lisLength = Program.CalcLIS(source, out actual);

            // assert
            Assert.IsTrue(expected.SequenceEqual(actual));
            Assert.AreEqual(lisLength, actual.Length);
        }
    }
}