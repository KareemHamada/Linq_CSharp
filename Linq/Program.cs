using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                Console.WriteLine(student.Id + " " + student.FirstName +" "+ student.Gender);
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

            ////=================================== Header =====================================
            ////=================================== Video 4 Aggregate function ==================
            // return string like => "India, US, UK, Canada, Australia"
            //string[] countries = { "India", "US", "UK", "Canada", "Australia" };
            //string result = countries.Aggregate((a,b) => a + ", "+b);
            //Console.WriteLine(result);

            //// get product(*) of all numbers 
            int[] Numbers = { 2, 3, 4, 5 };
            // without seed parameter
            int product = Numbers.Aggregate((a, b) => a * b);
            Console.WriteLine(product);
            // without seed parameter
            int seedProduct = Numbers.Aggregate(10,(a, b) => a * b);
            Console.WriteLine(seedProduct);


            ////=================================== Header =====================================
            ////=================================== Video 3 Aggregate functions ==================
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int smallest = Numbers.Min();
            //Console.WriteLine(smallest);
            //int smallestEven = Numbers.Where(a => a % 2 == 0).Min();
            //Console.WriteLine(smallestEven);

            //int largest = Numbers.Max();
            //Console.WriteLine(largest);
            //int largestEven = Numbers.Where(a => a % 2 == 0).Max();
            //Console.WriteLine(largestEven);

            //int sumOfAllNumbers = Numbers.Sum();
            //Console.WriteLine(sumOfAllNumbers);
            //int sumOfAllEvenNumbers = Numbers.Where(a => a % 2 == 0).Sum();
            //Console.WriteLine(sumOfAllEvenNumbers);

            //int countOfAll = Numbers.Count();
            //Console.WriteLine(countOfAll);
            //int countOfAllEvenNumbers = Numbers.Where(a => a % 2 == 0).Count();
            //Console.WriteLine(countOfAllEvenNumbers);

            //double AverageOfAll = Numbers.Average();
            //Console.WriteLine(AverageOfAll);
            //double AverageOfAllEvenNumbers = Numbers.Where(a => a % 2 == 0).Average();
            //Console.WriteLine(AverageOfAllEvenNumbers);

            //// find shortes country name and number of character on it
            //string[] countries = { "India", "USA", "UK" };
            //int shorestNameCount = countries.Min(a => a.Length);
            //Console.WriteLine(shorestNameCount);
            //string shorestName = countries.Where(a => a.Length == shorestNameCount).FirstOrDefault();
            //Console.WriteLine(shorestName);

            //int LargestNameCount = countries.Max(a => a.Length);
            //Console.WriteLine(LargestNameCount);

            //string LargestName = countries.Where(a => a.Length == LargestNameCount).FirstOrDefault();
            //Console.WriteLine(LargestName);



            ////=================================== Header =====================================
            ////=================================== Video 3 Extension Methods ==================
            ///// coonvert first char to upper if lower and vice versa


            //string strName = "pragim";
            //string res = strName.ChageFirstLetterCase();
            //string res2 = StringHelper.ChageFirstLetterCase(strName);
            //Console.WriteLine(res);

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);
            //IEnumerable<int> EvenNumbers2 = Enumerable.Where(Numbers,n => n % 2 == 0);
            ////=================================== Header =====================================
            ////======================== Video 2 using lampda and query expression =============

            //// ================================ using lampda expression ================================
            //var students2 = Student.GetAllStudents().Where(student => student.Gender == "Male").ToList();
            //IEnumerable<Student> students3 = Student.GetAllStudents().Where(student => student.Gender == "Male").ToList();
            ////PrintStudent(students2);
            ////PrintStudent(students3.ToList());


            //// ================================ using query expression ================================
            //var student4 = (from student in Student.GetAllStudents()
            //                where student.Gender == "Male"
            //                select student).ToList();
            //IEnumerable<Student> students5 = from student in Student.GetAllStudents()
            //                                  where student.Gender == "Male"
            //                                  select student;
            //PrintStudent(students5.ToList());









            ////=================================== Header =====================================
            ////=================================== Video 1 =====================================


            //// ================================ using where ================================
            //List < Student > newLsit = students.Where(s => s.Id % 2 == 0).ToList();
            //PrintStudent(newLsit);

            //// using where 
            //List<Student> newLsit = students.Where(s => s.Gender == "Female").ToList();
            //PrintStudent(newLsit);

            //// ================================ linq query ================================
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
