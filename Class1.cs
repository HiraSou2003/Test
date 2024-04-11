using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console. WriteLine("あんたの名前は？");

            string name = Console.ReadLine();                         // 入力
            Console.WriteLine($"こんにちは、{name}さん");       // パターン１
            //Console.WriteLine("こんにちは、" + name + "さん");  // パターン２
        }
    }
}