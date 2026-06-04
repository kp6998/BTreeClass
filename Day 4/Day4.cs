using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeClass.Day_4
{
    internal class Day4
    {
        //Conditional statements
        public void Main()
        {
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();
            int age = Convert.ToInt16(input);

            //If statement
            //Console.WriteLine("If statement");
            //if (age >= 18)
            //{
            //    Console.WriteLine("Eligible");
            //    return;
            //}
            //Console.WriteLine("Not eligible");

            //If else statement
            //Console.WriteLine("If else statement");
            //if (age >= 18)
            //{
            //    Console.WriteLine("Eligible");
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible");
            //}

            //Else if statement
            //if (age >= 18 && age <= 58)
            //{
            //    Console.WriteLine("Eligible to work, greater than 18 and less than 58");
            //}
            //else if (age > 58)
            //{
            //    Console.WriteLine("Not eligible, greater than 58");
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible, less than 18");
            //}

            //Nested If
            //if (age >= 18 && age <= 58)
            //{
            //    Console.WriteLine("Eligible to work, greater than 18 and less than 58");
            //}
            //else
            //{
            //    if (age > 58)
            //    {
            //        Console.WriteLine("Not eligible, greater than 58");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not eligible, less than 18");
            //    }
            //}

            //switch
            switch(age)
            {
                case 4:
                    Console.WriteLine("Baby");
                    break;

                case 10:
                    Console.WriteLine("Child");
                    break;

                case 18:
                    Console.WriteLine("Adult");
                    break;

                case 60:
                    Console.WriteLine("Senior Citizen");
                    break;

                default:
                    Console.WriteLine("Not defined");
                    break;
            }
        }
    }
}
