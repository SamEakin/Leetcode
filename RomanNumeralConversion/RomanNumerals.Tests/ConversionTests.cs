using NUnit.Framework;
using RomanNumerals;

namespace Tests
{
    public class ConversionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string input = "I";
            int expected = 1;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            string input = "II";
            int expected = 2;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test3()
        {
            string input = "III";
            int expected = 3;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {
            string input = "IV";
            int expected = 4;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test5()
        {
            string input = "V";
            int expected = 5;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test6()
        {
            string input = "VI";
            int expected = 6;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test7()
        {
            string input = "VII";
            int expected = 7;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test8()
        {
            string input = "VIII";
            int expected = 8;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test9()
        {
            string input = "IX";
            int expected = 9;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test10()
        {
            string input = "X";
            int expected = 10;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test11()
        {
            string input = "XI";
            int expected = 11;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test12()
        {
            string input = "XII";
            int expected = 12;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test13()
        {
            string input = "XIII";
            int expected = 13;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test14()
        {
            string input = "XIV";
            int expected = 14;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test15()
        {
            string input = "XV";
            int expected = 15;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test19()
        {
            string input = "XIX";
            int expected = 19;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test20()
        {
            string input = "XX";
            int expected = 20;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test21()
        {
            string input = "XXI";
            int expected = 21;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test40()
        {
            string input = "XL";
            int expected = 40;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        } 

        [Test]
        public void Test44()
        {
            string input = "XLIV";
            int expected = 44;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test50()
        {
            string input = "L";
            int expected = 50;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }  

        [Test]
        public void Test90()
        {
            string input = "XC";
            int expected = 90;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }  

        [Test]
        public void Test99()
        {
            string input = "XCIX";
            int expected = 99;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }  

        [Test]
        public void Test400()
        {
            string input = "CD";
            int expected = 400;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        } 

        [Test]
        public void Test900()
        {
            string input = "CM";
            int expected = 900;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }  

        [Test]
        public void Test1000()
        {
            string input = "M";
            int expected = 1000;
            Converter convert = new Converter(input);
            var result = convert.RomanToInt();
            Assert.AreEqual(expected, result);
        }                                        
    } ///tests
} ///class