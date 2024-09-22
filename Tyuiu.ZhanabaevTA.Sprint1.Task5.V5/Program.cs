using Tyuiu.ZhanabaevTA.Sprint1.Task5.V5.Lib;
using System.Globalization;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Преобразование типов и класс Convert                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: присвоить целой    *");
            Console.WriteLine("* переменной d первую цифру из дробной части положительного вещественного *");
            Console.WriteLine("* числа x (так, если x=32.597, то d=5).                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");

            var input = Console.ReadLine();

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "," };

            if (input.Contains("."))
            { formatter = new NumberFormatInfo { NumberDecimalSeparator = "." }; }
            double x = Convert.ToDouble(input, formatter);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
