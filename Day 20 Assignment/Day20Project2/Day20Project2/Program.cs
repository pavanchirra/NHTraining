using System;


namespace NullableTypes
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: NULLABLE TYPE
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int? firstValue = 20;
            int? secondValue = null;

            int? result;

            result = (firstValue.HasValue) ? firstValue : null;

            Console.WriteLine("The First Value Nullable type is : {0}", result);

            result = (secondValue.HasValue) ? secondValue : null;

            Console.WriteLine("The Second Value Nullable type is : {0}", result);

            Console.ReadKey();
        }
    }
}