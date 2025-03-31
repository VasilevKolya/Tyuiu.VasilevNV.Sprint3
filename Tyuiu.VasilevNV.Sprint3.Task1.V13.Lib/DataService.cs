using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            if (startValue <= 0)
                throw new ArgumentException("Начальное значение должно быть положительным");

            if (Math.Abs(value) < double.Epsilon)
                throw new ArgumentException("Значение value не может быть нулевым");

            double product = 1.0;

            int k = startValue;
            while (k <= stopValue)
            {

                double term = Math.Pow(value / k, 3);

                if (Math.Abs(product) < 1e-100 && term != 0)
                {
                    double logProduct = Math.Log10(product) + 3 * Math.Log10(value / k);
                    product = Math.Pow(10, logProduct);
                }
                else
                {
                    product *= term;
                }

                k++;
            }

            return product;
        }
    }
}
        