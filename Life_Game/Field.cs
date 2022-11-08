using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Field
    {
        public int x;
        public int y;
        private Graphics graphics;
        private Form1 form;
        private int resolution;

        public Field(Form1 form, int resolution)
        {
            x = 0;
            y = 0;
            this.form = form;
            this.resolution = resolution;
        }

        public void CreateField()
        {
            form.pictureBox1.Image = new Bitmap(form.pictureBox1.Width, form.pictureBox1.Height);
            graphics = Graphics.FromImage(form.pictureBox1.Image);
        }

        public void DrawNextGenerationField(int[,] field_)
        {
            graphics.Clear(Color.Black);

            for (int x = 0; x < field_.GetLength(0); x++)
            {
                for (int y = 0; y < field_.GetLength(1); y++)
                {
                    if (field_[x, y] == 1)
                        graphics.FillRectangle(Brushes.Blue, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    if (field_[x, y] == 2)
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    if (field_[x, y] == 3)
                        graphics.FillRectangle(Brushes.LawnGreen, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    if (field_[x, y] == 4)
                        graphics.FillRectangle(Brushes.Purple, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }

            form.pictureBox1.Refresh();
        }
        
    }
}
