using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata.Main
{
    public class Quantity
    {
        private int number;

        public Quantity(int quantity)
        {
            this.number = quantity;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Quantity)obj);
        }

        public override string ToString()
        {
            return number.ToString();
        }

        protected bool Equals(Quantity other)
        {
            return number == other.number;
        }

        public override int GetHashCode()
        {
            return number;
        }

        public void Add(Quantity other)
        {
            number += other.number;
        }

        public static Quantity operator % (Quantity operand, Quantity divisor)
        {
            return new Quantity(operand.number % divisor.number);
        }

        public static bool operator == (Quantity first, Quantity second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Quantity first, Quantity second)
        {
            return !first.Equals(second);
        }
    }
}
