using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string J = "z";
            string S = "ZZ";
            //Input: J = "aA", S = "aAAbbbb"
            while (true)
            {
                Console.WriteLine(NumJewelsInStones(J, S));
            }


        }

        private static int NumJewelsInStones(string J, string S)
        {
            int tmp = 0;
            foreach (char c in S)
            {
                if (J.Contains(c))
                {
                    tmp++;
                }
            }

            return tmp;
        }
    }


}
