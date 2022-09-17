using System;

namespace teningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teningarkast");
            var a = new Random();
            var b = a.Next(1,6);
            Console.WriteLine(b);

            
            
        }
    }
}
