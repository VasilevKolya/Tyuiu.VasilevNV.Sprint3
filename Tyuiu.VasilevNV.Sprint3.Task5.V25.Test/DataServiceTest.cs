using Tyuiu.VasilevNV.Sprint3.Task5.V25.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
                int stopValue1 = 5;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue2, stopValue1, stopValue2);
            double wait = 258.2491;
            Assert.AreEqual(wait,res);
        }
    }
}