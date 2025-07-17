using CMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class Attendance
    {
        public int AttendanceId { get; set; }

        public int? SessionId { get; set; }
        public Session? Session { get; set; }

        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        public AttendanceStatus AttendanceStatus { get; set; } = AttendanceStatus.Present;
        public string? Note { get; set; } = "Present";
    }
}
