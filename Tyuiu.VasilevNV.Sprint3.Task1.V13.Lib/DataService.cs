using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue = 1, int stopValue = 7)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного", nameof(startValue));

            if (startValue <= 0)
                throw new ArgumentException("Начальное значение должно быть положительным", nameof(startValue));

            if (Math.Abs(value) < double.Epsilon)
                throw new ArgumentException("Значение value не может быть нулевым", nameof(value));

            double product = 1.0;
            int k = startValue;

           
            while (k <= stopValue)
            {
             
                product *= Math.Pow(value, k);

                k++;
            }

            return Math.Round(product,3);
        }
    }
}