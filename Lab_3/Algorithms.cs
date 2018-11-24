using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Algorithms
    {
        /*private ListOfPoints list_of_points;
        private Color[] colors;
        private int[,] graph;
        private HashSet<int> set;
        private int[] temp_array;

        private static int count;

        public int[] GetResultArray()
        {
            return temp_array;
        }

        public Algorithms(ListOfPoints _list_of_points, Color[] _colors, int[,] _graph, HashSet<int> _set, int[] _temp_array)
        {
            list_of_points = _list_of_points;
            colors = _colors;
            graph = _graph;
            set = _set;
            temp_array = _temp_array;
            count = list_of_points.Count();
        }*/


        public static void RunExactSolution(ListOfPoints list_of_points, Color[] colors, int[,] graph, int[] temp_array)
        {
            HashSet<int> result_set = new HashSet<int>();
            int count = list_of_points.Count();
            for (int i = 0; i <= count - 1; i++)
            {
                temp_array[i] = 0;
            }

            for (int i = 0; i <= count - 1; i++)
            {
                result_set.Add(i);
                temp_array[i] = ExactSolution(i, result_set, count, graph, temp_array, colors);
                MyPoint myPoint = list_of_points.GetPoint(i);
                myPoint.Draw(1, colors[temp_array[i]]);
            }

        }

        public static int ExactSolution(int index, HashSet<int> result_set, int count, int[,] graph, int[] temp_array, Color[] colors)
        {
            HashSet<int> ColorSet = new HashSet<int>();
            bool check = false;
            int result = 0;

            for (int j = 0; j <= count - 1; j++)
            {
                if (result_set.Contains(j) && (graph[index, j] == 1))
                {
                    ColorSet.Add(temp_array[j]);
                }
            }

            do
            {
                if (ColorSet.Contains(result))
                {
                    result++;
                    check = false;
                }
                else
                {
                    check = true;
                }
            } while (!check);

            return result;
        }


    }
}
