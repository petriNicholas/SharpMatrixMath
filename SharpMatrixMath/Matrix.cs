using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Net.Mail;
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

        public void DisplayMatrix()
        {
            Console.Clear();
            for (int i = -1;i <= rows; i++) 
            { 
                string line="";

                if (i == -1) line += "/";
                else if (i == rows) line += "\\";
                else line += "|";

                for (int j = 0;j < columns; j++)
                {
                    if (i==-1 || i == rows) line += "---";
                    else line += " " + Table[i,j] + " ";
                }

                if (i == -1) line += "\\";
                else if (i == rows) line += "/";
                else line += "|";

                Console.WriteLine(line);
            }
        }
    }
}
