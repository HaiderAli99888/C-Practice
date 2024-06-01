using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
    {
    static void Main(string[] args)
    {
        Customer[] customer = new Customer[3];
        customer[0] = new Customer { Name= "Mark", Gender= Gender.Male};
        customer[1] = new Customer { Name = "Mary", Gender = Gender.Female };
        customer[2] = new Customer { Name = "Sam", Gender = Gender.Unknown };
        foreach(Customer cust in customer)
        {
            Console.WriteLine("Name = {0} and Gender = {1}",cust.Name,GenderConverter(cust.Gender));
        }
    }
    public static string GenderConverter(Gender gender) 
    {
        switch (gender)
        {
            case Gender.Male:
                return "male";
                case Gender.Female:
                return "Female";
                case Gender.Unknown:
                return "unknown";
            default:
                return "invalid";
        }
    }
}
public enum Gender
{
    Unknown,
    Male,
    Female
}
public class Customer
{
    public string Name { get; set; }
    public Gender Gender {  get; set; }
}
