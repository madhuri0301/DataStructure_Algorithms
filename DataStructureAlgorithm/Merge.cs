using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
	public class Merge
	{ 
		public void merge(int[] arr2, int l, int m, int r)
		{
			int num1 = m - l + 1;
			int num2 = r - m;

			int[] Left = new int[num1];
			int[] Right = new int[num2];

			// Copies value to temp arrays
			for (int i = 0; i < num1; ++i)
			
				Left[i] = arr2[l + i];
			
			for (int j = 0; j < num2; ++j)
			
				Right[j] = arr2[m + 1 + j];


			// Initial indexes of first and second sub arrays
			int x = 0, y = 0;
			// Initial index of merged array
			int k = l;
			while (x < num1 && y < num2)
			{
				if (Left[x] <= Right[y])
				{
					arr2[k] = Left[x];
					x++;
				}
				else
				{
					arr2[k] = Right[y];
					y++;
				}
				k++;
			}

			// Copy remaining elements of L[] if any
			while (x < num1)
			{
				arr2[k] = Left[x];
				x++;
				k++;
			}

			// Copy remaining elements of R[] if any
			while (y < num2)
			{
				arr2[k] = Right[y];
				y++;
				k++;
			}
		}

		// Main function that sorts arr[l..r] using
		public void Sort(int []arr2, int l, int r)
		{
			if (l < r)
			{
				// Find the middle point
				int m = l + (r - l) / 2;

				// Sort first and second halves
				Sort(arr2, l, m);
				Sort(arr2, m + 1, r);

				// Merge the sorted halves
				merge(arr2, l, m, r);
			}
		}
		public void PrintArray(int[] arr2)
		{
			int n = arr2.Length;
			for (int i = 0; i < n; ++i)
				Console.WriteLine(arr2[i] + " ");
		}
	}
}
