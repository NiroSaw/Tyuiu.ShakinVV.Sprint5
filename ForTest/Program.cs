using System.IO;
using System.Text;

namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
            string newContent = "";
            foreach (char c in content)
            {
                if (!char.IsUpper(c))
                {
                    newContent += c;
                }
            }
            File.WriteAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt", newContent);
            Console.WriteLine(String.Join("\n", newContent));
            Console.ReadKey();
        }
    }
}
