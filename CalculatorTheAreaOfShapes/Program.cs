using System;

namespace CalculatorTheAreaOfShapes
{
    class Program
    {
        /// <summary>
        /// Задаёт значение радиусу круга + проверят на положительность числа введёного как радиус круга
        /// </summary>
        /// <returns></returns>
        static TheAreaOfTheCircle AreaCircle()
        {
            var theAreaOfTheCircle = new TheAreaOfTheCircle();
            double min = 0;
            double minmin = 1;
            double max = 1.7976931348623157E+308;

            do
            {
               

                Console.Write("Введите радиус круга : ");
                theAreaOfTheCircle.CircleRadius = Convert.ToInt32(Console.ReadLine());

                if (theAreaOfTheCircle.CircleRadius >= min && theAreaOfTheCircle.CircleRadius >= minmin &&
                    theAreaOfTheCircle.CircleRadius <= max)
                    Console.WriteLine($" Все верно радиус круга должен быть положительным числом {theAreaOfTheCircle.CircleRadius}");

                else
                    Console.WriteLine($"Радиус круга {theAreaOfTheCircle.CircleRadius} не может быть отрицательным или равным нулю, введите положительное число!!!");
                Console.WriteLine("");

            }
            while (min >= theAreaOfTheCircle.CircleRadius || max <= theAreaOfTheCircle.CircleRadius);

            return theAreaOfTheCircle;
        }

        /// <summary>
        /// Высчитывает площаль круга по радиусу
        /// </summary>
        /// <param name="theAreaOfTheCircle"></param>
        static void CalculatingTheAreaOfCircle(TheAreaOfTheCircle theAreaOfTheCircle)
        {
           // Console.WriteLine("");

            double Pi = 3.141592653589793;

            double AreaCircle = theAreaOfTheCircle.CircleRadius;

            double CalculatingAreaOfCircle = Pi * (AreaCircle * AreaCircle);

            Console.WriteLine($"Площадь круга равна : {CalculatingAreaOfCircle.ToString("F" + 4)} ");
            Console.WriteLine("");
        }

        /// <summary>
        /// Задаёт значение сторонам треугольника + проверяет на положительность чисел введёных сторон
        /// </summary>
        /// <returns></returns>
        static TheAreaOfTheTriangle AreaTriangle()
        {
            var theAreaOfTheTriangle = new TheAreaOfTheTriangle();

            double min = 0;
            double minmin = 1;
            double max = 1.7976931348623157E+308;

            do
            {
                //Console.WriteLine("");

                Console.Write("Введите первую сторону треугольника : ");
                theAreaOfTheTriangle.TheFirstSideOfTheTriangle = Convert.ToInt32(Console.ReadLine());

                if (theAreaOfTheTriangle.TheFirstSideOfTheTriangle >= min && theAreaOfTheTriangle.TheFirstSideOfTheTriangle >= minmin &&
                    theAreaOfTheTriangle.TheFirstSideOfTheTriangle <= max)
                    Console.WriteLine($" Все верно первая сторона треугольника должна быть положительным числом {theAreaOfTheTriangle.TheFirstSideOfTheTriangle}");

                else
                    Console.WriteLine($"Первая сторона треугольника {theAreaOfTheTriangle.TheFirstSideOfTheTriangle} не может быть отрицательным числом или равным нулю, введите положительное число!!!");
                Console.WriteLine("");
            }
            while (min >= theAreaOfTheTriangle.TheFirstSideOfTheTriangle || max <= theAreaOfTheTriangle.TheFirstSideOfTheTriangle);

            do
            {
               // Console.WriteLine("");

                Console.Write("Введите вторую сторону треугольника : ");
                theAreaOfTheTriangle.TheSecondSideOfTheTriangle = Convert.ToInt32(Console.ReadLine());

                if (theAreaOfTheTriangle.TheSecondSideOfTheTriangle >= min && theAreaOfTheTriangle.TheSecondSideOfTheTriangle >= minmin &&
                    theAreaOfTheTriangle.TheSecondSideOfTheTriangle <= max)
                    Console.WriteLine($" Все верно вторая сторона треугольника должна быть положительным числом {theAreaOfTheTriangle.TheFirstSideOfTheTriangle}");

                else
                    Console.WriteLine($"Вторая сторона треугольника {theAreaOfTheTriangle.TheSecondSideOfTheTriangle} не может быть отрицательным числом или равным нулю, введите положительное число!!!");
                Console.WriteLine("");
            }
            while (min >= theAreaOfTheTriangle.TheSecondSideOfTheTriangle || max <= theAreaOfTheTriangle.TheSecondSideOfTheTriangle);

            do
            {
                //Console.WriteLine("");

                Console.Write("Введите третью сторону треугольника : ");
                theAreaOfTheTriangle.TheThirdSideOfTheTriangle = Convert.ToInt32(Console.ReadLine());

                if (theAreaOfTheTriangle.TheThirdSideOfTheTriangle >= min && theAreaOfTheTriangle.TheThirdSideOfTheTriangle >= minmin &&
                    theAreaOfTheTriangle.TheThirdSideOfTheTriangle <= max)
                    Console.WriteLine($" Все верно третья сторона треугольника должна быть положительным числом { theAreaOfTheTriangle.TheThirdSideOfTheTriangle}");

                else
                    Console.WriteLine($"Третья сторона треугольника { theAreaOfTheTriangle.TheThirdSideOfTheTriangle} не может быть отрицательным числом или равным нулю, введите положительное число!!!");
                Console.WriteLine("");
            }
            while (min >= theAreaOfTheTriangle.TheThirdSideOfTheTriangle || max <= theAreaOfTheTriangle.TheThirdSideOfTheTriangle);

            return theAreaOfTheTriangle;
        }

