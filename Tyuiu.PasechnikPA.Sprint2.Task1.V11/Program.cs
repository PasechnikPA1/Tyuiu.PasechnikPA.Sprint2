using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.PasechnikPA.Sprint2.Task1.V11.Lib;

namespace Tyuiu.PasechnikPA.Sprint2.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);



            Console.Title = "Спринт #2 | Выполнил: Пасечник П. А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся струры                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Варинант #11                                                            *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=)  *********");
            Console.WriteLine("*последовательность можно чередовать, но использовать один раз в выражении*");
            Console.WriteLine("*и логических операций (|, &, ||, &&, !, ^, последовательность операций не*");
            Console.WriteLine("*должна нарушаться), а также арифметических выражений, которая вернет     *");
            Console.WriteLine("*логическую последовательность(массив): (False, False, True, False, True, *");
            Console.WriteLine("*False), при a = 145, b = 156, c = 142, d = 117                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);




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
