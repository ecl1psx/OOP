namespace Program;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Starting...");

        var crossRoad = new CrossRoad();
        crossRoad.Start();

        Console.ReadKey();
    }
}