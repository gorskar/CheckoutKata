using System;
using System.Collections.Generic;
using System.Text;
using CheckoutKata.Main;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    [TestFixture]
    public class DiscountTests
    {
        [Test]
        public void testApplyDiscountAfterAddingOneItemDiscountsThreeItemAsByTwenty()
        {
            Discount sut = new Discount(new Quantity(3), new Money(20));

            Money runningTotal = new Money(150);
            sut.ApplyDiscountAfterAddingOneItem(new Quantity(3), runningTotal);

            Assert.That(runningTotal, Is.EqualTo(new Money(130)));
        }
    }
}
