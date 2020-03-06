using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, temp, sum=0;
            Console.WriteLine("请输入数组的大小");
            int n = int.Parse(Console.ReadLine());//字符串不是数字是会出错
            int[] nums;
            nums = new int[100];

            for(i = 0; i < n; i++)//输入n个数组元素
            {
                Console.WriteLine("请输入数组元素：");
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n - 1; i++)//冒泡排序,进行n-1轮比较,将整数数组元素从小到大排列
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            for(i = 0; i < n; i++)//对整数数组元素求和
            {
                sum += nums[i];
            }
            var k = (decimal) sum / n;//k是double类型，确保结果的准确
            //输出结果
            Console.WriteLine("整数数组的最大值是：" + nums[n - 1]);
            Console.WriteLine("整数数组的最小值是：" + nums[0]);
            Console.WriteLine("整数数组的平均值是：" + k);
            Console.WriteLine("整数数组的求和是：" + sum);
            Console.WriteLine();

        }
    }
}
