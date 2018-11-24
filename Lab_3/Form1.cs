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
        //Радиус узла графа
        int radius;

        //Список вершин графа
        ListOfPoints list_of_points;

        //Матрица смежности графа
        int[,] graph;


        int[] temp_array;

        int Count()
        {
            return list_of_points.Count();
        }

        //Цвета, в которые будет краситься граф
        Color[] colors = new Color[] { Color.Green, Color.Red, Color.Purple, Color.Blue, Color.Yellow, Color.Aqua,
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
            graph = new int[0, 0];
            radius = 10;
            temp_array = new int[0];
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Раскраска графа.\nПолный перебор и генетический алгоритм.", "Условие");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Algorithms.RunExactSolution(list_of_points, colors, graph, temp_array);
        }

        private void pictureBoxGraph_MouseDown(object sender, MouseEventArgs e)
        {
            MouseCoordinates coordinates = TakeCoordinates();
            //Правая кнопка мыши - создание точки
            if (e.Button == MouseButtons.Right)
            {
                MyPoint myPoint = new MyPoint(coordinates.MouseX, coordinates.MouseY, graphics, radius);
                if (!list_of_points.Cross(myPoint.GetX(), myPoint.GetY()))
                {
                    myPoint.Draw(0);
                    list_of_points.Add(myPoint);

                    if (graph.Length > 0)
                    {
                        int count = list_of_points.Count();
                        int[,] result = new int[count, count];
                        for (int i = 0; i < count - 1; i++)
                        {
                            for (int j = 0; j < count - 1; j++)
                            {
                                result[i, j] = graph[i, j];
                            }
                            result[i, count - 1] = 0;
                        }
                       /* for (int i = 0; i < count - 1; i++)
                        {
                            result[i, count - 1] = 0;
                        }*/
                        graph = result;

                        int[] temp_result = new int[count];
                        for (int i = 0; i < count - 2; i++)
                        {
                            temp_result[i] = temp_array[i];
                        }
                        //temp_result[count - 1] = 0;
                        temp_array = temp_result;

                    }
                    else
                    {
                        temp_array = new int[1];
                        graph = new int[1, 1];
                    }
                }
                else
                {
                    int i = list_of_points.IndexOfPoint(myPoint.GetX(), myPoint.GetY());
                    MyPoint temp = list_of_points.GetPoint(i);
                    temp.SetChoose(false);
                    temp.Draw(0);
                }
            }
            //Левая кнопка мыши - выделение узла для установки связи
            if (e.Button == MouseButtons.Left)
            {
                //MyPoint myPoint = new MyPoint(coordinates.MouseX, coordinates.MouseY, graphics, radius);
                //MouseCoordinates coordinates = TakeCoordinates();
                if (list_of_points.Cross(coordinates.MouseX, coordinates.MouseY))
                {
                    int i = list_of_points.IndexOfPoint(coordinates.MouseX, coordinates.MouseY);
                    MyPoint temp = list_of_points.GetPoint(i);
                    temp.SetChoose(true);
                    temp.Draw(0);
                    temp.Draw(2);
                    if (list_of_points.Selected() == 2)
                    {
                        temp.Draw(0);
                        temp.SetChoose(false);
                        int j = list_of_points.GetChoosen();
                        MyPoint temp_point_2 = list_of_points.GetPoint(j);
                        temp_point_2.Draw(0);
                        temp_point_2.SetChoose(false);
                        Pen pen_line = new Pen(Color.Black, 2);
                        graphics.DrawLine(pen_line, temp.GetX(), temp.GetY(), temp_point_2.GetX(), temp_point_2.GetY());
                        graph[i, j] = 1;
                        graph[j, i] = 1;
                    }
                }
            }
        }

        //Покраска графа с помощью массива цветов
        public void DrawColor(int[] temp_array)
        {
            int count = list_of_points.Count();
            for (int i = 0; i < count - 1; i++)
            {
                MyPoint point = list_of_points.GetPoint(i);
                point.Draw(1, Color.Black);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxGraph.Image = null;
            list_of_points = new ListOfPoints();
            graph = new int[0, 0];
            temp_array = new int[0];
        }
    }
}
