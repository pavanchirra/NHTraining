using System;


namespace DelegatesExample
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: DELEGATES EXAMPLE PROGRAM
    /// </summary>
    /// <param name="height"></param>
    /// <param name="width"></param>
    public delegate void rectDelegate(double height, double width);
    class Rectangle
    {
        // "area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of class
            // "rectangle", named as "rect"
            Rectangle rect = new Rectangle();

            
           

            // creating delegate object, name as "rectdele"
            // and pass the method as parameter by
            // class object "rect"
            rectDelegate rectdele = new rectDelegate(rect.area);

           
            rectdele += rect.perimeter;

            // by using "Invoke" method
            rectdele.Invoke(4, 5);
            Console.WriteLine();

            // call the methods with
            // different values
            rectdele.Invoke(16, 10);
        }
    }
}
