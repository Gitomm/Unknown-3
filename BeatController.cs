using System;
using System.Threading;
using BeatN;
using UnknownEng;
using System.Collections.Generic;
using System.Diagnostics;

namespace BeatControllerN
{
  public class BeatController
  {
    static int a;
    private int Counter = 0;
    public static int baseBeatLen = 1840;
    private static int beepHertz = 1000;
    private static int sleepInterval = 1000;
    private FVect fv = new FVect(1, 0);
    public List<Beat> beatList;
    public static bool fTime = true;
    public Stopwatch st = new Stopwatch();

    public BeatController()
    {
      beatList = new List<Beat>();
    }

    private void AssignBeat()
    {
      //Console.WriteLine("Check");
      if (st.ElapsedMilliseconds >= 200 || fTime)
      {
        Console.WriteLine("Bool");
        Console.WriteLine(st.toString());
        Console.WriteLine("Bork");
        Random _r = new Random();
        fTime = false;
        if (Counter == 0 || Counter == 8)
        {
          Console.WriteLine("BC");
          Counter = 0;
          a = _r.Next(1,5); //Next(1,4) may mean whole numbers up to 4 but not 4.
          beatList.Add(new Beat(1060, 16, baseBeatLen/a));
          st.Restart();
          fTime = false;
          Console.WriteLine("BCE");
        }
        else
        {
          switch (Counter)
          {
            case 1:
              a = _r.Next(2,5);
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
            case 2:
              a = _r.Next(2,5);
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
            case 3:
              a = _r.Next(2,5);
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
            case 4:
              a = _r.Next(3,5);
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
            case 5:
              a = _r.Next(3,5);
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
            case 6:
              a = _r.Next(3,5);
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
            case 7:
              a = 4;
              beatList.Add(new Beat(1060, 16, baseBeatLen/a));
              st.Restart();
            break;
          }
        }
      }
    }

    public void run()
    {
        AssignBeat();
        switch (a)
        {
          case 1:
            Console.WriteLine("That was a whole-note");
            if (beatList[0] != null)
            {
              if (beatList[0].cLife() == 0)
              {
                beatList.Remove(beatList[0]);
              }
              foreach (Beat b in beatList)
              {
                fv.applyV(b);
              }
              //Console.Beep(beepHertz, baseBeatLen);
              //Thread.Sleep(sleepInterval);
              Counter = Counter + 8;
              //Console.Beep(0,500);
            }
          break;
          case 2:
            Console.WriteLine("That was a half-note");
            if (beatList[0] != null)
            {
              if (beatList[0].cLife() == 0)
              {
                beatList.Remove(beatList[0]);
              }
              foreach (Beat b in beatList)
              {
                fv.applyV(b);
              }
              //Console.Beep(beepHertz, baseBeatLen/2);
              //Thread.Sleep(sleepInterval);
              Counter = Counter + 4;
              //Console.Beep(0,500);
            }
          break;
          case 3:
          if (beatList[0] != null)
          {
            Console.WriteLine("That was a fourth-note");
            if (beatList[0].cLife() == 0)
            {
              beatList.Remove(beatList[0]);
            }
            foreach (Beat b in beatList)
            {
              fv.applyV(b);
            }
            //Console.Beep(beepHertz, baseBeatLen/4);
            //Thread.Sleep(sleepInterval);
            Counter = Counter + 2;
            //Console.Beep(0,500);
          }
          break;
          case 4:
          if (beatList[0] != null)
          {
            Console.WriteLine("That was an eigth-note");
            if (beatList[0].cLife() == 0)
            {
              beatList.Remove(beatList[0]);
            }
            foreach (Beat b in beatList)
            {
              fv.applyV(b);
            }
            //Console.Beep(beepHertz, baseBeatLen/8);
            //Thread.Sleep(sleepInterval);
            Counter = Counter + 1;
            //Console.Beep(0,500);
          }
          break;
        }
    }
  }
}
