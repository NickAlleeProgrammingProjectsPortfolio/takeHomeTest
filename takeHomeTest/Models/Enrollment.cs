using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace takeHomeTest.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int RepairID { get; set; }
        public virtual phoneData phoneData { get; set; }
    }
}