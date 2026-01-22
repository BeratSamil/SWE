using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;


namespace Csharpders
{
    //--------
    public class Student
    {
        private string name;
        private int grade;
        private string faculty;
        private bool finished;
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public bool Finished
        {
            get { return finished; }
            set { finished = value; }
        }
        
        public int getScolarship()
        {
            int scolarship;
            if (this.Grade > 50)
            {
                scolarship = 1000;
            }
            else
            {
                scolarship = 500;
            }

            return scolarship;
        }

        static int getNum()
        {
            Random random = new Random();
            return random.Next(18, 60);
        }

        public Student(string pname, int pgrade, string pfaculty,bool pfinished)
        {
            name = pname;
            grade = pgrade;
            faculty = pfaculty;
            finished=pfinished;
            //finished = false;
        }
        
        // public virtual void SetRise(double percent)
        // {
        //     salary = Salary*(1.0+percent/100.0);
        // }
        
        public static void ShowEmployess(List<Student> students)
        {
        foreach (Student std in students)
            {
                string type = std.GetType().ToString();
                int pos = type.IndexOf('.');
				type = type.Substring(pos+1,5);
                if (std.Finished==true)
                {
                    type="Gradudate";
                }
                else if (std.Finished==false)
                {
                    type="Student";
                }
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t ", std.Name, std.Grade,std.Faculty,type );
            }
        }
    } //The end of class Employee
    
    //------------

    // public class GradStudent : Student
    // {   
    //     public GradStudent (string pname, int pgrade, string pfaculty, string ptitle) : base(pname, pgrade, pfaculty, pfinished)
    //     {
    //         Finished = true;
    //         Title = ptitle;
    //     }
        
    //     private string title;
        
    //     public  string Title
    //     {
    //         get { return title; }
    //         set { title = value; }
    //     }

    // } //The end of class GradStudent


    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Taha", 90, "Informatics",false));
            students.Add(new Student("Emir", 70, "Fine Arts",false));
            students.Add(new Student("Ayşe", 60, "Architecture",true));
            students.Add(new Student("Mehmet", 80, "Philosophy",true));
            students.Add(new Student("Elif", 88, "Biology",true));
            
            //students.Add(manager);
            
            //List<Manager> managers = new List<Manager>();
            
            
            Console.WriteLine("\n\n-------------The list of students------------\n");
            Student.ShowEmployess(students);
            
            

            // foreach (Employee emp in employees)
            //  {
            //      emp.SetRise(20);
            //  }
                        
            // Console.WriteLine("\n--------------After a 20% rise--------------\n");
            // Employee.ShowEmployess(employees);

            // ortalamaMaas = employees.Average(e => e.Salary);
            // Console.WriteLine($"\nOrtalama Maas After Rise:{ortalamaMaas}");


            
            // Console.WriteLine("\n--------------Info about Manager--------------\n");
            // Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", manager.Name, manager.Position, Math.Round(manager.Salary,2), manager.Age, manager.Title);
        }// The end of Main
            
    } // The end of class Program
}