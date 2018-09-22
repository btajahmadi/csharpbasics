using ModelBindingHowTos.Interfaces;
using SerializationHowTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingHowTos.Data
{
    public class OrderRepository : IOrderRepository
    {
        private static List<Order> _orders = Populate();
        public IEnumerable<Order> GetPage(int pageNumber, int itemsPerPage)
        {
            return _orders;
        }

        public Order OrderWithId(Guid id)
        {
            throw new NotImplementedException();
        }
        private static List<Order> Populate()
        {
            return new List<Order>()
            {
                new Order("Papmers", new Customer("KFG")),
                new Order("Washing Machine King Size", new Customer("Ajax Co")),
                new Order("Porcelaint", new Customer("Polar Federation")),
                new Order("sad", new Customer("Zincoderma Ltd.")),
                new Order("s", new Customer("Lipos")),
                new Order("Niaiu", new Customer("Bitfast Trading")),
                new Order("Hsgfa", new Customer("Jumpers")),
                new Order("Lsjja", new Customer("Ninja Pot")),
                new Order("Lshha", new Customer("Bella Terresa")),
                new Order("Nsguya", new Customer("UpTime Energy")),
                new Order("Oiuusa", new Customer("Sillio Enricone")),
                new Order("NJHsgga", new Customer("HTY")),
            };
        }

    }
}
