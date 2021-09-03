using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibraryCircle;

namespace MathTaskClassCircleTests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void CircleTest_5returned()
        {
            double AreaCircle = 5;
            double expected = 78.53981633974483;

            TestingOfCircle g = new TestingOfCircle();
            double actual = g.AreaCircleTesT(AreaCircle);

            Assert.AreEqual(expected, actual);
        }
    }
}
