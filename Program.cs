using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDOperations.Models;

public class Program
{
    public static void Main(string[] args)
    {
        CollegeDetails college = new CollegeDetails(1, "D.M.C.E.");

        //Add Departments
        college.departments.AddRange(new[]
        {
            new Department(1, "C.S."),
            new Department(2, "I.T."),
            new Department(3, "M.E"),
            new Department(4, "E.X.T.C.")
        });

        // Add professors
        college.professors.AddRange(new[]
        {
            new Professor(1001, "Miss Simi"),
            new Professor(1002, "Mrs Philomina"),
            new Professor(1003, "Mr Akshay"),
            new Professor(1004, "Mr Sunil")
        });

        // Add students
        college.students.AddRange(new[]
                {
            new Student(101, "Pranjal"),
            new Student(201, "Kavya"),
            new Student(301, "Nisha"),
            new Student(401, "Mandira")
        });

        MainMenu menu = new MainMenu();
        menu.Menu(college, college.students, college.professors, college.departments);
    
    }
}