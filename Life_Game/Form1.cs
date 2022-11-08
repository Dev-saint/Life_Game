using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Game
{
    public partial class Form1 : Form
    {
        
        public int resolution;
        public GameEngine gameEngine;
        public Field field;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            numericUpDown_DensityPlantsEating.Enabled = false;
            numericUpDown_Resolution.Enabled = false;
            numericUpDown_DensityPredators.Enabled = false;
            numericUpDown_DensityFood.Enabled = false;
            numericUpDown_DensityPoison.Enabled = false;
            numericUpDown_FoodBirth.Enabled = false;
            resolution = (int)numericUpDown_Resolution.Value;

            field = new Field(this, resolution);

            gameEngine = new GameEngine
                (
                    rows: pictureBox1.Height / resolution,
                    cols: pictureBox1.Width / resolution,
                    densityPlantsEating: (int)numericUpDown_DensityPlantsEating.Minimum + (int)numericUpDown_DensityPlantsEating.Maximum - (int)numericUpDown_DensityPlantsEating.Value,
                    densityPredators: (int)numericUpDown_DensityPredators.Minimum + (int)numericUpDown_DensityPredators.Maximum - (int)numericUpDown_DensityPredators.Value,
                    densityFood: (int)numericUpDown_DensityFood.Minimum + (int)numericUpDown_DensityFood.Maximum - (int)numericUpDown_DensityFood.Value,
                    densityPoison: (int)numericUpDown_DensityPoison.Minimum + (int)numericUpDown_DensityPoison.Maximum - (int)numericUpDown_DensityPoison.Value,
                    foodBirthChance: (int)numericUpDown_FoodBirth.Minimum + (int)numericUpDown_FoodBirth.Maximum - (int)numericUpDown_FoodBirth.Value
                );

            Text = $"Поколение {gameEngine.currentGeneration}";

            listBoxTypesOfCells.SelectedIndex = 0;

            field.CreateField();

            timer1.Interval = (int)numericUpDown_Timer.Value * 5;
            timer1.Start();
        }

        private void DrawNextGeneration()
        {
            var field_ = gameEngine.GetCurrentGeneration();
            field.DrawNextGenerationField(field_);
            Text = $"Поколение {gameEngine.currentGeneration}";
            gameEngine.NextGeneration();
        }

        private void StopGame()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                numericUpDown_DensityPlantsEating.Enabled = true;
                numericUpDown_DensityPredators.Enabled = true;
                numericUpDown_DensityFood.Enabled = true;
                numericUpDown_DensityPoison.Enabled = true;
                numericUpDown_FoodBirth.Enabled = true;
                numericUpDown_Resolution.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int type = 0;
            if (timer1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var x = e.Location.X / resolution;
                    var y = e.Location.Y / resolution;

                    if (listBoxTypesOfCells.SelectedIndex == 0)
                        type = 1;
                    else
                        if (listBoxTypesOfCells.SelectedIndex == 1)
                        type = 2;
                    else
                        if (listBoxTypesOfCells.SelectedIndex == 2)
                        type = 3;
                    else
                        if (listBoxTypesOfCells.SelectedIndex == 3)
                        type = 4;
                    

                    gameEngine.AddCell(x, y, type);
                }

                if (e.Button == MouseButtons.Right)
                {
                    var x = e.Location.X / resolution;
                    var y = e.Location.Y / resolution;
                    gameEngine.RemoveCell(x, y);
                }
            }
        }

        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
    }
}