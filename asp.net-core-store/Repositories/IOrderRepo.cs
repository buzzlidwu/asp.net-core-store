using System.Collections.Generic;
using System.Threading.Tasks;
using asp.net_core_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_store.Repositories
{
    public interface IOrderRepo<T> where T : class
    {
        Task<IList<T>> GetAllOrder();
        Task<int> ChangeStatus(List<int> lists);
        Task<Order> GetById(int? id);
    }
}