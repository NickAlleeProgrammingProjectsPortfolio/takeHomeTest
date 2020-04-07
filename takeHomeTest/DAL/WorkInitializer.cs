using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using takeHomeTest.Models;
using takeHomeTest.DAL;


namespace takeHomeTest.DAL
{
    public class WorkInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<workContext>
    {
        protected override void Seed(workContext context)
        {
            var Phones = new List<phoneData>
            {
            new phoneData{ID=1,Brand="samsung",ownerFirstName="jim",timestamp =DateTime.Parse("2005-09-01")},
            new phoneData{ID=1,Brand="apple",ownerFirstName="tim",timestamp =DateTime.Parse("2005-09-02")},
            new phoneData{ID=1,Brand="lg",ownerFirstName="bob",timestamp =DateTime.Parse("2005-09-03")}

            };

            Phones.ForEach(s => context.phoneData.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EnrollmentID=1,RepairID=1050},
            new Enrollment{EnrollmentID=2,RepairID=1051},
            new Enrollment{EnrollmentID=3,RepairID=1052},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}