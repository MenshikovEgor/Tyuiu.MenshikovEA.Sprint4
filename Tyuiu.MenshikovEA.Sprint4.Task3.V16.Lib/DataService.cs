using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MenshikovEA.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int res = 9;
            for (int i = 0; i <= 4; i++)
            {
                if (array[i, 4] < res)
                {
                    res = array[i, 4];
                }
            }
            return res;
        }
    }
}
