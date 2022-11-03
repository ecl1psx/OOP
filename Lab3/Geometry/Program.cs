namespace Program
{
    class App
    {
        public static void Main()
        {
            var figure = new Figure(new Point(1.1, 1.1), new Point(2.1, 3.4), new Point(5.6, 7.1));
            
            Console.WriteLine(figure.Name);
            Console.WriteLine(figure.PerimeterCalculator());
        }
    }
}