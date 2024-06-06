using System.Numerics;

namespace Unidim_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8, 9, 10 };

            int lengthArray3 = array1.Length + array2.Length;

            int[] array3 = new int[lengthArray3];

            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
            }

            DisplayArray(array3);

            for (int i = 0; i < array2.Length; i++)
            {
                array3[i+5] = array2[i];
            }

            DisplayArray(array3);

        }

        public static void DisplayArray(int[] array)
        {
            foreach (int arr in array)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
        }
    }
}