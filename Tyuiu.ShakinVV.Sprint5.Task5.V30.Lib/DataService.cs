using System;
using System.IO;
using System.Globalization;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShakinVV.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            int maxPrime = -1;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Replace(',', '.').Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string part in parts)
                    {
                        if (double.TryParse(part, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                        {
                            if (Math.Round(num, 3) == Math.Round(num))
                            {
                                int intNum = (int)num;


                                if (IsPrime(intNum) && intNum > maxPrime)
                                {
                                    maxPrime = intNum;
                                }
                            }
                        }
                    }
                }
            }

            return maxPrime == -1 ? 0 : maxPrime;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}