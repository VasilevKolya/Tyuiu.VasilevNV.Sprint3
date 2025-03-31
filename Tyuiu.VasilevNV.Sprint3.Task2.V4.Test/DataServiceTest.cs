using Tyuiu.VasilevNV.Sprint3.Task2.V4.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 56.231;
            Assert.AreEqual(wait,res);
        }
    }
}