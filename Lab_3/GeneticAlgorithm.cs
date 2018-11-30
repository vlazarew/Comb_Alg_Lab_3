using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class GeneticAlgorithm
    {
        private ListOfPoints list_of_points;
        private Color[] colors;
        private int[,] graph;
        private int[] color_array;
        private int min_chromatic;

        private static int count;

        private double crossover_frequency;
        private double mutation_rate;
        //Размер популяции
        private int population_size;
        //Количество поколений
        private int count_of_generations;
        private int parameters_number;

        public int GetMinChromatic()
        {
            min_chromatic = 0;
            for (int i = 0; i < color_array.Length; i++)
            {
                if (min_chromatic < color_array[i])
                {
                    min_chromatic = color_array[i];
                }
            }
            return min_chromatic + 1;
        }

        //Текущая популяция
        private ChildOfPopulation[] population;

        //Конструктор генетического алгоритма
        public GeneticAlgorithm(ListOfPoints _list_of_points, Color[] _colors, int[,] _graph, int[] _color_array,
             int pop_size, int count_of_gen)
        {
            list_of_points = _list_of_points;
            colors = _colors;
            graph = _graph;
            color_array = _color_array;

            count = list_of_points.Count();


            population_size = pop_size;
            count_of_generations = count_of_gen;

            population = new ChildOfPopulation[population_size];
        }

        public void RunGeneticSolution()
        {
            //Инициализация первой популяции
            Initialization();
            //Оценка приспособленности каждого из набора в популяции

            int s = 1;
        }

        //Формирование исходной популяции ( Набор из нескольких вариантов раскраски )
        private void Initialization()
        {
            Random random = new Random();
            for (int i = 0; i < population_size; i++)
            {
                //population[i] = new ChildOfPopulation[count];
                int[] temp = new int[count];
                for (int j = 0; j < count; j++)
                {
                    temp[j] = random.Next(1, 12);
                }
                population[i] = new ChildOfPopulation(temp, graph);
            }
        }

        // Оценка приспособленности ( пригодности )
        private int FindSuitability()
        {
            int result = 0;

            for (int i = 0; i < population.Length; i++)
            {

            }


            return result;
        }
    }
}
