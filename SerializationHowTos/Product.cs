using System;

namespace SerializationHowTos
{
    public class Product
    {
        private Product() { }
        public Product(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException();
            Description = description;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Description { get; private set; }
    }
}