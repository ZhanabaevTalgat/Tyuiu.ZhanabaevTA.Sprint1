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

            string value = "����� ������ � �����";
            var res = ds.CheckSymmetricalWords(value);
            Assert.AreEqual("�����, �����", res);
        }
    }
}