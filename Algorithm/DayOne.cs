using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class DayOne
    {

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length > 0)
            {
                int length = nums.Length;
                Console.WriteLine("original array:" + string.Join(",", nums) + "arraylength:" + length + "\n");
                //排序
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            //交换
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                Console.WriteLine("sort array:" + string.Join(",", nums) + "arraylength:" + length + "\n");

                //获取非重复数组的长度
                int m = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != nums[m])
                    {
                        m++;
                        nums[m] = nums[i];
                    }
                    Console.WriteLine("array:" + string.Join(",", nums) + " m:" + m + " i:" + i + " arraylength:" + length + "\n");
                }
                length = m +1;

                System.Array.Resize(ref nums, length);

                Console.WriteLine("end array:" + string.Join(",", nums) + "arraylength:" + length + "\n");
                return length;
            }
            return 0;
        }
    

      
    }

}
