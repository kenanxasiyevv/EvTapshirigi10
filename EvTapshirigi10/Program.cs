﻿namespace EvTapshirigi10
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                    min = i;

            }
          Console.WriteLine(min);
            
         
        }
    }
}
