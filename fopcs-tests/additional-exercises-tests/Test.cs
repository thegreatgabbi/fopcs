using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionalExercises;

namespace AdditionalExercises.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Question1Test()
        {
            Assert.AreEqual(Question1.PrintNumber(),
                "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20"
            );
        }

        [TestMethod]
        public void Question2Test()
        {
            Assert.AreEqual(Question2.PrintNumber(),
                "20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1"
            );
        }

        [TestMethod]
        public void Question3aTest()
        {
            Assert.AreEqual(Question3.a(), "1 3 5 7 9 11 13 15 17 19");
        }

        [TestMethod]
        public void Question3bTest()
        {
            Assert.AreEqual(Question3.b(), "1 3 5 7 9 11 13 15 17 19");
        }

        [TestMethod]
        public void Question4Test()
        {
            Assert.AreEqual(Question4.Fibonacci(), "0 1 1 2 3 5 8 13 21 34 55 89");
        }

        [TestMethod]
        public void Question5Test()
        {
            Assert.AreEqual(Question5.MakePattern(), "1 20 2 19 3 18 4 17 5 16 6 15 7 14 8 13 9 12 10 11");
        }

        //[TestMethod]
        //public void Question6Test()
        //{
        //    Assert.AreEqual(Question6.a(), "1 20 2 19 3 18 4 17 5 16 6 15 7 14 8 13 9 12 10 11");
        //}

        [TestMethod]
        public void Question18Test()
        {
            double[] a = new double[] { 2, 4, 8, 5.67, 7 };
            CollectionAssert.AreEqual(Question18.ReturnAverage(), a );
        }

        [TestMethod]
        public void Question19Test()
        {
            double[] test = new double[] { 3, 5, 9, 8, 7 };
            CollectionAssert.AreEqual(Question19.ReturnMax(), test);
        }

        [TestMethod]
        public void Question20Test()
        {
            double[,] test = new double[,] { 
                { 2, 4, 5 },
                { 5, 9, 6 },
                { 5, 6, 9 }
            };
            CollectionAssert.AreEqual(Question20.ReturnAverage(), test);
        }

        [TestMethod]
        public void Question22Test()
        {
            int[] a = new int[] { 2, 4, 5, 5, 9, 6 };

            int[] test1 = new int[] { 2, 4, 5, 5, 9, 6, 0, 0 };
            int[] test2 = new int[] { 2, 4, 5, 5 };

            CollectionAssert.AreEqual(Question22.ResizeArray(a, 8), test1);
            CollectionAssert.AreEqual(Question22.ResizeArray(a, 4), test2);
        }

        [TestMethod]
        public void Question23Test()
        {
            int a = 8;
            int b = 4;
            Question23.RankSize(ref a, ref b);
            Assert.AreEqual(a, 4);
            Assert.AreEqual(b, 8);

            a = 4;
            b = 8;
            Question23.RankSize(ref a, ref b);
            Assert.AreEqual(a, 4);
            Assert.AreEqual(b, 8);

            a = 8;
            b = 8;
            Question23.RankSize(ref a, ref b);
            Assert.AreEqual(a, 8);
            Assert.AreEqual(b, 8);
        }

        [TestMethod]
        public void Question24Test()
        {
            Assert.AreEqual(Question24.CheckPassword("abcABC1"), false); // not 8 characters long
            Assert.AreEqual(Question24.CheckPassword("abcde12345"), false); // no uppercase
            Assert.AreEqual(Question24.CheckPassword("ABCDE12345"), false); // no lowercase
            Assert.AreEqual(Question24.CheckPassword("abcABC1"), false); // no numbers

        }

    }
}
