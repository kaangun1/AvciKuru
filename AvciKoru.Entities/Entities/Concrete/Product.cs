using AvciKoru.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        public string CategoryId { get; set; }
        public string Category { get; set; }


    }
}
