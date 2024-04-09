using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread_and_parallel_comparison
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
	}
}
