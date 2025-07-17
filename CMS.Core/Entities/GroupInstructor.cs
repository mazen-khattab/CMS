using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class GroupInstructor
    {
        public int GroupInstructorId { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
    }
}
