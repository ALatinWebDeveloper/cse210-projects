using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFraction());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine();

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFraction());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine();

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFraction());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine();

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFraction());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}