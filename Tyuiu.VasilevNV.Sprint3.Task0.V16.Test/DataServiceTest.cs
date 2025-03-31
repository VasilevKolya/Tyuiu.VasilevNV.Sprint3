using Tyuiu.VasilevNV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 6;
            double wait = 10220.275;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(wait,res);
        }
    }
}