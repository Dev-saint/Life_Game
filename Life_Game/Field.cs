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
        private readonly Form1 form;
        private readonly int resolution;
        protected Cell dead_cell;
        protected Plants_Eating plants_Eating;
        protected Predator predator;
        protected Food food;
        protected Poison poison;

        public Field(Form1 form, int resolution,
            Cell dead_cell, Plants_Eating plants_Eating, Predator predator, Food food, Poison poison)
        {
            x = 0;
            y = 0;
            this.form = form;
            this.resolution = resolution;
            this.dead_cell = dead_cell;
            this.plants_Eating = plants_Eating;
            this.predator = predator;
            this.food = food;
            this.poison = poison;
        }

        public void CreateField()
        {
            form.pictureBox1.Image = new Bitmap(form.pictureBox1.Width, form.pictureBox1.Height);
            graphics = Graphics.FromImage(form.pictureBox1.Image);
        }

        public void DrawNextGenerationField(int[,] field_)
        {
            graphics.Clear(Color.Black);

            for (x = 0; x < field_.GetLength(0); x++)
            {
                for (y = 0; y < field_.GetLength(1); y++)
                {
                    if (plants_Eating.CheckType(field_[x, y]))
                        graphics.FillRectangle(plants_Eating.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    if (predator.CheckType(field_[x, y]))
                        graphics.FillRectangle(predator.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    if (food.CheckType(field_[x, y]))
                        graphics.FillRectangle(food.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    if (poison.CheckType(field_[x, y]))
                        graphics.FillRectangle(poison.color, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }

            form.pictureBox1.Refresh();
        }

    }
}