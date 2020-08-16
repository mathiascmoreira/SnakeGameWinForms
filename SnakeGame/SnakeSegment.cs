using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class SnakeSegment
    {
        public SnakeSegment(int line, int colunm)
        {
            Line = line;
            Colunm = colunm;
            PreviousLine = line;
            PreviousColunm = colunm;
        }

        private SnakeSegment previousSegment { get; set; }

        public int Line { get; set; }
        public int Colunm { get; set; }
        public int PreviousLine { get; set; }
        public int PreviousColunm { get; set; }
        //public void UpdatePosition(int line, colunm)
        //{

        //}




    }
}
