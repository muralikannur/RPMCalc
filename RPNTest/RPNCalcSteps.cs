using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculator;

namespace RPNTest
{
    [Binding]
    public class RPNCalcSteps
    {
        string input;
        [Given(@"input ""(.*)""")]
        public void GivenInput(string p0)
        {
            //ScenarioContext.Current.Pending();
            input = p0;
        }
        
        [Then(@"output (.*)")]
        public void ThenOutput(int p0)
        {
            //ScenarioContext.Current.Pending();
            RPNCal obj = new RPNCal();
            Assert.AreEqual(p0, obj.GetRPN(input));
        }
    }
}
