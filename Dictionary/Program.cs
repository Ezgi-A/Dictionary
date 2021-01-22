using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> users = new MyDictionary<int, string>();

            users.Add(0, "Ezgi");
            users.Add(1, "Furkan");
            users.Add(2, "Melisa");
            users.Add(3, "Elif");
            users.Add(4, "Berkay");
            users.Add(5, "Burcu");

            Console.WriteLine(users.Count);

            Console.WriteLine(users[0]);
            Console.WriteLine(users[1]);
            Console.WriteLine(users[2]);
            Console.WriteLine(users[3]);
            Console.WriteLine(users[4]);
            Console.WriteLine(users[5]);



        }
    }
}
