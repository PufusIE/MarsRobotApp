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
        public void AskForDimensions(GridModel grid)
        {
            bool validInput = false;
            do
            {
                validInput = true;

                string dimensions = AskAndGetStringResponse("Please enter grid dimensions: ");

                try
                {
                    grid = new GridModel(dimensions);
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
    }
}
