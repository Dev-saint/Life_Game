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

        protected int resolution;
        private int densityPlantsEating;
        private int densityPredators;
        private int densityFood;
        private int densityPoison;
        private int foodBirthChance;
        protected int cols;
        protected int rows;
        protected GameEngine gameEngine;
        protected Field field;
        protected Cell dead_cell;
        protected Plants_Eating plants_Eating;
        protected Predator predator;
        protected Food food;
        protected Poison poison;

        public Plants_Eating Plants_Eating { get => plants_Eating; set => plants_Eating = value; }
        public Predator Predator { get => predator; set => predator = value; }
        public Food Food { get => food; set => food = value; }
        public Poison Poison { get => poison; set => poison = value; }
        public int Cols { get => cols; set => cols = value; }
        public int Rows { get => rows; set => rows = value; }
        public int Resolution { get => resolution; set => resolution = value; }

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

            field = new Field(this, gameEngine);

            dead_cell = new Cell(gameEngine);
            plants_Eating = new Plants_Eating(1, densityPlantsEating, Brushes.Blue);
            predator = new Predator(2, densityPredators, Brushes.Crimson);
            food = new Food(3, densityFood, Brushes.LawnGreen, foodBirthChance);
            poison = new Poison(4, densityPoison, Brushes.Purple);

            gameEngine = new GameEngine(this); 

            Text = $"Поколение {gameEngine.currentGeneration}";

            listBoxTypesOfCells.SelectedIndex = 0;

            field.CreateField();

            timer1.Interval = (int)numericUpDown_Timer.Value * 5;
            timer1.Start();
        }

        private void DrawNextGeneration()
        {
            //var field_ = gameEngine.GetCurrentGeneration();
            field.DrawNextGenerationField();
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