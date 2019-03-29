using System;
using System.Collections.Generic;
using System.Text;
using DataStructuresAnd_Algorithms;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructuresAndAlgorithmsTests
{
    [TestFixture]
    class QueueShould
    {
        private Queue _queue;
        [SetUp]
        public void SetUp()
        {
            _queue = new Queue();
        }
        [Test]
        public void DequeueWhenEmpty()
        {
            _queue.Dequeue().Should().Be(-1);
        }
        [Test]
        public void DequeueOnce()
        {
            _queue.Enqueue(10);
            _queue.Dequeue().Should().Be(10);
        }
        [Test]
        public void DequeueTwice()
        {
            _queue.Enqueue(10);
            _queue.Enqueue(100);
            _queue.Dequeue().Should().Be(10);
            _queue.Dequeue().Should().Be(100);
        }
        [Test]
        public void DequeueThrice()
        {
            _queue.Enqueue(10);
            _queue.Enqueue(100);
            _queue.Enqueue(1000);
            _queue.Dequeue().Should().Be(10);
            _queue.Dequeue().Should().Be(100);
            _queue.Dequeue().Should().Be(1000);
        }
    }
}
