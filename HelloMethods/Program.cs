using System;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("pl");
            Console.WriteLine(message);
            Console.WriteLine("hey");
            Console.ReadLine();
        }
    }
}
