using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

[assembly:
InternalsVisibleTo("Program"), InternalsVisibleTo("MatrixGenerator")]
namespace lab3_threads
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static readonly int r = 400;
		static readonly int c = 400;

		private void button_start_Click(object sender, EventArgs e)
		{
			MatrixGenerator matrix = new MatrixGenerator();
			int[,] matrix1 = new int[r, c];
			int[,] matrix2 = new int[r, c];
			int[,] matrixR = new int[r, c];
			int[,] matrixS = new int[r, c];		// for sequential time measurement

			matrix1 = matrix.Generate(r, c);
			matrix2 = matrix.Generate(r, c);

			/*void matrixMultiplicationWithThreads(int thread_nr)
			{
				Thread[] threads = new Thread[thread_nr];
				for (int i = 0; i < thread_nr; i++)
				{
					threads[i] = new Thread(() => matrix.Multiply(matrix1, matrix2, r, c));
				}
				var watch = System.Diagnostics.Stopwatch.StartNew();
				foreach (Thread x in threads)
				{
					x.Start();
				}
				foreach (Thread x in threads)
				{
					x.Join();
				}
				watch.Stop();
				var elapsedMs = watch.ElapsedMilliseconds;
				textBox_time.AppendText("Parallel multiplication");
				textBox_time.AppendText(Environment.NewLine);
				textBox_time.AppendText("Elapsed time: ");
				textBox_time.AppendText(elapsedMs + " ms");
			}*/

			void Mult(int thread_nr)
			{
				int elementsPerThread = r / thread_nr;

				Thread[] threads = new Thread[thread_nr];

				for (int t = 0; t < thread_nr; t++)
				{
					int startRow = t * elementsPerThread;
					int endRow = (t == thread_nr - 1) ? r : startRow + elementsPerThread;

					threads[t] = new Thread(() =>
					{
						for (int i = startRow; i < endRow; i++)
						{
							for (int j = 0; j < c; j++)
							{
								for (int k = 0; k < r; k++)
								{
									matrixR[i, j] += matrix1[i, k] * matrix2[k, j];
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

				//return result;
			}

			//matrixMultiplicationWithThreads(4);
			var w = System.Diagnostics.Stopwatch.StartNew();
			Mult(4);
			w.Stop();
			var el = w.ElapsedMilliseconds;
			textBox_time.AppendText("Parallel multiplication");
			textBox_time.AppendText(Environment.NewLine);
			textBox_time.AppendText("Elapsed time: ");
			textBox_time.AppendText(el + " ms");

			// sequential multiplication
			var watch2 = System.Diagnostics.Stopwatch.StartNew();
			matrixS = matrix.Multiply(matrix1, matrix2, r, c);
			watch2.Stop();
			var elapsedtime = watch2.ElapsedMilliseconds;
			textBox_time_2.AppendText("Sequential multiplication");
			textBox_time_2.AppendText(Environment.NewLine);
			textBox_time_2.AppendText("Elapsed time: ");
			textBox_time_2.AppendText(elapsedtime + " ms");

			// input
			for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					textBox_input.AppendText(matrix1[i, j].ToString() + " ");
				}
				textBox_input.AppendText(Environment.NewLine);
			}

			for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					textBox_input_2.AppendText(matrix2[i, j].ToString() + " ");
				}
				textBox_input_2.AppendText(Environment.NewLine);
			}

			// output
			for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					textBox_output.AppendText(matrixS[i, j].ToString() + " ");
				}
				textBox_output.AppendText(Environment.NewLine);
			}
		}
	}
}
