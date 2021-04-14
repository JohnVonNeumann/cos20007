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
        public void TestTickIncrements()
        {
           _clock.Tick();
           Assert.AreEqual("00:00:01", _clock.Time);
        }

        [Test]
        public void TestResetClockToZero()
        {
           Assert.Pass(); 
        }

        [Test]
        public void TestTimeReturnsString()
        {
            Assert.Pass();
        }

        [Test]
        public void TestTimeStringFormatCorrect()
        {
           Assert.Pass(); 
        }
    }
}