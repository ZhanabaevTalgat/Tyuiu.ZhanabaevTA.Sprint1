using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhanabaevTA.Sprint1.Task0.V13.Lib;

namespace Tyuiu.Zhanabaevta.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}