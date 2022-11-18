using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Poison : Cell
    {
        public Poison(int type, int density, Brush color)
        {
            this.type = type;
            this.density = density;
            this.color = color;
        }

        ~Poison()
        {

        }
    }
}