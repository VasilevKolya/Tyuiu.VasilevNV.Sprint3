using Tyuiu.VasilevNV.Sprint3.Task3.V24.Lib;
using System.Net.NetworkInformation;

namespace Tyuiu.VasilevNV.Sprint3.Task3.V24.Test
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
