using NUnit.Framework;
using System;
using Calculator;

namespace Calculator.Test
{
    public class Tests
    {
        [TestFixture]
        public class CalculatorTests
        {

            [Test]
            public void Sum_MaxValue()
            {
                Assert.Multiple(() =>
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(int.MaxValue, 1));
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(4, int.MaxValue));
                }
                );

            }


            [Test]
            public void Minus_MinValue()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Minus(int.MinValue, 4));
            }


            [TestCase(45, 14, 59)]
            [TestCase(6875, 9895, 16770)]
            [TestCase(3462, -24, 3438)]
            [TestCase(-251, -24, -275)]
            public void Sum_correct(int a, int b, int c)
            {
                Assert.AreEqual(c, a + b);
            }



            [Test]
            public void Minus_correct()
            {
                //arrange
                int a = 10;
                int b = 25;
                int expected = -15;
                //act
                int actual = Calculator.Minus(a, b);
                //assert
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(expected, actual);
                    Assert.AreEqual(10 - 5, 10 - 5);
                    Assert.AreNotEqual(-5, 0);
                });

            }


            [TestCase(17, 2, 8)]
            public void Division_correct(int a, int b, int c)
            {
                int actual = Calculator.Division(a, b);
                Assert.AreEqual(a/b, actual);
            }

            [Test]

            public void Division_Zero()
            {
                Assert.Throws<DivideByZeroException>(() => Calculator.Division(int.MinValue, 0));
            }

            [Test]
            public void Multiplication_correct([Range(1,4)] int a, [Random(-5,2, 3)] int b)
            {
                int actual = Calculator.Multiplication(a, b);
                //assert
                Assert.That(a * b, Is.EqualTo(actual));
            }

            [Test]
            public void Multi_MaxMinValue()
            {
                Assert.Multiple(() =>
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(int.MaxValue, 2));
                    Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(4, int.MaxValue));
                }
                );

            }
        }
    }
}