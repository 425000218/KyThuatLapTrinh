/*
 * BT2 - TINH DIEN TICH VA CHU VI HINH TRON
 * Theo doan code mau trong de bai (class variables)
 * Ngon ngu: C# - Console App - .NET Framework
 * Chay trong: Visual Studio 2022
 */

using System;

class variables   // giu nguyen ten class theo de bai
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ---- Khai bao bien theo dung de bai ----
        int radius      = 4;
        const double PI = 3.14159;
        double circum, area;

        // ---- Tinh toan ----
        area   = PI * radius * radius;   // Dien tich = PI * r^2
        circum = 2 * PI * radius;        // Chu vi    = 2 * PI * r

        // ---- In ket qua (dung dinh dang cua de bai) ----
        Console.WriteLine("Ban kinh = {0}, PI = {1}", radius, PI);
        Console.WriteLine("Dien tich {0}", area);
        Console.WriteLine("Chu vi {0}", circum);

        Console.WriteLine();
        Console.WriteLine("Nhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}
