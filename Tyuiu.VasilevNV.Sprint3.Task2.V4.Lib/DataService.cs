using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            if (startValue <= 0)
                throw new ArgumentException("Начальное значение должно быть положительным");

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

            return Math.Round(product,3);
        }
    }
}
        

      