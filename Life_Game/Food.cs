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

        /*public Food()
        {
            type = 3;
            density = 0;
            x = 0;
            y = 0;
            color = Brushes.LawnGreen;
            BirthChance = 0;
        }*/

        /*public Food(int density, int x, int y, int BirthChance)
        {
            type = 3;
            this.density = density;
            this.x = x;
            this.y = y;
            color = Brushes.LawnGreen;
            this.BirthChance = BirthChance;
        }*/

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
