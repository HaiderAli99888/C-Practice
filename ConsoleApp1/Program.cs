using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;
using ConsoleApp1;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Haider
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee with Id = 2: " + company[2]);
            company[1] = "Haider";
            Console.WriteLine("Name of Employee with Id = 1: " + company[1]);

        }

    }
    public class Employee
    {
        public int EmployeeId { get; set; }   
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        public List<Employee> listEmployees= new List<Employee>();
        public Company()
        {
            listEmployees.Add(new Employee { EmployeeId=1 ,Name="mack",Gender="MALE" });
            listEmployees.Add(new Employee { EmployeeId = 2, Name = "mack2", Gender = "MALE" });
            listEmployees.Add(new Employee { EmployeeId = 3, Name = "mack3", Gender = "MALE" });
            listEmployees.Add(new Employee { EmployeeId = 4, Name = "mack4", Gender = "MALE" });
            listEmployees.Add(new Employee { EmployeeId = 5, Name = "mack5", Gender = "MALE" });
        }
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name=value;

            }
        }
    }

  
}

