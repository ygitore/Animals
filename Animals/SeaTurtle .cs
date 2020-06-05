using System;

namespace Animals
{
    class SeaTurtle: IWalking, ISwimming
    {
        public int MaximumDepth { get; } = 100;

        public void Run()
        {
            Console.WriteLine("SeaTurtle is now running");
        }

        public void Walk()
        {
            Console.WriteLine("SeaTurtle is now walking");
        }

        public void Swim()
        {
            Console.WriteLine("SeaTurtle is now swimming");
        }
    }
}