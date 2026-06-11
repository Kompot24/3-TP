using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void PrintTest()
        {
            var fractions = new Fraction(5,10);
            Assert.AreEqual("Дробь:5/10", fractions.Verbose());
        }

        [TestMethod()]
        public void SumTest()
        {
            var fraction = new Fraction(5,10);
            var secondFraction = new Fraction(4,10);
            fraction = fraction + secondFraction;
            Assert.AreEqual("Дробь:9/10", fraction.Verbose());
        }

        [TestMethod()]
        public void SumTestWithDifferentDenominator()
        {
            var fraction = new Fraction(5, 10);
            var secondFraction = new Fraction(4, 5);
            fraction = fraction + secondFraction;
            Assert.AreEqual("Дробь:65/50", fraction.Verbose());
        }


        [TestMethod()]
        public void SubstractionTest()
        {
            var fraction = new Fraction(5,10);
            var secondFraction = new Fraction(4, 10);
            fraction = fraction - secondFraction;
            Assert.AreEqual("Дробь:1/10", fraction.Verbose());
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            var fraction = new Fraction(5,10);
            var secondFraction = new Fraction(2, 2);
            fraction = fraction * secondFraction;
            Assert.AreEqual("Дробь:10/20", fraction.Verbose());
        }

        [TestMethod()]
        public void DivisionTest()
        {
            var fraction = new Fraction(5,10);
            var secondFraction = new Fraction(2, 8);
            fraction = fraction / secondFraction;
            Assert.AreEqual("Дробь:40/20", fraction.Verbose());
        }

        [TestMethod()]
        public void ReductionTest()
        {
            var fraction = new Fraction(5, 10);
            fraction.Reduction(fraction);
            Assert.AreEqual("Дробь:1/2", fraction.Verbose());
        }

        [TestMethod()]
        public void MoreCompareTest()
        {
            var fraction = new Fraction(8, 30);
            var secondFraction = new Fraction(9, 25);
            fraction = fraction > secondFraction;
            Assert.AreEqual("Дробь:9/25", fraction.Verbose());
        }

        [TestMethod()]
        public void LessCompareTest()
        {
            var fraction = new Fraction(8, 30);
            var secondFraction = new Fraction(9, 25);
            fraction = fraction < secondFraction;
            Assert.AreEqual("Дробь:8/30", fraction.Verbose());
        }

    }
}