using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Expertise { get; set; }
        public List<Course> AssignedCourses { get; set; }

        public Teacher()
        {
            AssignedCourses = new List<Course>();
        }

        public void UpdateTeacherInfo(string name, string email, string expertise)
        {
            Name = name;
            Email = email;
            Expertise = expertise;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Email: {Email}, Expertise: {Expertise}");
        }

        public List<Course> GetAssignedCourses()
        {
            return AssignedCourses;
        }
    }
}
