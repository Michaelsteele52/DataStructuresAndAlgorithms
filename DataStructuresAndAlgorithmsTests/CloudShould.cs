using System;
using System.Collections.Generic;
using System.Text;
using DataStructuresAnd_Algorithms;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DataStructuresAndAlgorithmsTests
{
    [TestFixture()]
    public class CloudShould
    {
        private Cloud _cloud;
        [SetUp]
        public void SetUp()
        {
            _cloud = new Cloud();
        }
        [TestCase(3)]
        public void AmountOfJumpsV1(int expected)
        {
            _cloud.Pairs(new[] {0, 1, 0, 0, 0, 1, 0}).Count.Should().Be(expected);
        }
        [TestCase(3)]
        public void AmountOfJumpsV2(int expected)
        {
            _cloud.Pairs(new[] { 0, 0, 1, 0, 0, 0, 1 }).Count.Should().Be(expected);
        }
        [TestCase(3)]
        public void AmountOfJumpsV3(int expected)
        {
            _cloud.Pairs(new[] { 0, 1, 0, 1, 0, 0, 0 }).Count.Should().Be(expected);
        }
        [TestCase(3)]
        public void AmountOfJumpsV4(int expected)
        {
            _cloud.Pairs(new[] { 0, 1, 0, 0, 0, 0, 1}).Count.Should().Be(expected);
        }
        [TestCase(3)]
        public void AmountOfJumpsV5(int expected)
        {
            _cloud.Pairs(new[] { 0, 0, 0, 0, 1, 0, 1 }).Count.Should().Be(expected);
        }
        [TestCase(3)]
        public void AmountOfJumpsV6(int expected)
        {
            _cloud.Pairs(new[] { 0, 0, 0, 0, 0, 0, 0 }).Count.Should().Be(expected);
        }

        [Test]
        public void TestyTest()
        {
            var result = _cloud.Pairs(new[] { 0, 1, 0, 0, 0, 1, 0 });
        }
    }
}
