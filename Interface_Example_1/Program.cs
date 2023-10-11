using System;

// Define an interface
public interface IDrawable
{
    void Draw();
}

// Implement the interface in a class
public class Circle : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Square : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        // Create instances
        IDrawable circle = new Circle();
        IDrawable square = new Square();

        // Call the method defined in the interface
        circle.Draw();
        square.Draw();
    }
}