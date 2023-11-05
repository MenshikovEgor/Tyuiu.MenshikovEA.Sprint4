using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MenshikovEA.Sprint4.Task1.V20.Lib
{
    public class DataService : ISprint4Task1V20
    {
        public int Calculate(int[] array)
        {
            int res = 0;

            for (int i = 0; i <= 9; i++)
            {
                if (array[i] % 2 != 0)
                    res += array[i];
            }
            return res;
        }
    }
}
