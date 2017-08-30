using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverNetExtensionTests
{
    [TestClass]
    public class DateTimeExtensionTests
    {
        [TestMethod]
        public void DateOfDayOfWeekTest()
        {
            //TODO add more conditions
            var mondayDate = DateTime.Now.DateOfDayOfWeek(DayOfWeek.Monday);
            Assert.IsTrue(mondayDate.DayOfWeek == DayOfWeek.Monday);
        }
    }
}
