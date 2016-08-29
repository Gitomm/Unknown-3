using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using UnknownEng;
using System.Media;

namespace UnknownMain
{
    public class UM : Renderer
    {
        public Bitmap bg;
        private Graphics g;
        private SoundPlayer p;
        public UM()
        {
          this.Size = new Size(1440, 960);
          this.g = this.CreateGraphics();
          p = new SoundPlayer();
          try
          {
            bg = new Bitmap("bg.bmp");
          }
          catch (ArgumentException)
          {
            Console.WriteLine("Error reading bg image");
          }
        }
        public override void run()
        {
          this.PlaySong();
        }

        private void PlaySong()
        {
            p.SoundLocation = "Orion\'s Medley.wav";
            p.Play();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
          this.g.DrawImage(bg, 0, 0);
          this.run();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
          Console.WriteLine("KeyPressed");
        }
    }

    public class temp
    {
        public static void Main(string[] args)
        {
          Application.EnableVisualStyles();
          UM m = new UM();
          Application.Run(m);
        }
    }
}
