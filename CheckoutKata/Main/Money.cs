using System;
using System.ComponentModel;

namespace CheckoutKata.Main
{
    public class Money
    {
        private int amount;

        public Money(int amount)
        {
            this.amount = amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Money) obj);
        }

        public override string ToString()
        {
            return amount.ToString();
        }

        protected bool Equals(Money other)
        {
            return amount == other.amount;
        }

        public override int GetHashCode()
        {
            return amount;
        }

        public void Add(Money itemPrice)
        {
            amount += itemPrice.amount;
        }

        public void Minus(Money itemPrice)
        {
            amount -= itemPrice.amount;
        }
    }
}
