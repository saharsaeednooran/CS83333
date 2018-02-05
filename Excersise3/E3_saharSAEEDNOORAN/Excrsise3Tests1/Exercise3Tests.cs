/* 
* CST8333-350 Programming Language Research Project
* Author: Sahar Saeednooran
* Exercise3Test : sample unit test for Exersise3 using MSTest framework
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exersise3;

namespace Exersise3.Tests
{
    [TestClass()]
    public class Exercise3Tests
    {
        [TestMethod()]
        public void CalculateFactorialTest1()
        {
            long actual = new Exercise3().CalculateFactorial(5);
            Assert.AreEqual(120, actual);
        }
        [TestMethod()]
        public void CalculateFactorialTest2()
        {
            long actual = new Exercise3().CalculateFactorial(0);
            Assert.AreEqual(1, actual);
        }
        [TestMethod()]
        public void CalculateFactorialTest3()
        {
            long actual = new Exercise3().CalculateFactorial(100);
            Assert.AreEqual(0, actual);
        }
    }
}