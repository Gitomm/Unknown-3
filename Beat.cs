using System;
using System.IO;
using System.Drawing;
using UnknownEng;

//Extends Entity for FVect implementation
public class Beat : Entity
{
    private static System.Timers.Timer aTimer, bTimer;
    private int x;
    private int y;
    //Image of the beat
    private Bitmap beatImg;
    public Beat(string s, int x, int y)
    {
      //s is used to declare the URL of the image of the beat
      beatImg = new Bitmap(s);
      this.x = x;
      this.y = y;
    }

    static void Main(string[] args)
    {
        int m;
        m = 1;
        Random _r = new Random(32);
        //Had int b assigned to a new Random Object with seed 32 previously; Now Random object _r is declared with seed 32, b is set to a random int between 0 and 32
        int b = _r.Next(0,32);

        for (int i = 1; i < 4; i = i + 1)
        {
          aTimer = new System.Timers.Timer();
          // what is this tenshi(all you wrote was aTimer) -> aTimer
          //Idk what the point of this is either -> display.thingbeat(_R);
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
