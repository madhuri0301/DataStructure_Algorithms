using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
    class BubbleSort
    {
		public void bubblesort(int []array) //Method To Use BubbleSort
		{

			int n = array.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						int temp = array[j];
						array[j] = array[j + 1];
						array[j + 1] = temp;
					}
				}
			}
		}
		public void printsortedarray(int []array) //Method To Use Sorted Array
		{
			int n = array.Length;
			for (int i = 0; i < n; ++i)
                Console.WriteLine(array[i] + " ");
		}

	}
}
