using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.Entities.Concrete
{
    public class AppUser : IdentityUser
    {

        public string? TcNo { get; set; }
        public string? SiteId { get; set; } // Hangi Siteden Kayit Yaptirmis
        public DateOnly? BirthDate { get; set; }
        public bool? Cinsiyet { get; set; }
    }
}
