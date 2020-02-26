using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp.net_core_store.Models;
using asp.net_core_store.Repositories;

namespace asp.net_core_store
{
    public class DetailsModel : PageModel
    {
        private readonly IOrderRepo<Order> _repo;

        public DetailsModel(asp.net_core_store.Models.OrderContext context, IOrderRepo<Order> repo)
        {
            _repo = repo;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _repo.GetById(id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
