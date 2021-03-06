using System;

namespace Array
{
    class Program
    {
        static void Main()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(" Prime numbers:");
            int j;
            for (int i = 0; i < array.Length; i++)
            {
                for (j = 2; j < array[i]; j++)
                    if ((array[i] % j == 0))
                    {
                        break;
                    }
                if (j == array[i])
                {
                    Console.WriteLine("{0}", +array[i]);
                }

            }
            Console.WriteLine("Even Numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                    if ((array[i] % 2 == 0))
                    {
                        Console.WriteLine("{0}", +array[i]);
                    }
            }
        }
    }
}
