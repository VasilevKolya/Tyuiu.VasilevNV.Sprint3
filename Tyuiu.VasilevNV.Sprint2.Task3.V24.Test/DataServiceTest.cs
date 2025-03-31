using Tyuiu.VasilevNV.Sprint2.Task3.V24.Lib;
namespace Tyuiu.VasilevNV.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string input = "gft hggt ntg";
            char oldChar = 'g';
            char newChar = '*';

            
            string res = ds.ReplaceCharInString(input, oldChar, newChar);

            Assert.AreEqual("*ft h**t nt*", res);
        }
    }
}