using System;
using src.Entities;

namespace conceitos_da_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 78, "White Wizard");
           
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
