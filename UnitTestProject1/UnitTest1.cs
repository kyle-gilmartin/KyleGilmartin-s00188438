using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalExam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Phone acc1 = new Phone();
            decimal percent = 10m;

            acc1.Deposit(10m);

            Assert.AreEqual(percent, acc1.IncressPrice);
        }
    }
}
