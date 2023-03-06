using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        public static void PrintStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName +" "+ student.Id);
            }
        }

        public static void PrintList(List<int> list)
        {
            foreach (var num in list)
            {
                Console.Write(num+ " ");               
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student studentAli = new Student();
            students.Add(studentAli.setStudentValues(studentAli,1, "ali", "mohamed", "Male"));

            Student studentAhmed = new Student();
            students.Add(studentAhmed.setStudentValues(studentAhmed, 2, "ahmed", "saad", "Male"));

            Student studentAfaf = new Student();
            students.Add(studentAfaf.setStudentValues(studentAfaf, 3, "afaf", "sayed", "Female"));

            Student studentAmr = new Student();
            students.Add(studentAmr.setStudentValues(studentAmr, 4, "amr", "khaled", "Male"));

            Student studentHoda = new Student();
            students.Add(studentHoda.setStudentValues(studentHoda, 5, "Hoda", "hassan", "Female"));

            // ================================ using where ================================
            List<Student> newLsit = students.Where(s => s.Id % 2 == 0).ToList();
            //PrintStudent(newLsit);

            //// using where 
            //List<Student> newLsit = students.Where(s => s.Gender == "Female").ToList();
            //PrintStudent(newLsit);

            // ================================ linq query ================================
            //List<Student> newLsit = (from student in students
            //                         where student.Gender == "Female"
            //                         select student).ToList();
            //PrintStudent(newLsit);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> list = (from num in numbers
            //                  where num %2 ==0
            //                  select num).ToList();
            //PrintList(list);
            ; Console.ReadKey();
        }
    }

    
}
