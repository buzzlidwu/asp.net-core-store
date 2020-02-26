namespace asp.net_core_store.Models
{
    public class Order : BaseEnitiy
    {
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public bool Status { get; set; }
    }
}