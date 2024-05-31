using System;
using System.IO;

namespace CustomExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Please enter first number: ");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter second number: ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\samplefiles\9log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        Console.WriteLine("There is a problem, please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " not found", ex);
                    }
                }
            }
            catch (Exception ep)
            {

                Console.WriteLine("Current Exception = {0}", ep.GetType().Name);
                if (ep.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", ep.InnerException.GetType().Name);
                }
            }
        }
    }
}

