using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Rover
    {
        public Plateau Plateau { get; set; }
        public Position Position { get; set; }

        public Rover(Plateau plateau, Position position)
        {
            this.Plateau = plateau;
            this.Position = position;
        }
    }
}
