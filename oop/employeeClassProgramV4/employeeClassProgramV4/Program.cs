using System;
using System.Collections.Generic;

namespace employeeClassProgram
{

    public class Employee
    {
        private string _name;
        private string _position;
        private double _salary;
        private int _age;
        public static int ctr = 0;


        static int getNum()
        {
            Random random = new Random();
            int number;
            number = random.Next(18, 65);
            return number;
        }

        public Employee(string name, string pos, double sal)
        {
            _name = name;
            _position = pos;
            _salary = sal;
            _age = getNum();
            ctr += 1;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string position
        {
            get { return _position; }
            set { _position = value; }
        }
        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }


        public static void showEmp(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", employees[i].name, employees[i].position, employees[i].salary, employees[i].age);
            }
        }

    }





    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            Employee employee1= new("Berat","IT",99999);
            Employee employee2 = new("Taha", "IT", 999999);


            Console.WriteLine("Name:{0}, Pos:{1} salary:{2}, {3} ",employee1.name,employee1.position,employee1.salary, employee1.age);
            Console.WriteLine("Name:{0}, Pos:{1} salary:{2}, {3} ", employee2.name, employee2.position, employee2.salary, employee2.age);*/

            //Employee[] employees = new Employee[4];

            List<Employee> employeeList = new List<Employee>();
            int numOfEmp = 5;

            for (int i = 0; i < numOfEmp; i++)
            {
                Employee emp = new Employee("emp" + i.ToString(), "HR", 99999);
                employeeList.Add(emp);

            }



            Employee.showEmp(employeeList);

            
            Console.WriteLine("We have {0} employees in our company", Employee.ctr);
        }
    }
}
