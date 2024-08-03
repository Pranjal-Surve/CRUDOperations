using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDOperations.Models;

namespace CRUDOperations.View
{
    internal class PrintDetails
    {
        public void Display(CollegeDetails college, List<Student> students, List<Professor> professors, List<Department> departments)
        {
            Console.WriteLine();
            Console.WriteLine("College ID : " + college.CollegeId);
            Console.WriteLine("College Name : " + college.CollegeName);

            Console.WriteLine();

            Console.WriteLine("Number of students : " + students.Count);
            Console.WriteLine("Number of Professors : " + professors.Count);
            Console.WriteLine("Number of Departments : " + departments.Count);

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Student Details");
            Console.WriteLine("_______________________________");
            Console.WriteLine($"|{"Student Id",-10} | {"Student Name",-15} |");
            foreach (Student student in students)
            {
                Console.WriteLine("_______________________________");
                Console.WriteLine($"|{student.StudentId,-10} | {student.StudentName,-15} |");
            }
            Console.WriteLine("_______________________________");
            Console.WriteLine();

            Console.WriteLine("Professor Details");
            Console.WriteLine("_________________________________");
            Console.WriteLine($"|{"Professo Id",-12} | {"Professor Name",-15} |");
            foreach (Professor professor in professors)
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine($"|{professor.ProfessorId,-12} | {professor.ProfessorName,-15} |");
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine();

            Console.WriteLine("Department Details");
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"|{"Department Id",-15} | {"Department Name",-18} |");
            foreach (Department department in departments)
            {
                Console.WriteLine("_______________________________________");
                Console.WriteLine($"|{department.DepartmentId,-15} | {department.DepartmentName,-18} |");
            }
            Console.WriteLine("_______________________________________");
        }
    }
}
