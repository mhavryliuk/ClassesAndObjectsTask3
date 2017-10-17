using System;

namespace ClassesAndObjectsTask3
{
    class Program
    {
        static void Main()
        {
            Rectangle firstRectangle = new Rectangle(20, 20);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Заданные параметры");
            Console.ResetColor();
            Console.WriteLine(firstRectangle);
            Console.WriteLine(firstRectangle.PerimeterCalculation());
            Console.WriteLine(firstRectangle.AreaCalculation());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nДемонстрация работы индексатора");
            Console.ResetColor();
            Console.WriteLine(firstRectangle[0]);
            Console.WriteLine(firstRectangle[1]);
            Console.WriteLine(firstRectangle[2]);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nДемонстрация перегрузки операций и констант");
            Console.ResetColor();
            Console.WriteLine(++firstRectangle);
            Console.WriteLine(--firstRectangle);
            Console.WriteLine(firstRectangle * 3);

            // Устанавливаем, является ли данный прямоугольник квадратом
            if (firstRectangle)
                Console.WriteLine("Заданный прямоугольник является квадратом.");
            else Console.WriteLine("Прямоугольник с заданными длинами сторон не является квадратом.");

            Console.ReadKey();
        }
    }
}
