﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevSA.Sprint3.Task4.V16.Lib
{
    public class DataService : ISprint3Task4V16
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for(int x=startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res =res *(((Math.Cos(x) + x) / x) + 0.25);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
