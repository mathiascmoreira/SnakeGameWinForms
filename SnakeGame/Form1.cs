using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        const char filledSquare = '◼';
        const char emptySquare = '◻';

        private readonly string line;
        private readonly Label[] lines;

        private readonly Snake snake;

        private Direction currentDirection;




        public Form1()
        {
            const int lineCount = 40;
            const int colunmCount = 40;

            currentDirection = Direction.Right;

            snake = new Snake();

            var builder = new StringBuilder();
            line = builder.Append(emptySquare, colunmCount).ToString();

            InitializeComponent();

            lines = LoadLines(lineCount, colunmCount);

            StartTimer();

            
        }

        private void StartTimer()
        {
            var timer = new System.Timers.Timer();
            timer.Interval = 1000;

            timer.SynchronizingObject = this;

            timer.Elapsed += OnTimedEvent;

            timer.AutoReset = true;

            timer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            UpdateField();
        }

        private Label[] LoadLines(int lineCount, int colunmCount)
        {
            var lines = new Label[lineCount];

            for (int i = 0; i < lineCount; i++)
            {
                var line = GetNewLine(i);
                line.Text = this.line;

                lines[i] = line;
                gameField.Controls.Add(line);

            }

            return lines;
        }

        private void UpdateField()
        {
            snake.Move(currentDirection);

            foreach (var segment in snake.Segments)
            {
                var newLine = lines[segment.Line];
                var previousLine = lines[segment.PreviousLine];

                newLine.Text = newLine.Text.Remove(segment.Colunm, 1).Insert(segment.Colunm, filledSquare+"");
                previousLine.Text = previousLine.Text.Remove(segment.PreviousColunm, 1).Insert(segment.PreviousColunm, emptySquare+"");
            }
        }

        private Label GetNewLine(int lineNumber)
        {
            var newLine = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(0, lineNumber*12),
                Name = $"label{lineNumber}",

            };

            return newLine;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    currentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    currentDirection = Direction.Down;
                    break;
                case Keys.Left:
                    currentDirection = Direction.Left;
                    break;
                case Keys.Right:
                    currentDirection = Direction.Right;
                    break;
            }
        }
    }


}
