using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MenshikovEA.Sprint4.Task7.V8.Lib
{
    public class DataService : ISprint4Task7V8
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrix = new int[n, m];

            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (mtrix[i, j] % 2 != 0)
                    {
                        sum += mtrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
