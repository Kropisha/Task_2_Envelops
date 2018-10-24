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
    public class BusinessLogicTests
    {
        [TestMethod]
        public void IsCorrectTest()
        {
            //arrange
            int side = 5;

            //act
            bool result = BusinessLogic.IsCorrect(side);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CompareEnvelopsTest()
        {
            //arrange
            Envelop first = new Envelop(3, 5);
            Envelop second = new Envelop(7, 9);
            BusinessLogic bl = new BusinessLogic();
            string expected = "You can put the first envelope in the second.";

            //act
            string result = bl.CompareEnvelops(first, second);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}