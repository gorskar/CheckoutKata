namespace CheckoutKata.Main
{
    public class ItemCode
    {
        private string itemCode;

        public ItemCode(string itemCode)
        {
            this.itemCode = itemCode;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ItemCode) obj);
        }

        protected bool Equals(ItemCode other)
        {
            return itemCode == other.itemCode;
        }

        public override int GetHashCode()
        {
            return (itemCode != null ? itemCode.GetHashCode() : 0);
        }
    }
}
