using CheckoutKata.Main;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class CheckoutTests
    {
        [Test]
        public void testWhenIScanNothingThenTotalIsZero()
        {
            Money expectedTotal = new Money(0);
            Checkout checkout = new Checkout();
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemAThenTotalIsFifty()
        {
            Money expectedTotal = new Money(50);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("A"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemBThenTotalIsThirty()
        {
            Money expectedTotal = new Money(30);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("B"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemCThenTotalIsTwenty()
        {
            Money expectedTotal = new Money(20);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("C"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemDThenTotalIsFifteen()
        {
            Money expectedTotal = new Money(15);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("D"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemAAndBThenTotalIsEighty()
        {
            Money expectedTotal = new Money(80);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("A"));
            checkout.Scan(new ItemCode("B"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemBTwiceThenTotalIsFourtyFive()
        {
            Money expectedTotal = new Money(45);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("B"));
            checkout.Scan(new ItemCode("B"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}