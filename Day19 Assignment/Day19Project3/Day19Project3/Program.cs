using System;
using System.Xml;
namespace Day18Project1
{
    /// <summary> 
    /// DONE BY: PAVAN 
    /// PURPOSE: CREATE AN XML FILE AND PRINT TEXT AND IN BETWEEN GIVE SOME SPACE// 
    /// </summary> 
    internal class Program

    {
        static void Main(string[] args)

        {
            XmlDocument m = new XmlDocument();

            m.Load("C:\\C#\\Project\\Day19 Assignment\\HELLO.XML");

            foreach (XmlNode p in m.DocumentElement.ChildNodes)

            {
                foreach (XmlNode p1 in p.ChildNodes)

                {
                    if (p1.Name == "ID")
                        Console.Write($"{p1.InnerText}, ");
                    if (p1.Name == "Name")
                        Console.Write($"{p1.InnerText}, ");
                    if (p1.Name == "Price")
                        Console.Write($"{p1.InnerText} \n");

                }
            }

            Console.ReadLine();
        }
    }
}
