using System;
using System.Collections.Generic;


namespace takeHomeTest.Models
{
    public class phoneData
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string ownerFirstName { get; set; }
        public DateTime timestamp { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}