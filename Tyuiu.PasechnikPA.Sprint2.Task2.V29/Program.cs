using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.PasechnikPA.Sprint2.Task2.V29.Lib;

namespace Tyuiu.PasechnikPA.Sprint2.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Title = "Спринт #2 | Выполнил: Пасечник П. А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся струры                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Варинант #29                                                            *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры ***");
            Console.WriteLine("*и вычисляет находится ли точка с координатами X,Y в заштрихованной *******");
            Console.WriteLine("*области.******************************************************************");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Введите значение переменной Х: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");

            }
            else
            {
                Console.WriteLine("Точка не находится в закрашенной области");
            }

            Console.ReadKey();
        }
    }
}
