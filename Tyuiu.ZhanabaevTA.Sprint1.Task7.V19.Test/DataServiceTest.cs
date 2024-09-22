using Tyuiu.ZhanabaevTA.Sprint1.Task7.V19.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(-5.159 , res);
        }
    }
}