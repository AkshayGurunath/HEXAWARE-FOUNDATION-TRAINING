using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Entity
{

    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public Teacher AssignedTeacher { get; set; }
        public List<Enrollment> EnrolledStudents { get; set; }  // Change here

        public Course()
        {
            EnrolledStudents = new List<Enrollment>();  // Change here
        }

        public void AssignTeacher(Teacher teacher)
        {
            AssignedTeacher = teacher;
        }

        public void UpdateCourseInfo(string courseCode, string courseName)
        {
            CourseCode = courseCode;
            CourseName = courseName;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course Code: {CourseCode}, Course Name: {CourseName}, Assigned Teacher: {AssignedTeacher?.Name}");
        }

        public List<Student> GetEnrollments()
        {
            List<Student> students = new List<Student>();
            foreach (var enrollment in EnrolledStudents)
            {
                students.Add(enrollment.GetStudent());
            }
            return students;
        }

        public Teacher GetTeacher()
        {
            return AssignedTeacher;
        }
    }

}
