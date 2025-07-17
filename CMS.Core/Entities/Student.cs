using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Faculty { get; set; } = string.Empty;
        public bool IsGraduated { get; set; } = false;
        public DateTime? BirthDate { get; set; }

        public string? AppUserId { get; set; }// FK
        public AppUser AppUser { get; set; } = null!;
        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
    }
}
