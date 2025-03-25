using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TimeIntervalLibrary.Tests
{
    [TestClass]
    public class TimeIntervalTests
    {
        [TestMethod]
        public void CreatesTimeInterval()
        {
            var interval = new TimeInterval(1, 30, 0);
            Assert.AreEqual("01:30:00", interval.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsArgumentException()
        {
            var interval = new TimeInterval(-1, 0, 0);
        }

        [TestMethod]
        public void AddIntervalCorrectly()
        {
            var interval1 = new TimeInterval(1, 30, 0);
            var interval2 = new TimeInterval(0, 45, 0);
            interval1.Add(interval2);
            Assert.AreEqual("02:15:00", interval1.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowsArgumentNullException()
        {
            var interval = new TimeInterval(1, 0, 0);
            interval.Add(null);
        }

        [TestMethod]
        public void ValidInterval()
        {
            var interval1 = new TimeInterval(2, 0, 0);
            var interval2 = new TimeInterval(0, 30, 0);
            interval1.Subtract(interval2);
            Assert.AreEqual("01:30:00", interval1.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullInterval()
        {
            var interval = new TimeInterval(1, 0, 0);
            interval.Subtract(null);
        }

        [TestMethod]
        public void TotalSeconds()
        {
            var interval = new TimeInterval(0, 1, 30); // 1 минута 30 секунд
            Assert.AreEqual(90, interval.TotalSeconds());
        }

        [TestMethod]
        public void TotalMinutes()
        {
            var interval = new TimeInterval(0, 2, 0); // 2 минуты
            Assert.AreEqual(2, interval.TotalMinutes());
        }

        [TestMethod]
        public void TotalHours()
        {
            var interval = new TimeInterval(1, 0, 0); // 1 час
            Assert.AreEqual(1, interval.TotalHours());
        }
    }
}
