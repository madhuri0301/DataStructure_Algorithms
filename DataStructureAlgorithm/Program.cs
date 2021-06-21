using System;

namespace DataStructureAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Data Structure Algorithm Problems");
            Console.WriteLine("Enter Your Choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    int[] array = { 22, 85, 43, 54, 11, 32 }; //initializing Parameters 
                    BubbleSort bs = new BubbleSort();
                    bs.bubblesort(array);
                    Console.WriteLine("Sorted array");
                    bs.printsortedarray(array);
                    break;

                // Passing a value to the array
                case 2:
                    String[] arr = { "Harshu", "Mansi", "Pranali" , "Priyanka", "Riya" };
                    String Name = "Riya";
                    int result = BinarySearch.binarySearch(arr, Name);

                    // Checking the value is present or not
                    if (result == -1)
                        Console.WriteLine("Name is not Present");

                    else
                        Console.WriteLine("Name is Present at " + " Position "  + result);
                    break;
            }
        }
    }
}
