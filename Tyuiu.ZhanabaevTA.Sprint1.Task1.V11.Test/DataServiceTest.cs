using Tyuiu.ZhanabaevTA.Sprint1.Task1.V11.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}