namespace Program;

public class Rectangle
{
    public double Area
    {
        get { return this.AreaCalculator(); }
    }

    public double Perimeter
    {
        get { return this.PerimeterCalculator(); }
    }

    private double side1;
    private double side2;
    
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public override string ToString()
    {
        return $"{AreaCalculator()} {PerimeterCalculator()}";
    }

    double AreaCalculator()
    {
        return this.side1 * this.side2;
    }

    double PerimeterCalculator()
    {
        return 2 * (this.side1 + this.side2);
    }
}