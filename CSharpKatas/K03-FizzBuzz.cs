﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharpKatas
{
    public class K03FizzBuzz
    {
        public string MapNumber(int i)
        {
            var divisibleByThree = i % 3 == 0;
            var divisibleByFive = i % 5 == 0;

            if (divisibleByThree && divisibleByFive) return "Fizz Buzz";
            if (divisibleByThree) return "Fizz";
            if (divisibleByFive) return "Buzz";

            return i.ToString();
        }

        public IEnumerable<string> DoFizzBuzzUpTo(int n)
        {
            return Enumerable.Range(1, n).Select(MapNumber);
        }
    }

    [TestFixture]
    public class FizzBuzz
    {
        [Test]
        public void MapNumber_DivideByThree_Fizz()
        {
            var fizzBuzz = new K03FizzBuzz();
            Assert.AreEqual("Fizz", fizzBuzz.MapNumber(3));
        }

        [Test]
        public void MapNumber_DivideByFive_Fizz()
        {
            var fizzBuzz = new K03FizzBuzz();
            Assert.AreEqual("Buzz", fizzBuzz.MapNumber(5));
        }

        [Test]
        public void MapNumber_DivideByThreeAndFive_FizzBuzz()
        {
            var fizzBuzz = new K03FizzBuzz();
            Assert.AreEqual("Fizz Buzz", fizzBuzz.MapNumber(15));
        }

        [Test]
        public void MapNumber_DivideByNeitherThreeNorFive_Number()
        {
            var fizzBuzz = new K03FizzBuzz();
            Assert.AreEqual("2", fizzBuzz.MapNumber(2));
        }

        [Test]
        public void DoFizzBuzzUpTo()
        {
            var actual = new K03FizzBuzz().DoFizzBuzzUpTo(36).ToList();
            var expeted = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "Fizz Buzz", "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "Fizz Buzz", "31", "32", "Fizz", "34", "Buzz", "Fizz" };
            Assert.AreEqual(actual.Count(), expeted.Length);
        }
    }
}
