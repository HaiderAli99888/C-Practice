using System;
using System.Collections.Generic;

namespace Haider
{
    class Program
    {
        public static void Main()
        {
            Customr customer1 = new Customr()
            {
                ID = 121,
                Name = "Ali",
                Salary = 5500
            };

            Customr customer2 = new Customr()
            {
                ID = 130,
                Name = "Ahmed",
                Salary = 6500
            };

            Customr customer3 = new Customr()
            {
                ID = 119,
                Name = "Mili",
                Salary = 4500
            };
        
            List<Customr> customerList = new List<Customr>();
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            Console.WriteLine("BEFORE SORT");
            foreach (Customr cust in customerList)
            {
                Console.WriteLine(cust.ID);
            }
            customerList.Sort();
            Console.WriteLine("AFTER SORT");
            foreach (Customr cust in customerList)
            {
                Console.WriteLine(cust.ID);
            }
          
            Console.WriteLine("bEFORE NAME SORTING");
            foreach (Customr cust in customerList)
            {
                Console.WriteLine(cust.Name);
            }
            Console.WriteLine("aFTER NAME SORTING");

            SortByName byName = new SortByName();
            customerList.Sort(byName);
            foreach (Customr cust in customerList)
            {
                Console.WriteLine(cust.Name);
            }
            Console.WriteLine("bEFORE NAME SORTING WITHOUT USING DELEGAT");
            foreach (Customr cust in customerList)
            {
                Console.WriteLine(cust.Salary);
            }
            customerList.Sort((x,y)=>x.Salary.CompareTo(y.Salary));
            Console.WriteLine("aFTER NAME SORTING USING DELEGATE");

            foreach (Customr cust in customerList)
            {
                Console.WriteLine(cust.Salary);
            }


        }
    }

    public class SortByName : IComparer<Customr>
    {   
        public int Compare(Customr x, Customr y)
            {
                return x.Name.CompareTo(y.Name);
            }
          
    }
    public class Customr:IComparable<Customr>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int CompareTo(Customr other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }
   

}
