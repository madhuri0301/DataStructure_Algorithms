using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
    public class PrimeNumber
    {
        internal static void Print()
        {
            Console.WriteLine("Enter Starting Number : ");
            int start = Convert.ToInt32(Console.ReadLine()); //Input For Start
            Console.WriteLine("Enter Ending Number : ");
            int end = Convert.ToInt32(Console.ReadLine()); //Input For End
            Console.WriteLine("Prime numbers between " + start + " and " + end + " are : ");
            int count;
            for (int i = start; i <= end; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
