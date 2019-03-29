using System;
using System.Collections.Generic;
using System.Text;
using DataStructuresAnd_Algorithms;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructuresAndAlgorithmsTests
{
    [TestFixture]
    class StackShould
    {
        private Stack _stack;
        [SetUp]
        public void SetUp()
        {
            _stack = new Stack();
            _stack.Push(10);
            _stack.Push(100);
            _stack.Push(1000);
        }

        [Test]
        public void PopAndRemoveValue()
        {
            _stack.Pop().Should().Be(1000);
            _stack.Pop().Should().Be(100);
            _stack.Pop().Should().Be(10);
            _stack.Pop().Should().Be(-1);
        }

        [Test]
        public void PeekWithoutRemovingValue()
        {
            _stack.Peek().Should().Be(1000);
            _stack.Peek().Should().Be(1000);
        }

        [Test]
        public void BeAbleToPushAndThenPop()
        {
            _stack.Push(54);
            _stack.Pop().Should().Be(54);
            _stack.Push(1124);
            _stack.Pop().Should().Be(1124);
            _stack.Peek().Should().Be(1000);
        }
    }
}
