using System.IO;
using Tyuiu.KoryakinaAE.Sprint5.Task0.V3.Lib;

namespace Tyuiu.KoryakinaAE.Sprint5.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\korya\source\repos\Tyuiu.KoryakinaAE.Sprint5\Tyuiu.KoryakinaAE.Sprint5.Task0.V3\bin\Debug\net8.0\OutPutFileTask0.txt";
            bool result = File.Exists(path);
            Assert.AreEqual(true, result);
        }
    }
}
