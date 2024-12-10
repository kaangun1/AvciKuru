using AvciKoru.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class OrderDetail:BaseEntity
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public byte? Discount { get; set; }
    }
}
