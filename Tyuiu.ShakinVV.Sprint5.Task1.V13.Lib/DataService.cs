using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.ShakinVV.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (File.Exists(path)) File.Delete(path);

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                double y = (denominator == 0) ? 0 : (2.0 * x - 3) / denominator + 5;

                y = Math.Round(y, 2);

                if (x == stopValue)
                    File.AppendAllText(path, y.ToString());
                else
                    File.AppendAllText(path, y.ToString() + "\n");
            }

            return path;

        }
    }
}
