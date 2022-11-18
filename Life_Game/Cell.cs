using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Cell
    {
        public int type;
        public int density;
        public Brush color;

        public Cell()
        {
            type = 0;
            density = 0;
            color = Brushes.Black;
        }

        public bool CheckType(int t)
        {
            if (t == type) return true;
            else return false;
        }

        ~Cell()
        {

        }
    }
}