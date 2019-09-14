using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIPKubusProject
{
    public class Scrambler
    {
        public static List<int> Scramble(int length)
        {
            //D
            Random random = new Random();
            List<int> scrambleList = new List<int>();

            //P
            for (int i = 0; i < length; i++)
            {
                int randomgtl = random.Next(1, 13); //12 mogenlijkheden
                scrambleList.Add(randomgtl);
            }
            return scrambleList;
        }
    }
}
