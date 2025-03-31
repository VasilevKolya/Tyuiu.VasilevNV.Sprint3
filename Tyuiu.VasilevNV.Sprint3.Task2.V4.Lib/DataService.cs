using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sin1 = Math.Sin(1);
            double denominator = Math.Pow(sin1, -7);
            double product = 1.0;
            int k = startValue;

            do
            {
                double term = Math.Pow(k / denominator, -2);
                product *= term;
                k++;
            }
            while (k <= stopValue);

            return product;
        }
    }
}   