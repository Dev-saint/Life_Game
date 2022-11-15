using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Life_Game
{
    public class GameEngine : Form1
    {
        public uint currentGeneration { get; private set; }
        protected int[,] field_;

        public int[,] Field_ { get => field_; set => field_ = value; }
     
        public GameEngine()
        {

        }

        public GameEngine(Form1 form)
        {
            cols = form.Cols;
            rows = form.Rows;
            plants_Eating = form.Plants_Eating;
            predator = form.Predator;
            food = form.Food;
            poison = form.Poison;
            int check;
            int density = 0;
            field_ = new int[cols, rows];
            Random random = new Random();

            // Цикл заполнения матрицы
            // 0 - мертвая, 1 - травоядная, 2 - хищник, 3 - еда, 4 - яд
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
                        if (dead_cell.CheckType(field_[x, y]))
                        {
                            check = random.Next(density);
                            if (check == 0)
                            {
                                if (plants_Eating.CheckType(type))
                                    field_[x, y] = plants_Eating.type;
                                else
                                    if (predator.CheckType(type))
                                    field_[x, y] = predator.type;
                                else
                                    if (food.CheckType(type))
                                    field_[x, y] = food.type;
                                else
                                    if (poison.CheckType(type))
                                    field_[x, y] = poison.type;
                            }
                        }
            }
        }

        public void NextGeneration()
        {
            var new_field = new int[cols, rows];
            Random random = new Random();

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var PlantsEatingNeighboursCount = dead_cell.CountNeighbours(x,y, plants_Eating.type);
                    var PredatorsNeighboursCount = dead_cell.CountNeighbours(x, y, predator.type);
                    var PoisonNeighboursCount = dead_cell.CountNeighbours(x, y, poison.type);

                    if (food.CheckType(field_[x,y]) && PlantsEatingNeighboursCount >= 1)
                        new_field[x,y] = plants_Eating.type;
                    else if (plants_Eating.CheckType(field_[x,y])
                        && (PlantsEatingNeighboursCount < 1 || PlantsEatingNeighboursCount > 4))
                        new_field[x, y] = dead_cell.type;
                    else
                        if (plants_Eating.CheckType(field_[x, y]) && PredatorsNeighboursCount >= 1)
                        new_field[x, y] = predator.type;
                    else
                        if ((plants_Eating.CheckType(field_[x, y]) || predator.CheckType(field_[x,y])) && PoisonNeighboursCount >= 1)
                        new_field[x, y] = dead_cell.type;
                    else
                    if (predator.CheckType(field_[x, y]) && (PredatorsNeighboursCount < 1 || PredatorsNeighboursCount > 3))
                        new_field[x, y] = dead_cell.type;
                    else
                        if (dead_cell.CheckType(field_[x,y]))
                    {
                        if (random.Next(food.BirthChance) == 0)
                            new_field[x,y] = food.type;
                    }
                    else
                        new_field[x,y] = field_[x, y];
                }
            }
            field_ = new_field;
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

        ~GameEngine()
        {

        }
    }
}