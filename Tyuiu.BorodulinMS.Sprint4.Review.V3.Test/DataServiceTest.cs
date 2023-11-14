using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint4.Review.V3.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Review.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string value = "27182818";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
