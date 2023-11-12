using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint4.Task7.V8.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Преобразовать в матрицу 3 на 4 строку 264795863157 и посчитать сумму \nнечётных элементов");

            string value = "264795863157";
            int n = 3;
            int m = 4;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(n, m, value));
            Console.ReadKey();
        }
    }
}
