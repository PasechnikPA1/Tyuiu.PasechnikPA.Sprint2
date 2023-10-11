﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.PasechnikPA.Sprint2.Task0.V6.Lib;

namespace Tyuiu.PasechnikPA.Sprint2.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 107;
            int y = 754;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);



            Console.Title = "Спринт #2 | Выполнил: Пасечник П. А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Варинант #6                                                             *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=) **********");
            Console.WriteLine("*последовательность операций не должна нарушаться и арифметических ********");
            Console.WriteLine("выражений, которая вернет логическую последовательность(массив): **********");
            Console.WriteLine("(True, True, True, False, True, False), при x = 107, y = 754)**************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

            }
            Console.ReadKey();
        }
    }
}
