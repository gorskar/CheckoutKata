using System.Collections.Generic;

namespace CheckoutKata.Main
{
    public class Checkout
    {
        private Money totalMoney = new Money(0);

        private PricingRules pricingRules = new PricingRules();

        private Dictionary<ItemCode, Quantity> scannedItems = new Dictionary<ItemCode, Quantity>(); //todo. group this and the totalMoney?

        public Money Total()
        {
            return totalMoney;
        }

        public void Scan(ItemCode itemCode)
        {
            if (!scannedItems.ContainsKey(itemCode)) { scannedItems[itemCode] = new Quantity(0); }
            scannedItems[itemCode].Add(new Quantity(1));
            pricingRules.ItemCodeScanned(itemCode, scannedItems[itemCode], totalMoney);
        }
    }
}
