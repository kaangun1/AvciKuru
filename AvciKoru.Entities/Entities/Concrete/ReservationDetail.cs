using AvciKoru.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class ReservationDetail:BaseEntity
    {
        public string ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public string AppUserId { get; set; }
        public string AppUser { get; set; }

    }
}
