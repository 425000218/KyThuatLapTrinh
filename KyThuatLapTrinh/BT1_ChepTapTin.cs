/*
 * BT1 - HUONG DAN CHEP TAP TIN
 * Yeu cau: Copy tap tin tu "C:\TUYENTAP\thotinh.txt" sang vi tri khac
 * Ngon ngu: C# - Console App - .NET Framework
 * Chay trong: Visual Studio 2022
 */

using System;
using System.IO;

class BT1_ChepTapTin
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("==========================================");
        Console.WriteLine("  BT1 - CHUONG TRINH CHEP TAP TIN (.cs)  ");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        // Duong dan nguon va dich
        string sourcePath = @"C:\TUYENTAP\thotinh.txt";
        string destFolder = @"C:\TUYENTAP\BACKUP";
        string destPath   = Path.Combine(destFolder, "thotinh_copy.txt");

        // B1. Kiem tra tap tin nguon co ton tai khong
        Console.WriteLine($"[B1] Kiem tra tap tin nguon: {sourcePath}");

        if (!File.Exists(sourcePath))
        {
            // Neu chua co, tao tap tin mau de demo
            Console.WriteLine("     --> Tap tin nguon chua ton tai. Dang tao tap tin mau...");
            Directory.CreateDirectory(Path.GetDirectoryName(sourcePath));
            File.WriteAllText(sourcePath,
                "Day la noi dung tap tin thotinh.txt\nDong 2 cua tap tin\nDong 3 cua tap tin");
            Console.WriteLine("     --> Da tao tap tin mau thanh cong!");
        }
        else
        {
            Console.WriteLine("     --> Tap tin nguon ton tai.");
        }

        Console.WriteLine();

        // B2. Chon vi tri dich (tao thu muc neu chua co)
        Console.WriteLine($"[B2] Chuan bi thu muc dich: {destFolder}");
        if (!Directory.Exists(destFolder))
        {
            Directory.CreateDirectory(destFolder);
            Console.WriteLine("     --> Da tao thu muc dich moi.");
        }
        else
        {
            Console.WriteLine("     --> Thu muc dich da ton tai.");
        }

        Console.WriteLine();

        // B3. Thuc hien chep tap tin (tuong duong "Copy" -> "Paste")
        Console.WriteLine("[B3] Dang chep tap tin...");
        try
        {
            // overwrite: true = ghi de neu file dich da ton tai
            File.Copy(sourcePath, destPath, overwrite: true);
            Console.WriteLine($"     --> Chep thanh cong!");
            Console.WriteLine($"     Nguon : {sourcePath}");
            Console.WriteLine($"     Dich  : {destPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"     --> Loi khi chep: {ex.Message}");
        }

        Console.WriteLine();

        // B4. Kiem tra ket qua - doc noi dung tap tin vua chep
        Console.WriteLine("[B4] Kiem tra noi dung tap tin sau khi chep:");
        Console.WriteLine("     ----------------------------------------");
        if (File.Exists(destPath))
        {
            string content = File.ReadAllText(destPath);
            Console.WriteLine(content);
        }
        Console.WriteLine("     ----------------------------------------");

        Console.WriteLine();
        Console.WriteLine(">>> Chuong trinh hoan thanh! Nhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}
