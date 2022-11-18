using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Plants_Eating : Cell
    {
        public Plants_Eating(int type, int density, Brush color)
        {
            base.type = new int();
            base.type = type;
            this.density = density;
            this.color = color;
        }

        ~Plants_Eating()
        {

        }
    }
}