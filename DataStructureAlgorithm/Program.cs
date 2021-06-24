using System;

namespace DataStructureAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Data Structure Algorithm Problems");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Binary Search");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Anagram Sort");
            Console.WriteLine("5. Merge Sort");      
            Console.WriteLine("6. Prime Number");

            Console.WriteLine("Enter Your Choice"); //Enter Your Choice for operation You Want To Perform
            int ch = Convert.ToInt32(Console.ReadLine()); //For Input
            switch (ch) //Switch Cases For Selecting Operations
            {
                //Bubble Sort
                case 1:
                    int[] array = { 22, 85, 43, 54, 11, 32 }; //initializing Parameters 
                    BubbleSort bs = new BubbleSort();
                    bs.bubblesort(array);
                    Console.WriteLine("Sorted array");
                    bs.printsortedarray(array);
                    break;

                // Passing a value to the array
                //Binary Search
                case 2:
                    String[] arr = { "Harshu", "Mansi", "Pranali", "Priyanka", "Riya" };
                    String Name = "Riya";
                    int result = BinarySearch.binarySearch(arr, Name);

                    // Checking the value is present or not
                    if (result == -1)
                        Console.WriteLine("Name is not Present");

                    else
                        Console.WriteLine("Name is Present at " + " Position " + result);
                    break;
                
                //Insertion Sort
                case 3:
                    int[] arr1 = { 3, 1, 12, 6, 33, 22, 45 };
                    InsertionSort insertion = new InsertionSort();
                    insertion.insertion(arr1);
                    insertion.printsortedarray(arr1);
                    break;

                //Anagram Sort
                case 4:
                    // array of two strings
                    char[] str1 = { 'm', 'a', 'd', 'a', 'm' };
                    char[] str2 = { 'm', 'a', 'd', 'a', 'm' };

                    if (Anagram.checkAnagram(str1, str2))
                        Console.WriteLine("The Two Strings are" + " Anagram of each other");

                    else
                        Console.WriteLine("The Two Strings are Not" + " Anagram of each other");
                    break;

                //Merge SOrt
                case 5:
                    int [] arr2 = { 88, 5, 27, 46, 39, 58, 72 };

                    Merge merge = new Merge();
                    Console.WriteLine("Given array-");
                    merge.PrintArray((arr2));

                    merge.Sort(arr2, 0, arr2.Length - 1);

                    Console.WriteLine("\n Sorted array-");
                    merge.PrintArray((arr2));
                    break;

                //Prime Sort
                case 6:
                    PrimeNumber.Print();
                    break;


            }
        }
    }
}
