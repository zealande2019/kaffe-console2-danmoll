using kaffe;
using System;
using System.Collections.Generic;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cortado cortado = new Cortado();
            Latte latte = new Latte();
            FlatWhite flatWhite = new FlatWhite(15);

            List<Imælk> liste = new List<Imælk>();
            liste.Add(cortado);
            liste.Add(latte);
            liste.Add(flatWhite);

        }
    }
}
