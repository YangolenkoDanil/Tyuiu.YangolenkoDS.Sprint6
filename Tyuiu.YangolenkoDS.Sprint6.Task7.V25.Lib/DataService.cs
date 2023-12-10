using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;



namespace Tyuiu.YangolenkoDS.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int xcol = 6;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, xcol] % 5 == 0)
                {
                    matrix[i, xcol] = 2;
                }

            }
            return matrix;
        }
    }
}
