using System;

namespace Animals
{
    public class Dog : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Dog is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Dog is now walking");
        }
    }
}