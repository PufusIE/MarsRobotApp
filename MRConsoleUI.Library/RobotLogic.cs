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
        private readonly IMovementLogic? _movementLogic;
        private GridModel? _grid;
        private List<char> _path;
        private DirectionStatus _direction;
        private List<int> _robotPosition;

        public RobotLogic()
        {
            
        }

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

        public void GetPath()
        {
            bool validInput = false;
            do
            {
                validInput = true;
                List<char> pathInput = AskAndGetStringResponse("Please enter robot's path: ").ToUpper().ToList();

                pathInput.ForEach(x =>
                {
                    if (x != 'F' && x != 'L' && x != 'R')
                    {
                        Console.WriteLine("Invalid path.");
                        validInput = false;
                    }
                });
                _path = pathInput;

            } while (validInput == false);
        }

        public void Move()
        {
            _direction = DirectionStatus.North;
            _robotPosition = new List<int> { 1, 1 };

            foreach (var command in _path)
            {
                switch (command)
                {
                    case 'F':
                        _movementLogic.MoveRobot(_robotPosition, _direction, _grid.Grid);
                        break;
                    case 'R':
                        switch (_direction)
                        {
                            case DirectionStatus.North:
                                _direction = DirectionStatus.East;
                                break;
                            case DirectionStatus.East:
                                _direction = DirectionStatus.South;
                                break;
                            case DirectionStatus.South:
                                _direction = DirectionStatus.West;
                                break;
                            case DirectionStatus.West:
                                _direction = DirectionStatus.North;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'L':
                        switch (_direction)
                        {
                            case DirectionStatus.North:
                                _direction = DirectionStatus.West;
                                break;
                            case DirectionStatus.West:
                                _direction = DirectionStatus.South;
                                break;
                            case DirectionStatus.South:
                                _direction = DirectionStatus.East;
                                break;
                            case DirectionStatus.East:
                                _direction = DirectionStatus.North;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }
        }
    }
}
