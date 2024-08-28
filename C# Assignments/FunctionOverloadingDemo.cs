/* Write a program to calculate the area of circle, rectangle and triangle using Function Overloading
 Circle: Pi * Area * Area;
 Rectangle: Area * breadth
 Triangle: 1⁄2 *Area* breadth */

using System;
class Shape
{
    double pi = 3.14;        
    public double RectangleArea(double length, double breadth)
    {
        return length * breadth;
    }
    public double CircleArea(double radius)
    {
        return radius * radius * pi;
    }
    public double TriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double circleArea = shape.CircleArea(radius);
        Console.WriteLine("The area of the circle is: " + circleArea);  
 
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the breadth of the rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());
        double rectangleArea = shape.RectangleArea(length, breadth); 

        Console.WriteLine("The area of the rectangle  is: " + RectangleArea);
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");

        double height = Convert.ToDouble(Console.ReadLine());
        double triangleArea = shape.TriangleArea(baseLength, height); 

        Console.WriteLine("The area of the triangle is: ” +triangleArea);
        Console.ReadLine();
 }
}
