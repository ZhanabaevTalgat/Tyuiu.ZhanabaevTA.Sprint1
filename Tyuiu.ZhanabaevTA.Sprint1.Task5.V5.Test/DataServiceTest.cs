using Tyuiu.ZhanabaevTA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int res = ds.Calculate(x);
            Assert.AreEqual(5, res);
        }
    }
}