        /// <summary>
        /// Высчитывает площаль треугольника по трём сторонам + проверяет являеться ли треугольник прямоугольным
        /// </summary>
        /// <param name="theAreaOfTheTriangle"></param>
        static void CalculatingTheAreaOfTriangle(TheAreaOfTheTriangle theAreaOfTheTriangle)
        {
          //  Console.WriteLine("");

            int a = 2;

            double TheFirstSideTriangle = theAreaOfTheTriangle.TheFirstSideOfTheTriangle;
            double TheSecondSideTriangle = theAreaOfTheTriangle.TheSecondSideOfTheTriangle;
            double ThirdPartyTriangle = theAreaOfTheTriangle.TheThirdSideOfTheTriangle;

            double TheSemiperimeterOfTriangle = (TheFirstSideTriangle + TheSecondSideTriangle +
                ThirdPartyTriangle) / a;

            double AreaTheTriangle = (TheSemiperimeterOfTriangle * (TheSemiperimeterOfTriangle -
                TheFirstSideTriangle) * (TheSemiperimeterOfTriangle - TheSecondSideTriangle) *
                (TheSemiperimeterOfTriangle - ThirdPartyTriangle));

            double AreaOfTheTriangle = Math.Sqrt(AreaTheTriangle);


            Console.WriteLine($"Площадь треугольника равна : {AreaOfTheTriangle.ToString("F" + 4)} ");

            if ((TheFirstSideTriangle * TheFirstSideTriangle == TheSecondSideTriangle *
                TheSecondSideTriangle + ThirdPartyTriangle * ThirdPartyTriangle) ||
                (TheSecondSideTriangle * TheSecondSideTriangle == TheFirstSideTriangle *
                TheFirstSideTriangle + ThirdPartyTriangle * ThirdPartyTriangle) ||
                (ThirdPartyTriangle * ThirdPartyTriangle == TheFirstSideTriangle * TheFirstSideTriangle +
                TheSecondSideTriangle * TheSecondSideTriangle))
            {
                Console.WriteLine("Треугольник являеться прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник не являеться прямоугольным");
            }
        }

        static void Main(string[] args)
        {
            var TheAreaCircle = AreaCircle();

            CalculatingTheAreaOfCircle(TheAreaCircle);

            var TheAreaTriangle = AreaTriangle();

            CalculatingTheAreaOfTriangle(TheAreaTriangle);

            Console.ReadLine();
        }
    }
}
