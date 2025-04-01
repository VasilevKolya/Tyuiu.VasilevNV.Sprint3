using Tyuiu.VasilevNV.Sprint3.Task7.V12.Lib;
namespace Tyuiu.VasilevNV.Sprint3.Task7.V12.Test
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
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -0.96;
            valueWaitArray[1] = -1.23;
            valueWaitArray[2] = -0.89;
            valueWaitArray[3] = 0.91;
            valueWaitArray[4] = 3.09;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = -3.09;
            valueWaitArray[7] = -0.91;
            valueWaitArray[8] = 0.89;
            valueWaitArray[9] = 1.23;
            valueWaitArray[10] = 0.96;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}