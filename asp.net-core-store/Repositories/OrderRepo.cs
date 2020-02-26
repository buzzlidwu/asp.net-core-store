using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_core_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace asp.net_core_store.Repositories
{
    public class OrderRepo : IOrderRepo<Order>
    {
        private readonly OrderContext _context;

        public OrderRepo(OrderContext context)
        {
            _context = context;
        }
        public async Task<int> ChangeStatus(List<int> lists)
        {
            try
            {
                var data = _context.Orders.Where(od => lists.Contains(od.Id));
                foreach (var order in data)
                {
                    order.Status = true;
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<Order> GetById(int? id)
        {
            try
            {
               return await _context.Orders.FindAsync(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public async Task<IList<Order>> GetAllOrder()
        {
            try
            {
                return await _context.Orders.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
