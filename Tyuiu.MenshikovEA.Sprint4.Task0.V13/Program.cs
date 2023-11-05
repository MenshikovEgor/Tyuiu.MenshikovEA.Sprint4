using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint4.Task0.V13.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("{2, 6, 2, 3, 4, 5, 4, 9, 7, 8}");

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumEvenArrEl(array));
            Console.ReadKey();
        }
    }
}
