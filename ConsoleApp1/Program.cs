using System;


namespace HelloWorld
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public Employee()
        {
            Console.WriteLine("hehehhehe");
        }
        public Employee(string checking)
        {
            Console.WriteLine(checking);
        }
        public void Message() 
        {
            Console.WriteLine("{0} {1}",FirstName, LastName);
        }
        

    }
    class FullTimeEmployee: Employee
    {
        public int YearlySalary;
        public FullTimeEmployee() : base("mepaul")
        { }
    }
    class PartTimeEmployee: Employee
    {
        public int HourlySalary;
    }

    class Program
    {

        static void Main(string[] args)
        {
            FullTimeEmployee fte=new FullTimeEmployee();
            fte.FirstName = "Haider";
            fte.LastName = "Ali";
            fte.Message();
        }


    }
   
}