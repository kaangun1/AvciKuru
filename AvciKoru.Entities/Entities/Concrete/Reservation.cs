using AvciKoru.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class Reservation:BaseEntity
    {
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }

        public string OdaId { get; set; }

        public Oda Oda { get; set; }

        public int Fiyat { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
