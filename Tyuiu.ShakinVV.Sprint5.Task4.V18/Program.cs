using Tyuiu.ShakinVV.Sprint5.Task4.V18.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V18.txt в котором есть      *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* Х в формуле y = cos(x) + (x^2/2).  Вычислить значение по формуле        *");
            Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой)            *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V18.txt");

            Console.WriteLine($"Путь к файлу: {path}");

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Убедитесь, что он лежит по указанному пути.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Результат: {res}");

            Console.ReadKey();
        }
    }
}
