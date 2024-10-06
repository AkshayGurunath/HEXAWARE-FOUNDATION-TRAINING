using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Entity
{
    internal class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; } // Foreign key to Student
        public int CourseID { get; set; }  // Foreign key to Course
        public DateTime EnrollmentDate { get; set; }
    }
}
