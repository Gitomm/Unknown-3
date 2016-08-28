using System;
using System.IO;
using System.drawing;
public class Beat
{
    private static System.Timers.Timer aTimer, bTimer;
    private int x
    private int y
    private BitMap(string s, int x, int y)
    {
      this.s = s
      this.x = x
      this.y = y
    }
    static void Main(string[] args)
    {
        int m = new int
        m = 1;
        int b = new Random(32);

        for (int i = 1; i < 4; i = i + 1)
        {
          aTimer = new System.Timers.Timer();
          aTimer
          display.thingbeat(_R)
        }
/*
        for (int i = 1; i < 100; i = i + 1)
        {
        Random _r = new Random(64);
        aTimer = new System.Timers.Timer();
        bTimer = new System.Timers.Timer();

        bTimer.Interval = 1000;
        aTimer.Interval = _r.Next(0,9999);

        bTimer = new System.Timers.Timer(1000);
        aTimer = new System.Timers.Timer(_r.Next(0,9999));

        aTimer.Elapsed += OnaTimedEvent;
        bTimer.Elapsed += OnbTimedEvent;

        aTimer.AutoReset = true;
        bTimer.AutoReset = true;

        aTimer.Enabled = true;
        bTimer.Enabled = true;
        }

*/
        Console.WriteLine("Press the Enter key to exit the program at any time... ");
        Console.ReadLine();

    }

    private static void OnaTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("___________________________________________________", e.SignalTime);
    }
     private static void OnbTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine(e.SignalTime);
    }
}
