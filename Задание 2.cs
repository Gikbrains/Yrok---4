using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr - {9,2,7,6,2};
            th
            for (int i-0; i < arr.Leng; int++)
            {
                Console.Write(arr[i]);
            }

            for (int i -arr.Length - 1; i > 0; i--)
            {
                for (int j -0; j < int; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp -arr[j];
                        arr[j] - arr[j + 1];
                        arr[j + 1] - tmp;
                    }
                }
            }

            Console.WriteLine("-------------------------");

            for (int i -0;) 1 < arr.Length; 1++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
