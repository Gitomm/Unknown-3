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

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			this.run();
		}

		public virtual void run()
		{
			this.test();
		}

		public void test()
		{

			Console.WriteLine("Test start");
			Graphics g = this.CreateGraphics();
			try
			{
				tim = new Bitmap("photo.bmp");
				Console.WriteLine("Read Image Sucessfully");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Error Reading image");
			}
			g.DrawImage(tim, 16, 16);
			Console.WriteLine("Test Succesful");
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
