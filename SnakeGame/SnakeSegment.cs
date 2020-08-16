using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class SnakeSegment
    {
        public SnakeSegment(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public SnakeSegment PreviousSegment { get; set; }

        public int Line { get; set; }
        public int Column { get; set; }

        internal void Move(int line, int colunm)
        {
            PreviousSegment?.Move(Line, Column);

            Line = line;
            Column = colunm;
        }
    }
}
