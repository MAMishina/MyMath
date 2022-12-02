using MyMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestForMath
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Sum_100_500_120300Returned()
        {
            MathClass mathClass = new MathClass();
            string expected = "120300";
            string actual = mathClass.SumAB(100,500);

            Assert.AreEqual(expected, actual);
        }
    }
}
