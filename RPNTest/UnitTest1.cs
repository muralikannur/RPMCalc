using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculator;

namespace RPNTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_numners_and_plussign_Should_Return_Total()
        {
                RPNCal obj = new RPNCal();
                string expr = "5,3,3,+,-";
                double expected = -1;
                double actual = obj.GetRPN(expr);
                Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_numners_and_minussign_Should_Return_Total()
        {
            RPNCal obj = new RPNCal();
            string expr = "2,2,5,1,+,5,3,-";
            double expected = 12;
            double actual = obj.GetRPN(expr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_numners_and_persentagesign_Should_Return_Total()
        {
            RPNCal obj = new RPNCal();
            string expr = "25,200,%";
            double expected = 12.5;
            double actual = obj.GetRPN(expr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_numners_and_persentagesign_and_plussign_Should_Return_Total()
        {
            RPNCal obj = new RPNCal();
            string expr = "20,25,+,100,%";
            double expected = 45;
            double actual = obj.GetRPN(expr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_numners_and_power_of_Should_Return_Total()
        {
            RPNCal obj = new RPNCal();
            string expr = "4,2,^";
            double expected = 16;
            double actual = obj.GetRPN(expr);
            Assert.AreEqual(expected, actual);
        }

    }
}
