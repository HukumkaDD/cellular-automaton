using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenProgram_v2._0
{
    class ColorManager
    {
        public ColorManager()
        {

        }
        public Color GetColor(int rg)
        {
            int r = 0;
            int g = 0;
            if (rg < 256)
            {
                g = 255;
                r = rg;
            }
            else
            {
                g = 510 - rg;
                r = 255;
            }
            return new Color(r, g, 0);
        }
    }
}
