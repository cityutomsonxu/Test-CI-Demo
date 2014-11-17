using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib1;
namespace Lib1Tests
{
    [TestClass]
    public class CalculatorCoreTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatorCore cal = new CalculatorCore();
            int result = cal.add(1, 2);
            Assert.AreEqual(5, result);
        }
    }
}
