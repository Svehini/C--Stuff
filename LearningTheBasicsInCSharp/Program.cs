// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            float number = 10.75f;
            string message = "Hello, World!";
            Console.WriteLine(message);
            Console.WriteLine(number);
            // string name = System.Console.ReadLine();
            // System.Console.WriteLine("Hello, " + name + "!");
            List <object> names = new List<object>();
            names.Add("Sveinung");
            names.Add("Per");
            names.Add(10);
            foreach (var name in names){
            System.Console.WriteLine(name);
            }

            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1.Add("Sveinung", 22);
            System.Console.WriteLine("What´s ur name?");
            string newname = System.Console.ReadLine();
            System.Console.WriteLine("What´s ur age?");
            int age = Convert.ToInt32(System.Console.ReadLine());
            dict1.Add(newname, age);
            foreach (KeyValuePair<string, int> elem in dict1)
            System.Console.WriteLine("name is: " + elem.Key + ", and age is: " + elem.Value);

        }
    }
}
