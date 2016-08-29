using System;
using System.Threading;
namespace BeatController
{
  class BeatController
  {
    static int a;
    static int b;
    //static double Note;
    static void AssignBeat()
    {
      Random _r = new Random();
      a = _r.Next(1,4);
      /*
      b = a;
      Console.WriteLine("The Beats are " + a*b);
      Console.WriteLine(a);
      Console.WriteLine(b);
      */
    }
    /*
    static void BeatTransition()
    {
      if (Note < 5000)
      {
        Note =
      }
    }
    */
    public static void Main(string[] args)
    {

      while (true)
      {
        AssignBeat();
        switch (a)
        {
          case 1:
          Console.WriteLine("That was a whole-note");
          Console.Beep(1000, 4000);
          Thread.Sleep(1000);
          //Console.Beep(0,500);
          break;
          case 2:
            for (int i = 0; i < 2; i = i + 1)
            {
              Console.WriteLine("That was a half-note");
              Console.Beep(1000, 2000);
              Thread.Sleep(1000);
              //Console.Beep(0,500);
            }
          break;
          case 3:
            for (int i = 0; i < 4; i = i + 1)
            {
              Console.WriteLine("That was a fourth-note");
              Console.Beep(1000, 1000);
              Thread.Sleep(1000);
              //Console.Beep(0,500);
            }
          break;
          case 4:
            for (int i = 0; i < 4; i = i + 1)
            {
              Console.WriteLine("That was an eigth-note");
              Console.Beep(1000, 500);
              Thread.Sleep(1000);
              //Console.Beep(0,500);
            }
          break;
        }
      }
    }
  }
}
