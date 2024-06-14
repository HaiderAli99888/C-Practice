
using System;
using System.Threading;

namespace MyFirstProgram
{
    public delegate void CallBackDelegate(int sum);
    class Program
    {
        public static void Print (int sum)
        {
            Console.WriteLine("Sum is {0}",sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int target= int.Parse(Console.ReadLine());
            CallBackDelegate callBack = new CallBackDelegate(Print);
            Number number= new Number(target,callBack);
            Thread newThread= new Thread(number.Nothing) ;
            newThread.Start();
        }
       
    }
    class Number
    {
         int _target;
        CallBackDelegate _callBackDelegate; 

        public Number(int target, CallBackDelegate callBackDelegate)
        {
            this._target = target;
            this._callBackDelegate = callBackDelegate;
        }
        public void Nothing()
        {
            int sum = 0;
           for (int i = 0; i <= _target; i++)
             {
                sum = sum + i;
            }
           if ( _callBackDelegate != null )
             _callBackDelegate(sum);
            
            
        }
    }
}