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

    }
}
