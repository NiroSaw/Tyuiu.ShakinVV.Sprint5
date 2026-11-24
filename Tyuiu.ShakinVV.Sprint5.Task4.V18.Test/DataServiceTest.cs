using Tyuiu.ShakinVV.Sprint5.Task4.V18.Lib;
using System.IO;

namespace Tyuiu.ShakinVV.Sprint5.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFile.txt");
            File.WriteAllText(path, "5");

            double res = ds.LoadFromDataFile(path);

            double wait = 12.784;

            Assert.AreEqual(wait, res);
        }
    }
}
