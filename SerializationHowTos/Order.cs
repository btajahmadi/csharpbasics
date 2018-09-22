using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SerializationHowTos
{
    public class Order : IXmlSerializable
    {
        private Order() { }
        public Order(string description, Customer customer)
        {
            if (customer == null) throw new ArgumentNullException();
            Description = description ?? throw new ArgumentNullException();
            CustomerId = customer.Id; 
            Id = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
        }
        public Guid Id { get; private set; }
        public DateTime DateCreated { get; private set; }
        public string Description { get; private set; }
        public Guid CustomerId { get; private set; }
        public List<OrderItem> Items { get; } = new List<OrderItem>();
        public void AddItem(Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException();
            Items.Add(new OrderItem(Id, product, quantity));
        }
        public static IEnumerable<Order> SeedOrders()
        {
            return new List<Order>()
            {



            };
        }
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("OrderId", Id.ToString());
            writer.WriteStartElement("DateCreated");
            writer.WriteAttributeString("Kind", DateCreated.Kind.ToString());
            writer.WriteValue(DateCreated.ToString());
            writer.WriteEndElement();
            writer.WriteElementString("Description", Description);
            writer.WriteElementString("CustomerId", CustomerId.ToString());
            writer.WriteStartElement("OrderItems");
            foreach (var item in Items)
            {
                writer.WriteStartElement("OrderItem");
                writer.WriteElementString("ProductId", item.ProductId.ToString());
                writer.WriteElementString("Quantity", item.Quantity.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();


        }
    }
}
