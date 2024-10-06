using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;


namespace StudentInformationSystem.BusinessLayer
{
    public class SIS
    {
        public void EnrollStudentInCourse(Student student, Course course)
        {
            // Create a new enrollment and add it to the student's enrollment list
            Enrollment enrollment = new Enrollment(student, course);
            student.Enrollments.Add(enrollment); // This line is correct
            course.EnrolledStudents.Add(enrollment); // This should also be included
        }

        public void AssignTeacherToCourse(Teacher teacher, Course course)
        {
            course.AssignTeacher(teacher);
            teacher.AssignedCourses.Add(course);
        }

        public void RecordPayment(Student student, decimal amount, DateTime paymentDate)
        {
            student.MakePayment(amount, paymentDate);
        }

        public void GenerateEnrollmentReport(Course course)
        {
            Console.WriteLine($"Enrollment Report for Course: {course.CourseName}");
            foreach (var student in course.GetEnrollments())
            {
                student.DisplayStudentInfo();
            }
        }

        public void GeneratePaymentReport(Student student)
        {
            Console.WriteLine($"Payment Report for Student: {student.FirstName} {student.LastName}");
            foreach (var payment in student.GetPaymentHistory())
            {
                Console.WriteLine($"Amount: {payment.GetPaymentAmount()}, Date: {payment.GetPaymentDate()}");
            }
        }

        public void CalculateCourseStatistics(Course course)
        {
            Console.WriteLine($"Course: {course.CourseName}");
            Console.WriteLine($"Number of Enrollments: {course.GetEnrollments().Count}");
            decimal totalPayments = course.GetEnrollments().Sum(s => s.GetPaymentHistory().Sum(p => p.GetPaymentAmount()));
            Console.WriteLine($"Total Payments: {totalPayments}");
        }
    }
}
