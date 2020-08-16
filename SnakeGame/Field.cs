using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeGame
{
    public class Field
    {
        private const char _filledSquare = '◼';
        private const char _emptySquare = '◻';

        private readonly int _lineCount;
        private readonly int _columnCount;

        private readonly Snake _snake;

        private SnakeSegment _food;


        public List<string> FieldCaracters { get; set; }

        public Field(int lineCount, int columnCount)
        {
            _lineCount = lineCount;
            _columnCount = columnCount;

            _snake = new Snake();
            _food = GetNewFoodPosition();

            FillField(); 
        }

        public void MoveSnack()
        {
            var nextPosition = _snake.GetNextPosition();

            if (nextPosition.Line == _food.Line && nextPosition.Column == _food.Column)
            {
                _snake.UpdateHead(_food);
                _food = GetNewFoodPosition();
            }

            _snake.Move();

            FillField();
        }

        public void MovingDirection(Direction direction)
        {
            _snake.MovingDirection = direction;
        }

        private void FillField()
        {
            ClearField();

            FillSnake();

            FillFood();
        }

        private void ClearField()
        {
            var line = new StringBuilder().Append(_emptySquare, _columnCount).ToString();

            FieldCaracters = Enumerable.Repeat(line, _lineCount).ToList();
        }

        private void FillSnake()
        {
            var segment = _snake.Head;

            while (segment != null)
            {
                FillSegment(segment);
                segment = segment.PreviousSegment;
            }
        }

        private void FillSegment(SnakeSegment segment)
        {
            var line = FieldCaracters.ElementAt(segment.Line).Remove(segment.Column, 1).Insert(segment.Column, $"{_filledSquare}");

            FieldCaracters.RemoveAt(segment.Line);
            FieldCaracters.Insert(segment.Line, line);
        }

        private void FillFood()
        {
            FillSegment(_food);
        }

        private SnakeSegment GetNewFoodPosition()
        {
            var line = new Random().Next(0, _lineCount);
            var column = new Random().Next(0, _columnCount);

            while (_snake.HasSegmentIn(line, column))
            {
                line = new Random().Next(0, _lineCount);
                column = new Random().Next(0, _columnCount);
            }

            return new SnakeSegment(line, column);
        }
    }
}
