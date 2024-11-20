using System;

public class Rational
{
    public int numerator, denominator;
    public Rational()
    {
        numerator = 0;
        denominator = 1;
    }

    public Rational(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static void WriteRational(Rational r)
    {
        Console.WriteLine($"{r.numerator}/{r.denominator}");
    }

    public static int GCD(int a, int b)
    {
        int r = a % b;
        if (r == 0)
            return b;
        else
            return GCD(b, r);
    }

    public void Reduce()
    {
        int gcd = GCD(this.numerator, this.denominator);
        this.numerator = this.numerator / gcd;
        this.denominator = this.denominator / gcd;
    }

    
    public static Rational Multiply(Rational r1, Rational r2)
    {
        // Test code here
        int newNumerator = r1.numerator * r2.numerator;
        int newDenominator = r1.denominator * r2.denominator;
        Rational result = new Rational(newNumerator, newDenominator);
        result.Reduce();
        return result;
    }

   
    public Rational Multiply2(Rational r1, Rational r2) // renamed method as I cant overload the method with the same parameters
    {
        // Test code here
        int newNumerator = r1.numerator * r2.numerator;
        int newDenominator = r1.denominator * r2.denominator;
        Rational result = new Rational(newNumerator, newDenominator);
        result.Reduce();
        return result;
    }

  
    public Rational Multiply(Rational r)
    {
        // Test code here
        int newNumerator = this.numerator * r.numerator;
        int newDenominator = this.denominator * r.denominator;
        Rational result = new Rational(newNumerator, newDenominator);
        result.Reduce();
        return result;
    }

    public static void Main(string[] args)
    {
        // Test code here
        Rational r1 = new Rational(1, 2);
        Rational r2 = new Rational(2, 4);

        Console.WriteLine("Static Multiply method result:");
        Rational result1 = Rational.Multiply(r1, r2);
        WriteRational(result1);  

        Console.WriteLine("Instance Multiply method result with two parameters:");
        Rational result2 = r1.Multiply2(r1, r2);
        WriteRational(result2);  

        Console.WriteLine("Instance Multiply method result with one parameter:");
        Rational result3 = r1.Multiply(r2);
        WriteRational(result3); 
    }
}
