using System;
using System.Xml;

namespace Day18Project1
{
    /// <summary>
    /// DONE BY: PAVAN
    /// PURPOSE: CREATE AN XML FILE AND PRINT THE TEXT//
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument m = new XmlDocument();
            m.Load("C:\\C#\\Project\\Day19 Assignment\\HELLO.XML");
            foreach(XmlNode p in m.DocumentElement.ChildNodes)
            {
                Console.WriteLine(p.InnerText);
            }
            Console.ReadLine();
        }
    }
}
