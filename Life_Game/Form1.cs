using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Game
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            numericUpDown_Density.Enabled = false;
            numericUpDown_Resolution.Enabled = false;
            resolution = (int)numericUpDown_Resolution.Value;

            gameEngine = new GameEngine
            (
                rows: pictureBox1.Height / resolution,
                cols: pictureBox1.Width / resolution,
                density: (int)numericUpDown_Density.Minimum + (int)numericUpDown_Density.Maximum - (int)numericUpDown_Density.Value
            );

            Text = $"Поколение {gameEngine.currentGeneration}";

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            timer1.Interval = (int)numericUpDown_Timer.Value * 5;
            timer1.Start();
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var field = gameEngine.GetCurrentGeneration();

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }

            pictureBox1.Refresh();
            Text = $"Поколение {gameEngine.currentGeneration}";
            gameEngine.NextGeneration();
        }

        private void StopGame()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                numericUpDown_Density.Enabled = true;
                numericUpDown_Resolution.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var x = e.Location.X / resolution;
                    var y = e.Location.Y / resolution;
                    gameEngine.AddCell(x, y);
                }

                if (e.Button == MouseButtons.Right)
                {
                    var x = e.Location.X / resolution;
                    var y = e.Location.Y / resolution;
                    gameEngine.RemoveCell(x, y);
                }
            }
        }
    }
}