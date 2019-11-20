using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOne d = new DayOne();
            int[] nums = { 1, 1, 2,1,3,4,5,1,2,5,7,9 };
            d.RemoveDuplicates(nums);

            Console.WriteLine("End!");
            Console.ReadKey();
        }
    }
}
