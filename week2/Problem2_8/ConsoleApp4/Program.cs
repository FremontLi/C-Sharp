using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12, m = 5;
            Console.WriteLine(n +"个人围成一圈" );
            Console.WriteLine("从1报数，凡是数到" + m + "的人出队列");
            Console.WriteLine();
            int i, j, last;
            int[] tag;
            tag = new int[100];
            //初始化tag数组，用来标志是否已经出队列
            for(i=0;i<n;i++)
            {
                tag[i] = 1;
            }
            //开始报数
            j = 1;
            last = n;//剩余人数last
            for(i=0;last>1;i++)
            {
                if (tag[i % n]==0) continue;//0则已经出队列
                if(j==m)
                {
                    j = 1;
                    tag[i % n] = 0;
                    Console.WriteLine("第" + (i % n + 1) + "个人出队列了！");
                    last--;
                }
                else 
                    j++;
            }
            for(i=0;i<n;i++)
            {
                if (tag[i]==1)
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("第" + (i + 1) + "个人活下来了");
        }
    }
}
