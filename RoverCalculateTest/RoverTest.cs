using MarsRover;
using MarsRover.Enum;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RoverCalculateTest
{
    public class RoverTest
    {
        [Fact]
        public void Test_Move_To_1_2_N_Area_5_5()
        {
            var plateau = new Plateau(5, 5);
            var position = new Position(1, 2, Direction.N);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("LMLMLMLMM");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("1 3 N", currentLocation);
        }

        [Fact]
        public void Test_Move_To_3_3_E_Area_5_5()
        {
            var plateau = new Plateau(5, 5);
            var position = new Position(3, 3, Direction.E);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MMRMMRMRRM");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("5 1 E", currentLocation);
        }

        [Fact]
        public void Test_Move_To_0_0_S_Area_5_5()
        {
            var plateau = new Plateau(5, 5);
            var position = new Position(0, 0, Direction.S);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MRMRMRMRMRMR");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("0 0 N", currentLocation);
        }

        [Fact]
        public void Test_Move_To_5_5_S_Area_5_5()
        {
            var plateau = new Plateau(5, 5);
            var position = new Position(5, 5, Direction.S);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MMMMMLMLLMMMMMML");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("0 0 S", currentLocation);
        }

        [Fact]
        public void Test_Move_To_0_5_E_Area_5_5()
        {
            var plateau = new Plateau(5, 5);
            var position = new Position(0, 5, Direction.E);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MRMLMRMLMRMLMRMLMRML");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("5 0 E", currentLocation);
        }

        [Fact]
        public void Test_Move_To_1_1_N_Area_2_2()
        {
            var plateau = new Plateau(2, 2);
            var position = new Position(1, 1, Direction.N);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MMRMMRMMRMMRMMRMRMRR");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("1 1 N", currentLocation);
        }

        [Fact]
        public void Test_Move_To_0_0_N_Area_0_0()
        {
            var plateau = new Plateau(0, 0);
            var position = new Position(0, 0, Direction.N);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MRLMRLMRLMRLR");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("0 0 E", currentLocation);
        }

        [Fact]
        public void Test_Move_To_2_2_N_Area_2_2()
        {
            var plateau = new Plateau(2, 2);
            var position = new Position(2, 2, Direction.N);
            var marsRover = new Rover(plateau, position);
            var rover = new RoverCalculate();

            rover.SetPosition(marsRover);
            rover.MoveRover("MRMRMLMLMLMRRML");
            var currentLocation = rover.CurrentPosition();

            Assert.Equal("2 2 N", currentLocation);
        }
    }
}
