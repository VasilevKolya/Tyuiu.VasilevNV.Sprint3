using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.VasilevNV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i < stopValue; i++)
            {
                sumSeries *= Math.Pow((double)value / i, 3);
            }

            return Math.Round(sumSeries, 6);
        }
    }
}
