using System;

// Triangle class
public class Triangle : Shape
{
    // using three sides to solve area
    // and perimeter
    private double sideA;
    private double sideB;
    private double sideC;
    // s = perimeter / 2
    // semi-perimeter
    private double s;
    // constructor
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
        // computation
        perimeter = sideA + sideB + sideC;
        s = perimeter / 2;
        area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }
    // area implemetation
    public override void Area()
    {
        MessageBox.Show($"Area of Triangle = {Math.Round(area, 2)} unit sq.");
    }
    // perimeter implementation
    public override void Perimeter()
    {
        MessageBox.Show($"Perimeter of Triangle = {perimeter} units");
    }
}
