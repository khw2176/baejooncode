using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        if(int.TryParse(input, out int y))
        {
            int CurrentYear = y - 543;
            Console.WriteLine(CurrentYear);
        }
    }
}