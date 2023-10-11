using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.PasechnikPA.Sprint2.Task3.V23.Lib;

namespace Tyuiu.PasechnikPA.Sprint2.Task3.V23
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Варинант #23                                                            *");
            Console.WriteLine("* Выполнил: Пасечник Павел Андреевич | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции Y с******");
            Console.WriteLine("*использованием вложенных оператор if-else, где пользователь вводит********");
            Console.WriteLine("*значение переменной X с клавиатуры.Округлить полученное значение до*******");
            Console.WriteLine("*трех знаков после запятой.************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Введите значение переменной Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

        
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
