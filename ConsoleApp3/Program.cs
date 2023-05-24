using System;

public class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Додавання двох комплексних чисел
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Віднімання двох комплексних чисел
    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    // Множення двох комплексних чисел
    public static Complex operator *(Complex c1, Complex c2)
    {
        return new Complex(
            c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
            c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    // Перевантаження методу ToString для виведення комплексного числа
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(1, 2);
        Complex c2 = new Complex(3, 4);

        Console.WriteLine("c1 = " + c1);
        Console.WriteLine("c2 = " + c2);

        Complex sum = c1 + c2;
        Console.WriteLine("c1 + c2 = " + sum);

        Complex difference = c1 - c2;
        Console.WriteLine("c1 - c2 = " + difference);

        Complex product = c1 * c2;
        Console.WriteLine("c1 * c2 = " + product);
    }
}