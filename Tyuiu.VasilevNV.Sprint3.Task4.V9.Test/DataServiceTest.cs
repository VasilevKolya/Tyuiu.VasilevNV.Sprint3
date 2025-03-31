using Tyuiu.VasilevNV.Sprint3.Task4.V9.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

           double res = ds.Calculate(startValue, stopValue);
                double wait = 0.1241;

            Assert.AreEqual(wait, res);
        }
    }
}