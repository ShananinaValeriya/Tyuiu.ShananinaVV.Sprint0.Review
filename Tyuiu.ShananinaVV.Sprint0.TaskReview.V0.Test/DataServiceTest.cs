using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ShananinaVV.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int a = 10;
            int b = 5;
            int c = 12;

            int res = DataService.Calc(a, b, c);

            Assert.AreEqual(135, res);
        }
    }
}
