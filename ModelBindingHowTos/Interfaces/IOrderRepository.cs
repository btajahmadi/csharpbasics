using SerializationHowTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingHowTos.Interfaces
{
    public interface IOrderRepository
    {
        Order OrderWithId(Guid id);
        IEnumerable<Order> GetPage(int pageNumber, int itemsPerPage);
    }
}
