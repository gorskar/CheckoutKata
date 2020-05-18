using CheckoutKata.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.Tests
{
    [TestFixture]
    public class QuantityTests
    {
        [Test]
        public void testQuantity1IsNotEqualToQuantity2()
        {
            Quantity Quantity1 = new Quantity(1);
            Quantity Quantity2 = new Quantity(2);

            Assert.AreNotEqual(Quantity1, Quantity2);
        }

        [Test]
        public void testQuantity1IsEqualToQuantity1()
        {
            Quantity Quantity1 = new Quantity(1);
            Quantity Quantity12 = new Quantity(1);

            Assert.AreEqual(Quantity1, Quantity12);
        }

        [Test]
        public void testQuantityAddOnePlusOneEqualsTwo()
        {
            Quantity QuantityOne1 = new Quantity(1);
            Quantity QuantityOne2 = new Quantity(1);

            QuantityOne1.Add(QuantityOne2);

            Assert.That(QuantityOne1, Is.EqualTo(new Quantity(2)));
        }

        [Test]
        public void testQuantityThreeModThreeEqualsZero()
        {
            Quantity QuantityThree1 = new Quantity(3);
            Quantity QuantityThree2 = new Quantity(3);

            Quantity Remainder = QuantityThree1 % QuantityThree2;

            Assert.That(Remainder, Is.EqualTo(new Quantity(0)));
        }

        [Test]
        public void testQuantitySevenModThreeEqualsOne()
        {
            Quantity QuantitySeven1 = new Quantity(7);
            Quantity QuantityThree1 = new Quantity(3);

            Quantity Remainder = QuantitySeven1 % QuantityThree1;

            Assert.That(Remainder, Is.EqualTo(new Quantity(1)));
        }
    }
}
