using System;

public abstract class Shape : IComparable<Shape>
{
    public double Area { get; protected set; }

    public int CompareTo(Shape compareShape)
    {
        return this.Area.CompareTo(compareShape.Area);
    }
}

public class CustomShape : Shape
{
    public CustomShape(double area)
    {
        this.Area = area;
    }
}

public class Square : Rectangle
{
    public Square(double side)
        : base(side, side)
    {
    }
}

public class Rectangle : Shape
{
    public Rectangle(double width, double height)
    {
        this.Area = width * height;
    }
}

public class Triangle : Shape
{
    public Triangle(double @base, double height)
    {
        this.Area = @base * height / 2;
    }
}

public class Circle : Shape
{
    public Circle(double radius)
    {
        this.Area = radius * radius * Math.PI;
    }
}