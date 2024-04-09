using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:
InternalsVisibleTo("Form1")]

namespace lab3_threads
{
	internal class MatrixGenerator
	{
		public int[,] Generate(int r, int c)
		{
			Random random = new Random();
			int[,] matrix = new int[r, c];
			for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					matrix[i, j] = random.Next(0, 10);
				}
			}
			return matrix;
		}

		public int[,] Multiply(int[,] m1, int[,] m2, int r, int c)
		{
			int[,]m3=new int[r, c];
			for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					m3[i, j] = 0;
					for (int k = 0; k < r; k++)
					{
						m3[i, j] += m1[i, k] * m2[k, j];
					}
				}
			}
			return m3;
		}
	}
}
