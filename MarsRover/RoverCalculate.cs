using MarsRover.Enum;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverCalculate : IRoverCalculate
    {

        public Rover _rover;
        public Direction _lastDirection;
        public bool controlAreaValue;

        public void SetPosition(Rover rover)
        {
            _rover = rover;
            _lastDirection = rover.Position.Direction;
        }

        public void MoveRover(string move)
        {
            controlAreaValue = ControlArea();
            foreach (var item in move)
            {
                switch (item)
                {
                    case 'M':
                        if (controlAreaValue && ControlMinMaxArea())
                        {
                            CalculateNewPosition();
                        }
                        else
                        {
                            Console.WriteLine("Not Area!!!");
                        }
                        break;
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    default:
                        Console.WriteLine("Wrong Parameters");
                        break;

                }
            }
        }

        public bool ControlArea()
        {
            if ((_rover.Position.X >= _rover.Plateau._min_Width && _rover.Position.X <= _rover.Plateau._max_Width) &&
                (_rover.Position.Y >= _rover.Plateau._min_Height && _rover.Position.Y <= _rover.Plateau._max_Height))
            {
                return true;
            }
            return false;
        }

        public string CurrentPosition()
        {
            return _rover.Position.X + " " + _rover.Position.Y + " " + _lastDirection;
        }

        public void TurnLeft()
        {
            _lastDirection = _lastDirection == Direction.N ? Direction.W : (Direction)((int)_lastDirection - 1);
        }

        public void TurnRight()
        {
            _lastDirection = _lastDirection == Direction.W ? Direction.N : (Direction)((int)_lastDirection + 1);
        }

        public void CalculateNewPosition()
        {
            switch (_lastDirection)
            {
                case Direction.N:
                    _rover.Position.Y += 1;
                    break;
                case Direction.E:
                    _rover.Position.X += 1;
                    break;
                case Direction.S:
                    _rover.Position.Y -= 1;
                    break;
                case Direction.W:
                    _rover.Position.X -= 1;
                    break;
            }
        }

        public bool ControlMinMaxArea()
        {
            if ((_rover.Plateau._min_Height == _rover.Position.Y && _lastDirection == Direction.S) ||
                (_rover.Plateau._max_Height == _rover.Position.Y && _lastDirection == Direction.N) ||
                (_rover.Plateau._min_Width == _rover.Position.X && _lastDirection == Direction.W) ||
                (_rover.Plateau._max_Width == _rover.Position.X && _lastDirection == Direction.E))
            {
                return false;
            }
            return true;
        }


    }
}
