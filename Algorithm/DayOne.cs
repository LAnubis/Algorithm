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
                Console.WriteLine("原始数组为：" + string.Join(",", nums) + "数组长度：" + length + "\n");
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
                Console.WriteLine("排序后的数组为：" + string.Join(",", nums) + "数组长度：" + length + "\n");

                //获取非重复数组的长度
                int m = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != nums[m])
                    {
                        m++;
                        nums[m] = nums[i];
                    }
                    Console.WriteLine("数组为：" + string.Join(",", nums) + " m值:" + m + " i值:" + i + " 数组长度：" + length + "\n");
                }
                length = m ++;
                Console.WriteLine("最终数组为：" + string.Join(",", nums) + "数组长度：" + length + "\n");
                return length;
            }
            return 0;
        }
    }

}
