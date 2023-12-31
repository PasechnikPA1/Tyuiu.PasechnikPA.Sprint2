﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PasechnikPA.Sprint2.Task6.V2.Lib;

namespace Tyuiu.PasechnikPA.Sprint2.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Пасечник П. А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся струры                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Варинант #2                                                             *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая использует оператор switch вычисляет**********");
            Console.WriteLine("*значение и возвращает результат. Условие: По данному номеру месяца,*******");
            Console.WriteLine("*к какой поре года относится.**********************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMouth = Convert.ToInt32(Console.ReadLine());


            string res;

            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Пора года для " + numMouth + " месяца это: " + ds.FindMonthSeason(numMouth);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
