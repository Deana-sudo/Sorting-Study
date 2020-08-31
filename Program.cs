using System;

namespace Sorting
{
    class Program
    {
        static void bubbleSort(int[] arr)
        {
            bubbleSrot(arr, arr.Length - 1);
        }
        static void bubbleSrot(int[] arr, int last)
        {
            if (last > 0)
            {
                for (int i = 1; i <= last; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        swap(arr, i - 1, i);
                    }
                }
                bubbleSrot(arr, last - 1);
            }
        }
        static void swap(int[] arr, int source, int target)
        {
            int temp = arr[source];
            arr[source] = arr[target];
            arr[target] = temp;
        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
               
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1, 5, 6, 7, 8, 9, 0, 3 }; 

            // 1 5 6 7 8 0 3 9
            // 1 5 6 7 0 3 8 9
            // 1 5 6 0 3 7 8 9
            // 1 5 0 3 6 7 8 9
            // 1 0 3 5 6 7 8 9
            // 0 1 3 5 6 7 8 9
            // ----> ???????

            Console.WriteLine(arr.Length);

            printArray(arr);
            bubbleSort(arr);
            Console.WriteLine(); // 줄바꿈
            printArray(arr);
        }
    }
    class BubbleSort
    {

       

    }
}
