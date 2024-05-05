using System;
using System.Threading.Tasks.Sources;

public class GradeAverage
{
 
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter Scores for average. Enter -1 to finish");
        int sum = 0;
        int count = 0;
        while (true)
        {
            Console.WriteLine("pLease enter score(0-20):");
            string input= Console.ReadLine();
            if (input =="-1")
                break;
            if(!int.TryParse(input, out int score) || score<0
                || score>20)
            {
                Console.WriteLine("Invalid Input");
                continue;
            }
            sum = sum + score;
            count++;
        }
         double average;
         if (count > 0)
         {
            average = (double)sum / count;
         }
         else
         {
            average = 0;
         }
        Console.WriteLine("The average score is: " + average);
        Console.Read();


    }
}

