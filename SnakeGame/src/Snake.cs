using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    public class Snake
    {
        private readonly int _lineCount;
        private readonly int _columnCount;
        private Direction _movingDirection;
        public SnakeSegment Head { get; set; }
        public SnakeSegment Food { get; set; }
        public List<SnakeSegment> AllSegments { get; set; }

        public Snake(int lineCount, int columnCount)
        {
            _lineCount = lineCount;
            _columnCount = columnCount;          

            Initialize();
        }

        public void Move()
        {
            var nextPosition = GetNextPosition();

            CheckIfGotFood(nextPosition);

            CheckIfNextPositionIsValid(nextPosition);

            Head.Move(nextPosition);

            CheckIfTouchedItself();
        }

        public void Initialize()
        {
            Head = new SnakeSegment(0, 0);
            AllSegments = new List<SnakeSegment> { Head };

            SetNewFoodPosition();

            _movingDirection = Direction.Right;
        }

        private SnakeSegment GetNextPosition()
        {
            switch (_movingDirection)
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

        public void UpdateHead()
        {
            Food.PreviousSegment = Head;
            AllSegments.Add(Food);

            Head = Food;
        }

        public void ChangeMovingDirection(Direction newDirection)
        {
            var isOposite = (_movingDirection == Direction.Down && newDirection == Direction.Up || _movingDirection == Direction.Up && newDirection == Direction.Down) ||
                    (_movingDirection == Direction.Left && newDirection == Direction.Right || _movingDirection == Direction.Right && newDirection == Direction.Left);

            if (!isOposite)
                _movingDirection = newDirection; 
        }

        private void SetNewFoodPosition()
        {
            var random = new Random();

            var line = random.Next(1, _lineCount - 1);
            var column = random.Next(1, _columnCount - 1);

            while (HasSegmentIn(line, column))
            {
                line = random.Next(1, _lineCount - 1);
                column = random.Next(1, _columnCount - 1);
            }

            Food = new SnakeSegment(line, column);
        }

        public bool HasSegmentIn(int line, int column)
        {
            return AllSegments.Any(c => c.Line == line && c.Column == column);
        }

        private void CheckIfGotFood(SnakeSegment nextPosition)
        {
            if (nextPosition.Line == Food.Line && nextPosition.Column == Food.Column)
            {
                UpdateHead();
                SetNewFoodPosition();
                nextPosition.Update(GetNextPosition());
            }
        }       

        private void CheckIfNextPositionIsValid(SnakeSegment nextPosition)
        {
            if (nextPosition.Line >= _lineCount || nextPosition.Column >= _columnCount)
                throw new Exception("Game Over");
        }

        private void CheckIfTouchedItself()
        {
            var touchedItself = AllSegments.Any(c => c.Line == Head.Line && c.Column == Head.Column && c != Head);

            if (touchedItself)
                throw new Exception("Game Over");
        }
    }
}
