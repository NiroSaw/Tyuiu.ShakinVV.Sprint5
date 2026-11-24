using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.ShakinVV.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            StringBuilder sb = new StringBuilder();

            foreach (char c in content)
            {

                if (!(c >= 'A' && c <= 'Z'))
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString();


            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V9.txt");


            File.WriteAllText(outputPath, result);


            Console.WriteLine(result);


            return outputPath;
        }
    }
}