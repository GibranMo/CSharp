/* Gibran Morales 008959470  - CMPE 137  - Feb 21 2014 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
           
            try
            {
                Console.WriteLine("Addition of TWO Numbers");
                Console.WriteLine();
                Console.WriteLine("Enter 1st number:");
                int temp1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number:");
                int temp2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result is:{0} ", temp1 + temp2);

            }
            catch (Exception error)
            {
                //Console.WriteLine("format error has occurred");
                Console.WriteLine(error.Message);
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine("Division of two numbers");
                Console.WriteLine();
                Console.WriteLine("Enter first number: ");
                double n1 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter 2nd number: ");
                double n2 = Convert.ToInt64(Console.ReadLine());

                double res = n1 / n2;
                Console.WriteLine("Result is: {0}", res);
                
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Exception caught:  {0}", error);
            }

            Console.WriteLine();
            try
            {
                Console.WriteLine("Multiplication of Two Numbers");
                Console.WriteLine();
                Console.WriteLine("Enter first number: ");
                long num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                long num2 = Convert.ToInt32(Console.ReadLine());
                long result = num1 * num2;
                Console.WriteLine("Result is: {0} ", result);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine("Subtraction of Two Numbers");
                Console.WriteLine("Enter 1st number: ");
                int sub1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd number: ");
                int sub2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result is: {0}", sub1 - sub2);
            }
            catch (FormatException e)
            {
                Console.WriteLine("*(changed) Some Exception occurded:  {0} ");
            }
            Console.WriteLine();
            try
            {               
                Random rand = new Random();
                byte  [] array = new byte  [5];
                rand.NextBytes(array);
                Console.WriteLine("Select an index no. 0 to 4 from the array ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your random number is: {0}  ", array[num] );
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception caught:  {0} ", e);
            }

            Console.Read();
        }
    }

}