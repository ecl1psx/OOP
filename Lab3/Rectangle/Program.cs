namespace Program
{
    class App
    {
        public static void Main()
        {
            Console.WriteLine("Type side1");
            var side1 = Console.ReadLine();
            
            Console.WriteLine("Type side2");
            var side2 = Console.ReadLine();

            var rectangle = new Rectangle(double.Parse(side1), double.Parse(side2));

            Console.WriteLine(rectangle.ToString());
        }
    }
}