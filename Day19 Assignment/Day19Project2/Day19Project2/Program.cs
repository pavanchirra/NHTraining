using System;
using System.Xml;

namespace Day18Project1
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CREATE AN XML FILE AND PRINT ONLY NAMES//
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
                    if (p1.Name == "Name")
                        Console.WriteLine(p1.InnerText);
                }
            }
            Console.ReadLine();
        }
    }
}

