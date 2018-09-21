using System;

namespace SerializationHowTos
{
    public class OrderItem
    {
        private OrderItem()
        {

        }
        internal OrderItem(Guid orderId, Guid productId, int quantity)
        {
            if (productId == null)
                throw new ArgumentNullException();
            if (orderId == null)
                throw new ArgumentNullException();
            if (quantity == 0)
                throw new ArgumentOutOfRangeException();
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
        public Guid OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }

    }
}