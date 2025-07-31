using System;

public abstract class Shape{
    public abstract void Draw();  //during compile time this is an abstract but during runtime this MUST be changed by a derived class
    public void DisplayInfo() //this is a concrete method 
    {
        Console.WriteLine("This is a shape.");
    }
}
public interface IResizable{
    void Resize(double factor); //during compile time this is seen as a signature but during runtime this must be implemented by a class
}


public class Circle : Shape, IResizable{
    public override void Draw(){ 
        Console.WriteLine("Drawing a circle ");
    }

    public void Resize(double factor){
        Console.WriteLine($"Resizing circle by {factor}x");
    }
}

class Abstraction{
    static void Main()
    {
        Shape myCircle = new Circle();
        myCircle.Draw();       // Calls overridden method
        myCircle.DisplayInfo(); // Calls inherited method

        IResizable resizable = (IResizable)myCircle; //explicit type conversion of  the circle object to an interface type
        resizable.Resize(1.5); // Calls interface method
    }
}