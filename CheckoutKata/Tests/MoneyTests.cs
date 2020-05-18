using CheckoutKata.Main;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class MoneyTests
    {
        [Test]
        public void testMoney1IsNotEqualToMoney2()
        {
            Money money1 = new Money(1);
            Money money2 = new Money(2);

            Assert.AreNotEqual(money1, money2);
        }
        
        [Test]
        public void testMoney1IsEqualToMoney1()
        {
            Money money1 = new Money(1);
            Money money12 = new Money(1);

            Assert.AreEqual(money1, money12);
        }

        [Test]
        public void testMoneyAddOnePlusOneEqualsTwo()
        {
            Money moneyOne1 = new Money(1);
            Money moneyOne2 = new Money(1);

            moneyOne1.Add(moneyOne2);

            Assert.That(moneyOne1, Is.EqualTo(new Money(2)));
        }

        [Test]
        public void testMoneyMinusTwoMinusOneEqualsOne()
        {
            Money moneyTwo1 = new Money(2);
            Money moneyOne1 = new Money(1);

            moneyTwo1.Minus(moneyOne1);

            Assert.That(moneyTwo1, Is.EqualTo(new Money(1)));
        }
    }
}
