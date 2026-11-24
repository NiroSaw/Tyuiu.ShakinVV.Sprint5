using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
//y = cos(x) + (x^2/2) 

namespace Tyuiu.ShakinVV.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Cos(x) + (Math.Pow(x, 2) / 2), 3);
            return res;
        }
    }
}
