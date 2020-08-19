using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public class FieldLine : Label
    {
        public FieldLine(int lineNumber)
        {
            AutoSize = true;
            Dock = DockStyle.None;
            Margin = new Padding(0);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location = new Point(0, lineNumber * 12);
            Name = $"label{lineNumber}";
        }
    }
}
