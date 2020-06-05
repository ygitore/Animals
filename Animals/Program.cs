using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Pigeon pigeon = new Pigeon();
            SeaTurtle seaTurtle = new SeaTurtle();
            Dog dog = new Dog();

            pigeon.Fly();

            System.Console.WriteLine("........");
            seaTurtle.Walk();
            seaTurtle.Run();
            seaTurtle.Swim();
            System.Console.WriteLine("........");
            dog.Walk();
            dog.Run();
            
        }
    }
}
