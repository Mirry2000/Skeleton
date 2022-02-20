using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string OrderContent { get; set; }
        public int OrderLine { get; set; }
    }
}