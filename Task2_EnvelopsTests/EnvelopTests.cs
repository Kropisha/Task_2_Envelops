using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2_Envelops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Envelops.Tests
{
    [TestClass()]
    public class EnvelopTests
    {
        [TestMethod]
        public void EnvelopTest_CorrectValues_ReturnEnvelop()
        {
            //arrange
            double width = 2.3;
            double height = 6.5;

            //act
            Envelop env = new Envelop(width, height);

            //assert
            Assert.IsNotNull(env);
            Assert.AreEqual(width, env.Width);
            Assert.AreEqual(height, env.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnvelopTest_IncorrectValues_ReturnException()
        {
            //arrange
            double width = -2.3;
            double height = 0;

            //act
            Envelop env = new Envelop(width, height);
        }

        [TestMethod]
        public void SquareTest_CorrectValues_ReturnSquare()
        {
            //arrange
            double width = 2;
            double height = 6;
            Envelop env = new Envelop(width, height);

            //act
            double result = env.Square();

            //assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void MinSideTest()
        {
            //arrange
            double width = 5;
            double height = 8;
            Envelop env = new Envelop(width, height);

            //act
            double result = env.MinSide();

            //assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MaxSideTest()
        {
            //arrange
            double width = 5;
            double height = 8;
            Envelop env = new Envelop(width, height);

            //act
            double result = env.MaxSide();

            //assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void DiagonalTest()
        {
            //arrange
            double width = 3.5;
            double height = 3;
            Envelop env = new Envelop(width, height);

            //act
            int result = (int)env.Diagonal();

            //assert
            Assert.AreEqual(4, result);
        }
    }
}