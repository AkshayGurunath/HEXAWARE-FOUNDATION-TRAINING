using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Enrollment> Enrollments { get; set; }  // Change here
        public List<Payment> PaymentHistory { get; set; }

        public Student()
        {
            Enrollments = new List<Enrollment>();  // Change here
            PaymentHistory = new List<Payment>();
        }

        public void EnrollInCourse(Course course)
        {
            var enrollment = new Enrollment(this, course);  // Create an enrollment object
            Enrollments.Add(enrollment);  // Add enrollment to the list
        }

        public void UpdateStudentInfo(string firstName, string lastName, DateTime dateOfBirth, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void MakePayment(decimal amount, DateTime paymentDate)
        {
            PaymentHistory.Add(new Payment { Amount = amount, PaymentDate = paymentDate, Student = this });
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FirstName} {LastName}, DOB: {DateOfBirth.ToShortDateString()}, Email: {Email}, Phone: {PhoneNumber}");
        }

        public List<Course> GetEnrolledCourses()
        {
            List<Course> courses = new List<Course>();
            foreach (var enrollment in Enrollments)
            {
                courses.Add(enrollment.GetCourse());
            }
            return courses;
        }

        public List<Payment> GetPaymentHistory()
        {
            return PaymentHistory;
        }
    }
}

