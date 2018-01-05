using System.Linq;
using NUnit.Framework;

namespace CSharpKatas
{
    public class Calculator
    {
        public int SumNumbers(int start, int count)
        {
            return Enumerable.Range(start, count).Sum();
        }
    }

    [TestFixture]
    public class Test
    {
        [Test]
        public void SumNumbers_StartAt100SumNext1_TotalIs100()
        {
            var kata = new Calculator();
            Assert.AreEqual(100, kata.SumNumbers(100, 1));
        }

        [Test]
        public void SumNumbers_StartAt100SumNext2_TotalIs201()
        {
            var kata = new Calculator();
            Assert.AreEqual(201, kata.SumNumbers(100, 2));
        }
        [Test]
        public void SumNumbers_StartAt100SumNext0_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0, kata.SumNumbers(100, 0));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext0_TotalIs0()
        {
            var kata = new Calculator();
            Assert.AreEqual(0, kata.SumNumbers(0, 0));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext3_TotalIs3()
        {
            var kata = new Calculator();
            Assert.AreEqual(3, kata.SumNumbers(0, 3));
        }

        [Test]
        public void SumNumbers_StartAt0SumNext100_TotalIs5050()
        {
            var kata = new Calculator();
            Assert.AreEqual(5050, kata.SumNumbers(1, 100));
        }
    }
}
