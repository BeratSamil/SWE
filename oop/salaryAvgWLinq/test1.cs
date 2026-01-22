using System;
using System.Collections.Generic;
using System.Linq;


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

        public int Position
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
        
        

        static int getNum()
        {
            Random random = new Random();
            return random.Next(18, 60);
        }

        public Student(string pname, int pgrade, string pfaculty, bool pfinished)
        {
            name = pname;
            grade = pgrade;
            faculty = pfaculty;
            grade = getNum();
            pfinished = false;
        }
        
        public virtual void SetRise(double percent)
        {
            salary = Salary*(1.0+percent/100.0);
        }
        
        public static void ShowEmployess(List<Employee> employees)
        {
        foreach (Employee emp in employees)
            {
                string type = emp.GetType().ToString();
                int pos = type.IndexOf('.');
				type = type.Substring(pos+1,5);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", emp.Name, emp.Position, Math.Round(emp.Salary,2), emp.Age, type);
            }
        }
    } //The end of class Employee
    
    //------------

    public class Manager : Employee
    {   
        public Manager (string pname, string pposition, double psalary, string ptitle) : base(pname, pposition, psalary)
        {
            Boss = true;
            Title = ptitle;
        }
        
        private string title;
        
        public  string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        public override void SetRise(double percent)
        {
            Salary = Salary*(1.0+percent/100.0);
            Salary += 2000;
        }
        
    } //The end of class Manager


    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Taha", "IT Engineer", 15000));
            employees.Add(new Employee("Emir", "Military", 80000));
            employees.Add(new Employee("Ayşe", "Doctor  ", 50000));
            employees.Add(new Employee("Mehmet", "Teacher  ", 20000));
            employees.Add(new Employee("Elif", "Designer", 30000));
            Manager manager = new Manager("Adam", "Designer", 80000, "CEO");
            employees.Add(manager);
            
            //List<Manager> managers = new List<Manager>();
            
            
            Console.WriteLine("\n\n-------------The list of employees------------\n");
            Employee.ShowEmployess(employees);
            double ortalamaMaas = employees.Average(e => e.Salary);
            Console.WriteLine($"\nOrtalama Maas:{ortalamaMaas}");


            foreach (Employee emp in employees)
             {
                 emp.SetRise(20);
             }
                        
            Console.WriteLine("\n--------------After a 20% rise--------------\n");
            Employee.ShowEmployess(employees);

            ortalamaMaas = employees.Average(e => e.Salary);
            Console.WriteLine($"\nOrtalama Maas After Rise:{ortalamaMaas}");


            
            Console.WriteLine("\n--------------Info about Manager--------------\n");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", manager.Name, manager.Position, Math.Round(manager.Salary,2), manager.Age, manager.Title);
        }// The end of Main
            
    } // The end of class Program
}
