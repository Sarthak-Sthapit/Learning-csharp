using System;
public class Calculator
{
    public virtual double Calculate(double a, double b)
    {
        Console.WriteLine("adding floats");
        return a + b;
    }
    public int Calculate(int a, int b)
    {
        Console.WriteLine("adding integers");
        return a + b;
    }
}
public class Multiplication : Calculator
{
    public override double Calculate(double a, double b)
    {
        Console.WriteLine("multiplying floats");
        return a * b;
    }
}

class Prog
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Multiplication mul = new Multiplication();

        Console.WriteLine(calc.Calculate(2, 3));
        Console.WriteLine(calc.Calculate(2.5, 3.5));

    
        Console.WriteLine(mul.Calculate(2.0, 3.0));     
        // Polymorphism 
        Calculator polycalc = new Multiplication(); // creates an object of multiplication class (child) but stores it in calculator class (parent)
        Console.WriteLine(polycalc.Calculate(2.0, 3.0));   
        
        /*
        during compilation "polycalc" is seen as "Calculator" Type but during runtime
        the behavior of the object is determined to be a "Multiplication hence Polymorphism is applied
        */
    }
}