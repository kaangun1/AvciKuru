using AvciKoru.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class Order:BaseEntity
    {

        public string AppUserId { get; set; } // SiparisiAlan Kisi
        public AppUser Employee { get; set; }

        public DateTime OrderDate { get; set; }
        public string OdaId { get; set; }
        public Oda Oda { get; set; }



    }
}
