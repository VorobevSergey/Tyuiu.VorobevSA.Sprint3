using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.VorobevSA.Sprint3.Task7.V15.Lib
{
    public class DataService : ISprint3Task7V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[]  valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y=0;
            int count = 0;
            for (int x=startValue; x<= stopValue; x++)  
            {
                if (x == 0)
                {
                    break;
                }
                else
                {

                    y = Math.Round( y + (Math.Sin(x) + ((2 * x) / 3) - Math.Cos(x) * 4 * x), 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
                
        }
    }
}
