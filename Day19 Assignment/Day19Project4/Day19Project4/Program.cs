using System;   
using System.Xml;

namespace Day19Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any number:");
            n = Convert.ToInt32(Console.ReadLine());
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\C#\\Project\\Day19 Assignment\\HELLO.XML");

            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach(XmlNode cnode in node.ChildNodes)
                {
                    bool id = cnode.Name == "id";
                    bool isIndex = (id == true ? Convert.ToInt32(cnode.InnerText) : 0) == n;
                    if(id && isIndex)
                    {
                        Console.WriteLine($"{cnode.Name}");
                    }
                }
            }
            Console.ReadLine();
           
        }
    }
}
