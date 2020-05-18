using System.Collections.Generic;

namespace CheckoutKata.Main
{
    public class PricingRules
    {
        private Dictionary<ItemCode, Money> pricingRules;
        private Dictionary<ItemCode, Discount> discounts;

        public PricingRules()
        {
            pricingRules = new Dictionary<ItemCode, Money>();
            pricingRules.Add(new ItemCode("A"), new Money(50));
            pricingRules.Add(new ItemCode("B"), new Money(30));
            pricingRules.Add(new ItemCode("C"), new Money(20));
            pricingRules.Add(new ItemCode("D"), new Money(15));

            discounts = new Dictionary<ItemCode, Discount>();
            discounts.Add(new ItemCode("A"), new Discount(new Quantity(3), new Money(20)));
            discounts.Add(new ItemCode("B"), new Discount(new Quantity(2), new Money(15)));
        }

        public Money get(ItemCode itemCode)
        {
            return pricingRules[itemCode];
        }

        public void ItemCodeScanned(ItemCode itemCode, Quantity totalCountOfThisItemCode,
            Money totalMoney)
        {
            Money itemPrice = pricingRules[itemCode];
            totalMoney.Add(itemPrice);

            if (discounts.ContainsKey(itemCode))
            {
                discounts[itemCode].ApplyDiscountAfterAddingOneItem(totalCountOfThisItemCode, totalMoney);
            }
        }
    }
}
