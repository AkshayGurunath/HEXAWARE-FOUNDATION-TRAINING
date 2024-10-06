using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Entity
{
    internal class Payment
    {
        public int PaymentID { get; set; }
        public int StudentID { get; set; } // Foreign key to Student
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
