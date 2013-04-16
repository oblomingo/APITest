using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest.Models
{
    class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ordinal { get; set; }

        // Navigation properties
        public ICollection<Link> Links { get; set; }
    }
}
