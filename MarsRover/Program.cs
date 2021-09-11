using MarsRover.Enum;
using MarsRover.Model;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            var plateau = new Plateau(5, 5);
            var position = new Position(1, 2, Direction.N);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();
            rover.SetPosition(marsRover);
            rover.MoveRover("LMLMLMLMM");
            var currentPosiiton = rover.CurrentPosition();

            Console.WriteLine(currentPosiiton);

            position = new Position(3, 3, Direction.E);
            marsRover = new Rover(plateau, position);
            rover.SetPosition(marsRover);
            rover.MoveRover("MMRMMRMRRM");
            currentPosiiton = rover.CurrentPosition();

            Console.WriteLine(currentPosiiton);

            Console.ReadLine();
        }
    }
}
