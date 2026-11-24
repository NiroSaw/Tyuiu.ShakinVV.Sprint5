using System;
using System.IO;
using Tyuiu.ShakinVV.Sprint5.Task5.V30.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Чтение данных из текстового файла                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V30.txt в котором есть набор*");
            Console.WriteLine("* значений. Найти максимальное целое число в файле, которое является      *");
            Console.WriteLine("* простым числом. Полученный результат вывести на консоль.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V30.txt");

            Console.WriteLine($"Путь к файлу: {path}");

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Проверьте, что он лежит в C:\\DataSprint5\\");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Максимальное простое целое число: {res}");

            Console.ReadKey();
        }
    }
}