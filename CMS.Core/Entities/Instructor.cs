using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? Bio { get; set; }
        public string? Specialization { get; set; }
        public DateTime? BirthDate { get; set; }

        public string? AppUserId { get; set; } // FK
        public AppUser AppUser { get; set; } = null!;

        public ICollection<GroupInstructor> GroupInstructors { get; set; } = new List<GroupInstructor>();
    }
}
