// See https://aka.ms/new-console-template for more information
using System;

class StarPattern 
{
    private int rows;
    private int col;

    public StarPattern(int choice)
    {
        rows = 5;
        col = 8;

        switch (choice)
        {
            case 1:
                GenRect();
                break;

            case 2:
                GenRightTri();
                break;

            case 3:
                GenLeftTri();
                break;

            case 4:
                GenPyr();
                break;

            case 5:
                GenDia();
                break;

            case 6:
                GenHolRec();
                break;

            default:
                InvalidChoice();
                break;                    
        }
     
    }
    
    public static void DisplayMenu()
    {
        Console.WriteLine("Star Pattern Generator");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Right Triangle");
        Console.WriteLine("3. Left Triangle");
        Console.WriteLine("4. Pyramid");
        Console.WriteLine("5. Diamond");
        Console.WriteLine("6. Hollow Rectangle");
        Console.WriteLine("Enter your choice (1 - 6)");
    }
    
    private void GenRect() 
    {
        for (int i = 0; i < rows; i++) // every row has "columns" number of elements
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    private void GenRightTri() // Row i has i ota elements
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private void GenLeftTri() //row i has (rows - i) spaces, then i stars
    {

        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        

        }
        
    }
    private void GenPyr() //row i has (rows - i) spaces then,(2xi - 1) (for symmetry the number of stars must be odd )stars
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    private void GenDia() //pyramid + inverted pyramid
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        for (int i = rows; i >= 1; i--)
        {
            for (int j = rows; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
    private void GenHolRec() //print star if its first row , last row , first column , last column
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= col; j++)
            {
                if (i == 1 || i == rows || j == 1 || j == col)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    private void InvalidChoice() 
    {
        Console.WriteLine("Invalid choice!");
    }
}

class Begins
{
    static void Main(string[] args)
    {
        StarPattern.DisplayMenu();
        int input = Convert.ToInt32(Console.ReadLine());
        StarPattern generator = new StarPattern(input);
    }
}