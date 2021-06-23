using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
	public class Anagram
	{
		public static bool checkAnagram(char[] str1, char[] str2)
		{
			int n1 = str1.Length;
			int n2 = str2.Length;

			// If length of both strings are not same, then they cannot be anagram
			if (n1 != n2)
				return false;

			// Sort both strings
			Array.Sort(str1);
			Array.Sort(str2);

			// Compare sorted strings
			for (int i = 0; i < n1; i++)
				if (str1[i] != str2[i])
					return false;

			return true;
		}
	}
}
