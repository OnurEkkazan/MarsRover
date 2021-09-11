using MarsRover.Enum;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IRoverCalculate
    {
        public void SetPosition(Rover rover);
        public bool ControlArea();
        public void MoveRover(string move);
        public string CurrentPosition();
        public void TurnLeft();
        public void TurnRight();
        public void CalculateNewPosition();
        public bool ControlMinMaxArea();


    }
}
