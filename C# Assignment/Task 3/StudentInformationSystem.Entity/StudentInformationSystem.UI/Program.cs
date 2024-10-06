using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BusinessLayer;

namespace StudentInformationSystem.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            SIS sis = new SIS();

            // Create some teachers
            Teacher teacher1 = new Teacher { Id = 1, Name = "Alice Smith", Email = "alice@example.com", Expertise = "Mathematics" };
            Teacher teacher2 = new Teacher { Id = 2, Name = "Bob Johnson", Email = "bob@example.com", Expertise = "Computer Science" };

            // Create some courses
            Course course1 = new Course { CourseCode = "CS101", CourseName = "Introduction to Programming" };
            Course course2 = new Course { CourseCode = "MATH101", CourseName = "Calculus I" };

            // Assign teachers to courses
            course1.AssignTeacher(teacher2);
            course2.AssignTeacher(teacher1);

            // Create some students
            Student student1 = new Student { Id = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(2000, 1, 1), Email = "john.doe@example.com", PhoneNumber = "123-456-7890" };
            Student student2 = new Student { Id = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(2001, 2, 2), Email = "jane.smith@example.com", PhoneNumber = "098-765-4321" };

            // Enroll students in courses
            sis.EnrollStudentInCourse(student1, course1);
            sis.EnrollStudentInCourse(student1, course2);
            sis.EnrollStudentInCourse(student2, course1);

            // Make payments for students
            student1.MakePayment(500, DateTime.Now);
            student2.MakePayment(600, DateTime.Now);

            // Display student information
            student1.DisplayStudentInfo();
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in student1.GetEnrolledCourses())
            {
                course.DisplayCourseInfo();
            }
            Console.WriteLine("Payment History:");
            foreach (var payment in student1.GetPaymentHistory())
            {
                Console.WriteLine($"Amount: {payment.Amount}, Date: {payment.PaymentDate}");
            }

            Console.WriteLine();

            student2.DisplayStudentInfo();
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in student2.GetEnrolledCourses())
            {
                course.DisplayCourseInfo();
            }
            Console.WriteLine("Payment History:");
            foreach (var payment in student2.GetPaymentHistory())
            {
                Console.WriteLine($"Amount: {payment.Amount}, Date: {payment.PaymentDate}");
            }

            Console.WriteLine();

            // Display teacher information
            teacher1.DisplayTeacherInfo();
            Console.WriteLine("Assigned Courses:");
            foreach (var course in teacher1.GetAssignedCourses())
            {
                course.DisplayCourseInfo();
            }

            teacher2.DisplayTeacherInfo();
            Console.WriteLine("Assigned Courses:");
            foreach (var course in teacher2.GetAssignedCourses())
            {
                course.DisplayCourseInfo();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
