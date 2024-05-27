using System;
using System.Reflection.Metadata.Ecma335;

class program
    {
    static void Main(string[] args)
    {
      List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID= 101, Name="Mary", Salary=5000,Experience=5});
        empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
        empList.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });
          
        IsPromotable isPromotable= new IsPromotable(PromoteNew);
        Employee.promote(empList, isPromotable);

    }
    public static bool PromoteNew(Employee emp)
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

    public static void promote(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach(Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine("{0}, Promoted", employee.Name);
            }
        }
    }
}