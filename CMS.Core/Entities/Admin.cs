using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class Admin 
    {
        public int AdminId { get; set; }
        public DateTime BirthDate { get; set; }

        public string? AppUserId { get; set; } // FK
        public AppUser AppUser { get; set; } = null!;
    }
}
