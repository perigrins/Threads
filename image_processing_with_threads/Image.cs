using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_processing_with_threads
{
	internal class Image
	{
		public void Grayscale(Bitmap b, PictureBox p)
		{
			//Bitmap result;
			int x, y;

			for (x = 0; x < b.Width; x++)
			{
				for (y = 0; y < b.Height; y++)
				{
					Color pc = b.GetPixel(x, y);
					int grayScale = (int)((pc.R * 0.3) + (pc.G * 0.59) + (pc.B * 0.11));
					Color nc = Color.FromArgb(pc.A, grayScale, grayScale, grayScale);
					b.SetPixel(x, y, nc);
				}
			}
			p.Image = b;
		}

		public void Negative(Bitmap bitmap, PictureBox pic)
		{
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					Color p = bitmap.GetPixel(x, y);

					int a = p.A;
					int r = p.R;
					int g = p.G;
					int b = p.B;

					r = 255 - r;
					g = 255 - g;
					b = 255 - b;

					bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
				}
			}
			pic.Image = bitmap;
		}

		public void Green(Bitmap bitmap, PictureBox pic)
		{
			Bitmap gr = new Bitmap(bitmap);
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					Color p = bitmap.GetPixel(x, y);

					int a = p.A;
					int g = p.G;

					//set green image pixel
					gr.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
				}
			}
			pic.Image = gr;
		}

		public void Threshold(Bitmap b, PictureBox p)
		{
			double avgBright = 0;
			for (int y = 0; y < b.Height; y++)
			{
				for (int x = 0; x < b.Width; x++)
				{
					avgBright += b.GetPixel(x, y).GetBrightness();
				}
			}

			avgBright = avgBright / (b.Width * b.Height);
			avgBright = avgBright < .3 ? .3 : avgBright;
			avgBright = avgBright > .7 ? .7 : avgBright;

			for (int y = 0; y < b.Height; y++)
			{
				for (int x = 0; x < b.Width; x++)
				{
					if (b.GetPixel(x, y).GetBrightness() > avgBright) b.SetPixel(x, y, Color.White);
					else b.SetPixel(x, y, Color.Black);
				}
			}
			p.Image = b;

		}
	}
}
