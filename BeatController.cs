using System;
using System.Threading;
namespace BeatController
{
  class BeatController
  {
    static int a;
    static int Counter;
    private static int baseBeatLen = 460;
    private static int beepHertz = 1000;
    private static int sleepInterval = 1000;
    static void AssignBeat()
    {
      Random _r = new Random();
      if (Counter == 0 || Counter == 8)
      {
        Counter = 0;
        a = _r.Next(1,5); //Next(1,4) may mean whole numbers up to 4 but not 4.
      }
      else
      {
        switch (Counter)
        {
          case 1:
            a = _r.Next(2,5);
          break;
          case 2:
            a = _r.Next(2,5);
          break;
          case 3:
            a = _r.Next(2,5);
          break;
          case 4:
            a = _r.Next(3,5);
          break;
          case 5:
            a = _r.Next(3,5);
          break;
          case 6:
            a = _r.Next(3,5);
          break;
          case 7:
            a = 4;
          break;
        }
      }
    }
    public static void Main(string[] args)
    {
        AssignBeat();
        switch (a)
        {
          case 1:
            Console.WriteLine("That was a whole-note");
            Console.Beep(beepHertz, baseBeatLen);
            Thread.Sleep(sleepInterval);
            Counter = Counter + 8;
            //Console.Beep(0,500);
          break;
          case 2:
            Console.WriteLine("That was a half-note");
            Console.Beep(beepHertz, baseBeatLen/2);
            Thread.Sleep(sleepInterval);
            Counter = Counter + 4;
            //Console.Beep(0,500);
          break;
          case 3:
            Console.WriteLine("That was a fourth-note");
            Console.Beep(beepHertz, baseBeatLen/4);
            Thread.Sleep(sleepInterval);
            Counter = Counter + 2;
            //Console.Beep(0,500);
          break;
          case 4:
            Console.WriteLine("That was an eigth-note");
            Console.Beep(beepHertz, baseBeatLen/8);
            Thread.Sleep(sleepInterval);
            Counter = Counter + 1;
            //Console.Beep(0,500);
          break;
        }
    }
  }
}
