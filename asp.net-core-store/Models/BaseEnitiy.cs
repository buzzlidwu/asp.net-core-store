using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_store.Models
{
    public class BaseEnitiy
    {
        [Key]
        public int Id { get; set; }
    }
}
