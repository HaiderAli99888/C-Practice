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
                Salary = 3000
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

            Dictionary<int, Customr> dictionaryCustomers = new Dictionary<int, Customr>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);


            foreach (KeyValuePair<int, Customr> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                Customr cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("--------------------------------");
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
