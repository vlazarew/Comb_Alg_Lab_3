using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        //Массив с полученными цветами для узлов
        int[] color_array;

        int Count()
        {
            return list_of_points.Count();
        }

        //Цвета, в которые будет краситься граф
        Color[] colors = new Color[] { Color.Green, Color.Red, Color.Purple, Color.Blue, Color.Yellow, Color.Aqua,
            Color.Maroon, Color.Olive, Color.Navy, Color.Teal, Color.Fuchsia, Color.Lime };

        public MainForm()
        {
            InitializeComponent();
            graphics = pictureBoxGraph.CreateGraphics();
            captionHeight = SystemInformation.CaptionHeight;
            borderSize = SystemInformation.BorderSize;
            list_of_points = new ListOfPoints();
            graph = new int[0, 0];
            radius = 10;
            color_array = new int[0];
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Раскраска графа.\nПолный перебор и генетический алгоритм.", "Условие");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (list_of_points.Count() == 0)
            {
                MessageBox.Show(this, "Не указано ни одной вершины графа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread threadExact = new Thread(RunExact);

            //Thread threadGenetic = new Thread(RunExact);

            threadExact.Start();
            //threadGenetic.Start();
        }

        public void RunExact()
        {
            ExactAlgorithm algorithms = new ExactAlgorithm(list_of_points, colors, graph, color_array);
            DateTime start_time = DateTime.Now;
            algorithms.RunExactSolution();
            DateTime finish_time = DateTime.Now;
            textBoxMinChromaticExact.Invoke(new Action(() => { textBoxMinChromaticExact.Text = algorithms.GetMinChromatic().ToString(); }));
            string total_time = Convert.ToString(finish_time.Subtract(start_time).TotalSeconds);
            textBoxTimeExact.Invoke(new Action(() => { textBoxTimeExact.Text = total_time; }));
        }

        public void RunGenetic()
        {
            //ExactAlgorithm algorithms = new ExactAlgorithm(list_of_points, colors, graph, color_array);
            DateTime start_time = DateTime.Now;
            //algorithms.RunExactSolution();
            DateTime finish_time = DateTime.Now;
            //textBoxMinChromaticGenetic.Invoke(new Action(() => { textBoxMinChromaticGenetic.Text = algorithms.GetMinChromatic().ToString(); }));
            string total_time = Convert.ToString(finish_time.Subtract(start_time).TotalSeconds);
            textBoxTimeGenetic.Invoke(new Action(() => { textBoxTimeGenetic.Text = total_time; }));
        }

        private void pictureBoxGraph_MouseDown(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            //Правая кнопка мыши - создание точки
            if (e.Button == MouseButtons.Right)
            {
                MyPoint myPoint = new MyPoint(location.X, location.Y, graphics, radius);
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
                        graph = result;

                        int[] temp_result = new int[count];
                        for (int i = 0; i < count - 2; i++)
                        {
                            temp_result[i] = color_array[i];
                        }
                        color_array = temp_result;

                    }
                    else
                    {
                        color_array = new int[1];
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
                if (list_of_points.Cross(location.X, location.Y))
                {
                    int i = list_of_points.IndexOfPoint(location.X, location.Y);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxGraph.Image = null;
            list_of_points = new ListOfPoints();
            graph = new int[0, 0];
            color_array = new int[0];
            textBoxMinChromaticExact.Clear();
            textBoxMinChromaticGenetic.Clear();
            textBoxStepsExact.Clear();
            textBoxStepsGenetic.Clear();
            textBoxTimeExact.Clear();
            textBoxTimeGenetic.Clear();
        }
    }
}
