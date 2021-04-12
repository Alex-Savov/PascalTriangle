using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] temp = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] array = new int[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == 0)
                    {
                        array[j] = 1;
                    }
                    else
                    {
                        array[j] = temp[j] + temp[j - 1];
                       
                    }
                }
                Console.Write(string.Join(' ', array));

                for (int k = 0; k < array.Length; k++)
                {
                    temp[k] = array[k];
                }
                Console.WriteLine();
            }
        }
    }
}
