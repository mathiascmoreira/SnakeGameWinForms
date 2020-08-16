using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        public Snake()
        {
            Head = new SnakeSegment(0, 0);

            Segments = new List<SnakeSegment> { Head };
        }

        public SnakeSegment Head { get; set; }
        public List<SnakeSegment> Segments { get; set; }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Head.PreviousLine = Head.Line--;
                    Head.PreviousColunm = Head.Colunm;
                    break;
                case Direction.Down:
                    Head.PreviousLine = Head.Line++;
                    Head.PreviousColunm = Head.Colunm;
                    break;
                case Direction.Left:
                    Head.PreviousColunm = Head.Colunm--;
                    Head.PreviousLine = Head.Line;
                    break;
                case Direction.Right:
                    Head.PreviousColunm = Head.Colunm++;
                    Head.PreviousLine = Head.Line;
                    break;
            }
        }
    }
}
