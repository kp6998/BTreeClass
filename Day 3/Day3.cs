using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeClass.Day_3
{
    internal class Day3
    {
        public void Main()
        {
            //Arthmetic Operators
            Console.WriteLine("Arthmetic Operators");
            int i = 0;
            i++;
            i++;
            Console.WriteLine(i);

            Console.WriteLine("For loop");
            for (int j = 5; j >= 0; j--)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("While loop");
            int k = 0;
            while (k < 5)
            {
                Console.WriteLine(k);
                k++;
            }

            //Comparison Operators
            Console.WriteLine("\nComparison Operators");
            int a = 10, b = 10;

            bool greater = a > b; // false
            bool lesser = a < b; // false
            bool equal = a == b; // true
            bool notEqual = a != b; // false
            bool greaterOrEqual = a >= b; // true
            bool lesserOrEqual = a <= b; // true

            Console.WriteLine($"a > b: {greater}");
            Console.WriteLine($"a < b: {lesser}");
            Console.WriteLine($"a == b: {equal}");
            Console.WriteLine($"a != b: {notEqual}");
            Console.WriteLine($"a >= b: {greaterOrEqual}");
            Console.WriteLine($"a <= b: {lesserOrEqual}");

            int atm = 10000;
            int bal = 1000;
            string inp = Console.ReadLine();
            int val = Convert.ToInt16(inp);

            if (val <= bal && val <= atm)
            {
                int afterWithdraw = atm - val; // 8500
                Console.WriteLine($"After Withdraw ATM bal: {afterWithdraw}");
                Console.WriteLine($"After Withdraw Acc bal: {bal - val}");
            }
            else if (val > atm)
            {
                Console.WriteLine("ATM has insufficient balance");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

            //Logical Operators
            Console.WriteLine("\nLogical Operators");

            if (1 == 1 && 1 == 1 && 1 == 1)
            {
                Console.WriteLine("Both conditions are true");
            }
            if (1 == 2 || 1 == 2 || 1 == 1)
            {
                Console.WriteLine("At least one condition is true");
            }
            if (!(1 != 1))
            {
                Console.WriteLine("Condition is false");
            }
            if ((1 == 1 && 1 == 1) || 1 == 2)
            {
                Console.WriteLine("Mixed conditions are true");
            }

            //Assignment Operators
            Console.WriteLine("\nAssignment Operators");

            int x = 10;
            x += 15; //==> x = x + 15; // 25
            x -= 7; //18
            x *= 2; //36
            x /= 6; //6
            x %= 4; //2
            x = 6;
            x &= 4; //4
            x = 6;
            x |= 4; //6
            x = 6;
            x ^=4; //2
            x = 6;
            x >>= 2; //1
            x = 6;
            x <<= 2; //24

            Console.WriteLine(x);


            //String
            Console.WriteLine("\nString");
            string str = "abcd";
            Console.WriteLine(str);
            str = str.ToUpper();
            Console.WriteLine(str);
            str = str.ToLower();
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            str = str + "efgh";
            str = string.Concat(str, "efgh");
            str += "efgh";
            Console.WriteLine(str);

            string str2 = "a";
            char[] chars = new char[1] { 'a' };

            if(chars.Length > 2)
            {

            }
            str2 = "abc";

            //Readline
            Console.WriteLine("\nRealine");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            input = input.ToUpper();
            Console.WriteLine(input);
        }

        void Test()
        {
            string a = "abc";
            Day3 d3 = new Day3();
            try
            {
                Console.WriteLine("aa");

            }
            catch
            {

            }
            finally
            {
                a = null;
            }
        }
    }
}
