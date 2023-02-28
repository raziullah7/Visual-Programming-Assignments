using System;

// Shape is the parent class of Triangle(form2)
// and Rectangle(form3) classes
public class Shape
{
    // most shapes will need these to be computed
    protected double area;
    protected double perimeter;
    // writing virtual methods to make their
    // implementation in derived classes compulsory
    public virtual void Area() { area = 0; }
    public virtual void Perimeter() { perimeter = 0; }
}
