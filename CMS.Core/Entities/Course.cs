﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<Group> Categories { get; set;} = new List<Group>();
    }
}
