using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, i = 0;
            
            int m = 0;
            int[] nums;
            nums = new int[1000];//整数数组
            int[] primes;
            primes = new int[1000];//素数数组
            Console.WriteLine("请输入数据的上限：");
            int max = int.Parse(Console.ReadLine());//数组元素上限

            Console.WriteLine("请输入数据的下限：");
            int min = int.Parse(Console.ReadLine());//数组元素下限
            Console.WriteLine();
            n = max - min + 1;//数据元素的个数
            for(i=0;i<n;i++)//将min到max之间的整数依次存入整数数组
            {
                nums[i] = min;
                min++;
                //Console.WriteLine(nums[i]);
            }

            for(i=0;i<n;i++)//判断整数元素是否是素数，并将素数存入primes数组
            {
                int a = 0;
                for (int k = 2; k < nums[i]; k++)
                {
                    if (nums[i] % k == 0)
                        a++;
                }
                if (a == 0)//如果是素数，则存入primes数组
                {
                    primes[m]=nums[i];
                    //Console.WriteLine(primes[m]);
                    m++;
                }
            }
            Console.WriteLine(max+"和"+(max-n+1)+"之间的素数有：");
            for(i=0;i<m;i++)
            {
                Console.Write(primes[i]+" ");//相邻两个素数之间用空格隔开
                if((i+1)%10==0)
                {
                    Console.WriteLine();//每输出10个素数换一次行
                }
            }
        }
    }
}
