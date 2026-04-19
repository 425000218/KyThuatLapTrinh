/*
 * BT3 - TOAN TU SO SANH (Comparison Operators)
 * Minh hoa bang cac vi du trong de bai:
 *   Symbol | Meaning                  | Example  | Value
 *   -------|--------------------------|----------|------
 *   <      | less than                | 3 < 5    | TRUE
 *   <=     | less than or equal to    | 43 <= 25 | FALSE
 *   >      | greater than             | 4 > 7    | FALSE
 *   >=     | greater than or equal to | 9 >= 2   | TRUE
 *   ==     | equal to                 | 20 == 6  | FALSE
 *   !=     | not equal to             | 20 != 6  | TRUE
 *
 * Ngon ngu: C# - Console App - .NET Framework
 * Chay trong: Visual Studio 2022
 */

using System;

class BT3_ToanTuSoSanh
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("================================================");
        Console.WriteLine("  BT3 - MINH HOA CAC TOAN TU SO SANH TRONG C#  ");
        Console.WriteLine("================================================");
        Console.WriteLine();

        // In tieu de bang
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          "Symbol", "Meaning", "Example", "Value");
        Console.WriteLine(new string('-', 60));

        // 1. < (less than)
        bool result1 = 3 < 5;
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          "<", "less than", "3 < 5", result1.ToString().ToUpper());

        // 2. <= (less than or equal to)
        bool result2 = 43 <= 25;
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          "<=", "less than or equal to", "43 <= 25", result2.ToString().ToUpper());

        // 3. > (greater than)
        bool result3 = 4 > 7;
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          ">", "greater than", "4 > 7", result3.ToString().ToUpper());

        // 4. >= (greater than or equal to)
        bool result4 = 9 >= 2;
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          ">=", "greater than or equal to", "9 >= 2", result4.ToString().ToUpper());

        // 5. == (equal to)
        bool result5 = 20 == 6;
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          "==", "equal to", "20 == 6", result5.ToString().ToUpper());

        // 6. != (not equal to)
        bool result6 = 20 != 6;
        Console.WriteLine("{0,-6} {1,-25} {2,-12} {3}",
                          "!=", "not equal to", "20 != 6", result6.ToString().ToUpper());

        Console.WriteLine(new string('-', 60));
        Console.WriteLine();

        // Phan mo rong: thu nhap so va so sanh
        Console.WriteLine("=== THU NHAP VA SO SANH HAI SO ===");
        Console.Write("Nhap so A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap so B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"A = {a}, B = {b}");
        Console.WriteLine($"A <  B : {(a < b ).ToString().ToUpper()}");
        Console.WriteLine($"A <= B : {(a <= b).ToString().ToUpper()}");
        Console.WriteLine($"A >  B : {(a > b ).ToString().ToUpper()}");
        Console.WriteLine($"A >= B : {(a >= b).ToString().ToUpper()}");
        Console.WriteLine($"A == B : {(a == b).ToString().ToUpper()}");
        Console.WriteLine($"A != B : {(a != b).ToString().ToUpper()}");

        Console.WriteLine();
        Console.WriteLine("Nhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}
