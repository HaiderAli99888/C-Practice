using System;
using System.Reflection.Metadata.Ecma335;

<<<<<<< Updated upstream
namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            string userChoice;
            string againChoice;
            int totalPrice = 0;
            do
            {
               
                do
                {
                    Console.Write("Please enter coffee size, Sir, : 1 for Small, 2 for Medium, 3 for Large: ");
                    userChoice = (Console.ReadLine());

                    switch (userChoice)
                    {
                        case "1":
                            totalPrice = totalPrice + 1;
                            break;
                        case "2":
                            totalPrice = totalPrice + 2;
                            break;
                        case "3":
                            totalPrice = totalPrice + 3;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid size");
                            break;
                    }
                }
                while (userChoice != "1" && userChoice != "2" && userChoice != "3");

                do {
                    Console.WriteLine("Do you want another coffee? ");
                    againChoice = Console.ReadLine().ToUpper();
                    switch (againChoice)
                    {
                        case "YES":
                            break;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                   
                }
                while(againChoice!="YES" && againChoice != "NO");
           
            }
            while (againChoice != "NO");
            Console.WriteLine("Total cost is {0}$", totalPrice);
        }
    }
}
=======
class program
    {
    static void Main(string[] args)
    {
      List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID= 101, Name="Mary", Salary=5000,Experience=5});
        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });
        IsPromotable isPromotable = new IsPromotable(criteria);  

        Employee.promote(empList, isPromotable);
    }
    public static bool criteria(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;

        }
        else
        {
return false;
        }
    }

}

delegate bool IsPromotable(Employee emp);
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void promote(List<Employee> employeeList, IsPromotable yesorno)
    {
        foreach(Employee employee in employeeList)
        {
            if (yesorno(employee))
            {
                Console.WriteLine("{0}, Promoted", employee.Name);
            }
        }
    }
}



>>>>>>> Stashed changes
