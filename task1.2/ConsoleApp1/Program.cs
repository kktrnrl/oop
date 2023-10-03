using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            if (int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Ви ввели число N");
            }
            else
            {
                Console.WriteLine("error :(");
            }
        }
    }
}