using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace ConsoleApplication01
{
    class Calculator
    {
        public int JiaFa(int x, int y)
        {
            return x + y;
        }
        public int JianFa(int x, int y)
        {
            return x - y;
        }
        public int ChenFa(int x, int y)
        {
            return x * y;
        }
        public int ChuFa(int x, int y)
        {
            return x / y;
        }
        public string Sjiafa(string m,string n)
        {
            string str;
            str = m + n;
            return str;
        }
        public string Sjianfa(string m, string n)
        {
            string str;
            str = m.Replace(n," ");
            return str;
        }
    }
}
