using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio3Tarea23_05_17
{
    class Util
    {
        private static Random rnd = new Random();
        private static string letters = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

        public static string RandomString(int L)
        {
            string t = "";

            for (int i = 0; i < L; i++ )
            {
                t += letters[rnd.Next(0,letters.Length)];
            }

            return t;
        }
    }
}
