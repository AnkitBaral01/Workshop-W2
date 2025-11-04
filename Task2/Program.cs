public class Circle
{
    public const double PI = 3.14;
    
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("TASK 2: Constants");
        
        Circle circle = new Circle();
        
        double radius = 5.0;
        
        double area = circle.CalculateArea(radius);
        double perimeter = circle.CalculatePerimeter(radius);
        
        Console.WriteLine($"Circle with radius {radius}:");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        
        Console.WriteLine("\nError Explanation:");
        Console.WriteLine("Constants declared with 'const' keyword cannot be modified.");
        Console.WriteLine("They are compile-time constants with fixed values.");
    }
}