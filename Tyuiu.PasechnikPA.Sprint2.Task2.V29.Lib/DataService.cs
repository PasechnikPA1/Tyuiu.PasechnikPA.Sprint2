using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PasechnikPA.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x>=4) && (x<=5) && (y>=1) && (y <= 2) || (x >= 3) && (x <= 7) && (y >= 3) && (y <= 5) || (x >= 5) && (x <= 7) && (y >= 6) && (y <= 12) || (x >= 5) && (x <= 11) && (y >= 6) || (x >= 11)  && (y >= 3) && (y <= 6) || (x >= 11) && (x <= 12) && (y >= 4) && (y <= 5) || (x >= 3) && (x <= 4) && (y >= 9) && (y <= 12) || (x >= 6) && (x <= 8) && (y >= 10) && (y <= 13) || (x >= 8) && (x <= 11) && (y >= 10) && (y <= 12) || (x >= 12)  && (y >= 10) )
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
