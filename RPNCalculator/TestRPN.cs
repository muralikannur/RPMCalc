using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;


namespace RPNCalculator
{
    public class TestRPN
    {

        public void testCase1()
        {
            RPNCal obj = new RPNCal();
            string expr = "2,2,+";
            double expected = 4;
            double actual = (double)obj.GetRPN(expr);
            Assert.AreEqual(expected, actual);
        }
    }
}
