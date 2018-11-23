using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        const int radius = 15;

        public struct MouseCoordinates
        {
            int MouseX;
            int MouseY;
        }

        enum Colors
        {
            clGreen, clRed, clPurple, clBlue, clYellow, clAqua,
            clMaroon, clOlive, clNavy, clTeal, clFuchsia, clLime
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Раскраска графа.\nПолный перебор и генетический алгоритм.", "Условие");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(bmp);
            Brush b = new SolidBrush(Color.Black);
            g.FillPie(b, new Rectangle(0, 0, 200, 200), -90, 90);
            g.FillPolygon(b, new PointF[] { new PointF(100, 100), new PointF(200, 100), new PointF(100, 200) });
            pictureBoxGraph.Image = bmp;
        }

        private void pictureBoxGraph_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics graphics = pictureBoxGraph.CreateGraphics();
            int captionHeight = SystemInformation.CaptionHeight;
            Size borderSize = SystemInformation.BorderSize;
            int X = MousePosition.X - this.Location.X - 2 * borderSize.Width - pictureBoxGraph.Location.X; // Позиция мыши на экране - Позиция главной формы на экране - Позиция picturebox на главной форме - 2 границы главной формы
            int Y = MousePosition.Y - this.Location.Y - captionHeight - pictureBoxGraph.Location.Y; // шапка формы потому что
            if (e.Button == MouseButtons.Left)
            {
                Pen blackPen = new Pen(Color.Black, 3);
                graphics.DrawEllipse(blackPen, X - radius, Y - radius, radius, radius);
                graphics.FillEllipse(Brushes.Black, X - radius, Y - radius, radius, radius);
            }
            if (e.Button == MouseButtons.Right)
            {
                Pen redPen = new Pen(Color.Red, 3);
                graphics.DrawEllipse(redPen, X - radius, Y - radius, radius, radius);
            }
        }

        /*public MouseCoordinates TakeCoordinates()
        {
            int X = MousePosition.X - this.Location.X - 2 * borderSize.Height - 2 * borderSize.Width;
            int Y = MousePosition.Y - this.Location.Y - captionHeight; // шапка формы потому что
            MouseCoordinates result = new MouseCoordinates(X, Y);
            return result;
        }

        public bool HasPoint(int x, int y)
        {
            bool result = ;
        }*/
    }
}
