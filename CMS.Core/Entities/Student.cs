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
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public bool IsGraduated { get; set; } = false;
        public DateTime? BirthDate { get; set; }

        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
    }
}
