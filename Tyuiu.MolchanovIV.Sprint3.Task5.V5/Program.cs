using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint3.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task5.V5
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 10;

            Console.Title = "Спринт #3 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение: суммы от 1 до 3 от суммы от 1 до 10 от частного     *");
            Console.WriteLine("* x/sin(k)                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Знчаение X:", x);
            Console.WriteLine("Знчаение startValue1:" + startValue1);
            Console.WriteLine("Знчаение startValue2:" + startValue2);
            Console.WriteLine("Знчаение stopValue1:" + stopValue1);
            Console.WriteLine("Знчаение stopValue2:" + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadLine();
        }
    }
}