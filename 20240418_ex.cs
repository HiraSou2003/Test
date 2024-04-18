using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class _20240418_ex
    {
        // ポインタを使ったC#
        static unsafe void PointerUsage()
        {
            int number = 10;

            unsafe
            {
                int* ptr = &number;
                Console.Write((int)ptr);
            }
        }

        static void Main()
        {
            // 参照型
            Console.WriteLine("参照型の例");
            int[] ary1 = { 1, 2, 3 };
            int[] ary2 = ary1;        // 参照をコピーするため、ary2もary1と同じオブジェクトとして参照

            // ary2を変更
            ary2[0] = 100;
            Console.WriteLine($"ary1[0] = {ary1[0]}");

            // 値型
            Console.WriteLine("値型の例");
            int x = 10;
            int y = x;
            x = 23;
            Console.WriteLine($"x：{x}, y：{y}");
        }
    }
}
