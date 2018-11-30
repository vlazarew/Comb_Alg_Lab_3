using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class ChildOfPopulation
    {
        private int[] color_array;
        private int[,] graph;
        private int valid;

        private Random random = new Random();

        public ChildOfPopulation(int[] _color_array, int[,] _graph)
        {
            color_array = _color_array;
            graph = _graph;
        }

        public int FindSuitability()
        {
            bool CanBe = true;
            List<int> colors = new List<int>();
            int count_of_colors = 0;

            for (int i = 0; i < color_array.Length && CanBe; i++)
            {
                if (colors.Contains(color_array[i]))
                {
                    int[] source = color_array;
                    int[] temp;
                    do
                    {
                        int index = colors.IndexOf(source[i]);
                        temp = new int[source.Length - index];
                        Array.Copy(source, index, temp, 0, temp.Length);
                        if (graph[i, index] == 1)
                        {
                            CanBe = false;
                            return valid = 100;
                        }
                        source = temp;
                    } while (temp.Contains(color_array[i]));

                }
            }


            return valid;
        }
    }
}
