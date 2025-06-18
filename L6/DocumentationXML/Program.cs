namespace DocumentationXML
{

    public class Program
    {
        /// <summary>
        /// Метод, который считает площадь треугольника по 3-м сторонам.
        /// </summary>
        /// <param name="firstSide"> Первая сторона треугольника </param>
        /// <param name="secondSide"> Вторая сторона треугольника </param>
        /// <returns>Возвращает площадь треугольника в м2 (double)</returns>

        public static double CalculateTriangleArea(double firstSide, double secondSide)
        {
            Console.WriteLine("Введите третью сторону треугольника для расчёта ");
            double thirdSide = double.Parse(Console.ReadLine());
            double semiPerimeter = FindSemiPerimeter(firstSide, secondSide, thirdSide);
            return Math.Sqrt(semiPerimeter *
                (semiPerimeter - firstSide) *
                (semiPerimeter - secondSide) *
                (semiPerimeter - thirdSide));
        }

        /// <summary>
        /// Метод, который считает полупериметр треугольника.
        /// </summary>
        /// <returns>Возвращает возвращает полупериметр треугольника в м2 (double)</returns>
        public static double FindSemiPerimeter(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }

        static void Main(string[] args)
        {
            /// <summary>
            /// Основная часть программы.
            /// </summary>
            Console.WriteLine(CalculateTriangleArea(2.3, 3.2));
        }
    }
}
