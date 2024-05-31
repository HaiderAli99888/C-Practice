using System;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Runtime.Serialization;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the numerator: ");
        int Numerator;
        bool IsNumeratorSuccessfull = int.TryParse(Console.ReadLine(), out Numerator);
        if (IsNumeratorSuccessfull)
        {
            Console.WriteLine("Please enter the Denominator: ");
            int Denominator;
            bool IsDenominatorSuccessfull = int.TryParse(Console.ReadLine(), out Denominator);
            if (IsDenominatorSuccessfull && Denominator != 0)
            {
                int result = Numerator / Denominator;
                Console.WriteLine(result);
            }
            else if(Denominator == 0 || !IsNumeratorSuccessfull)
                {
                    Console.WriteLine("Please enter a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
                
            
        }
        else
        {
            Console.WriteLine("Please enter a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
        }
    }

}