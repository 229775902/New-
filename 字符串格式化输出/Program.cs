using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串格式化输出
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //格式化
            //说明符
            //int price = 12;
            double popuLation = 7800000000D;
            //Console.WriteLine("{0:C}", price);

            ////填充位
            //string name1 = "Sunnnie";
            //string name2 = "Tom";
            //string name3 = "Jerry";
            //double score1 = 80;
            //double score2 = 64;
            //double score3 = 100;
            //Console.WriteLine("{0,-8}|{1}", "name", "score");
            //Console.WriteLine("--------+--------");
            //Console.WriteLine("{0,-8}|{1}", "name1", "score1");
            //Console.WriteLine("{0,-8}|{1}", "name2", "score2");
            //Console.WriteLine("{0,-8}|{1}", "name3", "score3");

            //混用一下
            Console.WriteLine("|{0,16:E}|", popuLation);
            Console.WriteLine("|{0,-16:E}|", popuLation);
        }
    }
}