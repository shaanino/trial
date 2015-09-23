using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using trial;

namespace trialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            test t = new test();

            int result = t.Add(6,4);

            Assert.Equals(21, result);
            

        }
    }
}
