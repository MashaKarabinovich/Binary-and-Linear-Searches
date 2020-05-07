using System;

namespace linearBinarySearches
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an array size:");
            int size = Int32.Parse(Console.ReadLine());

            int[] number = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("");
                Console.Write("Please enter your integer values:");
                number[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Arrays Value:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("" + number[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Target Value: 3");


            Console.WriteLine("Linear Search Comparisons: " + linearSearch(number));
            Console.WriteLine("Binary Search Comparisons: " + binarySearch(number, 3));

            Console.ReadLine();

        }

        public static int linearSearch(int[] array)
        {
            int value = 0;
            int find = 3;
            foreach (int temp in array)
            {
                value++;
                if (temp == find)
                {
                    return value;
                }

            }

            return value;

        }
        public static int binarySearch(int[] array, int find)
        {
            bool found = false;
            int value = 0;
            int low = 0;
            int high = array.Length;
            int mid = 0;
            while (!found)
            {
                value++;
                mid = (low + high) / 2;
                if (find == array[mid])
                    found = true;
                else if (find < array[mid])
                    high = mid;
                else
                    low = mid;
                if (low >= high - 1)
                    return value;
            }
            return value;
        }
    }
    }
}
