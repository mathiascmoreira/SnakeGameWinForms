using System;

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

        public void Move(SnakeSegment nextPosition)
        {
            PreviousSegment?.Move(this);

            Update(nextPosition);
        }

        public void Update(SnakeSegment nextPosition)
        {
            Line = nextPosition.Line;
            Column = nextPosition.Column;
        }
    }
}
