using System;
namespace BubbleSort
{
    class MySort
    {
        static void Main(string[] args)
        {
            int[] data = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= data.Length - 2; j++)
            {
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int d in data)
                Console.Write(d + " ");
            Console.Read();
        }
    }
}