using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:
InternalsVisibleTo("Form1"), InternalsVisibleTo("Program")]

namespace lab3_threads
{
	public class Matrix
	{
		Random random = new Random();
		public static int rows;
		public static int cols;
		public static int[,] matrix1 { get; set; }
		public static int[,] matrix2 { get; set; }
		public static int[,] matrixR;       // result matrix
		public static int[,] matrixT;       // threads matrix

		public int[,] Generate(int rows, int cols)
		{
			int[,] matrix = new int[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = random.Next(0, 10);
				}
			}
			return matrix;
		}

		public int[,] Multiply()
		{
			//int temp = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					//temp = 0;
					for (int k = 0; k < rows; k++)
					{
						matrixR[i, j] += matrix1[i, k] * matrix2[k, j];
					}
					//matrixR[i, j] = temp;
				}
			}
			return matrixR;
		}

		public static int[] getCol(int col)
		{
			int arrLen = cols;
			int[] newArr = new int[arrLen];
			for (int i = 0; i < arrLen; i++)
			{
				newArr[i] = matrix2[col, i];
			}
			return newArr;
		}

		public static int[] getRow(int row)
		{
			int arrLen = rows;
			int[] newArr = new int[arrLen];
			for (int i = 0; i < arrLen; i++)
			{
				newArr[i] = matrix1[i, row];
			}
			return newArr;
		}
		public static void multiplyNumbers(int rows, int cols)
		{
			/*for (int k = 0; k < rows; k++)
			{
				matrixR[rows, cols] += matrix1[rows, k] * matrix2[k, cols];
			}*/
			int[] row = getRow(rows);
			int[] col = getCol(cols);

			for (int i = 0; i < row.Length; i++)
			{
				matrixR[rows, cols] += row[i] * col[i];
			}
		}
		public void set_input(int[,]matrix1, int[,]matrix2)
		{
			//matrix1 = new int[rows, cols];
			//matrix2 = new int[rows, cols];
			Form1 theform = new Form1();
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					theform.textBox_input.AppendText(matrix1[i, j].ToString());
				}
				theform.textBox_input.AppendText(Environment.NewLine);
			}
			//theform.textBox_input.AppendText(Environment.NewLine);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					theform.textBox_input_2.AppendText(matrix2[i, j].ToString());
				}
				theform.textBox_input_2.AppendText(Environment.NewLine);
			}
		}
		public void set_output()
		{
			Form1 theform = new Form1();
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					//temp = 0;
					for (int k = 0; k < rows; k++)
					{
						matrixR[i, j] += matrix1[i, k] * matrix2[k, j];
						theform.textBox_output.AppendText(matrixR[i, j].ToString());
					}
					theform.textBox_input.AppendText(Environment.NewLine);
					//matrixR[i, j] = temp;
				}
			}
			theform.textBox_input.AppendText(Environment.NewLine);
		}
		/*public static void threadFunction(int thread_nr, Matrix matrix)
		{
			//int thread_nr = 4;
			for (int i = thread_nr; i < matrix.rows; i += 4)
			{
				for (int j = 0; j < matrix.cols; j++)
				{
					matrixT[i, j] = Thread.CurrentThread.ManagedThreadId;
					multiplyNumbers(i, j);
				}
			}
		}*/

		public static void threadFunction(object thread_nr, int rows, int cols)
		{
			int num = Convert.ToInt32(thread_nr);
			Thread.Sleep(100);
			for (int i = num; i < rows; i += num)
			{
				for (int j = 0; j < cols; j++)
				{
					//matrixT[i, j] = Thread.CurrentThread.ManagedThreadId;
					multiplyNumbers(i, j);
				}
			}
		}
	}
}
		

