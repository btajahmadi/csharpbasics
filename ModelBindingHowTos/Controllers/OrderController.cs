using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingHowTos.Interfaces;
using ModelBindingHowTos.ViewModels;

namespace ModelBindingHowTos.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        //public IActionResult Index()
        //{
        //    return RedirectToAction(nameof(List));
        //}
        [Route("Orders")]
        [Route("Orders/List")]
        public IActionResult List(int page = 1)
        {
            var query = _orderRepository.GetPage(page, 5)
                .Select(o => new OrderViewModel()
                {
                    OrderId = o.Id,
                    OrderDescription = o.Description
                });
            return View(query.ToList());
        }
    }
}