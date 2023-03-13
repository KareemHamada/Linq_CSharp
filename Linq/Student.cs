using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student
    {
 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public Student setStudentValues(Student student,int Id, string FirstName, string LastName, string Email)
        {
            student.Id = Id;
            student.FirstName = FirstName;
            student.LastName = LastName;
            student.Gender = Email;
            return student;
        }


        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>();

            Student student1 = new Student
            {
                Id = 101,
                FirstName = "Mark",
                Gender = "Male"
            };
            listStudents.Add(student1);

            Student student2 = new Student
            {
                Id = 102,
                FirstName = "Mary",
                Gender = "Female"
            };
            listStudents.Add(student2);

            Student student3 = new Student
            {
                Id = 103,
                FirstName = "John",
                Gender = "Male"
            };
            listStudents.Add(student3);

            Student student4 = new Student
            {
                Id = 104,
                FirstName = "Steve",
                Gender = "Male"
            };
            listStudents.Add(student4);

            Student student5 = new Student
            {
                Id = 105,
                FirstName = "Pam",
                Gender = "Female"
            };
            listStudents.Add(student5);

            return listStudents;
        }

    }
}
