using Tyuiu.ZhanabaevTA.Sprint1.Task4.V5.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.25, res);
        }
    }
}