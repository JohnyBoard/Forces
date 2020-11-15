using System;
using Forces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class BallTest
    {
        [TestMethod]
        public void SumTest()
        {
            Vector v1 = new Vector(0, -1);
            Vector v2 = new Vector(0, 1);
            Vector sum = v1 + v2;
            Assert.AreEqual(new Vector(), sum);
        }
    }
} 