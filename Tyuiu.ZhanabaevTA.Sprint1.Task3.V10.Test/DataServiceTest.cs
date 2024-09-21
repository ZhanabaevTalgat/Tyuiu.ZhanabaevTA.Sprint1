using Tyuiu.ZhanabaevTA.Sprint1.Task3.V10.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();
            double a = 23.6;
            var res = ds.NumberToMoney(a);
            Assert.AreEqual(23.60, res);
        }
    }
}