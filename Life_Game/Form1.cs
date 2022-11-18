using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Life_Game
{
    public partial class Form1 : Form
    {

        public int resolution;
        private int densityPlantsEating;
        private int densityPredators;
        private int densityFood;
        private int densityPoison;
        private int foodBirthChance;
        private int cols;
        private int rows;
        private GameEngine gameEngine;
        private Field field;
        private Cell dead_cell;
        private Plants_Eating plants_Eating;
        private Predator predator;
        private Food food;
        private Poison poison;

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

            densityPlantsEating = (int)numericUpDown_DensityPlantsEating.Minimum + (int)numericUpDown_DensityPlantsEating.Maximum - (int)numericUpDown_DensityPlantsEating.Value;
            densityPredators = (int)numericUpDown_DensityPredators.Minimum + (int)numericUpDown_DensityPredators.Maximum - (int)numericUpDown_DensityPredators.Value;
            densityFood = (int)numericUpDown_DensityFood.Minimum + (int)numericUpDown_DensityFood.Maximum - (int)numericUpDown_DensityFood.Value;
            densityPoison = (int)numericUpDown_DensityPoison.Minimum + (int)numericUpDown_DensityPoison.Maximum - (int)numericUpDown_DensityPoison.Value;
            foodBirthChance = (int)numericUpDown_FoodBirth.Minimum + (int)numericUpDown_FoodBirth.Maximum - (int)numericUpDown_FoodBirth.Value;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;

            dead_cell = new Cell();
            plants_Eating = new Plants_Eating(1, densityPlantsEating, Brushes.Blue);
            predator = new Predator(2, densityPredators, Brushes.Crimson);
            food = new Food(3, densityFood, Brushes.LawnGreen, foodBirthChance);
            poison = new Poison(4, densityPoison, Brushes.Purple);

            field = new Field(this, resolution, dead_cell, plants_Eating, predator, food, poison);
            gameEngine = new GameEngine(rows, cols,
                dead_cell, plants_Eating, predator, food, poison);

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
                        type = plants_Eating.type;
                    else
                        if (listBoxTypesOfCells.SelectedIndex == 1)
                        type = predator.type;
                    else
                        if (listBoxTypesOfCells.SelectedIndex == 2)
                        type = food.type;
                    else
                        if (listBoxTypesOfCells.SelectedIndex == 3)
                        type = poison.type;


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