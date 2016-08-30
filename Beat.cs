using System;
using System.IO;
using System.Drawing;
using UnknownEng;
using System.Diagnostics;

//Extends Entity for FVect implementation
public class Beat : Entity
{
    private int x;
    private int y;
    private Stopwatch stp;
    private int len;
    public Beat(string s, int x, int y, int len)
    {
      this.x = x;
      this.y = y;
      this.len = len;
      stp = new Stopwatch();
    }

    public int cLife()
    {
      if (stp.ElapsedMilliseconds == len)
      {
        this = null;
        return 0;
      }
      else
      {
        return stp.ElapsedMilliseconds - len;
      }
    }
}
