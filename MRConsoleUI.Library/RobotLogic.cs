using MRConsoleUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRConsoleUI.Library
{
    public class RobotLogic
    {
        private GridModel? _grid;
        private List<char> _path;
        public void AskForDimensions()
        {
            bool validInput = false;
            do
            {
                validInput = true;

                string dimensions = AskAndGetStringResponse("Please enter grid dimensions: ");

                try
                {
                    _grid = new GridModel(dimensions);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex?.Message);
                    validInput = false;
                }

            } while (validInput == false);
        }

        private string AskAndGetStringResponse(string message)
        {
            Console.WriteLine(message);
            var output = Console.ReadLine();
            return output;
        }

        public string GetPath(string input)
        {
            throw new Exception();
        }
    }
}
