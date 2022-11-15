using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Cell : GameEngine
    {
        public int type;
        public int density;
        public Brush color;

        public Cell()
        {
        }

        public Cell(GameEngine gameEngine)
        {
            type = 0;
            density = 0;
            color = Brushes.Black;
            field_ = gameEngine.Field_;
        }

        public Cell(int density)
        {
            type = 0;
            this.density = density;
            color = Brushes.Black;
        }

        public Cell(int type, int density, Brush color)
        {
            this.type = type;
            this.density = density;
            this.color = color;
        }

        public bool CheckType(int t)
        {
            if (t == type) return true;
            else return false;
        }

        public int CountNeighbours(int x, int y, int code)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;

                    if (field_[x,y] == code && !isSelfChecking)
                        count++;
                }
            }
            return count;
        }

        ~Cell()
        {

        }
    }
}
