using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        const int _lineCount = 40;
        const int _colunmCount = 40;

        private readonly Field _field;

        private List<Label> _lineControls;

        private System.Timers.Timer _timer;

        public Form1()
        {
            InitializeComponent();

            FillControls();

            _field = new Field(_lineCount, _colunmCount);

            StartGame();
        }

        private void FillControls()
        {
            _lineControls = new List<Label>();

            for (int i = 0; i < _lineCount; i++)
            {
                _lineControls.Add(GetNewLabel(i));
            }

            panel.Controls.AddRange(_lineControls.ToArray());

            
        }

        private void StartGame()
        {
            _timer = new System.Timers.Timer
            {
                Interval = 250,
                SynchronizingObject = this,
                AutoReset = true,
                Enabled = true
            };

            _timer.Elapsed += (sender, e) => UpdateField();
        }

        private void PauseGame()
        {
            _timer.Stop();
            _timer.Dispose();
        }

        private void UpdateField()
        {
            try
            {
                _field.MoveSnack();

                ShowField();
            }
            catch(Exception ex)
            {
                 gameOverLabel.Visible = true;
            }

        }

        private void ShowField()
        {
            foreach (var item in _field.FieldCaracters.Select((line, index) => new { index, line }))
            {
                _lineControls.ElementAt(item.index).Text = item.line;
            }

            
        }
       
        private Label GetNewLabel(int lineNumber)
        {
            return new Label
            {
                AutoSize = true,
                Dock = DockStyle.None,
                Margin = new Padding(0),
                Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(0, lineNumber * 12),
                Name = $"label{lineNumber}",
            };
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _field.MovingDirection(Direction.Up);
                    break;
                case Keys.Down:
                    _field.MovingDirection(Direction.Down);
                    break;
                case Keys.Left:
                    _field.MovingDirection(Direction.Left);
                    break;
                case Keys.Right:
                    _field.MovingDirection(Direction.Right);
                    break;
            }
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
