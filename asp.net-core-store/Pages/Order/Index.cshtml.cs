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
    public class IndexModel : PageModel
    {
        //private readonly asp.net_core_store.Models.OrderContext _context;
        private readonly IOrderRepo<Order> _repo;

        public IndexModel( IOrderRepo<Order> repo)
        {
            _repo = repo;
        }
        public IList<Order> Order { get;set; }
        [BindProperty]
        public List<int> AreChecked { get; set; }

        public async Task OnGetAsync()
        {
            Order = await _repo.GetAllOrder();
        }

        public async Task<IActionResult> OnPostJoinListAsync()
        {
            List<int> Select = AreChecked;
            if (Select.Count() == 0)
            {
                return RedirectToPage("/Order/Index");
            }

            if (await _repo.ChangeStatus(Select) == 0)
            {
                return RedirectToPage("./Error");
            }
           
            return RedirectToPage("/Order/Index");
        }
    }
}
