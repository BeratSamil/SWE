namespace employeeClassProgram
{

    public class Employee
    {
        public string _name;
        public string _position;
        public double _salary;


        public Employee(string name, string pos, double sal)
        {
            _name = name;
            _position = pos;
            _salary = sal;
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee employee1= new("Berat","IT",999999);
            Employee employee2 = new("Taha", "IT", 999999);

            Console.WriteLine("Name:{0}, Pos:{1} salary:{2} ",employee1._name,employee1._position,employee1._salary);
            Console.WriteLine("Name:{0}, Pos:{1} salary:{2} ", employee2._name, employee2._position, employee2._salary);


        }
    }


    
}
