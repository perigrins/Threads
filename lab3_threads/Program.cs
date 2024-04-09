using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[assembly:
InternalsVisibleTo("Form1"), InternalsVisibleTo("Matrix"), InternalsVisibleTo("Form1.Designer")]

namespace lab3_threads
{
	//internal static class Program
	class Program
	{
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}