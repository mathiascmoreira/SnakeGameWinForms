using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    public class Snake
    {
        public Snake()
        {
            Head = new SnakeSegment(0, 0);

            AllSegments = new List<SnakeSegment> { Head };

            MovingDirection = Direction.Right;
        }

        public SnakeSegment Head { get; set; }
        public List<SnakeSegment> AllSegments { get; set; }
        public Direction MovingDirection { get; set; }

        public SnakeSegment GetNextPosition()
        {
            switch (MovingDirection)
            {
                case Direction.Up:
                    return new SnakeSegment(Head.Line - 1, Head.Column);
                case Direction.Down:
                    return new SnakeSegment(Head.Line + 1, Head.Column);
                case Direction.Left:
                    return new SnakeSegment(Head.Line, Head.Column - 1);
                case Direction.Right:
                    return new SnakeSegment(Head.Line, Head.Column + 1);
                default:
                    return new SnakeSegment(Head.Line, Head.Column + 1);
            }
        }

        public void Move()
        {
            var nextPosition = GetNextPosition();

            Head.Move(nextPosition.Line, nextPosition.Column);
        }

        internal void UpdateHead(SnakeSegment newHead)
        {
            newHead.PreviousSegment = Head;

            Head = newHead;
        }

        public bool HasSegmentIn(int line, int column)
        {
            return AllSegments.Any(c => c.Line == line && c.Column == column);
        }
    }
}
