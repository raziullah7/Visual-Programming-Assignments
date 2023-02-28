using System;

// Rectangle class
public class Rectangle : Shape
{
    private double length;
    private double width;
    // constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
        // computing
        area = length * width;
        perimeter = 2 * (length + width);
    }
    // area implemetation
    public override void Area()
    {
        MessageBox.Show($"Area of Rectangle = {Math.Round(area, 2)} unit sq.");
    }
    // perimeter implemetation
    public override void Perimeter()
    {
        MessageBox.Show($"Perimeter of Rectangle = {perimeter} units");
    }
}
