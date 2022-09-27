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
        private int[,] field;
        private readonly int rows;
        private readonly int cols;

        public GameEngine(int rows, int cols, int densityPlantsEating, 
            int densityPredators, int densityFood, int densityPoison)
        {
            this.rows = rows;
            this.cols = cols;
            int check = 0;
            int density = 0;
            field = new int[cols, rows];
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

                for (int x = 0; x < cols; x++)
                    for (int y = 0; y < rows; y++)
                    {
                        check = random.Next(density);
                        if (check == 0 && field[x, y] == 0)
                            field[x, y] = type;  // 0 - мертвая, 1 - травоядная,
                                                 // 2 - хищник, 3 - растение, 4 - яд
                    }
            }
        }

        public void NextGeneration()
        {
            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var NeighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && NeighboursCount == 3)
                        newField[x, y] = true;
                    else if (hasLife && (NeighboursCount < 2 || NeighboursCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                }
            }
            field = newField;
            currentGeneration++;
        }

        public bool[,] GetCurrentGeneration()
        {
            var result = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = field[x, y];
                }
            }
            return result;
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }

            return count;
        }

        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void UpdateCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y))
                field[x, y] = state;
        }

        public void AddCell(int x, int y)
        {
            UpdateCell(x, y, state: true);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, state: false);
        }
    }
}