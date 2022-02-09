using System;


namespace Day13Project5
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: Declare TWO 2-D arrays of size (2,2) and read values from user and print the sum of the two matrices
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.SumOfTwoArrays();
            Console.ReadLine();
        }
        void SumOfTwoArrays()
        {
            Console.Write(" Enter any number:- ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[arrayLength, arrayLength];
            int[,] arraySecond = new int[arrayLength, arrayLength];
            int[,] arraySum = new int[arrayLength, arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Your First Array:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(array[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + array[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine(" Enter Your Second Array");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    arraySecond[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("This is Your Second Array:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(arraySecond[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arraySecond[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("If you want to the array press (Y/N):");

            string userInput = Convert.ToString(Console.ReadLine());

            if (userInput.ToUpper() == "Y")
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        arraySum[i, j] = array[i, j] + arraySecond[i, j];
                    }
                }
                Console.WriteLine("Result is");
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(arraySum[i, j]);
                        }
                        else
                        {
                            Console.Write(" " + arraySum[i, j]);
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("************ Press any key To Exit............");
            }
        }
    }
}