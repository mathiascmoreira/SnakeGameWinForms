using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class GameScreen : Form
    {
        const int LINE_COUNT = 40;
        const int COLUMN_COUNT = 40;

        private readonly Field _field;
        private readonly Snake _snake;
        private readonly System.Timers.Timer _timer;

        public GameScreen()
        {
            InitializeComponent();

            _field = new Field(LINE_COUNT, COLUMN_COUNT);
            _snake = new Snake(LINE_COUNT, COLUMN_COUNT);
            _timer = GetNewTimer();

            Controls.Add(_field);

            StartGame();
        }

        private System.Timers.Timer GetNewTimer()
        {
            var timer = new System.Timers.Timer
            {
                Interval = 250,
                SynchronizingObject = this,
                AutoReset = true,
                Enabled = true
            };

            timer.Elapsed += (sender, e) => UpdateSnakePosition();

            return timer;
        }

        private void StartGame()
        {
            _field.Initialize();
            _snake.Initialize();
            _timer.Start();

            buttonPause.Text = "Pause";
            gameOverMessage.Visible = false;
        }

        private void UpdateSnakePosition()
        {
            try
            {
                _snake.Move();

                _field.ShowSnake(_snake);
            }
            catch (Exception)
            {
                gameOverMessage.Visible = true;
                _timer.Stop();
            }
        }

        private void PauseGame()
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
                buttonPause.Text = "Continue";
            }
            else
            {
                _timer.Start();
                buttonPause.Text = "Pause";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _snake.ChangeMovingDirection(Direction.Up);
                    break;
                case Keys.Down:
                    _snake.ChangeMovingDirection(Direction.Down);
                    break;
                case Keys.Left:
                    _snake.ChangeMovingDirection(Direction.Left);
                    break;
                case Keys.Right:
                    _snake.ChangeMovingDirection(Direction.Right);
                    break;
            }
        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
