using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 11; i++)
            //{
            //    Console.WriteLine($"{i}");
            //    i=i+1;
            //}

            // PRINT STAR PATTERN
            //Console.WriteLine("enter the number: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 10);

            //SUM OF NATURAL NUMBERS

            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine($"The sum of 5 natural numbers = {sum}");


            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 4-i; j++)
            //    {
            //       Console.WriteLine(" ");                    
            //    }

            //    for (int k = 1; k <= 10; k++)
            //    {
            //        Console.WriteLine(k);
            //    }
            //    Console.WriteLine();
            //}

            //BREAK
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //CONTINUE

            //for (int i = 10; i <= 200; i = i + 10)
            //{
            //    if (i % 20 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //    if (i > 190)
            //    {
            //        break;
            //    }
            //}


            // SWITCH CASE 

            //Console.WriteLine("Enter a number for a day : ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //case 0:
            //    Console.WriteLine("Its a Sunday");
            //    break;

            //case 1:
            //    Console.WriteLine("Its a Monday");
            //    break;
            //case 2:
            //    Console.WriteLine("Its a Tuesday");
            //    break;
            //case 3:
            //    Console.WriteLine("Its a Wednesday");
            //    break;
            //case 4:
            //    Console.WriteLine("Its a Thursday");
            //    break;
            //case 5:
            //    Console.WriteLine("Its a Friday");
            //    break;
            //case 6:
            //    Console.WriteLine("Its a Saturday");
            //    break;
            //    default:
            //        Console.WriteLine("There is error");
            //        break;

            //}

            //ODD OR EVEN USING SWITCH CASE

            //Console.WriteLine("Enter the number : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //switch (n % 2)
            //{
            //    case 0:
            //        Console.WriteLine("even ");
            //        break;

            //    case 1:
            //        Console.WriteLine("odd");
            //        break;

            //    default:
            //        Console.WriteLine("There is error");
            //        break;

            //}


            //ARRAY

            //int[] num = { 1, 2, 3, 4, 5 };

            //  string[] day = { "monday", "Tuesday" };
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //  Console.WriteLine(day[i]);
            //}



            // PRINT HTE NUMBERS FROM 1 - 10 IN A PYRAMID FORM
            Console.WriteLine("enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine() );
            int space = rows ;
            int x = 0;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(++x  + " "  );
                  
                }
                Console.WriteLine("\n");
                space = space - 1;
            }
            Console.ReadLine();
        }
    }
}
