using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Linq;

namespace Tyuiu.ShakinVV.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {

            string content = File.ReadAllText(path);

            int count = 0;

            for (int i = 0; i < content.Length; i++)
            {

                if (char.IsDigit(content[i]))
                {

                    bool leftIsNotDigit = (i == 0) || !char.IsDigit(content[i - 1]);

                    bool rightIsNotDigit = (i == content.Length - 1) || !char.IsDigit(content[i + 1]);

                    if (leftIsNotDigit && rightIsNotDigit)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}