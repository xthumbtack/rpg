using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
   public static class Objects
    {
       public int str = 10, agl = 10, intel = 10, HP = 100, MP = 100;
       public int lvl = 1, exp = 0;

       public void Ryanh()
       {
           int[] stats = new int[5] { str + 10, agl, intel, HP, MP };
           int[] level = new int[2] { lvl, exp };
       }
       public void Matt()
       {
           int[] stats = new int[5] { str, agl, intel + 10, HP, MP };
           int[] level = new int[2] { lvl, exp };
       }
       public void Aung()
       {
           int[] stats = new int[5] { str, agl + 10, intel, HP, MP };
           int[] level = new int[2] { lvl, exp };
       }

       public void slime()
       {
           int slimeATK = 15, slimeHP = 80, slimeDEF = 10;
       }

       public void thief()
       {
           int thiefATK = 20, thiefHP = 120, thiefDEf = 15, thiefMP = 50;
       }

    }
}
