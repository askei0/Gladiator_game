using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        List<string> envanter = new List<string>();
        envanter.Add("Sword");
        envanter.Add("Bread");
        envanter.Add("Key");
        envanter.Add("Shield");

        foreach (string esya in envanter)
        {
            if (esya == "Key")
            {
                Console.WriteLine("Congrats, the door is open");
            }
            else
            {
                Console.WriteLine("You do not have a key in your inventory.");
            }
        }

    }
}
