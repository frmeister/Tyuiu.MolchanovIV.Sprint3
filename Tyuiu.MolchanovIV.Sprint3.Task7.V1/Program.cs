using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint3.Task7.V1.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task7.V1
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5, stopValue = 5, currentValue = -5;

            double[] result = new double[11];
            result = ds.GetMassFunction(startValue, stopValue);

            Console.Title = "Спринт #3 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=sin(x)/(x + 1.2) + (cos(x) * 7 * x) - 2 и записать            *");
            Console.WriteLine("* в табличном виде                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Изначальное значение X: " + startValue);
            Console.WriteLine("Крайнее значение X: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" +-----------+-----------+ ");
            Console.WriteLine(" |     X     |    F(x)   | ");
            Console.WriteLine(" +-----------+-----------+ ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(" |{0,5:d}       |  {1,5:f2}   |", startValue, result[i]);
                startValue++;
            }
            Console.WriteLine(" +-----------+-----------+");

            Console.ReadLine();

        }
    }
}
