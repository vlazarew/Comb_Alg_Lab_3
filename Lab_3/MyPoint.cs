using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class MyPoint
    {
        private const int radius = 15;
        private int X;
        private int Y;
        private bool choose;
        private Graphics graphics;

        public MyPoint(int _x, int _y, Graphics _graphics)
        {
            X = _x;
            Y = _y;
            choose = false;
            graphics = _graphics;
        }

        public void Draw(int status)
        {
            if ((status == 0) || (status == 1))
            {
                Pen blackPen = new Pen(Color.Black, 3);
                graphics.DrawEllipse(blackPen, X - radius, Y - radius, radius, radius);
                graphics.FillEllipse(Brushes.Black, X - radius, Y - radius, radius, radius);
            }
            if (status == 2)
            {
                Pen redPen = new Pen(Color.Red, 3);
                graphics.DrawEllipse(redPen, X - radius, Y - radius, radius, radius);
            }
        }

        public bool HasPoint(int _x, int _y)
        {
            bool result = ((_x >= X - 2 * radius)) && (_x <= (X + 2 * radius)) && (_y >= (Y - 2 * radius)) && (_y <= (Y + 2 * radius));
            return result;
        }

        public bool GetChoose()
        {
            return choose;
        }

        public void SetChoose(bool _choose)
        {
            choose = _choose;
        }
    }
}
