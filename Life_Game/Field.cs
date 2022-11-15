using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Life_Game
{
    public class Field : GameEngine
    {
        public int x;
        public int y;
        private Graphics graphics;
        private Form1 form;

        public Field(Form1 form, GameEngine gameEngine)
        {
            x = 0;
            y = 0;
            //this.form = form;
            resolution = form.Resolution;
            field_ = gameEngine.Field_;
        }

        public void CreateField()
        {
            form.pictureBox1.Image = new Bitmap(form.pictureBox1.Width, form.pictureBox1.Height);
            graphics = Graphics.FromImage(form.pictureBox1.Image);
        }

        public void DrawNextGenerationField()
        {
            graphics.Clear(Color.Black);
            
            for (x = 0; x < cols; x++)
                for (y = 0; y < rows; y++)
                {
                    if (plants_Eating.CheckType(field_[x, y]))
                        graphics.FillRectangle(plants_Eating.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    else
                    if (predator.CheckType(field_[x,y]))
                        graphics.FillRectangle(predator.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    else
                    if (food.CheckType(field_[x, y]))
                        graphics.FillRectangle(food.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    else
                    if (poison.CheckType(field_[x, y]))
                        graphics.FillRectangle(poison.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }

            form.pictureBox1.Refresh();
        }

        ~Field()
        {

        }
    }
}
