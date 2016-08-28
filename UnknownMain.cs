using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using UnknownEng;

namespace UnknownMain
{
    public class UM : Renderer
    {
        public override void run()
        {

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
