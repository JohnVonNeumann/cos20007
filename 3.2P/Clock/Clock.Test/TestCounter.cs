using System;
using System.Xml;
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
            int previousValue = _counter.Ticks;
            int newValue = previousValue + 1;
            _counter.Increment();
            Assert.AreEqual(newValue, _counter.Ticks);
            
        }

        [Test]
        public void TestMultipleIncrement()
        {
            int previousValue = _counter.Ticks;
            int newValue = previousValue + 3;
            for (int i = 0; i < newValue; i++)
            {
                _counter.Increment();
                
            }
            Assert.AreEqual(newValue, _counter.Ticks);
        }

        [Test]
        public void TestCounterReset()
        {
            _counter.Increment();
            _counter.Reset();
            Assert.AreEqual(0, _counter.Ticks);
        }
    }
}
