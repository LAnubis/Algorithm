using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOne d = new DayOne();
            int[] nums = { 1, 2, 3, 1, 1, 2, 3 };
            d.RemoveDuplicates(nums);

            Console.WriteLine("End!");
            Console.ReadKey();
        }
    }
}
