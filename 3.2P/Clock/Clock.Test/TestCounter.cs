using NUnit.Framework;

namespace Clock.Test
{
    public class TestCounter
    {

        private Counter _counter;

        [SetUp]
        public void Setup()
        {
            _counter = new Counter("testCounter");
        }

        [Test]
        public void TestInitialisedCounterIsZero()
        {
            Assert.AreEqual(0, _counter.Ticks);
        }

        [Test]
        public void TestIncrementCounter()
        {
            _counter.Increment();
            Assert.AreEqual(1, _counter.Ticks);
            
        }
    }
}
