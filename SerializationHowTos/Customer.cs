using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationHowTos
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException() : name;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
