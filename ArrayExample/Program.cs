using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array members:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();

            // Fill the array with random integers (positive and negative)
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }

            Console.WriteLine("The array is: " + string.Join(", ", arr));

            // Count the sum of the first 4 negative integers within the array
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && count < 4)
                {
                    sum += arr[i];
                    count++;
                }
            }

            Console.WriteLine("The sum of the first 4 negative integers in the array is: " + sum);
        }
    }
}