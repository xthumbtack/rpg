using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rpg
{
   public class Objects
    {
       // stats str agl int hp mp lvl exp
       public static int[] ryanhStats = new int[7] { 10, 10, 10, 100, 100, 1, 0 },
                           mattStats = new int[7]  { 10, 10, 10, 100, 100, 1, 0 },
                           aungStats = new int[7]  { 10, 10, 10, 100, 100, 1, 0 };
       // battle stats : atk, def
       public static int[] ryanhBattle = new int[2] { ryanhStats[0] * 2, ryanhStats[2] * (ryanhStats[2] / 2) };

       // items : power gloves, slippers of agility, mantle of intelligence
       public static int[] items = new int[3] { 0, 0, 0, };

       public static int gold = 0;

    }
}
