using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace UnknownEng
{
	public class Controller
	{
		public static char run()
		{
			Console.WriteLine("Input");
			char temp = ((char) Console.ReadKey().Key);
			Console.WriteLine(temp);
			while (Console.ReadKey().Key != ConsoleKey.Enter);
			return temp;
		}
	}

	public class Renderer : Form
	{
		public Bitmap tim;
		private Graphics g;
		public Renderer()
		{

			g = this.CreateGraphics();
			try
			{
				tim = new Bitmap("C:/Users/mike/Desktop/Unknown3/photo.bmp");
				Console.WriteLine("Read Image Sucessfully");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Error Reading image");
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			this.test();
		}

		public void test()
		{

			Console.WriteLine("Test start");
			Graphics g = this.CreateGraphics();
			g.DrawImage(tim, 16, 16);
			Console.WriteLine("test");
		}
	}

	public class temp
	{
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Renderer r = new Renderer();
			Application.Run(r);
			//r.test();
			//Console.WriteLine(Controller.run());
		}
	}
}