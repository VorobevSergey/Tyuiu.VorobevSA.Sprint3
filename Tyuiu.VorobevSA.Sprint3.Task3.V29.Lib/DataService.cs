using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorobevSA.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            foreach (char c in value)
            {
                if (c==item)
                {
                     value= value.Replace(c, ' ');
                }
            }
            return value;
        }
    }
}
