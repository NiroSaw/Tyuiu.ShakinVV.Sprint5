using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShakinVV.Sprint5.Task6.V18.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFile.txt");

            File.WriteAllText(path, "a 1 b 23 c 4 d 56 e 7");

            int res = ds.LoadFromDataFile(path);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}