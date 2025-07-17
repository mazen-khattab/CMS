using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class SessionGroup
    {
        public int SessionGroupId { get; set; }

        public int? SessionId { get; set; } // FK
        public Session? Session { get; set; } // RNP

        public int? GroupId { get; set; } // FK
        public Group? Group { get; set; } // RNP
    }
}
