using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShakinVV.Sprint5.Task7.V9.Lib;

namespace Tyuiu.ShakinVV.Sprint5.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

 
            string inputPath = Path.Combine(Path.GetTempPath(), "TestInput.txt");


            File.WriteAllText(inputPath, "Hello World! ПРИВЕТ");

            string outputPath = ds.LoadDataAndSave(inputPath);


            FileInfo fileInfo = new FileInfo(outputPath);
            Assert.IsTrue(fileInfo.Exists);

            string resultContent = File.ReadAllText(outputPath);
            Assert.AreEqual("ello orld! ПРИВЕТ", resultContent);
        }
    }
}