using System;
using System.IO;
using Tyuiu.ShakinVV.Sprint5.Task7.V9.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V9.txt в котором есть набор *");
            Console.WriteLine("* символьных данных. Удалить все заглавные латинские буквы из файла.      *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V9.txt.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V9.txt");

            Console.WriteLine($"Путь к исходному файлу: {path}");

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Проверьте, что он лежит в C:\\DataSprint5\\");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string outputPath = ds.LoadDataAndSave(path);

            Console.WriteLine($"Файл сохранён: {outputPath}");

            Console.ReadKey();
        }
    }
}