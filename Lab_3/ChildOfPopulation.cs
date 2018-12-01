using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class ChildOfPopulation
    {
        //Раскраска
        private int[] color_array;
        //Граф
        private int[,] graph;
        //Значение приспособленности данной раскраски
        private int valid;

        //Шанс попасть в селекцию
        private double chance;

        private bool cancross;

        private Random random = new Random();

        public int Valid
        {
            get { return valid; }
        }

        public int[] Color_Array
        {
            get { return color_array; }
            set { color_array = value; }
        }

        /*public int Color
        {
            get { return color_array[index]; }
            set { color_array[index] = value; }
        }*/

        public double Chance
        {
            get { return chance; }
            set { chance = value; }
        }

        public bool CanCross
        {
            get { return cancross; }
            set { cancross = value; }
        }

        //Конструктор
        public ChildOfPopulation(int[] _color_array, int[,] _graph)
        {
            color_array = _color_array;
            graph = _graph;
            valid = 100;
            CanCross = false;
        }

        //Оценка приспособленности раскраски из популяции
        public void FindSuitability()
        {
            //Возможна ли такая раскраска вообще
            //bool CanBe = true;
            //Список цветов, задействованных в раскраске графа
            List<int> colors = new List<int>();
            valid = 100;

            for (int i = 0; i < color_array.Length/* && CanBe*/; i++)
            {
                //Если такой цвет уже встречался в наборе
                if (colors.Contains(color_array[i]))
                {
                    //int[] source = color_array;
                    int[] source = new int[color_array.Length];
                    Array.Copy(color_array, source, source.Length);
                    int[] temp;
                    //Проверяем, что 2 вершины не покрашены в один цвет
                    // do
                    //{
                    List<int> tmp = new List<int>();
                    foreach (int el in source)
                    {
                        if (tmp.Contains(el))
                        {
                            int index = colors.IndexOf(source[i]);
                            if (index != -1)
                            {
                                //Если все таки это так
                                if (graph[i, index] == 1)
                                {
                                    //То такая раскраска не имеет права на существование
                                    //CanBe = false;
                                    // valid = 0 - не существует
                                    valid = 0;
                                    return;
                                }
                                temp = new int[source.Length - index - 1];
                                Array.Copy(source, index + 1, temp, 0, temp.Length);
                               // source = temp;
                            }
                        }
                        else
                        {
                            tmp.Add(el);
                        }
                    }

                    //                    } while (source.Contains(color_array[i]));
                }
                //Иначе просто добавляем цвет в список
                else
                {
                    colors.Add(color_array[i]);
                    //Чем ближе valid к 100, тем лучше
                    valid -= 2;
                }
            }
        }

    }
}
