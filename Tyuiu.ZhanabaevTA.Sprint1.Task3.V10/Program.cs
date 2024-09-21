using Tyuiu.ZhanabaevTA.Sprint1.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Операторы составного присваивания                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры дробное  *");
            Console.WriteLine("* число в денежный формат. Ответ округлить до 3 знаков после запятой.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите дробное число ->");
            double a = ds.NumberToMoney(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] r = a.ToString().Split(',');
            if (r[1].Length < 2)
            {
                r[1] += "0";
            }
            if (r[1].Length > 2)
            {
                r[1] = r[1].Substring(0,2);
            }
            Console.WriteLine($"{a} руб. - это {r[0]} руб. {r[1]} коп.");

            Console.ReadKey();
        }
    }
}
