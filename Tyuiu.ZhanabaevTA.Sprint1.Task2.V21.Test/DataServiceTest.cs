using Tyuiu.ZhanabaevTA.Sprint1.Task2.V21.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 3;
            var res = ds.CalculateRectangleSquare(value, valueTwo);
            Assert.AreEqual(6, res);
        }
    }
}