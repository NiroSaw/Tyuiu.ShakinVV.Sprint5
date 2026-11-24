using System;
using System.IO;
using Tyuiu.ShakinVV.Sprint5.Task6.V18.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V18.txt в котором есть набор*");
            Console.WriteLine("* символьных данных. Найти количество одноразрядных чисел в заданной      *");
            Console.WriteLine("* строке.                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V18.txt");
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

            int res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество одноразрядных чисел: {res}");

            Console.ReadKey();
        }
    }
}