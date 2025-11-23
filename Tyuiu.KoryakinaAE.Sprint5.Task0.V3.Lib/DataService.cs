using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KoryakinaAE.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = -(1.0 / 4) * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);
            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
