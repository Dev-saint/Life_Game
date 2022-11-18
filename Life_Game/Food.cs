using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Food : Cell
    {
        public int BirthChance;

        public Food(int type, int density, Brush color, int BirthChance)
        {
            this.type = type;
            this.density = density;
            this.color = color;
            this.BirthChance = BirthChance;
        }

        ~Food()
        {

        }
    }
}