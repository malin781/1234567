using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication01
{
    class Program
    {
        public static void Equals(int x,int y)
        {
            if(x==y)
                Console.WriteLine("两个整数相同。");
            else
                Console.WriteLine("两个整数不相同。");
        }
        static void Main(string[] args)
        {
            int x, y, z;
            string m, n;
            char a, b;
            Calculator c = new Calculator();
            Console.WriteLine("选择整数加减或字符串加减：");
            Console.WriteLine("1.选择整数加减：");
            Console.WriteLine("2.选择字符串加减：");
            z = Convert.ToInt32(Console.ReadLine());
            if (z == 1)
            {
                Console.WriteLine("请输入表达式（每输一个字符换行）:");
                Console.Write("第一个数:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("运算符:");
                a = Convert.ToChar(Console.ReadLine());
                Console.Write("第二个数:");
                y = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (a == '+')
                        Console.WriteLine("{0}+{1}={2}", x, y, c.JiaFa(x, y));
                    else if (a == '-')
                        Console.WriteLine("{0}-{1}={2}", x, y, c.JianFa(x, y));
                    else if (a == '*')
                        Console.WriteLine("{0}*{1}={2}", x, y, c.ChenFa(x, y));
                    else if (a == '/')
                        Console.WriteLine("{0}/{1}={2}", x, y, c.ChuFa(x, y));
                    else
                        Console.WriteLine("符号输入错误。");
                }
                catch
                {
                    Console.WriteLine("表达式输入错误。");
                }
                finally
                {
                    Equals(x, y);
                    Console.WriteLine("结束");
                }
            }
            else if(z==2)
            {
                Console.WriteLine("输入字符串1：");
                m = Console.ReadLine();
                Console.WriteLine("输入加法还是减法：");
                b = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("输入字符串2：");
                n = Console.ReadLine();
                if (b == '+')
                    Console.WriteLine("结果是：{0}", c.Sjiafa(m, n));
                else if (b == '-')
                    Console.WriteLine("结果是：{0}", c.Sjianfa(m, n));
            }
            else
                Console.WriteLine("输入错误。");
        }
    }
}
