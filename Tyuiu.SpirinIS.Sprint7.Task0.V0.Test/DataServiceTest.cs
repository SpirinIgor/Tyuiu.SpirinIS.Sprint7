using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SpirinIS.Sprint7.Task0.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint7.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCulc()
        {
            DataService ds = new DataService();
            int a = 5;
            int b = 6;

            var res = ds.Culc(a,b);
            Assert.AreEqual(11, res);
        }
    }
}
