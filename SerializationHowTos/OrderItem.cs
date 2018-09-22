using System;

namespace SerializationHowTos
{
    public class OrderItem
    {
        private OrderItem()
        {

        }
        internal OrderItem(Guid orderId, Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException();
            if (orderId == null)
                throw new ArgumentNullException();
            if (quantity == 0)
                throw new ArgumentOutOfRangeException();
            OrderId = orderId;
            ProductId = product.Id;
            ProductDescription = product.Description;
            Quantity = quantity;
        }
        public Guid OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public string ProductDescription { get; private set; }
    }
}