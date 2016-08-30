using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using UnknownEng;
using System.Media;
using BeatControllerN;
using BeatN;
using System.Threading;

namespace UnknownMain
{
    public class UM : Renderer
    {
        public Bitmap bg;
        private Graphics g;
        private SoundPlayer p;
        public int health;
        private SolidBrush b;
        private BeatController bc;
        public UM()
        {
          this.Size = new Size(1440, 960);
          this.g = this.CreateGraphics();
          health = 50;
          b = new SolidBrush(Color.Green);
          p = new SoundPlayer();
          bc = new BeatController();
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
          while(true)
          {
            this.PlaySong();
            this.drawHealth();
            foreach (Beat b in bc.beatList)
            {
              drawBeat(b);
            }
            bc.run();
            Thread.Sleep(100);
            BeatController.fTime = false;
          }
        }

        private void drawHealth()
        {
          g.FillRectangle(b, 512, 256, health*8, 64);
        }

        private void drawBeat(Beat b)
        {
          g.FillRectangle(new SolidBrush(b.getColor()), b.getX(), b.getY(), 64, 256);
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
          if (bc.beatList[0].cLife() < 300 && bc.beatList[0].cLife() > 0)
          {
            Console.WriteLine("Good hit");
          }
          else
          {
            health -= 10;
            Console.WriteLine("Bad hit");
          }
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
