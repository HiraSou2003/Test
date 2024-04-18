using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class _20240418_Prac1_Hirayama
    {
        static void Main(string[] args)
        {
            // 型推論
            var x = 10;
            var name = "John";

            // 参照型
            int[] numbers = new int[] { 1, 2, 3, };

            // 結果表示
            Console.WriteLine(x);
            Console.WriteLine(name);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine($"xの型は{x.GetType()}");
            Console.WriteLine($"nameの型は{name.GetType()}");
            Console.WriteLine($"numbersの型は{numbers.GetType()}");
        }
    }
}
