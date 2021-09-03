using System;

namespace MathTaskClassLibraryTriangle
{
    public class TestingOfTriangle
    {
        public double AreaTriangleTesT(double TheFirstSide, double TheSecondSide, double TheThirdSide)
        {
            double x = 2;
            double SemiperimeterOfTriangle = ((TheFirstSide + TheSecondSide + TheThirdSide) / x);
            return Math.Sqrt(SemiperimeterOfTriangle*(SemiperimeterOfTriangle - TheFirstSide) *
                (SemiperimeterOfTriangle - TheSecondSide) * (SemiperimeterOfTriangle - TheThirdSide));

        }
    }
}
