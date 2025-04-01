using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VasilevNV.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("Начальное значение не может быть больше конечного");

            if (startValue <= 0)
                throw new ArgumentException("Диапазон должен содержать только положительные числа");

            int totalSum = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                totalSum += GetDivisorsSum(num);
            }

            return totalSum;
        }
            private int GetDivisorsSum(int number)
            {
                if (number == 1) return 1;

                int sum = 1 + number; 

                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                return sum;
            }
        }
    }