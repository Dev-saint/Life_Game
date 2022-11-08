using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Game
{
    public class GameEngine : Form1
    {
        public uint currentGeneration { get; private set; }
        private int[,] field_;
        private int foodBirthChance;
        private /*readonly*/ int rows;
        private /*readonly*/ int cols;

        public GameEngine()
        {
            rows = 0;
            cols = 0;
            foodBirthChance = 0;
            field_ = null;
            currentGeneration = 0;
        }

        public GameEngine(int rows, int cols, int densityPlantsEating, 
            int densityPredators, int densityFood, int densityPoison, int foodBirthChance)
        {
            this.rows = rows;
            this.cols = cols;
            int check = 0;
            int density = 0;
            field_ = new int[cols, rows];
            Random random = new Random();

            // Цикл заполнения матрицы
            for (int type = 1; type < 5; type++)
            {
                if (type == 1) density = densityPlantsEating;
                else
                    if (type == 2) density = densityPredators;
                else
                    if (type == 3) density = densityFood;
                else
                    if (type == 4) density = densityPoison;

                this.foodBirthChance = foodBirthChance;

                for (int x = 0; x < cols; x++)
                    for (int y = 0; y < rows; y++)
                    {
                        if (field_[x, y] == 0)
                        {
                            check = random.Next(density);
                            if (check == 0)
                                field_[x, y] = type;  // 0 - мертвая, 1 - травоядная,
                                                     // 2 - хищник, 3 - еда, 4 - яд
                        }
                    }
            }
        }

        public void NextGeneration()
        {
            var newField = new int[cols, rows];
            Random random = new Random();

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var PlantsEatingNeighboursCount = CountNeighbours(x, y, 1);
                    var PredatorsNeighboursCount = CountNeighbours(x, y, 2);
                    var PoisonNeighboursCount = CountNeighbours(x, y, 4);

                    if (field_[x, y] == 3 && PlantsEatingNeighboursCount >= 1)
                        newField[x, y] = 1;
                    else if (field_[x, y] == 1
                        && (PlantsEatingNeighboursCount < 1 || PlantsEatingNeighboursCount > 4))
                        newField[x, y] = 0;
                    else
                        if (field_[x, y] == 1 && PredatorsNeighboursCount >= 1)
                        newField[x, y] = 2;
                    else
                        if ((field_[x, y] == 1 || field_[x, y] == 2) && PoisonNeighboursCount >= 1)
                        newField[x, y] = 0;
                    else
                    if (field_[x, y] == 2 && (PredatorsNeighboursCount < 1 || PredatorsNeighboursCount > 3))
                        newField[x, y] = 0;
                    else
                        if (field_[x, y] == 0)
                    {
                        if (random.Next(this.foodBirthChance) == 0)
                            newField[x, y] = 3;
                    }
                    else
                        newField[x, y] = field_[x, y];
                }
            }
            field_ = newField;
            currentGeneration++;
        }

        public int[,] GetCurrentGeneration()
        {
            var result = new int[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = field_[x, y];
                }
            }
            return result;
        }

        private int CountNeighbours(int x, int y, int code)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;

                    if (field_[col, row] == code && !isSelfChecking)
                        count++;
                }
            }

            return count;
        }

        public bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void UpdateCell(int x, int y, int state)
        {
            if (ValidateCellPosition(x, y))
                field_[x, y] = state;
        }

        public void AddCell(int x, int y, int type)
        {
            if (field_[x, y] == 0)
                UpdateCell(x, y, state: type);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, state: 0);
        }
    }
}