using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle.OutputToString());
            Console.WriteLine(rectangle.ToString());

            Console.WriteLine();

            var rectangularPrism = new RectangularPrism(3, 5, 10);
            Console.WriteLine(rectangularPrism.OutputToString());
            Console.WriteLine(rectangularPrism.ToString());

            Console.ReadLine();
        }
    }
}
