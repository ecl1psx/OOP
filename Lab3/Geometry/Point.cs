namespace Program;

public class Point
{
    private double _x;
    private double _y;
    public double X
    {
        get { return _x;  }
    }
    public double Y { get { return _y; } }

    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double DistanceTo(Point point)
    {
        return Math.Sqrt(Math.Pow((X - point.X), 2) + Math.Pow((Y - point.Y), 2));
    }
}