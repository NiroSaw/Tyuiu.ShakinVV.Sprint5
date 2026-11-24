using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShakinVV.Sprint5.Task5.V30.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFile.txt");

            File.WriteAllText(path, "5.5 9 13 4 7 11.0 2.333");

            double res = ds.LoadFromDataFile(path);
            double wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}