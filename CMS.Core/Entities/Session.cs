using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }

        public ICollection<SessionGroup> SessionGroup { get; set; } = new List<SessionGroup>();
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
