using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double A = int.Parse(input[0]);
            double B = int.Parse(input[1]);
        
            Console.WriteLine(A / B);
        }
    }   
}    