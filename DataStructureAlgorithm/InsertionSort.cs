using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
    public class InsertionSort
    {
		public void insertion(int[] arr1)
		{
			for (int i = 1; i < arr1.Length; i++)
			{
				int temp = arr1[i];
				int j = i - 1;
				while (j >= 0 && arr1[j] > temp)
				{
					arr1[j + 1] = arr1[j];
					j = j - 1;
				}
				arr1[j + 1] = temp;
			}          
		}
		public void printsortedarray(int[] arr1) //Method To Use Sorted Array
		{
			int n = arr1.Length;
			for (int i = 0; i < n; ++i)
				Console.WriteLine(arr1[i] + " ");
		}
	}
}
