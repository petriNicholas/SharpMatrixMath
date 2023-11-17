using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMatrixMath
{
    class Matrix
    {
        private float[,] Table;
        private readonly int columns;
        private readonly int rows;

        public Matrix(int n, int m)
        {
            rows = n;
            columns = m;
            Table = new float[rows, columns];
        }

        private void ZeroMatrix()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Table[i, j] = 0;
                }
            }
        }
    }
}
