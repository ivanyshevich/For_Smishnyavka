using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static int[] arr;
    static int sum = 0;
    static Stopwatch stopwatch = new Stopwatch();

    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr = new int[n];

        stopwatch.Start();
        PopulateArray(0, n);
        Task.WaitAll();
        stopwatch.Stop();

        Console.WriteLine("Array elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\n\nSum of array elements: " + sum);
        Console.WriteLine("Time taken to populate array: " + stopwatch.Elapsed.TotalMilliseconds + " milliseconds");
        Console.ReadKey();
    }

    static void PopulateArray(int start, int end)
    {
        if (end - start == 1)
        {
            Task.Run(() =>
            {
                arr[start] = new Random().Next(100);
                sum += arr[start];
            });
            return;
        }

        int mid = (start + end) / 2;
        Task task1 = Task.Run(() => PopulateArray(start, mid));
        Task task2 = Task.Run(() => PopulateArray(mid, end));
        Task.WaitAll(task1, task2);
    }
}