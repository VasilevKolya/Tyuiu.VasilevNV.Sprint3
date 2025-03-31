using Tyuiu.VasilevNV.Sprint3.Task1.V13.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task1.V13.Test
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

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 57.552;

            Assert.AreEqual(wait,res);
        }
    }
}