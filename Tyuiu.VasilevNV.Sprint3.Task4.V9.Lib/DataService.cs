using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    continue;

                double denominator = Math.Cos(x) - x;

                if (Math.Abs(denominator) < double.Epsilon)
                    throw new DivideByZeroException($"Знаменатель равен нулю при x = {x}");

                double y = x / denominator;
                product *= y;
            }

            return Math.Round(product,3);
        }
    }
}