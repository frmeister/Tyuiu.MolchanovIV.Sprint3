using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint3.Task0.V22.Lib;

namespace Tyuiu.MolchanovIV.Sprint3.Task0.V22
{
    class Program
    {
        static public void Main(string[] args)
        {
            DataService ds = new DataService();

            double res = 0.0;
            double value = 0.25;
            int startValue = 1, endValue = 8;

            Console.Title = "Спринт #3 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* произведение ряда по формуле, при a=0,25                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение а = ", + value);
            Console.WriteLine("Значение startValue = ", + startValue);
            Console.WriteLine("Значение endValue = ", + endValue);

            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.GetMultiplySeries(value, startValue, endValue);

            Console.WriteLine(Math.Round(res, 3));
       
            Console.ReadLine();
        }
    }
}