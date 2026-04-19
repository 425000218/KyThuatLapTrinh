using System;

namespace BaitapLHU
{
    class BT3
    {
        static void Main(string[] args)
        {
            // Căn lề các cột bằng cách sử dụng \t hoặc định dạng độ rộng chuỗi
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "Symbol", "Meaning", "Example", "Value");
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "<", "less than", "3 < 5", (3 < 5).ToString().ToUpper());
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "<=", "less than or equal to", "43 <= 25", (43 <= 25).ToString().ToUpper());
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", ">", "greater than", "4 > 7", (4 > 7).ToString().ToUpper());
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", ">=", "greater than or equal to", "9 >= 2", (9 >= 2).ToString().ToUpper());
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "==", "equal to", "20 == 6", (20 == 6).ToString().ToUpper());
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10}", "!=", "not equal to", "20 != 6", (20 != 6).ToString().ToUpper());

            Console.ReadLine();
        }
    }
}