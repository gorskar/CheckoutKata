namespace CheckoutKata.Main
{
    public class Discount
    {
        public Quantity quantity;
        public Money discount;

        public Discount(Quantity quantity, Money Discount)
        {
            this.quantity = quantity;
            discount = Discount;
        }

        public void ApplyDiscountAfterAddingOneItem(Quantity newQuantity, Money total)
        {
            if (newQuantity % quantity == new Quantity(0))
            {
                total.Minus(discount);
            }
        }
    }
}