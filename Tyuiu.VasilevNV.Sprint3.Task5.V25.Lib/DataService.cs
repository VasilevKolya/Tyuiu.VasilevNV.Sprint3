using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            if (startValue1 > stopValue1 || startValue2 > stopValue2)
                throw new ArgumentException("Начальные значения не могут быть больше конечных");

            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    totalSum += Math.Pow(x, k) + Math.Cos(k);
                }
            }

            return totalSum;
        }
    }
}
        }
    }
}
