using System.Net.Http.Headers;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.VasilevNV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;


            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            if (startValue <= 0)
                throw new ArgumentException("Начальное значение должно быть положительным");


            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow((double)value / k, 3);
                product *= term;
            }

            return Math.Round(product, 3);
        }
    }
}