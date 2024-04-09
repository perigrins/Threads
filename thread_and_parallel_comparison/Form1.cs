using System.Text.RegularExpressions;

namespace thread_and_parallel_comparison
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_start_Click(object sender, EventArgs e)
		{
			MatrixGenerator matrix = new MatrixGenerator();

			int[,] matrix1;
			int[,] matrix2;
			int rows = 200;
			int cols = 200;

			matrix1 = matrix.Generate(rows, cols);
			matrix2 = matrix.Generate(rows, cols);

			int[,] matrixP = new int[rows, cols];
			int[,] matrixT = new int[rows, cols];

			void Mult(int thread_nr)
			{
				int elementsPerThread = rows / thread_nr;

				Thread[] threads = new Thread[thread_nr];

				for (int t = 0; t < thread_nr; t++)
				{
					int startRow = t * elementsPerThread;
					int endRow = (t == thread_nr - 1) ? rows : startRow + elementsPerThread;

					threads[t] = new Thread(() =>
					{
						for (int i = startRow; i < endRow; i++)
						{
							for (int j = 0; j < cols; j++)
							{
								for (int k = 0; k < rows; k++)
								{
									matrixT[i, j] += matrix1[i, k] * matrix2[k, j];
								}
							}
						}
					});

					threads[t].Start();
				}

				foreach (Thread thread in threads)
				{
					thread.Join();
				}
			}

			// time measuring
			textBox_table.AppendText("nr of threads | parallel time | threads time");
			textBox_table.AppendText(Environment.NewLine);

			for (int x = 1; x < 5; x++)
			{
				long time_sum_parallel = 0;
				long time_sum_threads = 0;
				long time_threads_result = 0;
				long time_parallel_result = 0;

				int t = 5;
				while(t != 0)
				{
					ParallelOptions opt = new ParallelOptions()
					{
						MaxDegreeOfParallelism = x
					};

					matrix1 = matrix.Generate(rows, cols);
					matrix2 = matrix.Generate(rows, cols);

					var watch = System.Diagnostics.Stopwatch.StartNew();
					Parallel.For(0, rows, i =>
					{
						for (int j = 0; j < cols; j++)
						{
							matrixP[i, j] = 0;
							for (int k = 0; k < rows; k++)
							{
								matrixP[i, j] += matrix1[i, k] * matrix2[k, j];
							}
						}
					});
					watch.Stop();
					time_sum_parallel += watch.ElapsedMilliseconds;

					var watch2 = System.Diagnostics.Stopwatch.StartNew();
					Mult(x);
					watch2.Stop();
					time_sum_threads += watch2.ElapsedMilliseconds;

					t--;
				}

				time_parallel_result = time_sum_parallel / 5;
				time_threads_result = time_sum_threads / 5;
				string s1 = time_parallel_result.ToString();
				string s2 = time_threads_result.ToString();

				textBox_table.AppendText($"{ x.ToString()} | {s1} ms | {s2} ms");
				textBox_table.AppendText(Environment.NewLine);
			}
		}
	}
}
