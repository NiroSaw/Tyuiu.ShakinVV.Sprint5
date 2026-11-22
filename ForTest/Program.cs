namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "OutPutFileTask0.txt";
            double x2 = -1;
            double result2 = 2 * Math.Pow(x2, 3) + 5 * Math.Pow(x2, 2) - 3 * x2 + 1;
            File.AppendAllText(outputFile, result2.ToString());
            Console.ReadKey();

        }
    }
}
