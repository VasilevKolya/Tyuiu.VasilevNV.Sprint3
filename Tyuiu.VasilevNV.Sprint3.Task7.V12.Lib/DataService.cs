using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task7.V12.Lib
{
    public class DataService : ISprint3Task7V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            int size = stopValue - startValue + 1;
            double[] results = new double[size];

            for (int i = 0; i < size; i++)
            {
                double x = startValue + i;
                results[i] = CalculateFunctionValue(x);
            }

            return results;
        }

        private double CalculateFunctionValue(double x)
        {
            try
            {
                double denominator = 3 * x + 0.5;
                if (Math.Abs(denominator) < double.Epsilon)
                    return 0;

                double term1 = Math.Sin(x);
                double term2 = 2 / denominator;
                double term3 = 2 * Math.Cos(x) * 2 * x;

                double result = term1 + term2 - term3;
                return Math.Round(result, 2);
            }
            catch
            {
                return 0;
            }
        }
    }
}