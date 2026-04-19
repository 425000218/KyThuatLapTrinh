using System;

namespace BaitapLHU
{
    class BT2
    {
        public static void Main()
        {
            // Khai báo biến
            int radius = 4;
            const double PI = 3.14159;
            double circum, area;

            // Tính toán
            area = PI * radius * radius;
            circum = 2 * PI * radius;

            // In kết quả ra màn hình
            Console.WriteLine("// in kết quả");
            Console.WriteLine("Ban kinh = {0}, PI = {1}", radius, PI);
            Console.WriteLine("Dien tich {0}", area);
            Console.WriteLine("Chu vi {0}", circum);

            Console.ReadLine();
        }
    }
}