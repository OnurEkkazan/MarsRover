using MarsRover.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Position(int x, int y, Direction direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }
    }
}
