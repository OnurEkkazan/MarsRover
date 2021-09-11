using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Plateau
    {
        public int _min_Width { get; set; }
        public int _min_Height { get; set; }
        public int _max_Width { get; set; }
        public int _max_Height { get; set; }

        public Plateau(int _max_Width, int _max_Height)
        {
            this._max_Width = _max_Width;
            this._max_Height = _max_Height;
            this._min_Width = 0;
            this._min_Height = 0;
        }
    }
}
