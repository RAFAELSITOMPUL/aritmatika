using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka pertama: ");
        double angka1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        double angka2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nHasil Operasi Aritmatika:");
        Console.WriteLine($"{angka1} + {angka2} = {angka1 + angka2}");
        Console.WriteLine($"{angka1} - {angka2} = {angka1 - angka2}");
        Console.WriteLine($"{angka1} * {angka2} = {angka1 * angka2}");

        if (angka2 != 0)
        {
            Console.WriteLine($"{angka1} / {angka2} = {angka1 / angka2}");
        }
        else
        {
            Console.WriteLine("Pembagian tidak dapat dilakukan (pembagi nol).");
        }
    }
}
