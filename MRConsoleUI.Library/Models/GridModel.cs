using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library.Models
{
    public class GridModel
    {
        public List<int> Grid { get; set; } = new List<int>();

        public GridModel(string grid)
        {
            InitializeGrid(grid);
        }

        private void InitializeGrid(string grid)
        {
            try
            {
                List<string> parsedGrid = grid.ToLower().Split("x").ToList();
                parsedGrid.ForEach(x => Grid.Add(int.Parse(x)));
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException("Invalid value, please try again.");
            }

            ValidateGrid();
        }

        private void ValidateGrid()
        {
            Grid.ForEach(x =>
            {
                if (x <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value, please try again.");
                }
            });

            if (Grid.Count != 2)
            {
                throw new ArgumentOutOfRangeException("Invalid value, please try again.");
            }
        }
    }
}
