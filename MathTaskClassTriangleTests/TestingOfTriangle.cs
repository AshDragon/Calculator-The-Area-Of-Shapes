using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibraryTriangle;

namespace MathTaskClassTriangle
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void Triangleest_5_4_3returned()
        {
            double TheFirstSide = 5;
            double TheSecondSide = 4;
            double TheThirdSide = 3;

            double expected = 6;

            TestingOfTriangle test2 = new TestingOfTriangle();
            double actual = test2.AreaTriangleTesT(TheFirstSide, TheSecondSide, TheThirdSide);

            Assert.AreEqual(expected, actual);
        }
    }
}
