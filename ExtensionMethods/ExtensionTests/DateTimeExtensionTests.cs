using System;
using ExtensionMethods.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionTests
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
