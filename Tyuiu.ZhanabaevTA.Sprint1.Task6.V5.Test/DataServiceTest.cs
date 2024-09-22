using Tyuiu.ZhanabaevTA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();

            string value = "Казак пришел в шалаш";
            var res = ds.CheckSymmetricalWords(value);
            Assert.AreEqual("Казак, шалаш", res);
        }
    }
}