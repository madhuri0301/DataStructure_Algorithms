using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
    public class BinarySearch
    {
		public static int binarySearch(String[] arr, String Name)
		{
			int a = 0, b = arr.Length - 1;
			while (a <= b)
			{
				int m = a + (b - a) / 2;

				int res = Name.CompareTo(arr[m]);

				// Check if x is present at mid
				if (res == 0)
					return m;

				// If x greater, ignore left side
				if (res > 0)
					a = m + 1;

				// If x is smaller, ignore right side
				else
					b = m - 1;
			}

			return -1;
		}


	}
}
