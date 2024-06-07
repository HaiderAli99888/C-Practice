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
                Salary = 5000
            };

            Customr customer2 = new Customr()
            {
                ID = 140,
                Name = "Ahmed",
                Salary = 4500
            };

            Customr customer3 = new Customr()
            {
                ID = 119,
                Name = "Mili",
                Salary = 3500
            };

            Customr[] cus = new Customr[3];
                cus[0] = customer1;
            cus[1]= customer2;
            cus[2]= customer3;
            Dictionary<int, Customr> diss = cus.ToDictionary(cust => cust.ID, cust => cust);
            foreach(KeyValuePair<int, Customr> kvp in diss)
            {
                Customr info = kvp.Value;
                Console.WriteLine(info.Name);
            }
        }
    }

    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
