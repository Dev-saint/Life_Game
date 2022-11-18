using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Game
{
    public class GameEngine
    {
        public uint currentGeneration { get; private set; }
        private int[,] field_;
        private readonly int rows;
        private readonly int cols;
        private Cell dead_cell;
        private Plants_Eating plants_Eating;
        private Predator predator;
        private Food food;
        private Poison poison;

        public GameEngine()
        {
            rows = 0;
            cols = 0;
            field_ = null;
            dead_cell = null;
            plants_Eating = null;
            predator = null;
            food = null;
            poison = null;
            currentGeneration = 0;
        }

        public GameEngine(int rows, int cols,
            Cell dead_cell, Plants_Eating plants_Eating, Predator predator, Food food, Poison poison)
        {
            this.dead_cell = dead_cell;
            this.plants_Eating = plants_Eating;
            this.predator = predator;
            this.food = food;
            this.poison = poison;
            this.rows = rows;
            this.cols = cols;
            int check = 0;
            int density = 0;
            field_ = new int[cols, rows];
            Random random = new Random();

            // Цикл заполнения матрицы
            for (int type = 1; type < 5; type++)
            {
                if (plants_Eating.CheckType(type)) density = plants_Eating.density;
                else
                    if (predator.CheckType(type)) density = predator.density;
                else
                    if (food.CheckType(type)) density = food.density;
                else
                    if (poison.CheckType(type)) density = poison.density;

                for (int x = 0; x < cols; x++)
                    for (int y = 0; y < rows; y++)
                    {
                        if (dead_cell.CheckType(field_[x, y]))
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
                    var PlantsEatingNeighboursCount = CountNeighbours(x, y, plants_Eating.type);
                    var PredatorsNeighboursCount = CountNeighbours(x, y, predator.type);
                    var PoisonNeighboursCount = CountNeighbours(x, y, poison.type);

                    if (food.CheckType(field_[x, y]) && PlantsEatingNeighboursCount >= 1)
                        newField[x, y] = plants_Eating.type;
                    else
                    if (plants_Eating.CheckType(field_[x, y]))
                    {
                        if (PoisonNeighboursCount >= 1)
                            newField[x, y] = dead_cell.type;
                        else
                        if (PlantsEatingNeighboursCount < 1 || PlantsEatingNeighboursCount > 4)
                            newField[x, y] = dead_cell.type;

                        if (PredatorsNeighboursCount >= 1)
                            newField[x, y] = predator.type;
                    }
                    else
                    if (predator.CheckType(field_[x, y]))
                    {
                        if (PoisonNeighboursCount >= 1)
                            newField[x, y] = dead_cell.type;
                        else
                        if (PredatorsNeighboursCount < 1 || PredatorsNeighboursCount > 3)
                            newField[x, y] = dead_cell.type;
                    }
                    else
                        if (dead_cell.CheckType(field_[x, y]))
                    {
                        if (random.Next(food.BirthChance) == 0)
                            newField[x, y] = food.type;
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
            if (dead_cell.CheckType(field_[x, y]))
                UpdateCell(x, y, state: type);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, state: 0);
        }
    }
}