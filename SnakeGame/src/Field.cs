using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Field : Panel
    {
        private const char EMPTY_SQUARE = '◻';
        private const char FILLED_SQUARE = '◼';

        private readonly int _lineCount;
        private readonly int _columnCount;

        private readonly List<FieldLine> _lines;

        public Field(int lineCount, int columnCount)
        {
            Location = new Point(12, 41);
            Size = new Size(448, 474);

            _lineCount = lineCount;
            _columnCount = columnCount;
            _lines = new List<FieldLine>();

            SetField();
        }

        private void SetField()
        {
            for (int i = 0; i <= _lineCount - 1; i++)
            {
                _lines.Add(new FieldLine(i));
            }

            Controls.AddRange(_lines.ToArray());
        }

        public void ShowSnake(Snake snake)
        {
            Initialize();

            foreach (var segment in snake.AllSegments)
            {
                PaintSquare(segment);
            }

            PaintSquare(snake.Food);
        }

        private void PaintSquare(SnakeSegment segment)
        {
            var lineControl = _lines.ElementAt(segment.Line);

            lineControl.Text = lineControl.Text.Remove(segment.Column, 1).Insert(segment.Column, $"{FILLED_SQUARE}");
        }

        public void Initialize()
        {
            var lineText = new StringBuilder().Append(EMPTY_SQUARE, _columnCount).ToString();

            _lines.ForEach(line => line.Text = lineText);
        }
    }
}
