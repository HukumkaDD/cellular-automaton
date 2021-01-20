using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenProgram_v2._0
{
    static class RandomManager
    {
        public static int Rvalue()
        {
            Random rnd = new Random();
            return rnd.Next(0, 255);
        }

        public static int Rvalue(int a, int b)
        {
            Random rnd = new Random();
            return rnd.Next(a, b);
        }
    }
}
