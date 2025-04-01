using Tyuiu.VasilevNV.Sprint3.Task6.V15.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 15;

            int res = ds.GetSumTheDivisors(startValue,stopValue);

            int wait = 120;
            Assert.AreEqual(wait, res);
        }
    }
}