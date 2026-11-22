using Tyuiu.ShakinVV.Sprint5.Task1.V13.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"start Value = {startValue}");
            Console.WriteLine($"stop Value = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nТаблица значений:");
            Console.WriteLine("-----------------");
            Console.WriteLine("|   x   |   y   |");
            Console.WriteLine("-----------------");

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                double y = (denominator == 0) ? 0 : (2.0 * x - 3) / denominator + 5;
                y = Math.Round(y, 2);

                // Форматируем строку: {-5, 3} значит выровнять по правому краю, 3 символа
                Console.WriteLine($"| {x,3}   | {y,5} |");
            }
            Console.WriteLine("-----------------");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл сохранён: {path}");

            Console.ReadKey();
        }
    }
}
