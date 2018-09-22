using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingHowTos.ViewModels
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public string OrderDescription { get; set; }
    }
}
