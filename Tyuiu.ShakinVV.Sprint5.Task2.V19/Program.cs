using Tyuiu.ShakinVV.Sprint5.Task2.V19.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length / r;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана функция, F(x) = (2x-3)/(cos(x)+x)+5 (произвести табулирование) f(x)*");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1. Произвести проверку деления на  *");
            Console.WriteLine("* 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на*");
            Console.WriteLine("* консоль в таблицу. Значения округлить до двух знаков после запятой.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Массив:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(matrix);
            Console.WriteLine($"Файл сохранён: {path}");

            Console.ReadKey();
        }
    }
}
