using System;

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