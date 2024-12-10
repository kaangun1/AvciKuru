using AvciKoru.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class Oda : BaseEntity
    {
        public string Name { get; set; }
        public byte YatakSayisi { get; set; }
        public byte  M2 { get; set; }
        public bool IsReserved { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
