using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个1-12之间的整数:");
            int month = int.Parse(Console.ReadLine());
            while(month<1||month>12)
            {
                Console.WriteLine("您的输入有误，请输入一个1-12之间的整数:");
                month = int.Parse(Console.ReadLine());
            }   

            switch (month)
            {
                case 1:
                    Console.WriteLine("一月份的天数是31天");
                    break;
                case 2:
                    Console.WriteLine("二月份的天数是28或29天");
                    break;
                case 3:
                    Console.WriteLine("三月份的天数是31天");
                    break;
                case 4:
                    Console.WriteLine("四月份的天数是30天");
                    break;
                case 5:
                    Console.WriteLine("五月份的天数是31天");
                    break;
                case 6:
                    Console.WriteLine("六月份的天数是30天");
                    break;
                case 7:
                    Console.WriteLine("七月份的天数是31天");
                    break;
                case 8:
                    Console.WriteLine("八月份的天数是31天");
                    break;
                case 9:
                    Console.WriteLine("九月份的天数是30天");
                    break;
                case 10:
                    Console.WriteLine("十月份的天数是31天");
                    break;
                case 11:
                    Console.WriteLine("十一月份的天数是30天");
                    break;
                case 12:
                    Console.WriteLine("十二份的天数是31天");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
