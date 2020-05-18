using CheckoutKata.Main;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class ItemCodeTests
    {
        [Test]
        public void testItemCodeAIsEqualToItemCodeA()
        {
            ItemCode itemCode = new ItemCode("A");
            ItemCode itemCode2 = new ItemCode("A");

            Assert.AreEqual(itemCode, itemCode2);
        }
        
        [Test]
        public void testItemCodeBIsNotEqualToItemCodeA()
        {
            ItemCode itemCodeB = new ItemCode("B");
            ItemCode itemCodeA = new ItemCode("A");

            Assert.AreNotEqual(itemCodeA, itemCodeB);
        }
    }
}
