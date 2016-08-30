using System;
using System.IO;
using System.Drawing;
using UnknownEng;
using System.Diagnostics;
using BeatControllerN;

//Extends Entity for FVect implementation
namespace BeatN
{
  public class Beat : Entity
  {
      private int x;
      private int y;
      private int tTime;
      private Stopwatch stp;
      private int len;
      private Color c;
      public Beat(int x, int y, int len)
      {
        this.x = x;
        this.y = y;
        this.len = len;
        if (len == BeatController.baseBeatLen/2)
        {
          c = Color.Red;
        }
        else if (len == BeatController.baseBeatLen)
        {
          c = Color.Blue;
        }
        else if (len == BeatController.baseBeatLen*2)
        {
          c = Color.Pink;
        }
        else
        {
          c = Color.Yellow;
        }
        tTime = 2000 - BeatController.baseBeatLen;
        stp = new Stopwatch();
      }

      public int cLife()
      {
        if (stp.ElapsedMilliseconds == len + tTime)
        {
          return 0;
        }
        else
        {
          return (int) (stp.ElapsedMilliseconds - (len + tTime));
        }
      }

      public Color getColor()
      {
        return c;
      }
  }
}
