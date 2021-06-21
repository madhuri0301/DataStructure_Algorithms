using System;

namespace DataStructureAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Data Structure Algorithm Problems");

            int []array = { 22, 85, 43, 54, 11, 32 }; //initializing Parameters 
            BubbleSort bs = new BubbleSort();
            bs.bubblesort(array);
            Console.WriteLine("Sorted array");
            bs.printsortedarray(array); 
        }
    }
}
