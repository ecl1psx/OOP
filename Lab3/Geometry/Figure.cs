namespace Program;

public class Figure
{
    private string name;
    public string Name
    {
        get { return name; }
    }
    private Point[] _points;

    public Figure(Point point1, Point point2, Point point3)
    {
        name = "Triangle";
        
        _points = new Point[]{point1, point2, point3};
    }
    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        name = "Rectangle";
            
        _points = new Point[]{point1, point2, point3, point4};
    }
    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        name = "Pentagon";
        
        _points = new Point[]{point1, point2, point3, point4, point5};
    }

    static double LengthSide(Point A, Point B)
    {
        return A.DistanceTo(B);
    }

    public double PerimeterCalculator()
    {
        double perimiter = 0.0;

        for (int i = 1; i < _points.Length; i++)
        {
            var point1 = _points[i];
            var point2 = _points[i-1];

            perimiter += LengthSide(point1, point2);
        }

        return perimiter;
    }
}