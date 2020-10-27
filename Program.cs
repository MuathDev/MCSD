using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {





            /*
             *get age from user   
             * then check  
             * if his age greater than 20 or equl  display statement You'er Adult 
             * if his age between 10 and 20 display statement your'er teenager
             * if his age liss than 10 display statement your'er baby
             */


            Console.WriteLine("Enter your age : ");

            /*
            string age = Console.ReadLine();
            // convernt input  to integer and return boolen type if not integer..
            if(int.TryParse(age,out int num))
            {

                if (num >= 20)
                {
                    Console.WriteLine("Your'er Adult");
                }
                else if (num>=10 && num<20)
                {
                    Console.WriteLine("Your'er Teenager");
                }
                else
                {
                    Console.WriteLine("Your'er stil Baby");
                }

            }
            else
            {
                Console.WriteLine("Please enter entiger number '..' ");
            }
            */




            // catch an error user input no integer type 
            try
            {
                // convernt input  to integer 
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 20)
                {
                    Console.WriteLine("Your'er Adult");
                }
                else if (age >= 10 && age < 20)
                {
                    Console.WriteLine("Your'er Teenager");
                }
                else
                {
                    Console.WriteLine("Your'er stil Baby");
                }

            }
            catch(Exception e)
            {


                Console.WriteLine(" yoo enter integer number only '..'");


            }




        }
    }
}
