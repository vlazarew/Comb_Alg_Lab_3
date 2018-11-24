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
        //Поле, в котором мы рисуем
        Graphics graphics;
        //Высота окна главной формы
        int captionHeight;
        //Границы главной формы
        Size borderSize;

        //Список вершин графа
        ListOfPoints list_of_points;

        //Матрица смежности графа
        int[][] Graph;
        enum Set : byte { };
        int[] Array;

        //Цвета, в которые будет краситься граф
        Color[] Colors = new Color[] { Color.Green, Color.Red, Color.Purple, Color.Blue, Color.Yellow, Color.Aqua,
            Color.Maroon, Color.Olive, Color.Navy, Color.Teal, Color.Fuchsia, Color.Lime };

        //Структура, хранящая в себе координаты нашего указателя мыши
        public struct MouseCoordinates
        {
            public int MouseX;
            public int MouseY;
        }

        //Получение координат мыши относительно холста для рисования
        public MouseCoordinates TakeCoordinates()
        {
            MouseCoordinates result;
            result.MouseX = MousePosition.X - this.Location.X - 2 * borderSize.Width - pictureBoxGraph.Location.X; // Позиция мыши на экране - Позиция главной формы на экране - Позиция picturebox на главной форме - 2 границы главной формы
            result.MouseY = MousePosition.Y - this.Location.Y - captionHeight - pictureBoxGraph.Location.Y; // шапка формы потому что
            return result;
        }

        public MainForm()
        {
            InitializeComponent();
            graphics = pictureBoxGraph.CreateGraphics();
            captionHeight = SystemInformation.CaptionHeight;
            borderSize = SystemInformation.BorderSize;
            list_of_points = new ListOfPoints();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Раскраска графа.\nПолный перебор и генетический алгоритм.", "Условие");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGraph_MouseDown(object sender, MouseEventArgs e)
        {
            MouseCoordinates coordinates = TakeCoordinates();
            if (e.Button == MouseButtons.Left)
            {
                MyPoint myPoint = new MyPoint(coordinates.MouseX, coordinates.MouseY, graphics);
                list_of_points.Add(myPoint);
                myPoint.Draw(0);
            }
            if (e.Button == MouseButtons.Right)
            {
                //myPoint.Draw(2);
            }
        }

    }
}
