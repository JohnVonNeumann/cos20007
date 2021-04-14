using System.Data;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Clock.Test
{
    public class TestClock
    {
        private Clock _clock;

        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void TestClockInitialise()
        {
            string time = _clock.Time;
            Assert.AreEqual("00:00:00", time);
        }

        [Test]
        public void TestTickIncrementsSeconds()
        {
           _clock.Tick();
           Assert.AreEqual("00:00:01", _clock.Time);
        }

        [Test]
        public void TestTickIncrementsMinutes()
        {
            for (int i = 0; i < 60; i++)
            {
                _clock.Tick();
            }
            Assert.AreEqual("00:01:00", _clock.Time);
        }

        [Test]
        public void TestTickIncrementsHours()
        {
            for (int i = 0; i < 3600; i++)
            {
                _clock.Tick();
            }
            Assert.AreEqual("01:00:00", _clock.Time);
        }

        [Test]
        public void TestTickIncrementOutOfHoursThrowsException()
        {
            for (int i = 0; i < 86399; i++)
            {
                _clock.Tick();
            }

            Assert.Throws<InvalidExpressionException>(_clock.Tick);
        }

        [Test]
        public void TestResetClockToZero()
        {
            for (int i = 0; i < 2156; i++)
            {
                _clock.Tick();
            }
            _clock.Reset();
            Assert.AreEqual("00:00:00", _clock.Time);
        }

        [Test]
        public void TestTimeReturnsString()
        {
            Assert.IsInstanceOf<string>(_clock.Time);
        }

        [Test]
        public void TestTimeStringFormatCorrect()
        {
            Regex regex = new Regex("^([0-2][0-3]|[0-1][0-9]):[0-5][0-9]:[0-5][0-9]+$");
            Assert.True(regex.IsMatch(_clock.Time));
        }
    }
}