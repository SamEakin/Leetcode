using NUnit.Framework;
using ReverseNumber;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {}

        [Test]
        public void Test0()
        {
            int input = 0;
            int expected = 0;
            int result = Reverse.Flip(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test1()
        {
            int input = 1;
            int expected = 1;
            int result = Reverse.Flip(input);
            Assert.AreEqual(expected, result);
        }

    }
}