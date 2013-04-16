using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Models
{
    public class Task {
        public Task() {}
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCompleted { get; set; }

        public Priority Priority { get; set; }
        public Status Status { get; set; }

        // Navigation properties
        public ICollection<Link> Links { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<User> Assignees { get; set; }

    }
}
