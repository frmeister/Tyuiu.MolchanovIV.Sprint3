using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint3.Task6.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task6.V5
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 15, stopValue = 22;

            Console.Title = "Спринт #3 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [15, 22] сумму всех делителей                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Начало отрезка: ", startValue);
            Console.WriteLine("Конец отрезка: ", stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadLine();

        }
    }
}