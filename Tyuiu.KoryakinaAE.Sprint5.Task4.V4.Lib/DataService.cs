using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KoryakinaAE.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
            double strxd = Convert.ToDouble(strx);
            double result = Math.Round(((0.25*strxd)/(Math.Cos(strxd))), 3);
            return result;
        }
    }
}
