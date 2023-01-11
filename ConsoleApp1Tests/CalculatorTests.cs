using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void AddTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2,2) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest1()
        {
            Assert.Fail();
        }
    }
}