using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDOperations.View;

namespace CRUDOperations.Models
{
    internal class MainMenu
    {
        private PrintDetails printDetails = new PrintDetails(); // Create an instance of PrintDetails

        public void Menu(CollegeDetails college, List<Student> students, List<Professor> professors, List<Department> departments)
        {
            Console.WriteLine("What operation do you want to perform??");
            Console.WriteLine();
            Console.WriteLine("1.Add New Student " +
                "\n2.Display All " +
                "\n3.Update Student Details " +
                "\n4.Delete Student " +
                "\n5.Add New Professor " +
                "\n6.Update Professor Details " +
                "\n7.Delete Professor " +
                "\n8.Exit");

            int userInput = int.Parse(Console.ReadLine());

            while (userInput != 8)
            {
                switch (userInput)
                {
                    case 1:
                        CreateStudent(college.students);
                        break;
                    case 2:
                        printDetails.Display(college, college.students, college.professors, college.departments);
                        break;
                    case 3:
                        StudentUpdate(college.students);
                        break;
                    case 4:
                        StudentDelete(college.students);
                        break;
                    case 5:
                        AddProfessor(college.professors);
                        break;
                    case 6:
                        ProfessorUpdate(college.professors);
                        break;
                    case 7:
                        ProfessorDelete(college.professors);
                        break;
                    default:
                        Console.WriteLine("Select valid option.");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("What operation do you want to perform??");
                Console.WriteLine();
                Console.WriteLine("1.Add New Student " +
                    "\n2.Display All " +
                    "\n3.Update Student Details " +
                    "\n4.Delete Student " +
                    "\n5.Add New Professor " +
                    "\n6.Update Professor Details " +
                    "\n7.Delete Professor " +
                    "\n8.Exit");

                userInput = int.Parse(Console.ReadLine());
            }

        }     
        public static bool CheckStudentId(List<Student> students, int id)
        {
            foreach (Student student in students)
            {
                if (student.StudentId == id)
                {
                    return true;
                }
            }
            return false;
        }
       
        //Create Student
        public void CreateStudent(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student id: ");
            int id = int.Parse(Console.ReadLine());
           
            if (CheckStudentId(students, id))
            {
                Console.WriteLine("Id already exist!");
            }
            else
            {
                Console.WriteLine("Enter Student Name: ");
                string name = Console.ReadLine();
                // ID does not exist, so add the student
                students.Add(new Student(id, name));
                Console.WriteLine("Student Added Successfully");
            }
            
        }

        //Update Student
        public void StudentUpdate(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student Id: ");
            int userId = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int iterator = 0; iterator < students.Count; iterator++)
            {
                if (students[iterator].StudentId == userId)
                {
                    Console.WriteLine("Enter Student Id: ");
                    int newId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Student Name: ");
                    string newName = Console.ReadLine();

                    students[iterator] = new Student(newId, newName);
                    Console.WriteLine("Student Details Updated Successfully");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Id doesn't exist");
            }
        }

        //Delete Student
        public void StudentDelete(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Student Id: ");
            int userId = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int iterator = 0; iterator < students.Count; iterator++)
            {
                if (students[iterator].StudentId == userId)
                {
                    students.RemoveAt(iterator);
                    Console.WriteLine("Student Details Deleted Successfully");
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("ID doesn't exist");
            }
        }

        public static bool CheckProfessorId(List<Professor> professors, int id)
        {
            foreach (Professor professor in professors)
            {
                if (professor.ProfessorId == id)
                {
                    return true;
                }
            }
            return false;
        }
        //Create Professor
        public void AddProfessor(List<Professor> professors)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Professor id: ");
            int id = int.Parse(Console.ReadLine());
            

            if (CheckProfessorId(professors, id))
            {
                Console.WriteLine("Id already exist!");
            }
            else
            {
                Console.WriteLine("Enter Student Name: ");
                string name = Console.ReadLine();
                // ID does not exist, so add the professor
                professors.Add(new Professor(id, name));
                Console.WriteLine("Professor Added Successfully");
            }
        }

        //Update Professor
        public void ProfessorUpdate(List<Professor> professors)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Professor Id: ");
            int userId = int.Parse(Console.ReadLine());

            // Check if the professor ID exists
            if (CheckProfessorId(professors, userId))
            {
                // If ID exists, find the professor and update details
                for (int iterator = 0; iterator < professors.Count; iterator++)
                {
                    if (professors[iterator].ProfessorId == userId)
                    {
                        Console.WriteLine("Enter New Professor Id: ");
                        int newId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter New Professor Name: ");
                        string newName = Console.ReadLine();

                        professors[iterator] = new Professor(newId, newName);
                        Console.WriteLine("Professor Details Updated Successfully");
                        break; 
                    }
                }
            }
            else
            {
                Console.WriteLine("Id doesn't exist");
            }
        }


        //Delete Professor
        public void ProfessorDelete(List<Professor> professors)
        {
            Console.WriteLine();
            Console.WriteLine("Enter Professor Id: ");
            int userId = int.Parse(Console.ReadLine());

            // Check if the professor ID exists
            if (CheckProfessorId(professors, userId))
            {
                // Find and remove the professor with the given ID
                for (int iterator = 0; iterator < professors.Count; iterator++)
                {
                    if (professors[iterator].ProfessorId == userId)
                    {
                        professors.RemoveAt(iterator);
                        Console.WriteLine("Professor Details Deleted Successfully");
                        return; 
                    }
                }
            }
            else
            {
                Console.WriteLine("ID doesn't exist");
            }
        }

    }
}    
